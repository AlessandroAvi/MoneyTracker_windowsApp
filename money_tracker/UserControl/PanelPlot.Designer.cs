namespace money_tracker
{
    partial class PanelPlot
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pieChartNecessary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChartModality = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barChart_ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartNecessary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartModality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart_)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChartNecessary
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChartNecessary.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChartNecessary.Legends.Add(legend1);
            this.pieChartNecessary.Location = new System.Drawing.Point(50, 65);
            this.pieChartNecessary.Name = "pieChartNecessary";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChartNecessary.Series.Add(series1);
            this.pieChartNecessary.Size = new System.Drawing.Size(570, 350);
            this.pieChartNecessary.TabIndex = 4;
            this.pieChartNecessary.Text = "chart1";
            // 
            // pieChartCategory
            // 
            chartArea2.Name = "ChartArea1";
            this.pieChartCategory.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieChartCategory.Legends.Add(legend2);
            this.pieChartCategory.Location = new System.Drawing.Point(730, 495);
            this.pieChartCategory.Name = "pieChartCategory";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieChartCategory.Series.Add(series2);
            this.pieChartCategory.Size = new System.Drawing.Size(570, 350);
            this.pieChartCategory.TabIndex = 5;
            this.pieChartCategory.Text = "chart2";
            // 
            // pieChartModality
            // 
            chartArea3.Name = "ChartArea1";
            this.pieChartModality.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pieChartModality.Legends.Add(legend3);
            this.pieChartModality.Location = new System.Drawing.Point(50, 495);
            this.pieChartModality.Name = "pieChartModality";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pieChartModality.Series.Add(series3);
            this.pieChartModality.Size = new System.Drawing.Size(570, 350);
            this.pieChartModality.TabIndex = 6;
            this.pieChartModality.Text = "chart2";
            // 
            // barChart_
            // 
            chartArea4.Name = "ChartArea1";
            this.barChart_.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.barChart_.Legends.Add(legend4);
            this.barChart_.Location = new System.Drawing.Point(730, 65);
            this.barChart_.Name = "barChart_";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.barChart_.Series.Add(series4);
            this.barChart_.Size = new System.Drawing.Size(570, 350);
            this.barChart_.TabIndex = 7;
            this.barChart_.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(723, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Expenses by method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "Expenses by category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Macro expense goups";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(723, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "Expense by category";
            // 
            // PanelPlot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barChart_);
            this.Controls.Add(this.pieChartModality);
            this.Controls.Add(this.pieChartCategory);
            this.Controls.Add(this.pieChartNecessary);
            this.Name = "PanelPlot";
            this.Size = new System.Drawing.Size(1342, 864);
            ((System.ComponentModel.ISupportInitialize)(this.pieChartNecessary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartModality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartNecessary;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartModality;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
