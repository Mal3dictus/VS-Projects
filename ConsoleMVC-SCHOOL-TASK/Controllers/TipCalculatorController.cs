using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMVC_SCHOOL_TASK.Model;
using ConsoleMVC_SCHOOL_TASK.Views;

namespace ConsoleMVC_SCHOOL_TASK.Controllers
{
    public class TipCalculatorController
    {
        private Tip tip;
        private Display display;
        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amount,display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndTotal();
        }
            

       
    }
}
