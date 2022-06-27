using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;



namespace money_tracker
{
    public partial class Home : Form
    {
        static List<Transactions> database = new List<Transactions>();

        static ConfigValues cfg;
         


        public Home()
        {
            cfg = new ConfigValues();
            cfg.readXml_categories();
            cfg.readXml_modalities();

            loadCSV();
            InitializeComponent();

            PanelHome panel = new PanelHome(database);
            addUserControl(panel);

            // change colors
            panel1.BackColor        = Color.FromArgb(col.TABMENU_R, col.TABMENU_G, col.TABMENU_B);
            ButtonHome.FillColor    = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonPlots.FillColor   = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonList.FillColor    = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonQuit.FillColor    = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonSetting.FillColor = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);

        }


        public void loadCSV()
        {
            using (TextFieldParser parser = new TextFieldParser(cfg.csvPath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] transaction = parser.ReadFields();
                    Transactions trans = new Transactions(transaction);
                    database.Add(trans);
                }
            }
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            PanelHome panel = new PanelHome(database);
            addUserControl(panel);
        }

        private void ButtonPlots_Click(object sender, EventArgs e)
        {
            PanelPlot panel = new PanelPlot(database, cfg);
            addUserControl(panel);
        }

        private void ButtonList_Click(object sender, EventArgs e)
        {
            PanelList panel = new PanelList(database, cfg);
            addUserControl(panel);
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            PanelSettings panel = new PanelSettings(database, cfg);
            addUserControl(panel);
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    public class Transactions
    {

        public string date;
        public double amount;
        public int type;
        public int modality;
        public int category;
        public string note;

        public int year;
        public int month;
        public int day;

        public Transactions(string[] arr)
        {
            date     = arr[0];
            amount   = Convert.ToDouble(arr[1]);
            type     = Convert.ToInt16(arr[2]);
            modality = Convert.ToInt16(arr[3]);
            category = Convert.ToInt16(arr[4]);
            note     = arr[5];
        }

        public Transactions(int _amount)
        {
            amount = _amount;
        }

        public void parseDate()
        {
            if (date.Length < 9) return;
            year  = Convert.ToInt16(date.Substring(0,4));
            month = Convert.ToInt16(date.Substring(5, 2));
            day   = Convert.ToInt16(date.Substring(8, 2));
        }
    }

    public class col
    {
        public const int BACKGROUND_R = 196;
        public const int BACKGROUND_G = 214;
        public const int BACKGROUND_B = 223;

        public const int BUTTON_R = 16;
        public const int BUTTON_G = 114;
        public const int BUTTON_B = 166;

        public const int TABMENU_R = 41;
        public const int TABMENU_G = 76;
        public const int TABMENU_B = 93;

        public const int BOX_R = 115;
        public const int BOX_G = 201;
        public const int BOX_B = 248;

        public const int PICKER_R = 115;
        public const int PICKER_G = 201;
        public const int PICKER_B = 248;
    }



}
