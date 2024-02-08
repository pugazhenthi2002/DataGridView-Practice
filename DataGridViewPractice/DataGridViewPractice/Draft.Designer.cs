namespace DataGridViewPractice
{
    partial class Draft
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
            this.comboListUC1 = new DataGridViewPractice.ComboListUC();
            this.SuspendLayout();
            // 
            // comboListUC1
            // 
            this.comboListUC1.BackColor = System.Drawing.Color.AliceBlue;
            this.comboListUC1.Location = new System.Drawing.Point(257, 148);
            this.comboListUC1.Name = "comboListUC1";
            this.comboListUC1.Size = new System.Drawing.Size(350, 150);
            this.comboListUC1.TabIndex = 0;
            this.comboListUC1.Load += new System.EventHandler(this.comboListUC1_Load);
            // 
            // Draft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboListUC1);
            this.Name = "Draft";
            this.Text = "Draft";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboListUC comboListUC1;
    }
}