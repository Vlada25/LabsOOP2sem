using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorApp
{
    public partial class MainForm : Form
    {
        private Label header = new Label(),
            chooseFileLabel = new Label();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            header.Name = "Header";
            header.Text = "Text Editor";
            header.Font = new Font(Font.FontFamily, 13);
            header.Location = new Point(130, 15);
            Controls.Add(header);

            chooseFileLabel.Name = "ChoseFileLabel";
            chooseFileLabel.Text = "Chose file";
            chooseFileLabel.Font = new Font(Font.FontFamily, 11);
            chooseFileLabel.Location = new Point(50, 40);
            Controls.Add(chooseFileLabel);
        }
    }
}
