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
    public partial class PanelSettings : UserControl
    {
        ConfigValues cfg;

        public PanelSettings(List<Transactions> database, ConfigValues _cfg)
        {
            cfg = _cfg;
            InitializeComponent();

            initListCat();
            initListMod();


            textPathXML.Text = cfg.xmlPath;

            // change colors
            this.BackColor          = System.Drawing.Color.FromArgb(col.BACKGROUND_R, col.BACKGROUND_G, col.BACKGROUND_B);
            buttonCat.FillColor     = System.Drawing.Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            buttonMod.FillColor     = System.Drawing.Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            buttonPathXML.FillColor = System.Drawing.Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
            buttonSave.FillColor    = System.Drawing.Color.FromArgb(col.BUTTON_R, col.BUTTON_G, col.BUTTON_B);
        }


        // INIT LIST BOXES
        void initListCat()
        {
            listViewCat.Items.Clear();
            foreach (var item in cfg.categories)
            {
                string[] itemStr = { item.name, item.value.ToString() };
                listViewCat.Items.Add(new ListViewItem(itemStr) );
            }
        }

        void initListMod()
        {
            listViewMod.Items.Clear();
            foreach (var item in cfg.modalities)
            {
                string[] itemStr = { item.name, item.value.ToString() };
                listViewMod.Items.Add(new ListViewItem(itemStr));
            }
        }




        // BUTTONS
        private void buttonPathXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";

            if (dialog.ShowDialog() == DialogResult.OK) {
                textPathXML.Text = dialog.FileName;
            }
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            NewEnum dlg = new NewEnum(cfg.categories);
            dlg.ShowDialog();
            cfg.writeXml_categories();
            initListCat();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            NewEnum dlg = new NewEnum(cfg.modalities);
            dlg.ShowDialog();
            cfg.writeXml_modalities();
            initListMod();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            cfg.xmlPath = textPathXML.Text;
            cfg.writeXml_modalities();
            cfg.writeXml_categories();
        }


    }
}
