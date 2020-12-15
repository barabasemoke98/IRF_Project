namespace TBCJ6C_IRF_beadando
{
    partial class CovidCasesForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.relLabel = new System.Windows.Forms.Label();
            this.country2 = new System.Windows.Forms.ComboBox();
            this.country1 = new System.Windows.Forms.ComboBox();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CountryCombo = new System.Windows.Forms.ComboBox();
            this.ContinentCombo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(10, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 370);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 367);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(412, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 370);
            this.panel2.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(380, 364);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.relLabel);
            this.panel3.Controls.Add(this.country2);
            this.panel3.Controls.Add(this.country1);
            this.panel3.Controls.Add(this.enddate);
            this.panel3.Controls.Add(this.startdate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.CountryCombo);
            this.panel3.Controls.Add(this.ContinentCombo);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(10, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 60);
            this.panel3.TabIndex = 2;
            // 
            // relLabel
            // 
            this.relLabel.AutoSize = true;
            this.relLabel.Location = new System.Drawing.Point(689, 40);
            this.relLabel.Name = "relLabel";
            this.relLabel.Size = new System.Drawing.Size(13, 13);
            this.relLabel.TabIndex = 11;
            this.relLabel.Text = "?";
            // 
            // country2
            // 
            this.country2.FormattingEnabled = true;
            this.country2.Location = new System.Drawing.Point(714, 36);
            this.country2.Name = "country2";
            this.country2.Size = new System.Drawing.Size(71, 21);
            this.country2.TabIndex = 10;
            // 
            // country1
            // 
            this.country1.FormattingEnabled = true;
            this.country1.Location = new System.Drawing.Point(608, 36);
            this.country1.Name = "country1";
            this.country1.Size = new System.Drawing.Size(71, 21);
            this.country1.TabIndex = 9;
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(402, 38);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(200, 20);
            this.enddate.TabIndex = 8;
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(402, 6);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(200, 20);
            this.startdate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Date";
            // 
            // CountryCombo
            // 
            this.CountryCombo.FormattingEnabled = true;
            this.CountryCombo.Location = new System.Drawing.Point(231, 37);
            this.CountryCombo.Name = "CountryCombo";
            this.CountryCombo.Size = new System.Drawing.Size(110, 21);
            this.CountryCombo.TabIndex = 4;
            // 
            // ContinentCombo
            // 
            this.ContinentCombo.FormattingEnabled = true;
            this.ContinentCombo.Location = new System.Drawing.Point(125, 37);
            this.ContinentCombo.Name = "ContinentCombo";
            this.ContinentCombo.Size = new System.Drawing.Size(100, 21);
            this.ContinentCombo.TabIndex = 3;
            this.ContinentCombo.SelectedIndexChanged += new System.EventHandler(this.ContinentCombo_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "Load CSV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Where are more cases?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CovidCasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CovidCasesForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label relLabel;
        private System.Windows.Forms.ComboBox country2;
        private System.Windows.Forms.ComboBox country1;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CountryCombo;
        private System.Windows.Forms.ComboBox ContinentCombo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

