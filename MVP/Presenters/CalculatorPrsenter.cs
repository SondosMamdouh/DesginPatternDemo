using System;
using System.Collections.Generic;
using System.Linq;
using MVP.Views;
using MVP.Models;
using System.Windows.Forms;

namespace MVP.Presenters
{
    public class CalculatorPrsenter
    {
        Calculator calculator = new Calculator();
        private ICalulatior calulatiorView;

        public CalculatorPrsenter(ICalulatior view)
        {
            calulatiorView = view;
        }
        public void ConnectBetweenModelAndView()
        {
            calculator.NumberOne = Convert.ToDouble(calulatiorView.TxtNumberOne);
            calculator.NumberTwo = Convert.ToDouble(calulatiorView.TxtNumberTwo);
        }
        public void CalSum()
        {
            ConnectBetweenModelAndView();
            calulatiorView.TxtResult = calculator.CalculateSumation().ToString();
        }

        public void CalSub()
        {
            ConnectBetweenModelAndView();
            calulatiorView.TxtResult = calculator.CalculateSubtraction().ToString();
        }
        public void CalMulitplic()
        {
            ConnectBetweenModelAndView();
            calulatiorView.TxtResult = calculator.CalculateMultiplication().ToString();
        }

        public void CalDiv()
        {
            ConnectBetweenModelAndView();
            if (Convert.ToDouble(calulatiorView.TxtNumberTwo)==0)
            {
                MessageBox.Show("Can't Divide into Zero");
            }
            else
            {
                calulatiorView.TxtResult = calculator.CalculateDivion().ToString();
            }
        }
    }
}
