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
using System.Text.RegularExpressions;




namespace money_tracker
{
    public partial class Home : Form
    {
        static List<Transactions> database;

        static ConfigValues cfg;

        public int activePanel;
         


        public Home()
        {
            database = new List<Transactions>();
            cfg = new ConfigValues();
            activePanel = 100;


            cfg.readXml_categories();
            cfg.readXml_modalities();
            loadCSV();
            
            InitializeComponent();

            PanelHome panel = new PanelHome(database);
            addUserControl(panel);

            setColors();
        }

        public void loadCSV()
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show("ERROR: here was an error while reading the CSV \n\r" + e.Message);
                return;
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
            activePanel = 0;
            HighlightButton(activePanel);
            PanelHome panel = new PanelHome(database);
            addUserControl(panel);
        }

        private void ButtonPlots_Click(object sender, EventArgs e)
        {
            activePanel = 1;
            HighlightButton(activePanel);
            PanelPlot panel = new PanelPlot(database, cfg);
            addUserControl(panel);
        }

        private void ButtonList_Click(object sender, EventArgs e)
        {
            activePanel = 2;
            HighlightButton(activePanel);
            PanelList panel = new PanelList(database, cfg);
            addUserControl(panel);
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            activePanel = 3;
            HighlightButton(activePanel);
            PanelSettings panel = new PanelSettings(database, cfg);
            addUserControl(panel);
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            database.Clear();
            loadCSV();

            if (activePanel == 0)
            {
                PanelHome panel = new PanelHome(database);
                addUserControl(panel);
            }
            else if (activePanel == 1)
            {
                PanelPlot panel = new PanelPlot(database, cfg);
                addUserControl(panel);
            }
            else if (activePanel == 2)
            {
                PanelList panel = new PanelList(database, cfg);
                addUserControl(panel);
            }
            else if (activePanel == 3)
            {
                PanelSettings panel = new PanelSettings(database, cfg);
                addUserControl(panel);
            }
        }


        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HighlightButton(int code)
        {
            ButtonHome.FillColor    = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonPlots.FillColor   = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonList.FillColor    = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonSetting.FillColor = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);

            if (code == 0)
            {
                ButtonHome.FillColor = Color.FromArgb(col.BUTTON_PRESS_R, col.BUTTON_PRESS_G, col.BUTTON_PRESS_B);
            }
            else if(code == 1){
                ButtonPlots.FillColor = Color.FromArgb(col.BUTTON_PRESS_R, col.BUTTON_PRESS_G, col.BUTTON_PRESS_B);
            }
            else if (code == 2)
            {
                ButtonList.FillColor = Color.FromArgb(col.BUTTON_PRESS_R, col.BUTTON_PRESS_G, col.BUTTON_PRESS_B);
            }
            else if (code == 3)
            {
                ButtonSetting.FillColor = Color.FromArgb(col.BUTTON_PRESS_R, col.BUTTON_PRESS_G, col.BUTTON_PRESS_B);
            }
        }



        private void setColors()
        {
            panel1.BackColor = Color.FromArgb(col.TABMENU_R, col.TABMENU_G, col.TABMENU_B);
            ButtonHome.FillColor = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonPlots.FillColor = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonList.FillColor = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonQuit.FillColor = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonSetting.FillColor = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            ButtonRefresh.FillColor = Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
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

        public bool parseDate()
        {
            Regex r = new Regex("\\d{4}\\-\\d{2}\\-\\d{2}");
            Match match = r.Match(date);
            if (!match.Success) return false;
            if (date.Length != 10) return false;

            year  = Convert.ToInt16(date.Substring(0,4));
            month = Convert.ToInt16(date.Substring(5, 2));
            day   = Convert.ToInt16(date.Substring(8, 2));
            return true;
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

        public const int BUTTON_PRESS_R = 125;
        public const int BUTTON_PRESS_G = 211;
        public const int BUTTON_PRESS_B = 255;

        public const int DATE_R = 115;
        public const int DATE_G = 201;
        public const int DATE_B = 248;
    }



}
