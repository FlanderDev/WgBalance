namespace AuditHelper.Forms;

partial class TextInputForm
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
        tableLayoutPanel1 = new TableLayoutPanel();
        textBoxInput = new TextBox();
        button1 = new Button();
        button2 = new Button();
        labelText = new Label();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(textBoxInput, 0, 1);
        tableLayoutPanel1.Controls.Add(button1, 0, 2);
        tableLayoutPanel1.Controls.Add(button2, 1, 2);
        tableLayoutPanel1.Controls.Add(labelText, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(409, 81);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // textBoxInput
        // 
        tableLayoutPanel1.SetColumnSpan(textBoxInput, 2);
        textBoxInput.Dock = DockStyle.Bottom;
        textBoxInput.Location = new Point(3, 18);
        textBoxInput.Name = "textBoxInput";
        textBoxInput.Size = new Size(403, 23);
        textBoxInput.TabIndex = 0;
        // 
        // button1
        // 
        button1.Dock = DockStyle.Top;
        button1.Location = new Point(3, 47);
        button1.Name = "button1";
        button1.Size = new Size(198, 23);
        button1.TabIndex = 1;
        button1.Text = "Add";
        button1.UseVisualStyleBackColor = true;
        button1.Click += ButtonOk_Click;
        // 
        // button2
        // 
        button2.Dock = DockStyle.Top;
        button2.Location = new Point(207, 47);
        button2.Name = "button2";
        button2.Size = new Size(199, 23);
        button2.TabIndex = 2;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += ButtonCancel_Click;
        // 
        // label1
        // 
        labelText.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(labelText, 2);
        labelText.Dock = DockStyle.Bottom;
        labelText.Location = new Point(3, 0);
        labelText.Name = "label1";
        labelText.Size = new Size(403, 15);
        labelText.TabIndex = 3;
        labelText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TextInputForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        ClientSize = new Size(409, 81);
        Controls.Add(tableLayoutPanel1);
        Name = "TextInputForm";
        Text = "Input";
        Load += TextInputForm_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    internal TextBox textBoxInput;
    private Button button1;
    private Button button2;
    internal Label labelText;
}