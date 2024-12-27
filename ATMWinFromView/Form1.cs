using ATMStatePattern;
using ControllerLibrary;

namespace ATMWinFromView
{
    public partial class Form1 : Form, IATMView
    {
        private readonly ATMController _controller;
        public Form1()
        {
            InitializeComponent();
            var atm = new AtmContext(1, 5000, true, 0.1); // модель
            _controller = new ATMController(atm, this); // контроллер
        }

        public void DisplayMessage(string message)
        {
            lblMessage.Text = message;
        }

        public void DisplayStatus(int id, int cashAvailable, bool connectionStatus, string currentState)
        {
            string connectionStatusText = connectionStatus ? "Подключено" : "Отключено";
            lblStatus.Text = $@"
--- Текущий статус банкомата ---
ID банкомата: {id}
Доступная сумма: {cashAvailable} руб.
Состояние соединения: {connectionStatusText}
Текущее состояние: {currentState}
--------------------------------";
        }


        private void btnEnterPin_Click(object sender, EventArgs e)
        {
            string pin = txtPin.Text;
            _controller.InsertPin(pin);
            txtPin.Clear();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAmount.Text, out int amount))
            {
                _controller.PerformOperation("withdraw", amount);
                txtAmount.Clear();
            }
            else
            {
                DisplayMessage("Неверный ввод суммы.");
            }
        }

        private void btnReloadCash_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAmount.Text, out int amount))
            {
                _controller.ReloadCash(amount);
                txtAmount.Clear();
            }
            else
            {
                DisplayMessage("Неверный ввод суммы.");
            }
        }

        private void btnFixConnection_Click(object sender, EventArgs e)
        {
            _controller.FixConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
