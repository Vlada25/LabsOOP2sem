namespace StreamApp
{
    partial class MainForm
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
            this.comboBoxFiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonRead = new System.Windows.Forms.Button();
            this.ButtonWrite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStreams = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxFiles
            // 
            this.comboBoxFiles.FormattingEnabled = true;
            this.comboBoxFiles.Location = new System.Drawing.Point(142, 32);
            this.comboBoxFiles.Name = "comboBoxFiles";
            this.comboBoxFiles.Size = new System.Drawing.Size(194, 24);
            this.comboBoxFiles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chose file:";
            // 
            // ButtonRead
            // 
            this.ButtonRead.BackColor = System.Drawing.Color.White;
            this.ButtonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRead.Location = new System.Drawing.Point(122, 131);
            this.ButtonRead.Name = "ButtonRead";
            this.ButtonRead.Size = new System.Drawing.Size(110, 41);
            this.ButtonRead.TabIndex = 2;
            this.ButtonRead.Text = "Read";
            this.ButtonRead.UseVisualStyleBackColor = false;
            this.ButtonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // ButtonWrite
            // 
            this.ButtonWrite.BackColor = System.Drawing.Color.White;
            this.ButtonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonWrite.Location = new System.Drawing.Point(122, 191);
            this.ButtonWrite.Name = "ButtonWrite";
            this.ButtonWrite.Size = new System.Drawing.Size(110, 43);
            this.ButtonWrite.TabIndex = 3;
            this.ButtonWrite.Text = "Write";
            this.ButtonWrite.UseVisualStyleBackColor = false;
            this.ButtonWrite.Click += new System.EventHandler(this.ButtonWrite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(70, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Use:";
            // 
            // comboBoxStreams
            // 
            this.comboBoxStreams.FormattingEnabled = true;
            this.comboBoxStreams.Location = new System.Drawing.Point(142, 68);
            this.comboBoxStreams.Name = "comboBoxStreams";
            this.comboBoxStreams.Size = new System.Drawing.Size(194, 24);
            this.comboBoxStreams.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(359, 285);
            this.Controls.Add(this.comboBoxStreams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonWrite);
            this.Controls.Add(this.ButtonRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFiles);
            this.Name = "MainForm";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonRead;
        private System.Windows.Forms.Button ButtonWrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStreams;
    }
}

