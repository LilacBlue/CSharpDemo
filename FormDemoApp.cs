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
    public partial class FormDemoApp : Form
    {
        public FormDemoApp()
        {
            InitializeComponent();
        }
        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            panelOrange.Top = buttonUsers.Top;
        }
        private void ButtonTasks_Click(object sender, EventArgs e)
        {
            panelOrange.Top = buttonTasks.Top;
        }
        private void ButtonView_Click(object sender, EventArgs e)
        {
            panelOrange.Top = buttonView.Top;
        }
    }
}
