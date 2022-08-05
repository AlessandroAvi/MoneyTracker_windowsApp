using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

    


namespace money_tracker
{
    public partial class PanelPlot : UserControl
    {

        ConfigValues cfg;

        List<Transactions> database = new List<Transactions>();
        List<Transactions> filteredDatabase = new List<Transactions>();

        Home home;

        double totalExpenses = 0;
        double totalEntries = 0;
        double necessaryExpenses = 0;
        double notNeccessaryExpenses = 0;
        double[] categoryExpense;
        double[] modalityExpenses;

        int selectedMonth;
        int currentMonth;


        public PanelPlot(List<Transactions> _database, ConfigValues _cfg)
        {
            cfg = _cfg;
            database = _database;
            categoryExpense = new double[cfg.categories.Count];
            modalityExpenses = new double[cfg.modalities.Count];

            InitializeComponent();

            currentMonth = DateTime.Now.Month;
            monthPicker.SelectedIndex = currentMonth - 1;

            // change colors
            this.BackColor        = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            monthPicker.FillColor = System.Drawing.Color.FromArgb(col.DATE_R, col.DATE_G, col.DATE_B);
        }


        private void resetCounters()
        {
            totalExpenses = 0;
            totalEntries = 0;
            necessaryExpenses = 0;
            notNeccessaryExpenses = 0;
            for(int i = 0; i < categoryExpense.Length; i++)
            {
                categoryExpense[i] = 0;
            }
            for(int i=0; i<modalityExpenses.Length; i++)
            {
                modalityExpenses[i] = 0;
            }
        }               
        
        private void filterDatabase()
        {
            int currentMonth = DateTime.Today.Month;
            int currentYear = DateTime.Today.Year;

            foreach (var item in database)
            {
                // check minimum date
                if (!((item.year == currentYear) && (item.month == selectedMonth))) continue;

                filteredDatabase.Add(item);
            }
        }


        void computePieCharts()
        {
            foreach (var item in filteredDatabase)
            {
                if (item.type == 1)
                {
                    totalEntries += item.amount;
                    continue;
                }

                if (item.category == 4 || item.category == 5)
                {
                    notNeccessaryExpenses += item.amount;
                }
                else
                {
                    necessaryExpenses += item.amount;
                }               

                categoryExpense[item.category] += item.amount;
                modalityExpenses[item.modality] += item.amount;
                totalExpenses += item.amount;
            }
        }





        void loadPieChartCategory()
        {
            pieChartModality.Series[0].Points.Clear();
            string[] names = new string[cfg.categories.Count+1];
            float[] values = new float[cfg.categories.Count+1];

            // Add expenses categories
            for (int i = 0; i < categoryExpense.Length; i++)
            {
                names[i] = cfg.categories[i].name;
                values[i] = (float)(categoryExpense[i] / (totalEntries + totalExpenses));
            }

            // Add savings
            names[cfg.categories.Count] = "Savings";
            values[cfg.categories.Count] = (float)((totalEntries-totalExpenses) / (totalEntries + totalExpenses));

            pieChartModality.Series[0].ChartType = SeriesChartType.Pie;
            pieChartModality.Series[0].Points.DataBindXY(names, values);
            pieChartModality.BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            pieChartModality.ChartAreas[0].BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            pieChartModality.Legends[0].BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);

        }


        void loadPieChartModality()
        {
            pieChartCategory.Series[0].Points.Clear();
            string[] names = new string[cfg.modalities.Count];
            float[] values = new float[cfg.modalities.Count];

            // Add expenses categories
            for (int i = 0; i < modalityExpenses.Length; i++)
            {
                names[i]= cfg.modalities[i].name;
                values[i] = (float)(modalityExpenses[i] / (totalEntries + totalExpenses));
            }

            pieChartCategory.Series[0].ChartType = SeriesChartType.Pie;
            pieChartCategory.Series[0].Points.DataBindXY(names, values);
            pieChartCategory.BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            pieChartCategory.ChartAreas[0].BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            pieChartCategory.Legends[0].BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);

        }



        void loadBarPlot()
        {
            barChart_.Series[0].Points.Clear();
            string[] name = new string[cfg.categories.Count];
            double[] value = new double[cfg.categories.Count];

            for (int i=0; i<categoryExpense.Length; i++)
            {
                value[i] = categoryExpense[i];
                name[i]  = cfg.categories[i].name;
            }


            barChart_.Series[0].ChartType = SeriesChartType.Bar;
            barChart_.Series[0].Points.DataBindXY(name, value);

            barChart_.BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            barChart_.ChartAreas[0].BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            barChart_.Legends[0].BackColor = Color.Transparent;
        }



        void loadPieChartNecessary() {
            pieChartNecessary.Series[0].Points.Clear();
            string[] x = { "Necessary expenses", "Not necessary expenses", "Savings" };
            double[] y = new double[3];

            y[0] = necessaryExpenses;
            y[1] = notNeccessaryExpenses;
            y[2] = totalEntries - necessaryExpenses - notNeccessaryExpenses;
            if (y[2] < 0)
            {
                y[2] = 0;
            }

            pieChartNecessary.Series[0].ChartType = SeriesChartType.Pie;
            pieChartNecessary.Series[0].Points.DataBindXY(x, y);

            pieChartNecessary.BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            pieChartNecessary.ChartAreas[0].BackColor = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            pieChartNecessary.Legends[0].BackColor = Color.Transparent;
        }

        private void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMonth = monthPicker.SelectedIndex + 1;

            filteredDatabase.Clear();
            resetCounters();

            filterDatabase();
            computePieCharts();
            loadPieChartCategory();
            loadPieChartModality();
            loadBarPlot();
            loadPieChartNecessary();
        }
    }



}

    

