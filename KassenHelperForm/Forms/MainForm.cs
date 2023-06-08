using AuditHelper.Data;
using AuditHelper.Model;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace AuditHelper.Forms;

public partial class MainForm : Form
{
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

    private void ButtonPersonAdd_Click(object sender, EventArgs e)
    {
        var inputForm = new TextInputForm("Input the Persons name");
        if (inputForm.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(inputForm.labelText.Text))
            return;

        using var dbContext = new DatabaseContext();
        dbContext.People.Add(new Person(inputForm.labelText.Text));
        dbContext.SaveChanges();
    }

    private void ButtonPersonRemove_Click(object sender, EventArgs e)
    {
        var selectedPerson = GetSelectedPerson();
        if (selectedPerson == null)
            return;

        var result = MessageBox.Show($"Are you sure you want to remove the person '{selectedPerson.Name}' ({selectedPerson.Id}).", "Confirm", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
        {
            using var dbContext = new DatabaseContext();
            dbContext.People.Remove(selectedPerson);
            dbContext.SaveChanges();
        }
    }

    private void ButtonPurchaseAdd_Click(object sender, EventArgs e)
    {
        var inFormFilePath = new TextInputForm("Input the FilePath");
        if (inFormFilePath.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(inFormFilePath.labelText.Text))
            return;

        var filePath = inFormFilePath.labelText.Text.Trim().Trim('"');


        var inFormDecimal = new TextInputForm("Input price with '.'");
        if (inFormDecimal.ShowDialog() != DialogResult.OK || !decimal.TryParse(inFormDecimal.labelText.Text, out decimal price))
            return;


        var selectedPerson = GetSelectedPerson();
        if (selectedPerson == null)
            return;

        using var dbContext = new DatabaseContext();
        selectedPerson.Purchases.Add(new Purchase(filePath, price));
        dbContext.SaveChanges();
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

    private void DataGridViewPeople_SelectionChanged(object sender, EventArgs e)
    {
        var selectedPerson = GetSelectedPerson();
        if (selectedPerson == null)
            return;

        dataGridViewPurchase.DataSource = selectedPerson.Purchases;
    }

    private Person? GetSelectedPerson()
    {
        if (dataGridViewPeople.SelectedRows.Count <= 0)
            return null;

        if (dataGridViewPeople.SelectedRows.Cast<DataGridViewRow>().First().DataBoundItem is not Person selectedPerson)
        {
            MessageBox.Show("How is the selected Person null?");
            return null;
        }

        using var dbContext = new DatabaseContext();
        var foundPerson = dbContext.People.AsNoTracking().FirstOrDefault(p => p.Id == selectedPerson.Id);
        if (foundPerson == null)
            MessageBox.Show("Could not find matching person in database.");

        return foundPerson;
    }

    private void DataGridViewPurchase_SelectionChanged(object sender, EventArgs e)
    {
        var selectedPerson = GetSelectedPerson();

        if (selectedPerson == null ||dataGridViewPurchase.SelectedRows.Count <= 0)
            return;

        if (dataGridViewPurchase.SelectedRows.Cast<DataGridViewRow>().First().DataBoundItem is not Purchase selectedPurchase)
        {
            MessageBox.Show("How is the selected purchase null?");
            return;
        }

        var foundPurchase  = selectedPerson.Purchases.FirstOrDefault(p => p.Id == selectedPurchase.Id);
        if (foundPurchase == null)
        {
            MessageBox.Show("Could not find matching purchase in database.");
            return;
        }

        dataGridViewItems.DataSource = foundPurchase.Items;
    }

    private void DataGridViewItems_SelectionChanged(object sender, EventArgs e)
    {

    }
}