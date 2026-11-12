using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buladaco_week06_work05
{
    public partial class ucProductListing : UserControl
    {
        public ucProductListing()
        {
            InitializeComponent();
        }
        string[] units = { "Piece", "Box", "Kilogram", "Liter", "cm", "ft" };

        List<string> shopingList = new List<string>();

       private void ucProductListing_Load_1(object sender, EventArgs e)
        {
            cmbUnit.Items.AddRange(units);
            cmbUnit.SelectedIndex = 0;

            BoxItem.DataSource = shopingList;
        }

        private void updateGUI()
        {
            BoxItem.DataSource = null;
            BoxItem.DataSource = shopingList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtDescription.Text;
            double amount = double.Parse(txtAmount.Text);
            string unit = cmbUnit.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(unit) && !string.IsNullOrEmpty(item) &&
                    !string.IsNullOrEmpty(amount.ToString()))
            {
                string row = $"{item}   {amount}   {unit}";
                shopingList.Add(row);
                updateGUI();

                MessageBox.Show("ITEM ADDED");
                txtAmount.Clear();
                txtDescription.Clear();
                cmbUnit.Refresh();
                txtDescription.Focus();
            }
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = BoxItem.SelectedIndex;
            if(index != -1)
                {
                DialogResult deleteMessage = MessageBox.Show("BRU are you surer you want to delete it?" , 
                    "Delete Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                MessageBox.Show(shopingList[index] + "delete.");
                shopingList.RemoveAt(index);
                updateGUI() ;

                }
            
                else
                {
                lblPrompt.Text = "Please select an item to delete yow.";
                lblPrompt.Visible = true;
                }
            }

        private void BoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrompt.Text = " ";
            lblPrompt.Visible = false;
        }
    }
    }

