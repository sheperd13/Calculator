using Calculator.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculator
{
    public class CalculatorViewModel : ViewModelBase
    {
        private double displayValue;
        public double DisplayValue {
            get {return displayValue;}
            set
            {
                displayValue = value;
                OnPropertyChanged("DisplayValue");
            }
        }

        public ICommand NumberCommand {
            get
            {
                return new Command<string>((x) => NumberPushed(x));
            }
        }

        public ICommand OperatorCommand {
            get
            {
                return new Command<string>((x) => OperatorPushed(x));
            }
        }
        public ICommand EqualsCommand {
            get
            {
                return new Command<string>((x) => EqualsPushed(x));
            }
        }

        public CalculatorViewModel()
        {
            DisplayValue = 0.123;
        }

        private void NumberPushed(string x)
        {
            Console.WriteLine("Number Pushed: " + x);
            DisplayValue = Convert.ToDouble(x);
        }

        private void OperatorPushed(string x)
        {
            Console.WriteLine("Operator Pushed: " + x);
        }

        private void EqualsPushed(string x)
        {
            Console.WriteLine("Equals Pushed: " + x);
        }
    }
}
