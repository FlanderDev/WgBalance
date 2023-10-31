using AuditHelper.Buisness;
using AuditHelper.Data;
using AuditHelper.Model;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace AuditHelper.Forms;

public partial class MainForm : Form
{
    #region formCreation
    public MainForm() => InitializeComponent();

    private void MainForm_Load(object sender, EventArgs e)
    {
        using var dbContext = new DatabaseContext();

        try
        {
            dbContext.Database.EnsureCreated();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Could not ensure Database exists.{Environment.NewLine}{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        var peopleList = dbContext.People.AsNoTracking().ToList();
        dataGridViewPeople.DataSource = peopleList;
    }
    #endregion

    #region buttons_events
    private void ButtonPersonAdd_Click(object sender, EventArgs e)
    {
        var input = PromptForInput("Input the Persons name");
        if (string.IsNullOrWhiteSpace(input))
            return;

        DatabaseManager.AddNewPerson(new Person(input));
    }

    private void ButtonPersonRemove_Click(object sender, EventArgs e)
    {
        var selectedPerson = GetSelectedPerson();
        if (selectedPerson == null)
            return;

        var result = MessageBox.Show($"Are you sure you want to remove the person '{selectedPerson.Name}' ({selectedPerson.Id}).", "Confirm", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
            DatabaseManager.RemovePerson(selectedPerson);
    }

    private void ButtonPurchaseAdd_Click(object sender, EventArgs e)
    {
    }

    private void ButtonPurchaseRemove_Click(object sender, EventArgs e)
    {

    }

    private void ButtonItemAdd_Click(object sender, EventArgs e)
    {

    }

    private void ButtonItemRemove_Click(object sender, EventArgs e)
    {

    }

    #endregion

    #region dataGridView_events
    private void DataGridViewPeople_SelectionChanged(object sender, EventArgs e)
    {
    }


    private void DataGridViewPurchase_SelectionChanged(object sender, EventArgs e)
    {
    }

    private void DataGridViewItems_SelectionChanged(object sender, EventArgs e)
    {

    }
    #endregion

    #region helperMethods
    private Person? GetSelectedPerson()
    {
        if (dataGridViewPeople.SelectedRows.Count <= 0)
            return null;

        if (dataGridViewPeople.SelectedRows.Cast<DataGridViewRow>().First().DataBoundItem is not Person selectedPerson)
            return null;

        return selectedPerson;
    }

    private Purchase? GetSelectedPurchase()
    {
        if (dataGridViewPurchase.SelectedRows.Count <= 0)
            return null;

        if (dataGridViewPurchase.SelectedRows.Cast<DataGridViewRow>().First().DataBoundItem is not Purchase selectedPurchase)
            return null;

        return selectedPurchase;
    }

    private Item? GetSelectedItem()
    {
        if (dataGridViewItems.SelectedRows.Count <= 0)
            return null;

        if (dataGridViewItems.SelectedRows.Cast<DataGridViewRow>().First().DataBoundItem is not Item selectedItem)
            return null;

        return selectedItem;
    }

    private string? PromptForInput(string labelText) => PromptForInputs(labelText).First();
    private List<string?> PromptForInputs(params string[] labelTexts)
    {
        var results = new List<string?>();

        foreach (var labelText in labelTexts)
        {
            var textInputForm = new TextInputForm(labelText);
            if (textInputForm.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(textInputForm.textBoxInput.Text))
                results.Add(null);
            else
                results.Add(textInputForm.textBoxInput.Text);
        }

        return results;
    }
    #endregion
}