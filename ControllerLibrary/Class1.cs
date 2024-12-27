using ATMStatePattern;
using System;
using System.Data;

namespace ControllerLibrary
{
    public interface IATMView
    {
        void DisplayMessage(string message);
        void DisplayStatus(int id, int cashAvailable, bool connectionStatus, string currentState);
    }

    public class ATMController
    {
        private readonly AtmContext _atm;
        private readonly IATMView _view;

        public ATMController(AtmContext atm, IATMView view)
        {
            _atm = atm;
            _view = view;
            _atm.Notify = _view.DisplayMessage; 
        }

        public void InsertPin(string pin)
        {
            _atm.InsertPin(pin);
            _view.DisplayStatus(_atm.Id, _atm.CashAvailable, _atm.IsConnected, _atm.CurrentState.GetType().ToString());
        }

        public void PerformOperation(string operation, int amount = 0)
        {
            _atm.PerformOperation(operation, amount);
            _view.DisplayStatus(_atm.Id, _atm.CashAvailable, _atm.IsConnected, _atm.CurrentState.GetType().ToString());
        }

        public void ReloadCash(int amount)
        {
            _atm.ReloadCash(amount);
            _view.DisplayStatus(_atm.Id, _atm.CashAvailable, _atm.IsConnected, _atm.CurrentState.GetType().ToString());
        }

        public void FixConnection()
        {
            _atm.FixConnection();
            _view.DisplayStatus(_atm.Id, _atm.CashAvailable, _atm.IsConnected, _atm.CurrentState.GetType().ToString());
        }
    }
}
