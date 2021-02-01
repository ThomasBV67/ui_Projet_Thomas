namespace UI_projet
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCurrentTemp = new System.Windows.Forms.Button();
            this.panelSelectSection = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTempHistory = new System.Windows.Forms.Button();
            this.btnAddCapt = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabCurrentTemp = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.tabAddCapt = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelSelectSection.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabCurrentTemp.SuspendLayout();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCurrentTemp
            // 
            this.btnCurrentTemp.Location = new System.Drawing.Point(3, 3);
            this.btnCurrentTemp.Name = "btnCurrentTemp";
            this.btnCurrentTemp.Size = new System.Drawing.Size(145, 66);
            this.btnCurrentTemp.TabIndex = 0;
            this.btnCurrentTemp.Text = "Températures actuelles";
            this.btnCurrentTemp.UseVisualStyleBackColor = true;
            this.btnCurrentTemp.Click += new System.EventHandler(this.btnCurrentTemp_Click);
            // 
            // panelSelectSection
            // 
            this.panelSelectSection.Controls.Add(this.btnCurrentTemp);
            this.panelSelectSection.Controls.Add(this.btnTempHistory);
            this.panelSelectSection.Controls.Add(this.btnAddCapt);
            this.panelSelectSection.Controls.Add(this.btnInfo);
            this.panelSelectSection.Location = new System.Drawing.Point(0, -1);
            this.panelSelectSection.Name = "panelSelectSection";
            this.panelSelectSection.Size = new System.Drawing.Size(153, 574);
            this.panelSelectSection.TabIndex = 1;
            // 
            // btnTempHistory
            // 
            this.btnTempHistory.Location = new System.Drawing.Point(3, 75);
            this.btnTempHistory.Name = "btnTempHistory";
            this.btnTempHistory.Size = new System.Drawing.Size(145, 66);
            this.btnTempHistory.TabIndex = 1;
            this.btnTempHistory.Text = "Historique des températures";
            this.btnTempHistory.UseVisualStyleBackColor = true;
            this.btnTempHistory.Click += new System.EventHandler(this.btnTempHistory_Click);
            // 
            // btnAddCapt
            // 
            this.btnAddCapt.Location = new System.Drawing.Point(3, 147);
            this.btnAddCapt.Name = "btnAddCapt";
            this.btnAddCapt.Size = new System.Drawing.Size(145, 66);
            this.btnAddCapt.TabIndex = 2;
            this.btnAddCapt.Text = "Ajout de capteurs";
            this.btnAddCapt.UseVisualStyleBackColor = true;
            this.btnAddCapt.Click += new System.EventHandler(this.btnAddCapt_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(3, 219);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(145, 66);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabCurrentTemp);
            this.tabControlMain.Controls.Add(this.tabHistory);
            this.tabControlMain.Controls.Add(this.tabAddCapt);
            this.tabControlMain.Controls.Add(this.tabInfo);
            this.tabControlMain.Location = new System.Drawing.Point(155, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(911, 571);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabCurrentTemp
            // 
            this.tabCurrentTemp.Controls.Add(this.textBox1);
            this.tabCurrentTemp.Controls.Add(this.button2);
            this.tabCurrentTemp.Controls.Add(this.tb);
            this.tabCurrentTemp.Controls.Add(this.button1);
            this.tabCurrentTemp.Location = new System.Drawing.Point(4, 22);
            this.tabCurrentTemp.Name = "tabCurrentTemp";
            this.tabCurrentTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrentTemp.Size = new System.Drawing.Size(903, 545);
            this.tabCurrentTemp.TabIndex = 0;
            this.tabCurrentTemp.Text = "Températures actuelles";
            this.tabCurrentTemp.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 153);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Capteur : \r\nChambre Froide 3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 263);
            this.button2.TabIndex = 2;
            this.button2.Text = "Capteur précédent";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(400, 349);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(204, 80);
            this.tb.TabIndex = 1;
            this.tb.Text = "3.4 oC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 263);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prochain capteur";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.chart1);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(903, 545);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "Historique des températures";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // tabAddCapt
            // 
            this.tabAddCapt.Location = new System.Drawing.Point(4, 22);
            this.tabAddCapt.Name = "tabAddCapt";
            this.tabAddCapt.Size = new System.Drawing.Size(903, 545);
            this.tabAddCapt.TabIndex = 2;
            this.tabAddCapt.Text = "Ajout de capteurs";
            this.tabAddCapt.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(903, 545);
            this.tabInfo.TabIndex = 3;
            this.tabInfo.Text = "Information";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(891, 533);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 575);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelSelectSection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSelectSection.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabCurrentTemp.ResumeLayout(false);
            this.tabCurrentTemp.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCurrentTemp;
        private System.Windows.Forms.FlowLayoutPanel panelSelectSection;
        private System.Windows.Forms.Button btnTempHistory;
        private System.Windows.Forms.Button btnAddCapt;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabCurrentTemp;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabAddCapt;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

