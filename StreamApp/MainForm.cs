using StreamLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamApp
{
    public partial class MainForm : Form
    {
        private string[] filenames = { @"..\File1.txt", @"..\File2.txt" };
        private string[] streams = { "FileStream", "BufferStream", "MemoryStream" };
        public MainForm()
        {
            InitializeComponent();

            comboBoxFiles.Items.AddRange(filenames);
            comboBoxStreams.Items.AddRange(streams);
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxFiles.SelectedItem is null || comboBoxStreams.SelectedItem is null)
                {
                    throw new Exception("You must choose both items");
                }

                MyStream myStream = new MyStream((string)comboBoxFiles.SelectedItem);

                switch ((string)comboBoxStreams.SelectedItem)
                {
                    case "FileStream":
                        myStream = new MyFileStream(myStream);
                        myStream.Read();
                        break;
                    case "BufferStream":
                        myStream = new MyBufferStream(myStream);
                        myStream.Read();
                        break;
                    case "MemoryStream":
                        myStream = new MyMemoryStream(myStream);
                        myStream.Read();
                        break;
                }

                MessageBox.Show(myStream.Text, $"Text from {(string)comboBoxFiles.SelectedItem} read with {(string)comboBoxStreams.SelectedItem}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
