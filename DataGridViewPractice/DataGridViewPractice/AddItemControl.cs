using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewPractice
{
    public enum ItemToken
    {
        Add,
        Update
    }
    class AddItemControl: Form
    {
        public AddItemControl(List<string> items=null)
        {
            itemDetails = items;
            FormBorderStyle = FormBorderStyle.None;
        }

        private int startX = 0, startY = 0, stepY = 100;
        private int columnCount;
        private ItemToken itemToken;
        private List<string> columnName = new List<string>();
        private List<string> itemDetails;
        private DetailsTemplate entryTemplate;

        public int ColumnCount
        {
            get
            {
                return columnCount;
            }
            set
            {
                columnCount = value-1;
            }
        }

        public List<string> ColumnName
        {
            get
            {
                return columnName;
            }
            set
            {
                columnName = value;
            }
        }

        public delegate void ItemsHandler(ItemToken token, List<string> items);
        public event ItemsHandler ItemsAdded;

        protected override void OnLoad(EventArgs e)
        {
            if (itemDetails == null)
            {
                itemToken = ItemToken.Add;
                itemDetails = Enumerable.Repeat("", columnCount).ToList();
            }
            else
            {
                itemToken = ItemToken.Update;
            }

            Height = columnCount * 100 + 96;
            for (int ctr = 0; ctr < columnCount; ctr++)
            {
                entryTemplate = new DetailsTemplate();
                entryTemplate.Size = new Size(Width, 100);
                entryTemplate.Location = new Point(startX, startY); startY += stepY;
                entryTemplate.LabelName = columnName[ctr];
                entryTemplate.ItemName = itemDetails[ctr];
                this.Controls.Add(entryTemplate);
            }

            Button b = new Button();
            b.Size = new Size(75, 30);
            b.Location = new Point((Width-75)/2, startY+30);
            b.Text = "Add Item";
            b.Click += OnItemsAdded;
            this.Controls.Add(b);
        }

        private void OnItemsAdded(object sender, EventArgs e)
        {
            int i = 0;
            DetailsTemplate temp;
            foreach(Control Iter in this.Controls)
            {
                if (Iter is DetailsTemplate)
                {
                    temp = Iter as DetailsTemplate;
                    itemDetails[i] = temp.ItemName;
                    i++;
                }
            }

            ItemsAdded?.Invoke(itemToken, itemDetails);
            this.Close();
        }

        protected override void OnResize(EventArgs e)
        {
            Height = columnCount * 100 + 96;
            
            foreach(DetailsTemplate Iter in this.Controls)
            {
                Iter.Width = Width;
            }
        }
    }
}
