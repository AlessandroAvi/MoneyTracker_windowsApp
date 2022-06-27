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
    public partial class NewEnum : Form
    {
        List<KeyValue> list;

        public NewEnum(List<KeyValue> _list)
        {
            InitializeComponent();
            list = _list;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!textValue.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(textValue, "Value must be a number");
                return;
            }

            foreach (KeyValue kv in list)
            {
                if(kv.value == Int16.Parse(textValue.Text))
                {
                    errorProvider1.SetError(textValue, "Value already exists");
                    return;
                }
            }



            list.Add(new KeyValue(textName.Text, Int16.Parse(textValue.Text)));
            this.Close();
        }
    }
}
