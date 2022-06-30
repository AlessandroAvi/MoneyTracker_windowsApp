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
        List<Transactions> database            = new List<Transactions>();

        ChartValues<double> plotValues = new ChartValues<double>();


        int startupMonth;
        int currentMonth = DateTime.Now.Month;

        public PanelHome(List<Transactions> _database)
        {
            database = _database;

            InitializeComponent();

            monthPicker.SelectedIndex = currentMonth - 1;
            startupMonth = monthPicker.SelectedIndex + 1;

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
            monthPicker.FillColor         = System.Drawing.Color.FromArgb(col.DATE_R, col.DATE_G, col.DATE_B);
        }


        public void setLabelTotalBalance()
        {
            double balance = 0;
            foreach (var item in database)
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
            if (currentMonth < startupMonth)
            {
                labelDaysCounter.Text = "No data available";
            }
            else if (currentMonth > startupMonth)
            {
                labelDaysCounter.Text = "Transaction of the last " + DateTime.DaysInMonth(DateTime.Now.Year, startupMonth) + " days of month " + startupMonth;
            }
            else
            {
                labelDaysCounter.Text = "Transaction of the last " + DateTime.Now.Day + " days";
            }
        }

        public void filterLastMonth()
        {
            foreach (var item in database)
            {
                if (!item.parseDate()) continue;
                if (item.month == startupMonth)
                {
                    databaseCurrentMonth.Add(item);
                }
            }
        }


        void plotValues1Month()
        {
            plotValues.Clear();
            int day, month;
            double balance = 0;
            int year = DateTime.Now.Year;
            if (startupMonth == currentMonth)
            {            
                day = DateTime.Now.Day;
                month = DateTime.Now.Month;
            }
            else
            {
                day = DateTime.DaysInMonth(year, startupMonth);
                month = startupMonth;
            }

            // fill the list with zeroes
            for (int i = 0; i < day; i++)
            {
                plotValues.Add(0);
            }

            // fill the list with the actial values
            foreach (var item in database)
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

        private void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            startupMonth = monthPicker.SelectedIndex + 1;
            databaseCurrentMonth.Clear();
            filterLastMonth();
            plotValues1Month();
            setLabelTotalBalance();
            setLabelMonthBalance();
            setLabelMonthExpenses();
            setLabelDaysCounter();
            createPlotTransactions();
        }






        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}
