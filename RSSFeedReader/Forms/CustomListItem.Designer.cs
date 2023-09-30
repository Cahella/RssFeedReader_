namespace RSSFeedReader.Forms
{
    partial class CustomListItem
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
            panel1 = new Panel();
            lblTitle = new Label();
            lblDate = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 107);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Cursor = Cursors.Hand;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(19, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(475, 71);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Dock = DockStyle.Right;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = SystemColors.HighlightText;
            lblDate.Location = new Point(402, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(92, 20);
            lblDate.TabIndex = 1;
            lblDate.Text = "Publish Date";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomListItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            Controls.Add(lblDate);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "CustomListItem";
            Size = new Size(494, 91);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblDate;
    }
}
