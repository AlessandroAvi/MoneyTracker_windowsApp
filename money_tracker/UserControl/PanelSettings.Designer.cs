namespace money_tracker
{
    partial class PanelSettings
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
            this.buttonPathXML = new Guna.UI2.WinForms.Guna2Button();
            this.textPathXML = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCat = new System.Windows.Forms.Label();
            this.labelMod = new System.Windows.Forms.Label();
            this.listViewCat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMod = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCat = new Guna.UI2.WinForms.Guna2Button();
            this.buttonMod = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // buttonPathXML
            // 
            this.buttonPathXML.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPathXML.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPathXML.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPathXML.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPathXML.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPathXML.ForeColor = System.Drawing.Color.White;
            this.buttonPathXML.Location = new System.Drawing.Point(66, 51);
            this.buttonPathXML.Name = "buttonPathXML";
            this.buttonPathXML.Size = new System.Drawing.Size(160, 40);
            this.buttonPathXML.TabIndex = 3;
            this.buttonPathXML.Text = "Cfg path";
            this.buttonPathXML.Click += new System.EventHandler(this.buttonPathXML_Click);
            // 
            // textPathXML
            // 
            this.textPathXML.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPathXML.DefaultText = "";
            this.textPathXML.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPathXML.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPathXML.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPathXML.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPathXML.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPathXML.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPathXML.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPathXML.Location = new System.Drawing.Point(283, 51);
            this.textPathXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPathXML.Name = "textPathXML";
            this.textPathXML.PasswordChar = '\0';
            this.textPathXML.PlaceholderText = "";
            this.textPathXML.SelectedText = "";
            this.textPathXML.Size = new System.Drawing.Size(620, 40);
            this.textPathXML.TabIndex = 4;
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCat.Location = new System.Drawing.Point(62, 172);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(107, 24);
            this.labelCat.TabIndex = 6;
            this.labelCat.Text = "Categories";
            // 
            // labelMod
            // 
            this.labelMod.AutoSize = true;
            this.labelMod.Font = new System.Drawing.Font("Roboto", 12F);
            this.labelMod.Location = new System.Drawing.Point(542, 172);
            this.labelMod.Name = "labelMod";
            this.labelMod.Size = new System.Drawing.Size(189, 24);
            this.labelMod.TabIndex = 8;
            this.labelMod.Text = "Payment modalities";
            // 
            // listViewCat
            // 
            this.listViewCat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewCat.Font = new System.Drawing.Font("Roboto", 12F);
            this.listViewCat.HideSelection = false;
            this.listViewCat.Location = new System.Drawing.Point(66, 221);
            this.listViewCat.Name = "listViewCat";
            this.listViewCat.Size = new System.Drawing.Size(290, 270);
            this.listViewCat.TabIndex = 9;
            this.listViewCat.UseCompatibleStateImageBehavior = false;
            this.listViewCat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CATEGORY";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "VALUE";
            this.columnHeader2.Width = 130;
            // 
            // listViewMod
            // 
            this.listViewMod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewMod.Font = new System.Drawing.Font("Roboto", 12F);
            this.listViewMod.HideSelection = false;
            this.listViewMod.Location = new System.Drawing.Point(546, 221);
            this.listViewMod.Name = "listViewMod";
            this.listViewMod.Size = new System.Drawing.Size(290, 270);
            this.listViewMod.TabIndex = 10;
            this.listViewMod.UseCompatibleStateImageBehavior = false;
            this.listViewMod.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MODALITY";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "VALUE";
            this.columnHeader4.Width = 130;
            // 
            // buttonCat
            // 
            this.buttonCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCat.ForeColor = System.Drawing.Color.White;
            this.buttonCat.Location = new System.Drawing.Point(256, 497);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(100, 40);
            this.buttonCat.TabIndex = 11;
            this.buttonCat.Text = "ADD";
            this.buttonCat.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMod.ForeColor = System.Drawing.Color.White;
            this.buttonMod.Location = new System.Drawing.Point(736, 497);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(100, 40);
            this.buttonMod.TabIndex = 12;
            this.buttonMod.Text = "ADD";
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(1135, 802);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 45);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // PanelSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonCat);
            this.Controls.Add(this.listViewMod);
            this.Controls.Add(this.listViewCat);
            this.Controls.Add(this.labelMod);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.textPathXML);
            this.Controls.Add(this.buttonPathXML);
            this.Name = "PanelSettings";
            this.Size = new System.Drawing.Size(1342, 864);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button buttonPathXML;
        private Guna.UI2.WinForms.Guna2TextBox textPathXML;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label labelMod;
        private System.Windows.Forms.ListView listViewCat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewMod;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2Button buttonCat;
        private Guna.UI2.WinForms.Guna2Button buttonMod;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
    }
}
