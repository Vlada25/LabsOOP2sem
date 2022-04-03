namespace SalaryManagerApp
{
    partial class UpdateEntityForm
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
            this.tableNameLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableNameLable
            // 
            this.tableNameLable.AutoSize = true;
            this.tableNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableNameLable.Location = new System.Drawing.Point(28, 38);
            this.tableNameLable.Name = "tableNameLable";
            this.tableNameLable.Size = new System.Drawing.Size(108, 25);
            this.tableNameLable.TabIndex = 1;
            this.tableNameLable.Text = "table name";
            // 
            // UpdateEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.tableNameLable);
            this.Name = "UpdateEntityForm";
            this.Text = "UpdateEntityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tableNameLable;
    }
}