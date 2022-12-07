using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MongoDB.Driver;
using MongoDB.Bson;

namespace money_tracker
{
    public partial class PanelList : UserControl
    {

        List<Transactions> database = new List<Transactions>();

        DateTime beginDay;
        DateTime endDay;

        ConfigValues cfg;

        PanelList panelList;

        Home home;


        public PanelList(List<Transactions> _database, ConfigValues _cfg, Home _home)
        {
            InitializeComponent();

            database = _database;
            initValues();
            refreshListView();
            panelList = this;
            cfg = _cfg;
            home = _home;


            // change colors
            this.BackColor              = Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            buttonDateApply.FillColor   = Color.FromArgb(col.BUTTON_R,col.BUTTON_G,col.BUTTON_B);
            ButtonAddItem.FillColor     = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonPDF.FillColor         = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            datePickerBegin1.FillColor  = Color.FromArgb(col.PICKER_R, col.PICKER_G, col.PICKER_B);
            datePickerEnd1.FillColor    = Color.FromArgb(col.PICKER_R, col.PICKER_G, col.PICKER_B);


        }



        public async void addTransaction(string date, string amount, string type, string mode, string cat, string note)
        {
            var db = home.GetDb();

            var collection = db.GetCollection<BsonDocument>("Production");

            var document = new BsonDocument()
            {
                {"date",date },
                {"amount",amount },
                {"type",type },
                {"method",mode },
                {"cat",cat },
                {"note",note }
            };

            await collection.InsertOneAsync(document);
        }


        private void initValues()
        {
            beginDay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            endDay   = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            datePickerBegin1.Value = beginDay;
            datePickerEnd1.Value = endDay;
        }




        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            NewItem dlg = new NewItem(panelList);
            dlg.Show();
        }



        private void refreshListView()
        {
            listViewTransactions.Items.Clear();

            foreach (var item in database)
            {
                // check minimum date
                if (!((item.year >= beginDay.Year) && (item.month >= beginDay.Month) && (item.month >= beginDay.Day))) continue;

                // check maximum date
                if (!((item.year <= endDay.Year) && (item.month <= endDay.Month) && (item.month <= endDay.Day))) continue;


                string[] elementStr = { item.date, item.amount.ToString(), fromIntToType(item.type), 
                                        fromIntToModality(item.modality), fromIntToCategory(item.category), item.note };
                listViewTransactions.Items.Add(new ListViewItem(elementStr));
            }
        }


        private void datePickerBegin_ValueChanged(object sender, EventArgs e)
        {
        }

        private void datePickerEnd_ValueChanged(object sender, EventArgs e)
        {
        }


        string fromIntToType(int type)
        {
            switch (type)
            {
            case 0:
                return "Expense";
            case 1:
                return "Income";
            default:
                return "NULL";
            }
        }

        string fromIntToModality(int mod)
        {
            switch (mod)
            {
                case 0:
                    return "Cash";
                case 1:
                    return "PayPal";
                case 2:
                    return "PP Card";
                case 3:
                    return "CC Card";
                default :
                    return "NULL";
            }
        }

        string fromIntToCategory(int cat)
        {
            switch (cat)
            {
                case 0:
                    return "Rent";
                case 1:
                    return "Groceries";
                case 2:
                    return "Living";
                case 3:
                    return "Transport";
                case 4:
                    return "Sport";
                case 5:
                    return "Other";
                default:
                    return "NULL";
            }
        }



        public struct dateContainer
        {
            public int year;
            public int month;
            public int day;
        }

        private void buttonDateApply_Click(object sender, EventArgs e)
        {
            refreshListView();
        }

        private void datePickerBegin1_ValueChanged(object sender, EventArgs e)
        {
            beginDay = datePickerBegin1.Value;
        }

        private void datePickerEnd1_ValueChanged(object sender, EventArgs e)
        {
            endDay = datePickerEnd1.Value;
        }

        private void ButtonPDF_Click(object sender, EventArgs e)
        {

        }
    }
}
