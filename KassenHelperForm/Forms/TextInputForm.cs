using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditHelper.Forms;

public partial class TextInputForm : Form
{
    public TextInputForm(string labelText)
    {
        InitializeComponent();
        this.labelText.Text = labelText;
    }

    private void TextInputForm_Load(object sender, EventArgs e)
    {

    }

    private void ButtonOk_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
