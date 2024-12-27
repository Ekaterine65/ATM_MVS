namespace ATMWinFromView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            txtPin = new TextBox();
            btnEnterPin = new Button();
            txtAmount = new TextBox();
            btnWithdraw = new Button();
            btnReloadCash = new Button();
            btnFixConnection = new Button();
            btnExit = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(21, 25);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(134, 20);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Статус банкомата:";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(21, 179);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(125, 27);
            txtPin.TabIndex = 2;
            // 
            // btnEnterPin
            // 
            btnEnterPin.Location = new Point(24, 226);
            btnEnterPin.Name = "btnEnterPin";
            btnEnterPin.Size = new Size(122, 73);
            btnEnterPin.TabIndex = 3;
            btnEnterPin.Text = "Ввести PIN-код";
            btnEnterPin.UseVisualStyleBackColor = true;
            btnEnterPin.Click += btnEnterPin_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(177, 179);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(279, 27);
            txtAmount.TabIndex = 4;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(180, 226);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(122, 73);
            btnWithdraw.TabIndex = 5;
            btnWithdraw.Text = "Снять деньги";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnReloadCash
            // 
            btnReloadCash.Location = new Point(334, 226);
            btnReloadCash.Name = "btnReloadCash";
            btnReloadCash.Size = new Size(122, 73);
            btnReloadCash.TabIndex = 6;
            btnReloadCash.Text = "Пополнить кассу";
            btnReloadCash.UseVisualStyleBackColor = true;
            btnReloadCash.Click += btnReloadCash_Click;
            // 
            // btnFixConnection
            // 
            btnFixConnection.Location = new Point(24, 323);
            btnFixConnection.Name = "btnFixConnection";
            btnFixConnection.Size = new Size(122, 73);
            btnFixConnection.TabIndex = 7;
            btnFixConnection.Text = "Исправить соединение";
            btnFixConnection.UseVisualStyleBackColor = true;
            btnFixConnection.Click += btnFixConnection_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(180, 323);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(122, 73);
            btnExit.TabIndex = 8;
            btnExit.Text = "Завершить работу";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(512, 25);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(91, 20);
            lblMessage.TabIndex = 9;
            lblMessage.Text = "Сообщения";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 422);
            Controls.Add(lblMessage);
            Controls.Add(btnExit);
            Controls.Add(btnFixConnection);
            Controls.Add(btnReloadCash);
            Controls.Add(btnWithdraw);
            Controls.Add(txtAmount);
            Controls.Add(btnEnterPin);
            Controls.Add(txtPin);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStatus;
        private TextBox txtPin;
        private Button btnEnterPin;
        private TextBox txtAmount;
        private Button btnWithdraw;
        private Button btnReloadCash;
        private Button btnFixConnection;
        private Button btnExit;
        private Label lblMessage;
    }
}
