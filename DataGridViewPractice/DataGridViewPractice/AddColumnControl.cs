using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewPractice
{
    public partial class AddColumnControl : Form
    {
        public AddColumnControl()
        {
            InitializeComponent();
        }
        public delegate void ColumnDetailsHandler(string columnName, string columnType);
        public event ColumnDetailsHandler ColumnAdded;

        private void addColumnButton_Click(object sender, EventArgs e)
        {
            ColumnAdded?.Invoke(columnHeaderNameTextBox.Text, columnTypeComboBox.Text);
            this.Close();
        }

        private void columnTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
