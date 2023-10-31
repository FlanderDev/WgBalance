namespace AuditHelper.FormControl
{
    partial class PurchaseControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            labelPurchaseFullFileName = new Label();
            textBoxFullFileName = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelPurchaseFullFileName, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxFullFileName, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(150, 150);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelPurchaseFullFileName
            // 
            labelPurchaseFullFileName.AutoSize = true;
            labelPurchaseFullFileName.Dock = DockStyle.Fill;
            labelPurchaseFullFileName.Location = new Point(3, 0);
            labelPurchaseFullFileName.Name = "labelPurchaseFullFileName";
            labelPurchaseFullFileName.Size = new Size(55, 150);
            labelPurchaseFullFileName.TabIndex = 0;
            labelPurchaseFullFileName.Text = "File Path:";
            // 
            // textBoxFullFileName
            // 
            textBoxFullFileName.Dock = DockStyle.Top;
            textBoxFullFileName.Location = new Point(64, 3);
            textBoxFullFileName.Name = "textBoxFullFileName";
            textBoxFullFileName.PlaceholderText = "enther the path to the evidence file";
            textBoxFullFileName.Size = new Size(83, 23);
            textBoxFullFileName.TabIndex = 1;
            // 
            // PurchaseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PurchaseControl";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelPurchaseFullFileName;
        private TextBox textBoxFullFileName;
    }
}
