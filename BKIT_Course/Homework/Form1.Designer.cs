namespace Homework
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null; /// Required designer variable.

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
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonExact = new System.Windows.Forms.Button();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxApproxTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonApprox = new System.Windows.Forms.Button();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxThreadCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxThreadCountAll = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLoadFile.Location = new System.Drawing.Point(21, 17);
            this.buttonLoadFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(177, 35);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Чтение из файла";
            this.buttonLoadFile.UseVisualStyleBackColor = false;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время чтения из файла:";
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(424, 22);
            this.textBoxFileReadTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.ReadOnly = true;
            this.textBoxFileReadTime.Size = new System.Drawing.Size(349, 26);
            this.textBoxFileReadTime.TabIndex = 2;
            this.textBoxFileReadTime.TextChanged += new System.EventHandler(this.textBoxFileReadTime_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слово для поиска:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(477, 107);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(296, 26);
            this.textBoxFind.TabIndex = 4;
            // 
            // buttonExact
            // 
            this.buttonExact.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExact.Location = new System.Drawing.Point(22, 153);
            this.buttonExact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(176, 35);
            this.buttonExact.TabIndex = 5;
            this.buttonExact.Text = "Точный поиск";
            this.buttonExact.UseVisualStyleBackColor = false;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.Location = new System.Drawing.Point(433, 153);
            this.textBoxExactTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.ReadOnly = true;
            this.textBoxExactTime.Size = new System.Drawing.Size(340, 26);
            this.textBoxExactTime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время четкого поиска:";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(803, 22);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(480, 404);
            this.listBoxResult.TabIndex = 8;
            // 
            // textBoxApproxTime
            // 
            this.textBoxApproxTime.Location = new System.Drawing.Point(435, 335);
            this.textBoxApproxTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxApproxTime.Name = "textBoxApproxTime";
            this.textBoxApproxTime.ReadOnly = true;
            this.textBoxApproxTime.Size = new System.Drawing.Size(340, 26);
            this.textBoxApproxTime.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Время нечеткого поиска:";
            // 
            // buttonApprox
            // 
            this.buttonApprox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonApprox.Location = new System.Drawing.Point(22, 254);
            this.buttonApprox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonApprox.Name = "buttonApprox";
            this.buttonApprox.Size = new System.Drawing.Size(176, 69);
            this.buttonApprox.TabIndex = 9;
            this.buttonApprox.Text = "Параллельный неточный поиск";
            this.buttonApprox.UseVisualStyleBackColor = false;
            this.buttonApprox.Click += new System.EventHandler(this.buttonApprox_Click);
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(665, 203);
            this.textBoxMaxDist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(110, 26);
            this.textBoxMaxDist.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Максимальное расстояние для нечеткого поиска:";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExit.Location = new System.Drawing.Point(424, 391);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(178, 35);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSaveReport.Location = new System.Drawing.Point(117, 391);
            this.buttonSaveReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(210, 35);
            this.buttonSaveReport.TabIndex = 15;
            this.buttonSaveReport.Text = "Сохранение отчета";
            this.buttonSaveReport.UseVisualStyleBackColor = false;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.Location = new System.Drawing.Point(534, 62);
            this.textBoxFileReadCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.ReadOnly = true;
            this.textBoxFileReadCount.Size = new System.Drawing.Size(240, 26);
            this.textBoxFileReadCount.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Количество уникальных слов в файле:";
            // 
            // textBoxThreadCount
            // 
            this.textBoxThreadCount.Location = new System.Drawing.Point(675, 248);
            this.textBoxThreadCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxThreadCount.Name = "textBoxThreadCount";
            this.textBoxThreadCount.Size = new System.Drawing.Size(100, 26);
            this.textBoxThreadCount.TabIndex = 19;
            this.textBoxThreadCount.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Количество потоков:";
            // 
            // textBoxThreadCountAll
            // 
            this.textBoxThreadCountAll.Location = new System.Drawing.Point(666, 292);
            this.textBoxThreadCountAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxThreadCountAll.Name = "textBoxThreadCountAll";
            this.textBoxThreadCountAll.ReadOnly = true;
            this.textBoxThreadCountAll.Size = new System.Drawing.Size(109, 26);
            this.textBoxThreadCountAll.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 298);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Вычисленное количество потоков:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1296, 476);
            this.Controls.Add(this.textBoxThreadCountAll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxThreadCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSaveReport);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxApproxTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonApprox);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExact);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoadFile);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Домашняя работа по БКИТ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonExact;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxApproxTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonApprox;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxThreadCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxThreadCountAll;
        private System.Windows.Forms.Label label8;
    }
}

