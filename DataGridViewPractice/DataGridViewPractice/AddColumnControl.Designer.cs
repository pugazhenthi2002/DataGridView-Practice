namespace DataGridViewPractice
{
    partial class AddColumnControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.columnHeaderNameLbl = new System.Windows.Forms.Label();
            this.columnTypeLbl = new System.Windows.Forms.Label();
            this.columnHeaderNameTextBox = new System.Windows.Forms.RichTextBox();
            this.addColumnButton = new System.Windows.Forms.Button();
            this.columnTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.columnHeaderNameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.columnTypeLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.columnHeaderNameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addColumnButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.columnTypeComboBox, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 303);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // columnHeaderNameLbl
            // 
            this.columnHeaderNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnHeaderNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnHeaderNameLbl.Location = new System.Drawing.Point(3, 0);
            this.columnHeaderNameLbl.Name = "columnHeaderNameLbl";
            this.columnHeaderNameLbl.Size = new System.Drawing.Size(294, 60);
            this.columnHeaderNameLbl.TabIndex = 0;
            this.columnHeaderNameLbl.Text = "Column Header Text";
            this.columnHeaderNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnTypeLbl
            // 
            this.columnTypeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnTypeLbl.Location = new System.Drawing.Point(3, 120);
            this.columnTypeLbl.Name = "columnTypeLbl";
            this.columnTypeLbl.Size = new System.Drawing.Size(294, 60);
            this.columnTypeLbl.TabIndex = 1;
            this.columnTypeLbl.Text = "Column Type";
            this.columnTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnHeaderNameTextBox
            // 
            this.columnHeaderNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnHeaderNameTextBox.Location = new System.Drawing.Point(30, 70);
            this.columnHeaderNameTextBox.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.columnHeaderNameTextBox.Name = "columnHeaderNameTextBox";
            this.columnHeaderNameTextBox.Size = new System.Drawing.Size(240, 40);
            this.columnHeaderNameTextBox.TabIndex = 2;
            this.columnHeaderNameTextBox.Text = "";
            // 
            // addColumnButton
            // 
            this.addColumnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addColumnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addColumnButton.Location = new System.Drawing.Point(45, 250);
            this.addColumnButton.Margin = new System.Windows.Forms.Padding(45, 10, 45, 10);
            this.addColumnButton.Name = "addColumnButton";
            this.addColumnButton.Size = new System.Drawing.Size(210, 43);
            this.addColumnButton.TabIndex = 4;
            this.addColumnButton.Text = "Add Column";
            this.addColumnButton.UseVisualStyleBackColor = true;
            this.addColumnButton.Click += new System.EventHandler(this.addColumnButton_Click);
            // 
            // columnTypeComboBox
            // 
            this.columnTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnTypeComboBox.FormattingEnabled = true;
            this.columnTypeComboBox.ItemHeight = 29;
            this.columnTypeComboBox.Items.AddRange(new object[] {
            "String",
            "Combo",
            "Button",
            "Link",
            "Image"});
            this.columnTypeComboBox.Location = new System.Drawing.Point(30, 193);
            this.columnTypeComboBox.Margin = new System.Windows.Forms.Padding(30, 13, 30, 3);
            this.columnTypeComboBox.Name = "columnTypeComboBox";
            this.columnTypeComboBox.Size = new System.Drawing.Size(240, 37);
            this.columnTypeComboBox.TabIndex = 5;
            this.columnTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.columnTypeComboBox_SelectedIndexChanged);
            // 
            // AddColumnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 303);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddColumnControl";
            this.Text = "AddColumnControl";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label columnHeaderNameLbl;
        private System.Windows.Forms.Label columnTypeLbl;
        private System.Windows.Forms.RichTextBox columnHeaderNameTextBox;
        private System.Windows.Forms.Button addColumnButton;
        private System.Windows.Forms.ComboBox columnTypeComboBox;
    }
}