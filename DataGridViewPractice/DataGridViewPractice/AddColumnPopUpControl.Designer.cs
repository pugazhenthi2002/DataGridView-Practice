namespace DataGridViewPractice
{
    partial class AddColumnPopUpControl
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
            this.columnTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addColumnPanel = new System.Windows.Forms.Panel();
            this.addColumnBtn = new System.Windows.Forms.Button();
            this.comboListAddPanel = new System.Windows.Forms.Panel();
            this.comboTextPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.addColumnPanel.SuspendLayout();
            this.comboListAddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.columnHeaderNameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.columnTypeLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.columnHeaderNameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.columnTypeComboBox, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 200);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // columnHeaderNameLbl
            // 
            this.columnHeaderNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnHeaderNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnHeaderNameLbl.Location = new System.Drawing.Point(3, 0);
            this.columnHeaderNameLbl.Name = "columnHeaderNameLbl";
            this.columnHeaderNameLbl.Size = new System.Drawing.Size(282, 50);
            this.columnHeaderNameLbl.TabIndex = 0;
            this.columnHeaderNameLbl.Text = "Column Header Text";
            this.columnHeaderNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnTypeLbl
            // 
            this.columnTypeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnTypeLbl.Location = new System.Drawing.Point(3, 100);
            this.columnTypeLbl.Name = "columnTypeLbl";
            this.columnTypeLbl.Size = new System.Drawing.Size(282, 50);
            this.columnTypeLbl.TabIndex = 1;
            this.columnTypeLbl.Text = "Column Type";
            this.columnTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnHeaderNameTextBox
            // 
            this.columnHeaderNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnHeaderNameTextBox.Location = new System.Drawing.Point(30, 60);
            this.columnHeaderNameTextBox.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.columnHeaderNameTextBox.Name = "columnHeaderNameTextBox";
            this.columnHeaderNameTextBox.Size = new System.Drawing.Size(228, 30);
            this.columnHeaderNameTextBox.TabIndex = 2;
            this.columnHeaderNameTextBox.Text = "";
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
            this.columnTypeComboBox.Location = new System.Drawing.Point(30, 163);
            this.columnTypeComboBox.Margin = new System.Windows.Forms.Padding(30, 13, 30, 3);
            this.columnTypeComboBox.Name = "columnTypeComboBox";
            this.columnTypeComboBox.Size = new System.Drawing.Size(228, 37);
            this.columnTypeComboBox.TabIndex = 5;
            this.columnTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.columnTypeComboBox_SelectedIndexChanged);
            // 
            // addColumnPanel
            // 
            this.addColumnPanel.Controls.Add(this.addColumnBtn);
            this.addColumnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addColumnPanel.Location = new System.Drawing.Point(0, 400);
            this.addColumnPanel.Name = "addColumnPanel";
            this.addColumnPanel.Padding = new System.Windows.Forms.Padding(75, 10, 75, 10);
            this.addColumnPanel.Size = new System.Drawing.Size(288, 50);
            this.addColumnPanel.TabIndex = 2;
            // 
            // addColumnBtn
            // 
            this.addColumnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addColumnBtn.Location = new System.Drawing.Point(75, 10);
            this.addColumnBtn.Name = "addColumnBtn";
            this.addColumnBtn.Size = new System.Drawing.Size(138, 30);
            this.addColumnBtn.TabIndex = 0;
            this.addColumnBtn.Text = "Add Column";
            this.addColumnBtn.UseVisualStyleBackColor = true;
            this.addColumnBtn.Click += new System.EventHandler(this.addColumnBtn_Click);
            // 
            // comboListAddPanel
            // 
            this.comboListAddPanel.Controls.Add(this.comboTextPanel);
            this.comboListAddPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboListAddPanel.Location = new System.Drawing.Point(0, 200);
            this.comboListAddPanel.Name = "comboListAddPanel";
            this.comboListAddPanel.Size = new System.Drawing.Size(288, 200);
            this.comboListAddPanel.TabIndex = 3;
            // 
            // comboTextPanel
            // 
            this.comboTextPanel.ColumnCount = 1;
            this.comboTextPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.comboTextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboTextPanel.Location = new System.Drawing.Point(0, 0);
            this.comboTextPanel.Name = "comboTextPanel";
            this.comboTextPanel.RowCount = 1;
            this.comboTextPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.comboTextPanel.Size = new System.Drawing.Size(288, 200);
            this.comboTextPanel.TabIndex = 0;
            // 
            // AddColumnPopUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.comboListAddPanel);
            this.Controls.Add(this.addColumnPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddColumnPopUpControl";
            this.Text = "AddColumnPopUpControl";
            this.Load += new System.EventHandler(this.AddColumnPopUpControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.addColumnPanel.ResumeLayout(false);
            this.comboListAddPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label columnHeaderNameLbl;
        private System.Windows.Forms.Label columnTypeLbl;
        private System.Windows.Forms.RichTextBox columnHeaderNameTextBox;
        private System.Windows.Forms.ComboBox columnTypeComboBox;
        private System.Windows.Forms.Panel addColumnPanel;
        private System.Windows.Forms.Button addColumnBtn;
        private System.Windows.Forms.Panel comboListAddPanel;
        private System.Windows.Forms.TableLayoutPanel comboTextPanel;
    }
}