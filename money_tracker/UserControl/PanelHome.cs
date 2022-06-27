using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace money_tracker
{
    public partial class PanelHome : UserControl
    {
        List<Transactions> databaseCurrentMonth = new List<Transactions>();
        List<Transactions> _database            = new List<Transactions>();

        ChartValues<double> plotValues = new ChartValues<double>();


        int startupMonth = Convert.ToInt16(DateTime.Now.ToString("MM"));

        public PanelHome(List<Transactions> database)
        {

            _database = database;
            InitializeComponent();

            filterLastMonth();
            plotValues1Month();

            setLabelTotalBalance();
            setLabelMonthBalance();
            setLabelMonthExpenses();
            setLabelDaysCounter();

            createPlotTransactions();

            // change colors
            this.BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            panelCurrentBalance.BackColor = System.Drawing.Color.FromArgb(col.BOX_R, col.BOX_G,col.BOX_B);
            panelMonthBalance.BackColor   = System.Drawing.Color.FromArgb(col.BOX_R, col.BOX_G,col.BOX_B);
        }


        public void setLabelTotalBalance()
        {
            double balance = 0;
            foreach (var item in _database)
            {
                if (item.type == 0)
                {
                    balance -= item.amount;
                }
                else if (item.type == 1)
                {
                    balance += item.amount;
                }
            }
            labelTotalBalance.Text = "Total:   " + balance.ToString() + " €";
        }


        public void setLabelMonthBalance()
        {
            double balance = 0;
            foreach (var item in databaseCurrentMonth)
            {
                if (item.type == 0)
                {
                    balance -= item.amount;
                }
                else if(item.type == 1)
                {
                    balance += item.amount;
                }
            }
            labelMonthBalance.Text = "Month balance:       " + balance.ToString() + " €";
        }


        public void setLabelMonthExpenses()
        {
            double balance = 0;
            foreach (var item in databaseCurrentMonth)
            {
                if (item.type == 0)  balance += item.amount;
            }
            labelMonthExpenses.Text = "Month expenses:   " + balance.ToString() + " €";
        }

        public void setLabelDaysCounter()
        {
            labelDaysCounter.Text = "Transaction of the last " + DateTime.Now.Day + " days";
        }

        public void filterLastMonth()
        {
            foreach (var item in _database)
            {
                item.parseDate();
                if (item.month == startupMonth)
                {
                    databaseCurrentMonth.Add(item);
                }
            }
        }


        public void plotValues3Month()
        {
            // get current month and day
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            double balance = 0;

            int daysLast3Months = day + DateTime.DaysInMonth(year, month - 1) + DateTime.DaysInMonth(year, month - 2);

            // fill the list with zeroes
            for(int i=0; i<daysLast3Months; i++)
            {
                plotValues.Add(0);
            }


            // fill the list with the actial values
            foreach (var item in _database)
            {
                int counter =  0;
                double sign = (item.type==0? -1:1);

                balance += item.amount * sign;

                if (item.month == month-2)
                {
                    counter = item.day - 1;
                    plotValues[counter] = balance;
                }
                else if (item.month == month - 1)
                {
                    counter = DateTime.DaysInMonth(year, month - 1) + item.day - 2;
                    plotValues[counter] = balance;
                }
                else if (item.month == month)
                {
                    counter = DateTime.DaysInMonth(year, month - 2) + DateTime.DaysInMonth(year, month - 1) + item.day - 3;
                    plotValues[counter] = balance;
                }

                for (int i=counter; i<plotValues.Count; i++)
                {
                    plotValues[i] = balance;
                }
            }
        }


        void plotValues1Month()
        {
            // get current month and day
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            double balance = 0;

            // fill the list with zeroes
            for (int i = 0; i < day; i++)
            {
                plotValues.Add(0);
            }


            // fill the list with the actial values
            foreach (var item in _database)
            {
                int counter = 0;
                double sign = (item.type == 0 ? -1 : 1);

                balance += item.amount * sign;

                if (item.month == month )
                {
                    counter = item.day - 1;
                    plotValues[counter] = balance;
                }

                for (int i = counter; i < plotValues.Count; i++)
                {
                    plotValues[i] = balance;
                }
            }


            elementHost1.BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            //elementHost1.ChartAreas[0].BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            //elementHost1.Legends[0].BackColor = Color.Transparent;

        }



        public void createPlotTransactions()
        {            
            SeriesCollection data = new SeriesCollection
            {
                new LineSeries
                {
                    Title = " Transaqctions last 3 months",
                    Values = plotValues,
                    LineSmoothness = 0 //0: straight lines, 1: really smooth lines
                }

            };

            chartCartesian.Series = data;
        }






            

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        
    



























    }
}
