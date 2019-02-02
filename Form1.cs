using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WinFormsList.Model;

namespace WinFormsList
{
    public partial class Form1 : Form
    {
        private List<Person> allPeople = new List<Person>();
        private List<Person> depPeople = new List<Person>();
        private BindingList<Person> people = new BindingList<Person>();
        private BindingList<Department> departments;

        private Person selectedPerson;

        AutoCompleteStringCollection source;
        public Form1()
        {
            InitializeComponent();

            source = new AutoCompleteStringCollection() { "01" };
            textBoxIdDep.AutoCompleteCustomSource = source;

            departments = new BindingList<Department>(){ new Department() { Id = 01, Name = "ABC" } };
            depGridView.DataSource = departments;

            peopleListBox.DataSource = people;
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIdDep.Text, out var id))
                return;

            var person = new Person
            {
                IdDep = id,
                FirstName = textBox1.Text,
                MiddleName = textBox2.Text,
                LastName = textBox3.Text,
            };
            
            allPeople.Add(person);
            ShowAllOrDepPeople(allPeople);
        }

        private void peopleListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedPerson = (Person)peopleListBox.SelectedItem;
            textBox1.Text = selectedPerson.FirstName;
            textBox2.Text = selectedPerson.MiddleName;
            textBox3.Text = selectedPerson.LastName;
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            selectedPerson = (Person)peopleListBox.SelectedItem;
            selectedPerson.FirstName = textBox1.Text;
            selectedPerson.MiddleName = textBox2.Text;
            selectedPerson.LastName = textBox3.Text;
            people.ResetBindings();
        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            people.Remove(selectedPerson);
            allPeople.Remove(selectedPerson);
        }

        private void addDeptButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxNewDepId.Text, out var id))
            {
                MessageBox.Show($"Wrong department Id: '{textBoxNewDepId.Text}'");
                return;
            }
            Department dept = new Department()
            {
                Id = id,
                Name = textBoxNewDepName.Text
            };
            if (departments.Any(d => d.Id == id))
            {
                MessageBox.Show($"Department with Id '{id}' already exists!");
                return;
            }

            departments.Add(dept);
        }
        private void depGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectDepartment();
            peopleListBox.DataSource = people;
        }
        private void SelectButton1_Click(object sender, EventArgs e)
        {
            ShowAllOrDepPeople(depPeople);
        }
        private void SelectDepartment()
        {
            if (depGridView.SelectedRows.Count < 1)
                return;

            var selectedRow = depGridView.SelectedRows[0];
            if (!int.TryParse(selectedRow.Cells[0].Value.ToString(), out var depId))
                return;
            textBoxIdDep.Text = depId.ToString();
            depPeople = allPeople.Where(x => x.IdDep == depId).ToList();
        }

        private void ShowAllOrDepPeople(List<Person> AllOrDepPeople)
        {
            people = new BindingList<Person>(AllOrDepPeople);
            peopleListBox.DataSource = people;
        }
        private void DeleteButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You want to delete a department and all its contents?",
                "Delete of department",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.OK)
            {
                foreach (var item in depPeople)
                {
                    people.Remove(item);
                    allPeople.Remove(item);
                }
                // удаляем выделенные строки из dataGridView
                foreach (DataGridViewRow row in depGridView.SelectedRows)
                {
                    depGridView.Rows.Remove(row);
                }
            }
            else
                return;
        }

        private void ShowAllButton1_Click(object sender, EventArgs e)
        {
            ShowAllOrDepPeople(allPeople);
        }
    }
}
