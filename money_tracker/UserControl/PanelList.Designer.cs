namespace money_tracker
{
    partial class PanelList
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
            this.ButtonAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.listViewTransactions = new System.Windows.Forms.ListView();
            this.col0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDateApply = new Guna.UI2.WinForms.Guna2Button();
            this.datePickerBegin1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datePickerEnd1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonPDF = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAddItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAddItem.Font = new System.Drawing.Font("Roboto", 10.8F);
            this.ButtonAddItem.ForeColor = System.Drawing.Color.White;
            this.ButtonAddItem.Location = new System.Drawing.Point(64, 781);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(180, 45);
            this.ButtonAddItem.TabIndex = 1;
            this.ButtonAddItem.Text = "Add item";
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // listViewTransactions
            // 
            this.listViewTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col0,
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.listViewTransactions.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTransactions.HideSelection = false;
            this.listViewTransactions.Location = new System.Drawing.Point(64, 138);
            this.listViewTransactions.Name = "listViewTransactions";
            this.listViewTransactions.Size = new System.Drawing.Size(1207, 613);
            this.listViewTransactions.TabIndex = 3;
            this.listViewTransactions.UseCompatibleStateImageBehavior = false;
            this.listViewTransactions.View = System.Windows.Forms.View.Details;
            // 
            // col0
            // 
            this.col0.Text = "DATE";
            this.col0.Width = 150;
            // 
            // col1
            // 
            this.col1.Text = "AMOUNT";
            this.col1.Width = 150;
            // 
            // col2
            // 
            this.col2.Text = "TYPE";
            this.col2.Width = 150;
            // 
            // col3
            // 
            this.col3.Text = "MODALITY";
            this.col3.Width = 200;
            // 
            // col4
            // 
            this.col4.Text = "CATEGORY";
            this.col4.Width = 200;
            // 
            // col5
            // 
            this.col5.Text = "NOTES";
            this.col5.Width = 285;
            // 
            // buttonDateApply
            // 
            this.buttonDateApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDateApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDateApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDateApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDateApply.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDateApply.ForeColor = System.Drawing.Color.White;
            this.buttonDateApply.Location = new System.Drawing.Point(683, 68);
            this.buttonDateApply.Name = "buttonDateApply";
            this.buttonDateApply.Size = new System.Drawing.Size(100, 40);
            this.buttonDateApply.TabIndex = 8;
            this.buttonDateApply.Text = "Apply";
            this.buttonDateApply.Click += new System.EventHandler(this.buttonDateApply_Click);
            // 
            // datePickerBegin1
            // 
            this.datePickerBegin1.Checked = true;
            this.datePickerBegin1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePickerBegin1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickerBegin1.Location = new System.Drawing.Point(64, 68);
            this.datePickerBegin1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerBegin1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerBegin1.Name = "datePickerBegin1";
            this.datePickerBegin1.Size = new System.Drawing.Size(274, 40);
            this.datePickerBegin1.TabIndex = 9;
            this.datePickerBegin1.Value = new System.DateTime(2022, 5, 21, 17, 31, 53, 82);
            this.datePickerBegin1.ValueChanged += new System.EventHandler(this.datePickerBegin1_ValueChanged);
            // 
            // datePickerEnd1
            // 
            this.datePickerEnd1.Checked = true;
            this.datePickerEnd1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePickerEnd1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickerEnd1.Location = new System.Drawing.Point(368, 68);
            this.datePickerEnd1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerEnd1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerEnd1.Name = "datePickerEnd1";
            this.datePickerEnd1.Size = new System.Drawing.Size(274, 40);
            this.datePickerEnd1.TabIndex = 10;
            this.datePickerEnd1.Value = new System.DateTime(2022, 5, 21, 17, 31, 58, 799);
            this.datePickerEnd1.ValueChanged += new System.EventHandler(this.datePickerEnd1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select starting date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select end date";
            // 
            // ButtonPDF
            // 
            this.ButtonPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonPDF.Font = new System.Drawing.Font("Roboto", 10.8F);
            this.ButtonPDF.ForeColor = System.Drawing.Color.White;
            this.ButtonPDF.Location = new System.Drawing.Point(1094, 781);
            this.ButtonPDF.Name = "ButtonPDF";
            this.ButtonPDF.Size = new System.Drawing.Size(177, 45);
            this.ButtonPDF.TabIndex = 13;
            this.ButtonPDF.Text = "Generate PDF";
            this.ButtonPDF.Click += new System.EventHandler(this.ButtonPDF_Click);
            // 
            // PanelList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.ButtonPDF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickerEnd1);
            this.Controls.Add(this.datePickerBegin1);
            this.Controls.Add(this.buttonDateApply);
            this.Controls.Add(this.listViewTransactions);
            this.Controls.Add(this.ButtonAddItem);
            this.Name = "PanelList";
            this.Size = new System.Drawing.Size(1342, 864);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button ButtonAddItem;
        private System.Windows.Forms.ListView listViewTransactions;
        private System.Windows.Forms.ColumnHeader col0;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col5;
        private Guna.UI2.WinForms.Guna2Button buttonDateApply;
        private System.Windows.Forms.ColumnHeader col2;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickerBegin1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickerEnd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ButtonPDF;
    }
}
