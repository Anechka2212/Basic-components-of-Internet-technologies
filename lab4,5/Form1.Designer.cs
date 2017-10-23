namespace Lab4
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
            this.file = new System.Windows.Forms.Button();
            this.FileReadTime = new System.Windows.Forms.TextBox();
            this.FileReadCount = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.TextBox();
            this.SeachTime = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.ListBox();
            this.Approx = new System.Windows.Forms.Button();
            this.MaxDist = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.file.Location = new System.Drawing.Point(12, 12);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(191, 52);
            this.file.TabIndex = 0;
            this.file.Text = "Чтение из файла";
            this.file.UseVisualStyleBackColor = false;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // FileReadTime
            // 
            this.FileReadTime.Location = new System.Drawing.Point(228, 12);
            this.FileReadTime.Name = "FileReadTime";
            this.FileReadTime.Size = new System.Drawing.Size(327, 26);
            this.FileReadTime.TabIndex = 1;
            // 
            // FileReadCount
            // 
            this.FileReadCount.Location = new System.Drawing.Point(228, 59);
            this.FileReadCount.Name = "FileReadCount";
            this.FileReadCount.Size = new System.Drawing.Size(327, 26);
            this.FileReadCount.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Search.Location = new System.Drawing.Point(31, 125);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(153, 35);
            this.Search.TabIndex = 3;
            this.Search.Text = "Поиск слова";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(228, 129);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(248, 26);
            this.find.TabIndex = 4;
            // 
            // SeachTime
            // 
            this.SeachTime.AutoSize = true;
            this.SeachTime.Location = new System.Drawing.Point(85, 249);
            this.SeachTime.Name = "SeachTime";
            this.SeachTime.Size = new System.Drawing.Size(66, 20);
            this.SeachTime.TabIndex = 5;
            this.SeachTime.Text = "Время: ";
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 20;
            this.Result.Location = new System.Drawing.Point(228, 249);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(241, 104);
            this.Result.TabIndex = 6;
            // 
            // Approx
            // 
            this.Approx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Approx.Location = new System.Drawing.Point(31, 186);
            this.Approx.Name = "Approx";
            this.Approx.Size = new System.Drawing.Size(153, 40);
            this.Approx.TabIndex = 7;
            this.Approx.Text = "Поиск";
            this.Approx.UseVisualStyleBackColor = false;
            this.Approx.Click += new System.EventHandler(this.Approx_Click);
            // 
            // MaxDist
            // 
            this.MaxDist.Location = new System.Drawing.Point(228, 186);
            this.MaxDist.Name = "MaxDist";
            this.MaxDist.Size = new System.Drawing.Size(241, 26);
            this.MaxDist.TabIndex = 8;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Location = new System.Drawing.Point(400, 416);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(140, 45);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Report.Location = new System.Drawing.Point(400, 483);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(140, 41);
            this.Report.TabIndex = 11;
            this.Report.Text = "Отчёт";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(567, 557);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MaxDist);
            this.Controls.Add(this.Approx);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SeachTime);
            this.Controls.Add(this.find);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.FileReadCount);
            this.Controls.Add(this.FileReadTime);
            this.Controls.Add(this.file);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button file;
        private System.Windows.Forms.TextBox FileReadTime;
        private System.Windows.Forms.TextBox FileReadCount;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox find;
        private System.Windows.Forms.Label SeachTime;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.Button Approx;
        private System.Windows.Forms.TextBox MaxDist;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Report;
    }
}

