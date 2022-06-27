using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace money_tracker
{
    public partial class NewItem : Form
    {
        PanelList father;

        public NewItem(PanelList panelList)
        {
            father = panelList;
            InitializeComponent();

            datePicker.Value = DateTime.Now;
            comboCat.SelectedIndex = 5;
            comboMod.SelectedIndex = 2;
            comboType.SelectedIndex = 0;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // save the parameters and add them to the csv
            string date     = datePicker.Value.ToString();
            string year     = date.Substring(6, 4);
            string month    = date.Substring(3, 2);
            string day      = date.Substring(0, 2);
            string date_real = year + "-" + month + "-" + day;
            string amount   = textNotes.Text;
            string type     = comboType.SelectedIndex.ToString();
            string mod      = comboMod.SelectedIndex.ToString();
            string cat = comboCat.SelectedIndex.ToString();
            string note    = textNotes.Text;

            father.addTransaction(date_real, amount, type, mod, cat, note);


            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
