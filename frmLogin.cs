using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buladaco_week06_work05
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                MessageBox.Show("lOGIN SUCCESSFUL!");
                var inventoryForm = new frmInventory();
                inventoryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username or passwordtch!");
            }
    
            
        }
        
    }
}
