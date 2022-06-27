namespace money_tracker
{
    partial class NewItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.textNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelModality = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.comboType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboMod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonOK = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textAmount
            // 
            this.textAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textAmount.DefaultText = "";
            this.textAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textAmount.Location = new System.Drawing.Point(250, 100);
            this.textAmount.Name = "textAmount";
            this.textAmount.PasswordChar = '\0';
            this.textAmount.PlaceholderText = "";
            this.textAmount.SelectedText = "";
            this.textAmount.Size = new System.Drawing.Size(249, 36);
            this.textAmount.TabIndex = 0;
            // 
            // textNotes
            // 
            this.textNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNotes.DefaultText = "";
            this.textNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textNotes.Location = new System.Drawing.Point(250, 380);
            this.textNotes.Name = "textNotes";
            this.textNotes.PasswordChar = '\0';
            this.textNotes.PlaceholderText = "";
            this.textNotes.SelectedText = "";
            this.textNotes.Size = new System.Drawing.Size(249, 82);
            this.textNotes.TabIndex = 4;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(90, 110);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(81, 24);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Amount";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Roboto", 12F);
            this.labelType.Location = new System.Drawing.Point(90, 180);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(52, 24);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "Type";
            // 
            // labelModality
            // 
            this.labelModality.AutoSize = true;
            this.labelModality.Font = new System.Drawing.Font("Roboto", 12F);
            this.labelModality.Location = new System.Drawing.Point(90, 250);
            this.labelModality.Name = "labelModality";
            this.labelModality.Size = new System.Drawing.Size(86, 24);
            this.labelModality.TabIndex = 7;
            this.labelModality.Text = "Modality";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.labelCategory.Location = new System.Drawing.Point(90, 320);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(90, 24);
            this.labelCategory.TabIndex = 8;
            this.labelCategory.Text = "Category";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Roboto", 12F);
            this.labelNote.Location = new System.Drawing.Point(90, 390);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(53, 24);
            this.labelNote.TabIndex = 9;
            this.labelNote.Text = "Note";
            // 
            // comboType
            // 
            this.comboType.BackColor = System.Drawing.Color.Transparent;
            this.comboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboType.ItemHeight = 30;
            this.comboType.Items.AddRange(new object[] {
            "EXPENSE",
            "INCOME"});
            this.comboType.Location = new System.Drawing.Point(250, 170);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(249, 36);
            this.comboType.TabIndex = 10;
            // 
            // comboMod
            // 
            this.comboMod.BackColor = System.Drawing.Color.Transparent;
            this.comboMod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboMod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboMod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboMod.ItemHeight = 30;
            this.comboMod.Items.AddRange(new object[] {
            "CASH",
            "PAYPAL",
            "PRE PAID CARD",
            "CONCO CORRENTE CARD"});
            this.comboMod.Location = new System.Drawing.Point(250, 240);
            this.comboMod.Name = "comboMod";
            this.comboMod.Size = new System.Drawing.Size(249, 36);
            this.comboMod.TabIndex = 11;
            // 
            // comboCat
            // 
            this.comboCat.BackColor = System.Drawing.Color.Transparent;
            this.comboCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboCat.ItemHeight = 30;
            this.comboCat.Items.AddRange(new object[] {
            "RENT",
            "GROCERIES",
            "LIVING",
            "TRANSPORT",
            "SPORT",
            "OTHER"});
            this.comboCat.Location = new System.Drawing.Point(250, 310);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(249, 36);
            this.comboCat.TabIndex = 12;
            // 
            // buttonOK
            // 
            this.buttonOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(399, 494);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 40);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(280, 494);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // datePicker
            // 
            this.datePicker.Checked = true;
            this.datePicker.FillColor = System.Drawing.Color.White;
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.Location = new System.Drawing.Point(250, 30);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(249, 36);
            this.datePicker.TabIndex = 15;
            this.datePicker.Value = new System.DateTime(2022, 5, 21, 16, 43, 13, 190);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Roboto", 12F);
            this.labelDate.Location = new System.Drawing.Point(90, 40);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 24);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Date";
            // 
            // NewItem
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(522, 541);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.comboMod);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelModality);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.textAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textAmount;
        private Guna.UI2.WinForms.Guna2TextBox textNotes;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelModality;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelNote;
        private Guna.UI2.WinForms.Guna2ComboBox comboType;
        private Guna.UI2.WinForms.Guna2ComboBox comboMod;
        private Guna.UI2.WinForms.Guna2ComboBox comboCat;
        private Guna.UI2.WinForms.Guna2Button buttonOK;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private System.Windows.Forms.Label labelDate;
    }
}