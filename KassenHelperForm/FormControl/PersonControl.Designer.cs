namespace AuditHelper.FormControl
{
    partial class PersonControl
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
            labelPersonName = new Label();
            textBoxPersonName = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelPersonName, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxPersonName, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(150, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelPersonName
            // 
            labelPersonName.AutoSize = true;
            labelPersonName.Dock = DockStyle.Fill;
            labelPersonName.Location = new Point(3, 0);
            labelPersonName.Name = "labelPersonName";
            labelPersonName.Size = new Size(42, 150);
            labelPersonName.TabIndex = 0;
            labelPersonName.Text = "Name:";
            // 
            // textBoxPersonName
            // 
            textBoxPersonName.Dock = DockStyle.Top;
            textBoxPersonName.Location = new Point(51, 3);
            textBoxPersonName.Name = "textBoxPersonName";
            textBoxPersonName.PlaceholderText = "enter the persons name";
            textBoxPersonName.Size = new Size(96, 23);
            textBoxPersonName.TabIndex = 1;
            // 
            // PersonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PersonControl";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelPersonName;
        private TextBox textBoxPersonName;
    }
}
