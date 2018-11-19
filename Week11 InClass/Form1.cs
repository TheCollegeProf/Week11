using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11_InClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String rooms = cmbRooms.Text;

            //int roomCount;
            //bool isNum = int.TryParse(rooms, out roomCount);

            //if(isNum && roomCount > 0)
            //{
            // Output the variables per instruction
            lblOutput.Text = "Hello " + name + " your home has " + rooms + " bedrooms.";
            //}

            //else
            //{
            //    MessageBox.Show("Invalid entry, please try again");
            //    txtRooms.Clear();
            //}


        }
    }
}
