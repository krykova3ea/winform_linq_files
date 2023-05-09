using System;

namespace Laba4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.namePath = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.nameFilesN = new System.Windows.Forms.Label();
            this.numericNum = new System.Windows.Forms.NumericUpDown();
            this.methodType = new System.Windows.Forms.Label();
            this.linqUp = new System.Windows.Forms.RadioButton();
            this.linqDown = new System.Windows.Forms.RadioButton();
            this.filesCol = new System.Windows.Forms.Label();
            this.filesColNum = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.time4 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // namePath
            // 
            this.namePath.AutoSize = true;
            this.namePath.Location = new System.Drawing.Point(17, 19);
            this.namePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namePath.Name = "namePath";
            this.namePath.Size = new System.Drawing.Size(112, 16);
            this.namePath.TabIndex = 0;
            this.namePath.Text = "Заданный путь: ";
            // 
            // pathBox
            // 
            this.pathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathBox.Location = new System.Drawing.Point(140, 19);
            this.pathBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(186, 22);
            this.pathBox.TabIndex = 1;
            // 
            // nameFilesN
            // 
            this.nameFilesN.AutoSize = true;
            this.nameFilesN.Location = new System.Drawing.Point(17, 59);
            this.nameFilesN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameFilesN.Name = "nameFilesN";
            this.nameFilesN.Size = new System.Drawing.Size(145, 16);
            this.nameFilesN.TabIndex = 2;
            this.nameFilesN.Text = "Количество файлов: ";
            // 
            // numericNum
            // 
            this.numericNum.Location = new System.Drawing.Point(176, 59);
            this.numericNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericNum.Name = "numericNum";
            this.numericNum.Size = new System.Drawing.Size(56, 22);
            this.numericNum.TabIndex = 3;
            this.numericNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // methodType
            // 
            this.methodType.AutoSize = true;
            this.methodType.Location = new System.Drawing.Point(17, 105);
            this.methodType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.methodType.Name = "methodType";
            this.methodType.Size = new System.Drawing.Size(141, 16);
            this.methodType.TabIndex = 4;
            this.methodType.Text = "Способ выполнения:";
            // 
            // linqUp
            // 
            this.linqUp.AutoSize = true;
            this.linqUp.Checked = true;
            this.linqUp.Location = new System.Drawing.Point(21, 133);
            this.linqUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.linqUp.Name = "linqUp";
            this.linqUp.Size = new System.Drawing.Size(70, 20);
            this.linqUp.TabIndex = 5;
            this.linqUp.TabStop = true;
            this.linqUp.Text = "С LINQ";
            this.linqUp.UseVisualStyleBackColor = true;
            this.linqUp.CheckedChanged += new System.EventHandler(this.linqUp_CheckedChanged);
            // 
            // linqDown
            // 
            this.linqDown.AutoSize = true;
            this.linqDown.Location = new System.Drawing.Point(21, 156);
            this.linqDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.linqDown.Name = "linqDown";
            this.linqDown.Size = new System.Drawing.Size(86, 20);
            this.linqDown.TabIndex = 6;
            this.linqDown.TabStop = true;
            this.linqDown.Text = "Без LINQ";
            this.linqDown.UseVisualStyleBackColor = true;
            this.linqDown.CheckedChanged += new System.EventHandler(this.linqDown_CheckedChanged);
            // 
            // filesCol
            // 
            this.filesCol.AutoSize = true;
            this.filesCol.Location = new System.Drawing.Point(337, 19);
            this.filesCol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filesCol.Name = "filesCol";
            this.filesCol.Size = new System.Drawing.Size(125, 16);
            this.filesCol.TabIndex = 7;
            this.filesCol.Text = "Найдено файлов: ";
            // 
            // filesColNum
            // 
            this.filesColNum.AutoSize = true;
            this.filesColNum.Location = new System.Drawing.Point(462, 19);
            this.filesColNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filesColNum.Name = "filesColNum";
            this.filesColNum.Size = new System.Drawing.Size(14, 16);
            this.filesColNum.TabIndex = 8;
            this.filesColNum.Text = "0";
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(80, 550);
            this.time1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(141, 16);
            this.time1.TabIndex = 9;
            this.time1.Text = "Время выполнения: -";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 569);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(265, 153);
            this.dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 730);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Самый большой файл";
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(481, 550);
            this.time2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(141, 16);
            this.time2.TabIndex = 12;
            this.time2.Text = "Время выполнения: -";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(417, 569);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.RowTemplate.Height = 31;
            this.dataGridView2.Size = new System.Drawing.Size(284, 153);
            this.dataGridView2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 730);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Top-N длинных по размеру";
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Location = new System.Drawing.Point(80, 779);
            this.time3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(141, 16);
            this.time3.TabIndex = 15;
            this.time3.Text = "Время выполнения: -";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(31, 798);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 72;
            this.dataGridView3.RowTemplate.Height = 31;
            this.dataGridView3.Size = new System.Drawing.Size(265, 155);
            this.dataGridView3.TabIndex = 16;
            // 
            // time4
            // 
            this.time4.AutoSize = true;
            this.time4.Location = new System.Drawing.Point(481, 779);
            this.time4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time4.Name = "time4";
            this.time4.Size = new System.Drawing.Size(141, 16);
            this.time4.TabIndex = 17;
            this.time4.Text = "Время выполнения: -";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(417, 798);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 72;
            this.dataGridView4.RowTemplate.Height = 31;
            this.dataGridView4.Size = new System.Drawing.Size(284, 155);
            this.dataGridView4.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 961);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Файлы-псевдодубликаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 961);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Распределение вложенных папок по размеру";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(530, 19);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(612, 328);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(21, 198);
            this.chart2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(486, 349);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(728, 588);
            this.chart3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(409, 365);
            this.chart3.TabIndex = 23;
            this.chart3.Text = "chart3";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(459, 61);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Количество псевдодубликатов: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 703);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.time4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.filesColNum);
            this.Controls.Add(this.filesCol);
            this.Controls.Add(this.linqDown);
            this.Controls.Add(this.linqUp);
            this.Controls.Add(this.methodType);
            this.Controls.Add(this.numericNum);
            this.Controls.Add(this.nameFilesN);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.namePath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namePath;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label nameFilesN;
        private System.Windows.Forms.NumericUpDown numericNum;
        private System.Windows.Forms.Label methodType;
        private System.Windows.Forms.RadioButton linqUp;
        private System.Windows.Forms.RadioButton linqDown;
        private System.Windows.Forms.Label filesCol;
        private System.Windows.Forms.Label filesColNum;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label time4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
    }
}

