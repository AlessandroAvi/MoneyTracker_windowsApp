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
        List<Transactions> databaseFiltered;
        List<Transactions> database;

        ChartValues<double> plotValues = new ChartValues<double>();


        int selectedMonth;
        int currentMonth;

        public PanelHome(List<Transactions> _database)
        {
            database = _database;
            databaseFiltered = new List<Transactions>();

            InitializeComponent();

            currentMonth = DateTime.Now.Month;
            monthPicker.SelectedIndex = currentMonth - 1;

            filterDatabaseMonth();
            calculatePlot();

            displayPlot();

            setColors();
        }



        #region COSMETIC
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
            string result = (Math.Truncate(balance * 100) / 100).ToString("0.00").PadLeft(8, '\x2007'); ;
            labelTotalBalanceVal.Text = result + " €";
        }


        public void setLabelMonthBalance()
        {
            double balance = 0;
            int counter = 0;
            foreach (var item in databaseFiltered)
            {
                counter ++;
                if (item.type == 0)
                {
                    balance -= item.amount;
                }
                else if(item.type == 1)
                {
                    balance += item.amount;
                }
            }
            string result = (Math.Truncate(balance * 100) / 100).ToString("0.00").PadLeft(8, '\x2007'); ;
            labelMonthBalanceVal.Text = result + " €";
        }


        public void setLabelMonthExpenses()
        {
            double balance = 0;
            foreach (var item in databaseFiltered)
            {
                if (item.type == 0)  balance += item.amount;
            }
            string result = (Math.Truncate(balance * 100) / 100).ToString("0.00").PadLeft(8, '\x2007'); ;
            labelMonthExpensesVal.Text = result + " €";
        }

        public void setLabelMonthEntries()
        {
            double balance = 0;
            foreach (var item in databaseFiltered)
            {
                if (item.type == 1) balance += item.amount;
            }
            string result = (Math.Truncate(balance * 100) / 100).ToString("0.00").PadLeft(8, '\x2007'); ;
            labelMonthEntriesVal.Text = result + " €";

        }

        public void setLabelDaysCounter()
        {
            if (currentMonth < selectedMonth)
            {
                labelDaysCounter.Text = "No data available";
            }
            else if (currentMonth > selectedMonth)
            {
                labelDaysCounter.Text = "Transaction of the last " + DateTime.DaysInMonth(DateTime.Now.Year, selectedMonth) + " days of month " + selectedMonth;
            }
            else
            {
                labelDaysCounter.Text = "Transaction of the last " + DateTime.Now.Day + " days";
            }
        }

        private void setColors()
        {
            this.BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            panelCurrentBalance.BackColor = System.Drawing.Color.FromArgb(col.BOX_R, col.BOX_G, col.BOX_B);
            panelMonthBalance.BackColor = System.Drawing.Color.FromArgb(col.BOX_R, col.BOX_G, col.BOX_B);
            monthPicker.FillColor = System.Drawing.Color.FromArgb(col.DATE_R, col.DATE_G, col.DATE_B);
        }
        #endregion


        public void filterDatabaseMonth()
        {
            foreach (var item in database)
            {
                if (!item.parseDate()) continue;
                if (item.month == selectedMonth)
                {
                    databaseFiltered.Add(item);
                }
            }
        }


        void calculatePlot()
        {
            plotValues.Clear();
            int day;
            double balance = 0;
            int year = DateTime.Now.Year;

            if (selectedMonth == currentMonth)
            {            
                day   = DateTime.Now.Day;
            }
            else
            {
                day = DateTime.DaysInMonth(year, selectedMonth);
            }

            // init the list with zeroes
            for (int i = 1; i <= day; i++)
            {
                plotValues.Add(0);
            }

            bool first = true;

            // fill the list with the actial values
            foreach (var item in database)
            {
                if (first)
                {
                    for (int k = 0; k < plotValues.Count; k++)
                    {
                        plotValues[k] = balance;
                    }
                    if (item.month == selectedMonth) first = false;
                }

                double sign = (item.type == 0 ? -1 : 1);

                balance += item.amount * sign;

                if (item.month == selectedMonth)
                {
                    for (int i= item.day-1; i < plotValues.Count; i++)
                    {
                        plotValues[i] = balance;
                    }
                }


            }

            elementHost1.BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
        }



        public void displayPlot()
        {
            chartCartesian.Series.Clear();
            SeriesCollection data; ;
            data = new SeriesCollection
            {
                new LineSeries
                {
                    Values = plotValues,
                    LineSmoothness = 0 //0: straight lines, 1: really smooth lines
                }

            };

            chartCartesian.Series = data;
        }

        private void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMonth = monthPicker.SelectedIndex + 1;
            databaseFiltered.Clear();
            plotValues.Clear();
            filterDatabaseMonth();

            setLabelTotalBalance();
            setLabelMonthBalance();
            setLabelMonthExpenses();
            setLabelMonthEntries();
            setLabelDaysCounter();
            calculatePlot();
            displayPlot();
        }
    }
}
