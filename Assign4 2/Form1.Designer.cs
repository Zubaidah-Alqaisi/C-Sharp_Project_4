namespace Assign4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 1.5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 3D);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pointChart = new System.Windows.Forms.RadioButton();
            this.columnChart = new System.Windows.Forms.RadioButton();
            this.pieChart = new System.Windows.Forms.RadioButton();
            this.barChart = new System.Windows.Forms.RadioButton();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ChooseAFile = new System.Windows.Forms.Button();
            this.ValueFromFile = new System.Windows.Forms.Button();
            this.ValueAtRandom = new System.Windows.Forms.Button();
            this.ValueFromUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(268, 36);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(397, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pointChart);
            this.groupBox1.Controls.Add(this.columnChart);
            this.groupBox1.Controls.Add(this.pieChart);
            this.groupBox1.Controls.Add(this.barChart);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(296, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chart Options";
            // 
            // pointChart
            // 
            this.pointChart.AutoSize = true;
            this.pointChart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointChart.Location = new System.Drawing.Point(190, 80);
            this.pointChart.Name = "pointChart";
            this.pointChart.Size = new System.Drawing.Size(100, 23);
            this.pointChart.TabIndex = 3;
            this.pointChart.TabStop = true;
            this.pointChart.Text = "Point Chart ";
            this.pointChart.UseVisualStyleBackColor = true;
            this.pointChart.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // columnChart
            // 
            this.columnChart.AutoSize = true;
            this.columnChart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnChart.Location = new System.Drawing.Point(190, 35);
            this.columnChart.Name = "columnChart";
            this.columnChart.Size = new System.Drawing.Size(116, 23);
            this.columnChart.TabIndex = 2;
            this.columnChart.TabStop = true;
            this.columnChart.Text = "Column Chart ";
            this.columnChart.UseVisualStyleBackColor = true;
            this.columnChart.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // pieChart
            // 
            this.pieChart.AutoSize = true;
            this.pieChart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChart.Location = new System.Drawing.Point(17, 80);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(88, 23);
            this.pieChart.TabIndex = 1;
            this.pieChart.TabStop = true;
            this.pieChart.Text = "Pie Chart ";
            this.pieChart.UseVisualStyleBackColor = true;
            this.pieChart.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // barChart
            // 
            this.barChart.AutoSize = true;
            this.barChart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barChart.Location = new System.Drawing.Point(17, 35);
            this.barChart.Name = "barChart";
            this.barChart.Size = new System.Drawing.Size(87, 23);
            this.barChart.TabIndex = 0;
            this.barChart.TabStop = true;
            this.barChart.Text = "Bar Chart";
            this.barChart.UseVisualStyleBackColor = true;
            this.barChart.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(12, 78);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(99, 20);
            this.numberTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter a number below";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(563, 537);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(102, 33);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(431, 537);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(105, 33);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ChooseAFile
            // 
            this.ChooseAFile.AutoSize = true;
            this.ChooseAFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseAFile.Location = new System.Drawing.Point(66, 132);
            this.ChooseAFile.Name = "ChooseAFile";
            this.ChooseAFile.Size = new System.Drawing.Size(121, 29);
            this.ChooseAFile.TabIndex = 8;
            this.ChooseAFile.Text = "Choose a file ";
            this.ChooseAFile.UseVisualStyleBackColor = true;
            this.ChooseAFile.Click += new System.EventHandler(this.ChooseAFile_Click);
            // 
            // ValueFromFile
            // 
            this.ValueFromFile.AutoSize = true;
            this.ValueFromFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueFromFile.Location = new System.Drawing.Point(66, 184);
            this.ValueFromFile.Name = "ValueFromFile";
            this.ValueFromFile.Size = new System.Drawing.Size(121, 29);
            this.ValueFromFile.TabIndex = 9;
            this.ValueFromFile.Text = "Value from File ";
            this.ValueFromFile.UseVisualStyleBackColor = true;
            this.ValueFromFile.Click += new System.EventHandler(this.ValueFromFile_Click);
            // 
            // ValueAtRandom
            // 
            this.ValueAtRandom.AutoSize = true;
            this.ValueAtRandom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueAtRandom.Location = new System.Drawing.Point(66, 238);
            this.ValueAtRandom.Name = "ValueAtRandom";
            this.ValueAtRandom.Size = new System.Drawing.Size(122, 29);
            this.ValueAtRandom.TabIndex = 10;
            this.ValueAtRandom.Text = "Value at Random";
            this.ValueAtRandom.UseVisualStyleBackColor = true;
            this.ValueAtRandom.Click += new System.EventHandler(this.ValueAtRandom_Click);
            // 
            // ValueFromUser
            // 
            this.ValueFromUser.AutoSize = true;
            this.ValueFromUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueFromUser.Location = new System.Drawing.Point(129, 72);
            this.ValueFromUser.Name = "ValueFromUser";
            this.ValueFromUser.Size = new System.Drawing.Size(121, 29);
            this.ValueFromUser.TabIndex = 11;
            this.ValueFromUser.Text = "Value from User ";
            this.ValueFromUser.UseVisualStyleBackColor = true;
            this.ValueFromUser.Click += new System.EventHandler(this.ValueFromUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 587);
            this.Controls.Add(this.ValueFromUser);
            this.Controls.Add(this.ValueAtRandom);
            this.Controls.Add(this.ValueFromFile);
            this.Controls.Add(this.ChooseAFile);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pointChart;
        private System.Windows.Forms.RadioButton columnChart;
        private System.Windows.Forms.RadioButton pieChart;
        private System.Windows.Forms.RadioButton barChart;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ChooseAFile;
        private System.Windows.Forms.Button ValueFromFile;
        private System.Windows.Forms.Button ValueAtRandom;
        private System.Windows.Forms.Button ValueFromUser;
    }
}

