using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class personControl : UserControl
    {
        List<PersonModel> people = new List<PersonModel>();
        public personControl()
        {
            InitializeComponent();
            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPeople();
            WireUpUsersList();
        }

        private void WireUpUsersList()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = people;

        }

        private void ButtonAddPerson_Click(object sender, EventArgs e)
        {
            resetBackgroundColor();
            if (textFName.Text == "" || textLName.Text == "")
            {
                if (textFName.Text == "")
                {
                    textFName.BackColor = System.Drawing.Color.LightCoral;
                }
                if (textLName.Text == "")
                {
                    textLName.BackColor = System.Drawing.Color.LightCoral;
                }
                this.labelLogContent.Text = "Person NOT added. First name and last name are required.";
            }
            else if (IsValidEmail(textEmail.Text) || textEmail.Text=="")
            {
                PersonModel person = new PersonModel
                {
                    FirstName = textFName.Text,
                    LastName = textLName.Text,
                    Email = textEmail.Text,
                    Role = textRole.Text,
                    Info = textInfo.Text
                };

                bool personAdded = SqliteDataAccess.SavePerson(person);
                LoadPeopleList();

                textFName.Text = "";
                textLName.Text = "";
                textEmail.Text = "";
                textRole.Text = "";
                textInfo.Text = "";
                if (personAdded)
                {
                    this.labelLogContent.Text = "Person succesfully added to the database.";
                }
                else
                {
                    this.labelLogContent.Text = "There was a problem with adding a person to the database. Try again";
                }
            }
            else
            {
                this.labelLogContent.Text = "The email you've entered is not valid. Try again.";
                textEmail.BackColor = System.Drawing.Color.LightCoral;
            }
        }

        private void ButtonSearchPerson_Click(object sender, EventArgs e)
        {
            resetBackgroundColor();
            PersonModel person = new PersonModel
            {
                FirstName = textFName.Text,
                LastName = textLName.Text,
                Email = textEmail.Text,
                Role = textRole.Text,
                Info = textInfo.Text
            };

            people = SqliteDataAccess.SearchPerson(person);
            WireUpUsersList();
            if (people.Count==0)
            {
                this.labelLogContent.Text = "There is no one fulfilling the requirements. Try to be more generic.";
            }
            else
            {
                this.labelLogContent.Text = "";
            }
        }

        private void ButtonShowAll_Click(object sender, EventArgs e)
        {
            resetBackgroundColor();
            LoadPeopleList();
            this.labelLogContent.Text = "Showing all the records from the database.";

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            resetBackgroundColor();
            if (dataGridView.Rows.Count > 0) { 
                PersonModel person = new PersonModel
                {
                    Id = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString()),
                    FirstName = dataGridView.SelectedRows[0].Cells[1].Value.ToString(),
                    LastName = dataGridView.SelectedRows[0].Cells[2].Value.ToString(),
                    Email = dataGridView.SelectedRows[0].Cells[3].Value.ToString(),
                    Role = dataGridView.SelectedRows[0].Cells[4].Value.ToString(),
                    Info = dataGridView.SelectedRows[0].Cells[5].Value.ToString()
                };

                Popup formPopup = new Popup(person);
                formPopup.ShowDialog(this);
                this.labelLogContent.Text = "";

                if (formPopup.DeletePerson)
                {
                    int personId = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    bool deletedPerson = SqliteDataAccess.DeletePerson(personId);
                    LoadPeopleList();
                    if (deletedPerson)
                    {
                        this.labelLogContent.Text = "Person succesfully deleted from the database.";
                    }
                    else
                    {
                        this.labelLogContent.Text = "There was a problem with deleting a person from the database. Try again";
                    }
                }
            }
            else
            {
                this.labelLogContent.Text = "There is no data to delete.";
            }


        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool dataModified = false;
            PersonModel person = new PersonModel
            {
                Id = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString()),
                FirstName = dataGridView.SelectedRows[0].Cells[1].Value.ToString(),
                LastName = dataGridView.SelectedRows[0].Cells[2].Value.ToString(),
                Email = dataGridView.SelectedRows[0].Cells[3].Value.ToString(),
                Role = dataGridView.SelectedRows[0].Cells[4].Value.ToString(),
                Info = dataGridView.SelectedRows[0].Cells[5].Value.ToString()
            };
            if (IsValidEmail(dataGridView.SelectedRows[0].Cells[3].Value.ToString()))
            {
                dataModified = SqliteDataAccess.ModifyPerson(person);
                if (dataModified)
                {
                    dataGridView.CurrentCell.Style.BackColor = System.Drawing.Color.White;
                    this.labelLogContent.Text = "Person data succesfully modified.";
                }
                else
                {
                    this.labelLogContent.Text = "There was a problem with modifying a person's data in the database. Try again";
                }
            }
            else
            {
                this.labelLogContent.Text = "The eamil was not updated. Enter a valid email.";
                dataGridView.CurrentCell.Style.BackColor = System.Drawing.Color.LightCoral;
            }      

        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void resetBackgroundColor()
        {
            textEmail.BackColor = System.Drawing.Color.White;
            textFName.BackColor = System.Drawing.Color.White;
            textLName.BackColor = System.Drawing.Color.White;
        }
    }
}
