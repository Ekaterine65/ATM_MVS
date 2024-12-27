using ATMStatePattern;
using ControllerLibrary;

namespace ATMConsoleView
{
    public class ATMView : IATMView
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayStatus(int id, int cashAvailable, bool connectionStatus, string currentState)
        {
            string connectionStatusText = connectionStatus ? "Подключено" : "Отключено";

            Console.WriteLine("\n--- Текущий статус банкомата ---");
            Console.WriteLine($"ID банкомата: {id}");
            Console.WriteLine($"Доступная сумма: {cashAvailable} руб.");
            Console.WriteLine($"Состояние соединения: {connectionStatusText}");
            Console.WriteLine($"Текущее состояние: {currentState}");
            Console.WriteLine("--------------------------------\n");
        }

        public void Run(ATMController controller)
        {
            while (true)
            {
                Console.WriteLine("\n1. Ввести PIN\n2. Снять деньги\n3. Пополнить кассу\n4. Исправить соединение\n5. Выход");
                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите PIN: ");
                        string pin = Console.ReadLine();
                        controller.InsertPin(pin);
                        break;

                    case "2":
                        Console.Write("Введите сумму для снятия: ");
                        if (int.TryParse(Console.ReadLine(), out int amount))
                        {
                            controller.PerformOperation("withdraw", amount);
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод.");
                        }
                        break;

                    case "3":
                        Console.Write("Введите сумму для пополнения кассы: ");
                        if (int.TryParse(Console.ReadLine(), out int reloadAmount))
                        {
                            controller.ReloadCash(reloadAmount);
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод.");
                        }
                        break;

                    case "4":
                        controller.FixConnection();
                        break;

                    case "5":
                        Console.WriteLine("Работа завершена.");
                        return;

                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var atm = new AtmContext(1, 5000, true, 0.1); // Создаем модель
            var view = new ATMView(); // Создаем представление
            var controller = new ATMController(atm, view); // Создаем контроллер и передаем ему модель и представление

            view.Run(controller);
        }
    }
}
