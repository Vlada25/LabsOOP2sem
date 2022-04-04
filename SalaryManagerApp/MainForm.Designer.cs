namespace SalaryManagerApp
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
            this.tablesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.ClearTableBtn = new System.Windows.Forms.Button();
            this.StartInitBtn = new System.Windows.Forms.Button();
            this.CreateEntityBtn = new System.Windows.Forms.Button();
            this.DeleteEntityBtn = new System.Windows.Forms.Button();
            this.UpdateEntityBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tablesComboBox
            // 
            this.tablesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesComboBox.FormattingEnabled = true;
            this.tablesComboBox.Location = new System.Drawing.Point(82, 75);
            this.tablesComboBox.Name = "tablesComboBox";
            this.tablesComboBox.Size = new System.Drawing.Size(228, 28);
            this.tablesComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(138, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose table:";
            // 
            // ShowBtn
            // 
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowBtn.Location = new System.Drawing.Point(53, 145);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(130, 43);
            this.ShowBtn.TabIndex = 2;
            this.ShowBtn.Text = "Show Table";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // ClearTableBtn
            // 
            this.ClearTableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearTableBtn.Location = new System.Drawing.Point(209, 145);
            this.ClearTableBtn.Name = "ClearTableBtn";
            this.ClearTableBtn.Size = new System.Drawing.Size(130, 43);
            this.ClearTableBtn.TabIndex = 3;
            this.ClearTableBtn.Text = "Clear Table";
            this.ClearTableBtn.UseVisualStyleBackColor = true;
            this.ClearTableBtn.Click += new System.EventHandler(this.ClearTableBtn_Click);
            // 
            // StartInitBtn
            // 
            this.StartInitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartInitBtn.Location = new System.Drawing.Point(53, 324);
            this.StartInitBtn.Name = "StartInitBtn";
            this.StartInitBtn.Size = new System.Drawing.Size(286, 47);
            this.StartInitBtn.TabIndex = 4;
            this.StartInitBtn.Text = "Init by Start Values (All tables)";
            this.StartInitBtn.UseVisualStyleBackColor = true;
            this.StartInitBtn.Click += new System.EventHandler(this.StartInitBtn_Click);
            // 
            // CreateEntityBtn
            // 
            this.CreateEntityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateEntityBtn.Location = new System.Drawing.Point(53, 208);
            this.CreateEntityBtn.Name = "CreateEntityBtn";
            this.CreateEntityBtn.Size = new System.Drawing.Size(130, 43);
            this.CreateEntityBtn.TabIndex = 5;
            this.CreateEntityBtn.Text = "Create Entity";
            this.CreateEntityBtn.UseVisualStyleBackColor = true;
            this.CreateEntityBtn.Click += new System.EventHandler(this.CreateEntityBtn_Click);
            // 
            // DeleteEntityBtn
            // 
            this.DeleteEntityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEntityBtn.Location = new System.Drawing.Point(209, 208);
            this.DeleteEntityBtn.Name = "DeleteEntityBtn";
            this.DeleteEntityBtn.Size = new System.Drawing.Size(130, 43);
            this.DeleteEntityBtn.TabIndex = 6;
            this.DeleteEntityBtn.Text = "Delete Entity";
            this.DeleteEntityBtn.UseVisualStyleBackColor = true;
            this.DeleteEntityBtn.Click += new System.EventHandler(this.DeleteEntityBtn_Click);
            // 
            // UpdateEntityBtn
            // 
            this.UpdateEntityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateEntityBtn.Location = new System.Drawing.Point(121, 266);
            this.UpdateEntityBtn.Name = "UpdateEntityBtn";
            this.UpdateEntityBtn.Size = new System.Drawing.Size(147, 43);
            this.UpdateEntityBtn.TabIndex = 7;
            this.UpdateEntityBtn.Text = "Update Entity";
            this.UpdateEntityBtn.UseVisualStyleBackColor = true;
            this.UpdateEntityBtn.Click += new System.EventHandler(this.UpdateEntityBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 393);
            this.Controls.Add(this.UpdateEntityBtn);
            this.Controls.Add(this.DeleteEntityBtn);
            this.Controls.Add(this.CreateEntityBtn);
            this.Controls.Add(this.StartInitBtn);
            this.Controls.Add(this.ClearTableBtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablesComboBox);
            this.Name = "MainForm";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tablesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button ClearTableBtn;
        private System.Windows.Forms.Button StartInitBtn;
        private System.Windows.Forms.Button CreateEntityBtn;
        private System.Windows.Forms.Button DeleteEntityBtn;
        private System.Windows.Forms.Button UpdateEntityBtn;
    }
}

