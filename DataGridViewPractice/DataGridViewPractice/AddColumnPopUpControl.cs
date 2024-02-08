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
    public partial class AddColumnPopUpControl : Form
    {
        public AddColumnPopUpControl()
        {
            InitializeComponent();
        }
        private int RowCount = 0;
        private List<RichTextBox> comboListBoxCollection = new List<RichTextBox>();
        public delegate void ColumnDetailsHandler(string columnName, string columnType);
        public event ColumnDetailsHandler ColumnAdded;

        private void columnTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox c = new ComboBox();
            if(c.Text != "ComboBox")
            {
                CreateComboList();
                addColumnPanel.Dock = DockStyle.Bottom;
            }
            else
            {
                comboListAddPanel.Visible = true;
            }
        }

        private void CreateComboList()
        {
            RichTextBoxCreation();
        }

        private void RichTextBoxCreation()
        {
            RichTextBox r = new RichTextBox();
            r.Dock = DockStyle.Fill;
            r.Margin = new Padding(30, 10, 30, 10);
            comboTextPanel.Controls.Add(r, 0, RowCount);
            comboTextPanel.RowCount++;
            RowCount++;
        }

        private void addColumnBtn_Click(object sender, EventArgs e)
        {
            ColumnAdded?.Invoke(columnHeaderNameTextBox.Text, columnTypeComboBox.Text);
            this.Close();
        }

        private void AddColumnPopUpControl_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Height = 200;
            comboListAddPanel.Height = 0;
            addColumnPanel.Dock = DockStyle.Top;
            comboListAddPanel.Visible = false;
            comboListAddPanel.Height = 0;
            Height = tableLayoutPanel1.Height + addColumnPanel.Height + 39;
        }
    }
}
