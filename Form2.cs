using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Cards
{
    public partial class editCardForm : Form
    {
        public editCardForm()
        {
            InitializeComponent();
            tabControl1.Selected += new TabControlEventHandler(tabControl1_Selected);
        }

        private void editCardForm_Load(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == simpleEditPage.Name)
            {
                editCardForm.ActiveForm.WindowState = FormWindowState.Normal;
                editCardForm.ActiveForm.Size = new Size(400, 250);
                editCardForm.ActiveForm.MaximizeBox = false;
                editCardForm.ActiveForm.MinimizeBox = false;
            }
            else
            {
                editCardForm.ActiveForm.WindowState = FormWindowState.Normal;
                editCardForm.ActiveForm.Size = new Size(800, 450);
                editCardForm.ActiveForm.MaximizeBox = true;
                editCardForm.ActiveForm.MinimizeBox = true;
            }
        }
    }
}