namespace money_tracker
{
    partial class PanelHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCurrentBalance = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTotalBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMonthBalance = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMonthEntries = new System.Windows.Forms.Label();
            this.labelDaysCounter = new System.Windows.Forms.Label();
            this.labelMonthExpenses = new System.Windows.Forms.Label();
            this.labelMonthBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.chartCartesian = new LiveCharts.Wpf.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.monthPicker = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelMonthEntriesVal = new System.Windows.Forms.Label();
            this.labelMonthExpensesVal = new System.Windows.Forms.Label();
            this.labelMonthBalanceVal = new System.Windows.Forms.Label();
            this.labelTotalBalanceVal = new System.Windows.Forms.Label();
            this.panelCurrentBalance.SuspendLayout();
            this.panelMonthBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCurrentBalance
            // 
            this.panelCurrentBalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCurrentBalance.Controls.Add(this.labelTotalBalanceVal);
            this.panelCurrentBalance.Controls.Add(this.labelTotalBalance);
            this.panelCurrentBalance.Controls.Add(this.label2);
            this.panelCurrentBalance.Location = new System.Drawing.Point(799, 43);
            this.panelCurrentBalance.Name = "panelCurrentBalance";
            this.panelCurrentBalance.Size = new System.Drawing.Size(457, 152);
            this.panelCurrentBalance.TabIndex = 1;
            // 
            // labelTotalBalance
            // 
            this.labelTotalBalance.AutoSize = true;
            this.labelTotalBalance.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalBalance.Location = new System.Drawing.Point(114, 83);
            this.labelTotalBalance.Name = "labelTotalBalance";
            this.labelTotalBalance.Size = new System.Drawing.Size(87, 34);
            this.labelTotalBalance.TabIndex = 1;
            this.labelTotalBalance.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current total balance";
            // 
            // panelMonthBalance
            // 
            this.panelMonthBalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMonthBalance.Controls.Add(this.labelMonthBalanceVal);
            this.panelMonthBalance.Controls.Add(this.labelMonthExpensesVal);
            this.panelMonthBalance.Controls.Add(this.labelMonthEntriesVal);
            this.panelMonthBalance.Controls.Add(this.label3);
            this.panelMonthBalance.Controls.Add(this.labelMonthEntries);
            this.panelMonthBalance.Controls.Add(this.labelDaysCounter);
            this.panelMonthBalance.Controls.Add(this.labelMonthExpenses);
            this.panelMonthBalance.Controls.Add(this.labelMonthBalance);
            this.panelMonthBalance.Controls.Add(this.label4);
            this.panelMonthBalance.Location = new System.Drawing.Point(267, 43);
            this.panelMonthBalance.Name = "panelMonthBalance";
            this.panelMonthBalance.Size = new System.Drawing.Size(451, 253);
            this.panelMonthBalance.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(10, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 2);
            this.label3.TabIndex = 6;
            // 
            // labelMonthEntries
            // 
            this.labelMonthEntries.AutoSize = true;
            this.labelMonthEntries.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthEntries.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMonthEntries.Location = new System.Drawing.Point(35, 67);
            this.labelMonthEntries.Name = "labelMonthEntries";
            this.labelMonthEntries.Size = new System.Drawing.Size(205, 34);
            this.labelMonthEntries.TabIndex = 5;
            this.labelMonthEntries.Text = "Month entries: ";
            // 
            // labelDaysCounter
            // 
            this.labelDaysCounter.AutoSize = true;
            this.labelDaysCounter.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaysCounter.Location = new System.Drawing.Point(113, 215);
            this.labelDaysCounter.Name = "labelDaysCounter";
            this.labelDaysCounter.Size = new System.Drawing.Size(205, 18);
            this.labelDaysCounter.TabIndex = 4;
            this.labelDaysCounter.Text = "Transaction of the last x days";
            // 
            // labelMonthExpenses
            // 
            this.labelMonthExpenses.AutoSize = true;
            this.labelMonthExpenses.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelMonthExpenses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMonthExpenses.Location = new System.Drawing.Point(35, 110);
            this.labelMonthExpenses.Name = "labelMonthExpenses";
            this.labelMonthExpenses.Size = new System.Drawing.Size(238, 34);
            this.labelMonthExpenses.TabIndex = 2;
            this.labelMonthExpenses.Text = "Month expenses: ";
            // 
            // labelMonthBalance
            // 
            this.labelMonthBalance.AutoSize = true;
            this.labelMonthBalance.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMonthBalance.Location = new System.Drawing.Point(35, 164);
            this.labelMonthBalance.Name = "labelMonthBalance";
            this.labelMonthBalance.Size = new System.Drawing.Size(218, 34);
            this.labelMonthBalance.TabIndex = 1;
            this.labelMonthBalance.Text = "Month balance: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(73, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 49);
            this.label4.TabIndex = 0;
            this.label4.Text = "Month balance";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(113, 440);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(819, 361);
            this.elementHost1.TabIndex = 3;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.chartCartesian;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(104, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current month transaction visualization";
            // 
            // monthPicker
            // 
            this.monthPicker.BackColor = System.Drawing.Color.Transparent;
            this.monthPicker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.monthPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthPicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monthPicker.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monthPicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.monthPicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.monthPicker.ItemHeight = 30;
            this.monthPicker.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "Septemer",
            "October",
            "Novermber",
            "December"});
            this.monthPicker.Location = new System.Drawing.Point(64, 49);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new System.Drawing.Size(140, 36);
            this.monthPicker.TabIndex = 5;
            this.monthPicker.SelectedIndexChanged += new System.EventHandler(this.monthPicker_SelectedIndexChanged);
            // 
            // labelMonthEntriesVal
            // 
            this.labelMonthEntriesVal.AutoSize = true;
            this.labelMonthEntriesVal.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthEntriesVal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMonthEntriesVal.Location = new System.Drawing.Point(273, 67);
            this.labelMonthEntriesVal.Name = "labelMonthEntriesVal";
            this.labelMonthEntriesVal.Size = new System.Drawing.Size(26, 34);
            this.labelMonthEntriesVal.TabIndex = 7;
            this.labelMonthEntriesVal.Text = "-";
            // 
            // labelMonthExpensesVal
            // 
            this.labelMonthExpensesVal.AutoSize = true;
            this.labelMonthExpensesVal.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthExpensesVal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMonthExpensesVal.Location = new System.Drawing.Point(273, 110);
            this.labelMonthExpensesVal.Name = "labelMonthExpensesVal";
            this.labelMonthExpensesVal.Size = new System.Drawing.Size(26, 34);
            this.labelMonthExpensesVal.TabIndex = 8;
            this.labelMonthExpensesVal.Text = "-";
            // 
            // labelMonthBalanceVal
            // 
            this.labelMonthBalanceVal.AutoSize = true;
            this.labelMonthBalanceVal.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthBalanceVal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMonthBalanceVal.Location = new System.Drawing.Point(273, 164);
            this.labelMonthBalanceVal.Name = "labelMonthBalanceVal";
            this.labelMonthBalanceVal.Size = new System.Drawing.Size(26, 34);
            this.labelMonthBalanceVal.TabIndex = 9;
            this.labelMonthBalanceVal.Text = "-";
            // 
            // labelTotalBalanceVal
            // 
            this.labelTotalBalanceVal.AutoSize = true;
            this.labelTotalBalanceVal.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBalanceVal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalBalanceVal.Location = new System.Drawing.Point(228, 83);
            this.labelTotalBalanceVal.Name = "labelTotalBalanceVal";
            this.labelTotalBalanceVal.Size = new System.Drawing.Size(26, 34);
            this.labelTotalBalanceVal.TabIndex = 10;
            this.labelTotalBalanceVal.Text = "-";
            // 
            // PanelHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.monthPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.panelMonthBalance);
            this.Controls.Add(this.panelCurrentBalance);
            this.Name = "PanelHome";
            this.Size = new System.Drawing.Size(1342, 864);
            this.panelCurrentBalance.ResumeLayout(false);
            this.panelCurrentBalance.PerformLayout();
            this.panelMonthBalance.ResumeLayout(false);
            this.panelMonthBalance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelCurrentBalance;
        private System.Windows.Forms.Label labelTotalBalance;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panelMonthBalance;
        private System.Windows.Forms.Label labelMonthBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDaysCounter;
        private System.Windows.Forms.Label labelMonthExpenses;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart chartCartesian;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox monthPicker;
        private System.Windows.Forms.Label labelMonthEntries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMonthBalanceVal;
        private System.Windows.Forms.Label labelMonthExpensesVal;
        private System.Windows.Forms.Label labelMonthEntriesVal;
        private System.Windows.Forms.Label labelTotalBalanceVal;
    }
}
