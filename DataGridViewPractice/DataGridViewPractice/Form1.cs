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
    public partial class Form1 : Form
    {
        private int currentIndex = 0;
        private AddItemControl addItemPopUpControl;
        private AddColumnPopUpControl addColumnPopUpControl;
        private List<string> columnNames;
        private List<string> selectedRowItemDetails;

        public List<string> ColumnNames
        {
            get
            {
                return columnNames;
            }
            set
            {
                columnNames = value;
            }
        }

        public Form1()
        {
            ColumnNames = new List<string>();

            InitializeComponent();
            SetupStudentsDataGridView();
            SetupSelectedStudentDataGridView();
            UpdateSelectedStudentGridView();
        }


        private void addItemBtn_Click(object sender, EventArgs e)
        {
            addItemPopUpControl = new AddItemControl();
            addItemPopUpControl.StartPosition = FormStartPosition.Manual;
            addItemPopUpControl.Location = new Point(Location.X + (Width - addItemPopUpControl.Width) / 2, Location.Y + (Height - addItemPopUpControl.Height) / 2);
            addItemPopUpControl.ItemsAdded += OnItemsAdded;
            addItemPopUpControl.DataBindings.Add("ColumnName", this, "ColumnNames");
            addItemPopUpControl.DataBindings.Add("ColumnCount", studentGridViewTable, "ColumnCount");

            addItemPopUpControl.Show();
        }


        private void addColumnBtn_Click(object sender, EventArgs e)
        {
            addColumnPopUpControl = new AddColumnPopUpControl();
            addColumnPopUpControl.StartPosition = FormStartPosition.Manual;
            addColumnPopUpControl.Location = new Point(Location.X + (Width - addColumnPopUpControl.Width) / 2, Location.Y + (Height - addColumnPopUpControl.Height) / 2);
            addColumnPopUpControl.ColumnAdded += OnColumnAdded;
            
            addColumnPopUpControl.Show();
        }

        private void OnItemsAdded(ItemToken itemToken, List<string> e)
        {
            DataGridViewRow row;

            if (itemToken == ItemToken.Add)
            { 
                row = (DataGridViewRow)studentGridViewTable.Rows[0].Clone();
                row.Cells[0].Value = studentGridViewTable.RowCount;

                for (int ctr = 0; ctr < e.Count; ctr++)
                {
                    row.Cells[ctr + 1].Value = e[ctr];
                }

                studentGridViewTable.Rows.Add(row);
                currentIndex = studentGridViewTable.RowCount-2;
            }
            else
            {
                row = studentGridViewTable.Rows[currentIndex];
                for (int ctr = 0; ctr < e.Count; ctr++)
                {
                    row.Cells[ctr + 1].Value = e[ctr];
                }
            }

            studentGridViewTable_CellClick(studentGridViewTable, new DataGridViewCellEventArgs(0, currentIndex));
        }

        private void OnColumnAdded(string columnName, string columnType)
        {
            switch(columnType)
            {
                case "String":  DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
                                textColumn.HeaderText = columnName;
                                textColumn.Name = columnName;
                                studentGridViewTable.Columns.Add(textColumn);
                                break;

                case "Link":    DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
                                linkColumn.HeaderText = columnName;
                                linkColumn.Name = columnName;
                                studentGridViewTable.Columns.Add(linkColumn);
                                break;

                case "Image":   DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                                imageColumn.HeaderText = columnName;
                                imageColumn.Name = columnName;
                                studentGridViewTable.Columns.Add(imageColumn);
                                break;

                case "Combo":  DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
                                comboColumn.HeaderText = columnName;
                                comboColumn.Name = columnName;
                                studentGridViewTable.Columns.Add(comboColumn);
                                break;

                case "Button":  DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                                buttonColumn.HeaderText = columnName;
                                buttonColumn.Name = columnName;
                                studentGridViewTable.Columns.Add(buttonColumn);
                                break;
            }
            columnNames.Add(columnName);
            UpdateSelectedStudentGridView();
            studentGridViewTable_CellClick(studentGridViewTable, new DataGridViewCellEventArgs(0, currentIndex));
        }

        private void SetupStudentsDataGridView()
        {
            this.Controls.Add(studentGridViewTable);

            studentGridViewTable.ColumnCount = 4;

            studentGridViewTable.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            studentGridViewTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            studentGridViewTable.ColumnHeadersDefaultCellStyle.Font =
                new Font(studentGridViewTable.Font, FontStyle.Bold);
              
            studentGridViewTable.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            studentGridViewTable.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            studentGridViewTable.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            studentGridViewTable.GridColor = Color.Black;
            studentGridViewTable.RowHeadersVisible = false;

            studentGridViewTable.Columns[0].Name = "S.No";
            studentGridViewTable.Columns[1].Name = "RollNo";
            studentGridViewTable.Columns[2].Name = "Name";
            studentGridViewTable.Columns[3].Name = "Phone No";
            studentGridViewTable.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            studentGridViewTable.MultiSelect = false;
            studentGridViewTable.Dock = DockStyle.Fill;
            studentGridViewTable.BringToFront();

            studentGridViewTable.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                studentGridViewTable_CellFormatting);

            ColumnNames.Add("RollNo");
            ColumnNames.Add("Name");
            ColumnNames.Add("Phone No");
        }

        private void SetupSelectedStudentDataGridView()
        {
            selectedStudentGridView.ColumnCount = 2;

            selectedStudentGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            selectedStudentGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            selectedStudentGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(selectedStudentGridView.Font, FontStyle.Bold);

            selectedStudentGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            selectedStudentGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            selectedStudentGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            selectedStudentGridView.GridColor = Color.Black;
            selectedStudentGridView.RowHeadersVisible = false;

            selectedStudentGridView.Columns[0].Name = "Content";
            selectedStudentGridView.Columns[1].Name = "Details";
            
            selectedStudentGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            selectedStudentGridView.MultiSelect = false;
            selectedStudentGridView.Dock = DockStyle.Fill;
            selectedStudentGridView.BringToFront();

            selectedStudentGridView.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                selectedStudentGridView_CellFormatting);
        }

        private void selectedStudentGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.selectedStudentGridView.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }

        private void studentGridViewTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.studentGridViewTable.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }

        private void studentGridViewTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
            selectedRowItemDetails = new List<string>();
            if (currentIndex >= 0)
            {
                for (int ctr = 1; ctr < studentGridViewTable.ColumnCount; ctr++)
                {
                    var x = studentGridViewTable.Rows[currentIndex].Cells[ctr].Value;
                    selectedRowItemDetails.Add((string)studentGridViewTable.Rows[currentIndex].Cells[ctr].Value);
                }

                addItemPopUpControl = new AddItemControl(selectedRowItemDetails);
                addItemPopUpControl.StartPosition = FormStartPosition.Manual;
                addItemPopUpControl.Location = new Point(Location.X + (Width - addItemPopUpControl.Width) / 2, Location.Y + (Height - addItemPopUpControl.Height) / 2);
                addItemPopUpControl.ItemsAdded += OnItemsAdded;
                addItemPopUpControl.DataBindings.Add("ColumnName", this, "ColumnNames");
                addItemPopUpControl.DataBindings.Add("ColumnCount", studentGridViewTable, "ColumnCount");
                addItemPopUpControl.Show();
            }
        }

        private void studentGridViewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
            if (currentIndex >= 0)
            {
                for (int ctr = 1; ctr < studentGridViewTable.ColumnCount; ctr++)
                {
                    selectedStudentGridView.Rows[ctr-1].Cells[1].Value = (string)studentGridViewTable.Rows[currentIndex].Cells[ctr].Value;
                }
            }
        }

        private void UpdateSelectedStudentGridView()
        {
            while(selectedStudentGridView.RowCount!=1)
            {
                selectedStudentGridView.Rows.RemoveAt(selectedStudentGridView.RowCount-2);
            }
            for (int ctr = 0; ctr < columnNames.Count; ctr++)
            {
                selectedStudentGridView.Rows.Add(columnNames[ctr], "");
            }
        }
    }
}
