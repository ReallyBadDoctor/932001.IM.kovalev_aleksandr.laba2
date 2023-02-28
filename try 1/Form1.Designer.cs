namespace try_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rubnow = new System.Windows.Forms.NumericUpDown();
            this.unow = new System.Windows.Forms.NumericUpDown();
            this.ustart = new System.Windows.Forms.NumericUpDown();
            this.rubstart = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.rubstart);
            this.panel1.Controls.Add(this.ustart);
            this.panel1.Controls.Add(this.unow);
            this.panel1.Controls.Add(this.rubnow);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "USD START";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUB START";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUB NOW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "USD NOW";
            // 
            // rubnow
            // 
            this.rubnow.DecimalPlaces = 2;
            this.rubnow.Location = new System.Drawing.Point(255, 39);
            this.rubnow.Name = "rubnow";
            this.rubnow.Size = new System.Drawing.Size(75, 22);
            this.rubnow.TabIndex = 4;
            this.rubnow.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // unow
            // 
            this.unow.DecimalPlaces = 2;
            this.unow.Location = new System.Drawing.Point(255, 5);
            this.unow.Name = "unow";
            this.unow.Size = new System.Drawing.Size(75, 22);
            this.unow.TabIndex = 1;
            this.unow.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // ustart
            // 
            this.ustart.DecimalPlaces = 2;
            this.ustart.Location = new System.Drawing.Point(89, 3);
            this.ustart.Name = "ustart";
            this.ustart.Size = new System.Drawing.Size(82, 22);
            this.ustart.TabIndex = 5;
            this.ustart.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // rubstart
            // 
            this.rubstart.DecimalPlaces = 2;
            this.rubstart.Location = new System.Drawing.Point(89, 39);
            this.rubstart.Name = "rubstart";
            this.rubstart.Size = new System.Drawing.Size(82, 22);
            this.rubstart.TabIndex = 6;
            this.rubstart.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(429, 10);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 38);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Act/Stop";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(18, 97);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "USD";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "RUB";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(996, 430);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 591);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown rubstart;
        private System.Windows.Forms.NumericUpDown ustart;
        private System.Windows.Forms.NumericUpDown unow;
        private System.Windows.Forms.NumericUpDown rubnow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

