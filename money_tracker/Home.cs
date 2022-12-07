﻿using System;
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
using MongoDB.Driver;
using MongoDB.Bson;



namespace money_tracker
{
    public partial class Home : Form
    {
        // Classes
        static List<Transactions> database;
        static ConfigValues cfg;
        IMongoCollection<BsonDocument> DBcollection;

        // Panels
        PanelHome panelH;
        PanelPlot panelP;
        PanelList panelL;
        PanelSettings panelS;

        // Other
        public int activePanel;

        public MongoClient dbClient;
        public IMongoDatabase db;

        public Home()
        {
            database = new List<Transactions>();
            cfg = new ConfigValues();
            activePanel = 0;

            ConnectDB();
            ReadFromDB();

            cfg.readXml_categories();
            cfg.readXml_modalities();
            
            InitializeComponent();

            setColors();

            panelH = new PanelHome(database);
            addUserControl(panelH);
            panelP = new PanelPlot(database, cfg);
            addUserControl(panelP);
            panelL = new PanelList(database, cfg, this);
            addUserControl(panelL);
            panelS = new PanelSettings(database, cfg);
            addUserControl(panelS);

            HighlightButton(activePanel);
        }


        public void ConnectDB()
        {
            dbClient = new MongoClient("mongodb+srv://alessandroavi:0oWRT7oqf4alqzaS@clusterbot.gxgqhc5.mongodb.net/?retryWrites=true&w=majority");
            db = dbClient.GetDatabase("ClusterBot");
            DBcollection = db.GetCollection<BsonDocument>("Production");
        }


        public IMongoDatabase GetDb()
        {
            return dbClient.GetDatabase("ClusterBot");
        }



        public void ReadFromDB()
        {
            var items = DBcollection.Find(new BsonDocument()).ToList();
            Console.WriteLine(items);
            foreach (BsonDocument item in items)
            {
                Transactions trans = new Transactions(item[1].ToString(), // date
                                                      item[2].ToDouble(), // amount
                                                      item[3].ToString(), // type
                                                      item[4].ToString(), // method or mod
                                                      item[5].ToString(), // cat
                                                      item[6].ToString()); // note
                database.Add(trans);
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            //panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            activePanel = 0;
            HighlightButton(activePanel);
        }

        private void ButtonPlots_Click(object sender, EventArgs e)
        {
            activePanel = 1;
            HighlightButton(activePanel);
        }

        private void ButtonList_Click(object sender, EventArgs e)
        {
            activePanel = 2;
            HighlightButton(activePanel);
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            activePanel = 3;
            HighlightButton(activePanel);
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            database.Clear();
            ReadFromDB();

            panelH.refreshDatabase(database);
            panelH.Refresh();
            panelP.Refresh();
            panelL.Refresh();
            panelS.Refresh();
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
                panelH.BringToFront();
            }
            else if(code == 1){
                ButtonPlots.FillColor = Color.FromArgb(col.BUTTON_PRESS_R, col.BUTTON_PRESS_G, col.BUTTON_PRESS_B);
                panelP.BringToFront();
            }
            else if (code == 2)
            {
                ButtonList.FillColor = Color.FromArgb(col.BUTTON_PRESS_R, col.BUTTON_PRESS_G, col.BUTTON_PRESS_B);
                panelL.BringToFront();
            }
            else if (code == 3)
            {
                ButtonSetting.FillColor = Color.FromArgb(col.BUTTON_PRESS_R, col.BUTTON_PRESS_G, col.BUTTON_PRESS_B);
                panelS.BringToFront();
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


        public Transactions(string _date, double _amount, string _type, string _mod, string _cat, string _note)
        {
            date     = _date;
            amount   = _amount;
            type     = Convert.ToInt16(_type);
            modality = Convert.ToInt16(_mod);
            category = Convert.ToInt16(_cat);
            note     = _note;
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
