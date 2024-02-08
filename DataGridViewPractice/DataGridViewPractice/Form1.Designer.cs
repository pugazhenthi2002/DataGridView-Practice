namespace DataGridViewPractice
{
    partial class Form1
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
            this.studentGridViewTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addColumnBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.selectedStudentGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridViewTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedStudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGridViewTable
            // 
            this.studentGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGridViewTable.Location = new System.Drawing.Point(0, 0);
            this.studentGridViewTable.Name = "studentGridViewTable";
            this.studentGridViewTable.Size = new System.Drawing.Size(600, 450);
            this.studentGridViewTable.TabIndex = 0;
            this.studentGridViewTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridViewTable_CellClick);
            this.studentGridViewTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridViewTable_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectedStudentGridView);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addColumnBtn);
            this.panel1.Controls.Add(this.addItemBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // addColumnBtn
            // 
            this.addColumnBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addColumnBtn.Location = new System.Drawing.Point(0, 372);
            this.addColumnBtn.Name = "addColumnBtn";
            this.addColumnBtn.Size = new System.Drawing.Size(200, 39);
            this.addColumnBtn.TabIndex = 1;
            this.addColumnBtn.Text = "Add Column";
            this.addColumnBtn.UseVisualStyleBackColor = true;
            this.addColumnBtn.Click += new System.EventHandler(this.addColumnBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addItemBtn.Location = new System.Drawing.Point(0, 411);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(200, 39);
            this.addItemBtn.TabIndex = 0;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // selectedStudentGridView
            // 
            this.selectedStudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedStudentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedStudentGridView.Location = new System.Drawing.Point(0, 53);
            this.selectedStudentGridView.Name = "selectedStudentGridView";
            this.selectedStudentGridView.Size = new System.Drawing.Size(200, 266);
            this.selectedStudentGridView.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 53);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 53);
            this.panel3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentGridViewTable);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentGridViewTable)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedStudentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentGridViewTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addColumnBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.DataGridView selectedStudentGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

