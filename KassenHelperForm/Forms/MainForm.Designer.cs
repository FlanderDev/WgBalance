namespace AuditHelper.Forms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new TableLayoutPanel();
        buttonItemRemove = new Button();
        buttonItemAdd = new Button();
        buttonPurchaseRemove = new Button();
        buttonPurchaseAdd = new Button();
        dataGridViewItems = new DataGridView();
        dataGridViewPurchase = new DataGridView();
        dataGridViewPeople = new DataGridView();
        buttonPersonAdd = new Button();
        buttonPersonRemove = new Button();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewPeople).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 6;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
        tableLayoutPanel1.Controls.Add(buttonItemRemove, 5, 2);
        tableLayoutPanel1.Controls.Add(buttonItemAdd, 4, 2);
        tableLayoutPanel1.Controls.Add(buttonPurchaseRemove, 3, 2);
        tableLayoutPanel1.Controls.Add(buttonPurchaseAdd, 2, 2);
        tableLayoutPanel1.Controls.Add(dataGridViewItems, 4, 0);
        tableLayoutPanel1.Controls.Add(dataGridViewPurchase, 2, 0);
        tableLayoutPanel1.Controls.Add(dataGridViewPeople, 0, 0);
        tableLayoutPanel1.Controls.Add(buttonPersonAdd, 0, 2);
        tableLayoutPanel1.Controls.Add(buttonPersonRemove, 1, 2);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(894, 604);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // buttonItemRemove
        // 
        buttonItemRemove.Dock = DockStyle.Top;
        buttonItemRemove.Location = new Point(744, 577);
        buttonItemRemove.Name = "buttonItemRemove";
        buttonItemRemove.Size = new Size(147, 23);
        buttonItemRemove.TabIndex = 8;
        buttonItemRemove.Text = "Remove";
        buttonItemRemove.UseVisualStyleBackColor = true;
        buttonItemRemove.Click += ButtonItemRemove_Click;
        // 
        // buttonItemAdd
        // 
        buttonItemAdd.Dock = DockStyle.Top;
        buttonItemAdd.Location = new Point(596, 577);
        buttonItemAdd.Name = "buttonItemAdd";
        buttonItemAdd.Size = new Size(142, 23);
        buttonItemAdd.TabIndex = 7;
        buttonItemAdd.Text = "Add";
        buttonItemAdd.UseVisualStyleBackColor = true;
        buttonItemAdd.Click += ButtonItemAdd_Click;
        // 
        // buttonPurchaseRemove
        // 
        buttonPurchaseRemove.Dock = DockStyle.Top;
        buttonPurchaseRemove.Location = new Point(448, 577);
        buttonPurchaseRemove.Name = "buttonPurchaseRemove";
        buttonPurchaseRemove.Size = new Size(142, 23);
        buttonPurchaseRemove.TabIndex = 6;
        buttonPurchaseRemove.Text = "Remove";
        buttonPurchaseRemove.UseVisualStyleBackColor = true;
        buttonPurchaseRemove.Click += ButtonPurchaseRemove_Click;
        // 
        // buttonPurchaseAdd
        // 
        buttonPurchaseAdd.Dock = DockStyle.Top;
        buttonPurchaseAdd.Location = new Point(300, 577);
        buttonPurchaseAdd.Name = "buttonPurchaseAdd";
        buttonPurchaseAdd.Size = new Size(142, 23);
        buttonPurchaseAdd.TabIndex = 5;
        buttonPurchaseAdd.Text = "Add";
        buttonPurchaseAdd.UseVisualStyleBackColor = true;
        buttonPurchaseAdd.Click += ButtonPurchaseAdd_Click;
        // 
        // dataGridViewItems
        // 
        dataGridViewItems.AllowUserToAddRows = false;
        dataGridViewItems.AllowUserToDeleteRows = false;
        dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableLayoutPanel1.SetColumnSpan(dataGridViewItems, 2);
        dataGridViewItems.Dock = DockStyle.Fill;
        dataGridViewItems.EditMode = DataGridViewEditMode.EditProgrammatically;
        dataGridViewItems.Location = new Point(596, 3);
        dataGridViewItems.MultiSelect = false;
        dataGridViewItems.Name = "dataGridViewItems";
        tableLayoutPanel1.SetRowSpan(dataGridViewItems, 2);
        dataGridViewItems.RowTemplate.Height = 25;
        dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewItems.Size = new Size(295, 568);
        dataGridViewItems.TabIndex = 2;
        dataGridViewItems.SelectionChanged += DataGridViewItems_SelectionChanged;
        // 
        // dataGridViewPurchase
        // 
        dataGridViewPurchase.AllowUserToAddRows = false;
        dataGridViewPurchase.AllowUserToDeleteRows = false;
        dataGridViewPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableLayoutPanel1.SetColumnSpan(dataGridViewPurchase, 2);
        dataGridViewPurchase.Dock = DockStyle.Fill;
        dataGridViewPurchase.EditMode = DataGridViewEditMode.EditProgrammatically;
        dataGridViewPurchase.Location = new Point(300, 3);
        dataGridViewPurchase.MultiSelect = false;
        dataGridViewPurchase.Name = "dataGridViewPurchase";
        tableLayoutPanel1.SetRowSpan(dataGridViewPurchase, 2);
        dataGridViewPurchase.RowTemplate.Height = 25;
        dataGridViewPurchase.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewPurchase.Size = new Size(290, 568);
        dataGridViewPurchase.TabIndex = 1;
        dataGridViewPurchase.SelectionChanged += DataGridViewPurchase_SelectionChanged;
        // 
        // dataGridViewPeople
        // 
        dataGridViewPeople.AllowUserToAddRows = false;
        dataGridViewPeople.AllowUserToDeleteRows = false;
        dataGridViewPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableLayoutPanel1.SetColumnSpan(dataGridViewPeople, 2);
        dataGridViewPeople.Dock = DockStyle.Fill;
        dataGridViewPeople.EditMode = DataGridViewEditMode.EditProgrammatically;
        dataGridViewPeople.Location = new Point(3, 3);
        dataGridViewPeople.MultiSelect = false;
        dataGridViewPeople.Name = "dataGridViewPeople";
        tableLayoutPanel1.SetRowSpan(dataGridViewPeople, 2);
        dataGridViewPeople.RowTemplate.Height = 25;
        dataGridViewPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewPeople.Size = new Size(291, 568);
        dataGridViewPeople.TabIndex = 0;
        dataGridViewPeople.SelectionChanged += DataGridViewPeople_SelectionChanged;
        // 
        // buttonPersonAdd
        // 
        buttonPersonAdd.Dock = DockStyle.Top;
        buttonPersonAdd.Location = new Point(3, 577);
        buttonPersonAdd.Name = "buttonPersonAdd";
        buttonPersonAdd.Size = new Size(143, 23);
        buttonPersonAdd.TabIndex = 3;
        buttonPersonAdd.Text = "Add";
        buttonPersonAdd.UseVisualStyleBackColor = true;
        buttonPersonAdd.Click += ButtonPersonAdd_Click;
        // 
        // buttonPersonRemove
        // 
        buttonPersonRemove.Dock = DockStyle.Top;
        buttonPersonRemove.Location = new Point(152, 577);
        buttonPersonRemove.Name = "buttonPersonRemove";
        buttonPersonRemove.Size = new Size(142, 23);
        buttonPersonRemove.TabIndex = 4;
        buttonPersonRemove.Text = "Remove";
        buttonPersonRemove.UseVisualStyleBackColor = true;
        buttonPersonRemove.Click += ButtonPersonRemove_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(894, 604);
        Controls.Add(tableLayoutPanel1);
        Name = "MainForm";
        Text = "Form1";
        Load += MainForm_Load;
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewPeople).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private DataGridView dataGridViewPeople;
    private DataGridView dataGridViewItems;
    private DataGridView dataGridViewPurchase;
    private Button buttonItemRemove;
    private Button buttonItemAdd;
    private Button buttonPurchaseRemove;
    private Button buttonPurchaseAdd;
    private Button buttonPersonAdd;
    private Button buttonPersonRemove;
}