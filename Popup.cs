using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Popup : Form
    {
        PersonModel person;
        public Boolean DeletePerson { get; set; }
        public Popup(PersonModel person)
        {
            InitializeComponent();
            this.person = person;
            this.labelPersonName.Text = person.FirstName + " " + person.LastName;
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            this.Close();
            DeletePerson = true;
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
            DeletePerson = false;
        }
    }
}
