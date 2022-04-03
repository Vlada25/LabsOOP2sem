using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagerApp
{
    public partial class UpdateEntityForm : Form
    {
        private Type _entityType;

        public UpdateEntityForm(string tableName, Type entityType)
        {
            InitializeComponent();

            tableNameLable.Text = tableName;
            _entityType = entityType;
        }
    }
}
