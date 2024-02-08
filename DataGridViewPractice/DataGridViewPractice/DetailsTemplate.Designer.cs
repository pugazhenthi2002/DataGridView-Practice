namespace DataGridViewPractice
{
    partial class DetailsTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.entryColNameLabel = new System.Windows.Forms.Label();
            this.entryDetailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.entryColNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.entryDetailsRichTextBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // entryColNameLabel
            // 
            this.entryColNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryColNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryColNameLabel.Location = new System.Drawing.Point(3, 0);
            this.entryColNameLabel.Name = "entryColNameLabel";
            this.entryColNameLabel.Size = new System.Drawing.Size(144, 65);
            this.entryColNameLabel.TabIndex = 0;
            this.entryColNameLabel.Text = "Column Name";
            this.entryColNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryDetailsRichTextBox
            // 
            this.entryDetailsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryDetailsRichTextBox.Location = new System.Drawing.Point(3, 68);
            this.entryDetailsRichTextBox.Name = "entryDetailsRichTextBox";
            this.entryDetailsRichTextBox.Size = new System.Drawing.Size(144, 29);
            this.entryDetailsRichTextBox.TabIndex = 1;
            this.entryDetailsRichTextBox.Text = "";
            // 
            // DetailsTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DetailsTemplate";
            this.Size = new System.Drawing.Size(150, 100);
            this.Resize += new System.EventHandler(this.DetailsTemplate_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label entryColNameLabel;
        private System.Windows.Forms.RichTextBox entryDetailsRichTextBox;
    }
}
