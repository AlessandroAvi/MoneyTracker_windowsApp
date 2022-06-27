using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using LiveCharts;


namespace money_tracker
{
    public partial class PanelPlot : UserControl
    {

        List<Transactions> _database = new List<Transactions>();

        List<Transactions> filteredDatabase = new List<Transactions>();

        double[] pointChart = new double[31];
        List<double> pointChart2 = new List<double>();

        double totalExpenses = 0;
        double[] categoryExpense = {0,0,0,0,0,0}; 


        public PanelPlot(List<Transactions> database)
        {
            _database = database;
            InitializeComponent();

            filterDatabase();

            computePieChart();
            loadPieChart();

            computePointChart();
            loadPointChart();
        }



        private void filterDatabase()
        {
            int currentMonth = DateTime.Today.Month;
            int currentYear  = DateTime.Today.Year;

            foreach (var item in _database)
            {
                // check minimum date
                if (!((item.year == currentYear) && (item.month == currentMonth))) continue;

                filteredDatabase.Add(item);
            }
        }


        void computePieChart()
        {
            foreach (var item in filteredDatabase)
            {
                if (item.type == 1) continue;

                categoryExpense[item.category] += item.amount;
                totalExpenses += item.amount;
            }
        }

        Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

        void computePointChart()
        {
            int currentMonth = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
                
            for(int i=0; i< currentMonth; i++)
            { 
                double tmp = 0;
                foreach (var item in filteredDatabase)
                {
                    if (item.day == i) tmp += item.amount;
                }
                pointChart[i] = tmp;
                pointChart2.Add();
            }
            
        }

        void loadPointChart()
        {
            cartesianChart1.Series = new LiveCharts.SeriesCollection
            {
                new LiveCharts.Wpf.LineSeries
                {
                    Title = "Month expenses by day",
                    Values = new ChartValues<double> pointChart
                }
            };
        }

        void loadPieChart()
        {
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection
            {
                new LiveCharts.Wpf.PieSeries
                {
                    Values = new ChartValues<double> { categoryExpense[0]/totalExpenses},
                    Title = "Rent",
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new LiveCharts.Wpf.PieSeries
                {
                    Values = new ChartValues<double> { categoryExpense[1]/totalExpenses},
                    Title = "Groceries",
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new LiveCharts.Wpf.PieSeries
                {
                    Values = new ChartValues<double> { categoryExpense[2]/totalExpenses},
                    Title = "Living",
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new LiveCharts.Wpf.PieSeries
                {
                    Values = new ChartValues<double> { categoryExpense[3]/totalExpenses},
                    Title = "Transport",
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new LiveCharts.Wpf.PieSeries
                {
                    Values = new ChartValues<double> { categoryExpense[4]/totalExpenses},
                    Title = "Sport",
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new LiveCharts.Wpf.PieSeries
                {
                    Values = new ChartValues<double> { categoryExpense[5]/totalExpenses},
                    Title = "Other",
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Right;

            foreach (var ps in series)
            {
                pieChart1.Series.Add(ps);
            }
        }
 
    }
}
