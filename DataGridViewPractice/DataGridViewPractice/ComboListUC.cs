using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewPractice
{
    public partial class ComboListUC : UserControl
    {
        public ComboListUC()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addListBtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();

            tableLayoutPanel1.RowCount++;
            Height = 75 * tableLayoutPanel1.RowCount;
            float eachComboListHeight = 100 / (float)tableLayoutPanel1.RowCount;
            for (int ctr = 0; ctr < tableLayoutPanel1.RowCount; ctr++) 
            {
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75));
            }

            createComboList();
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, tableLayoutPanel1.RowCount - 2);
            tableLayoutPanel1.Controls.Add(addListBtn, 0, tableLayoutPanel1.RowCount - 1);

            tableLayoutPanel1.ResumeLayout();
        }

        private void createComboList()
        {
            richTextBox1 = new RichTextBox();
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Location = new System.Drawing.Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(269, 63);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";

            delListBtn = new Button();
            delListBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            delListBtn.Location = new System.Drawing.Point(278, 3);
            delListBtn.Name = "delListBtn";
            delListBtn.Size = new System.Drawing.Size(63, 63);
            delListBtn.TabIndex = 0;
            delListBtn.Text = "X";
            delListBtn.UseVisualStyleBackColor = true;
            delListBtn.Click += OnComboListDeleted;

            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(delListBtn, 1, 0);
            tableLayoutPanel2.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(344, 69);
            tableLayoutPanel2.TabIndex = 0;
        }

        private void OnComboListDeleted(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();

            tableLayoutPanel1.RowCount--;
            Height = 75 * tableLayoutPanel1.RowCount;
            float eachComboListHeight = 100 / (float)tableLayoutPanel1.RowCount;
            for (int ctr = 0; ctr < tableLayoutPanel1.RowCount; ctr++)
            {
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75));
            }

            //tableLayoutPanel1.Controls.Remove(addListBtn, 0, tableLayoutPanel1.RowCount - 1);
            var x = sender as Button;
            tableLayoutPanel1.ResumeLayout();
        }
    }
}
