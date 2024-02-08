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
    public partial class DetailsTemplate : UserControl
    {
        public string LabelName
        {
            get
            {
                return entryColNameLabel.Text;
            }
            set
            {
                entryColNameLabel.Text = value;
            }
        }

        public string ItemName
        {
            get
            {
                return entryDetailsRichTextBox.Text;
            }
            set
            {
                entryDetailsRichTextBox.Text = value;
            }
        }

        public DetailsTemplate()
        {
            InitializeComponent();
        }

        private void DetailsTemplate_Resize(object sender, EventArgs e)
        {
            entryDetailsRichTextBox.Margin = new Padding(Width / 10, Height / 100, Width / 10, Height / 100);
        }
    }
}
