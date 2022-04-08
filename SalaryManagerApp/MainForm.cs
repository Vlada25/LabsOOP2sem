using SalaryLibrary;
using System;
using System.Windows.Forms;

namespace SalaryManagerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tablesComboBox.Items.AddRange(Service.TablesInDb);

            try
            {
                Service.CreateTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablesComboBox.SelectedItem is null)
                {
                    throw new Exception("You must choose table!");
                }

                TableForm tableForm = new TableForm((string)tablesComboBox.SelectedItem);
                tableForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTableBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablesComboBox.SelectedItem is null)
                {
                    foreach (string tableName in Service.TablesInDb)
                    {
                        Service.TableManager.ClearTable(tableName);
                    }
                    MessageBox.Show($"All tables have cleared");
                }
                else
                {
                    Service.TableManager.ClearTable((string)tablesComboBox.SelectedItem);
                    MessageBox.Show($"Table {(string)tablesComboBox.SelectedItem} has cleared");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StartInitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Service.InitStartValues();
                MessageBox.Show("Tables have been initialized by start values");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateEntityBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablesComboBox.SelectedItem is null)
                {
                    throw new Exception("You must choose table!");
                }

                CreateEntityForm createEntityForm = new CreateEntityForm(
                    (string)tablesComboBox.SelectedItem,
                    Service.GetEntityType((string)tablesComboBox.SelectedItem));

                createEntityForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteEntityBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablesComboBox.SelectedItem is null)
                {
                    throw new Exception("You must choose table!");
                }

                DeleteEntityForm deleteEntityForm = new DeleteEntityForm((string)tablesComboBox.SelectedItem);
                deleteEntityForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateEntityBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablesComboBox.SelectedItem is null)
                {
                    throw new Exception("You must choose table!");
                }

                UpdateEntityForm updateEntityForm = new UpdateEntityForm(
                    (string)tablesComboBox.SelectedItem,
                    Service.GetEntityType((string)tablesComboBox.SelectedItem));

                updateEntityForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void execQuery1_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                TableForm tableForm = new TableForm("Workers and productions", "Where price > ", queryId: 0);
                tableForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
