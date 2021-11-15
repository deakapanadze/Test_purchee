using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_purchee.Models;

namespace Test_purchee
{
    public partial class Purchase : Form
    {
        dbmanager db = new dbmanager();

        public Purchase()
        {
            InitializeComponent();
        }
      

        private void Purchase_Load(object sender, EventArgs e)
        {
            GetInComes();
            GetRequirements();
        }


        private void GetInComes()
        {
            dataGridView1.DataSource = db.GetInComes();

        }

        private void GetRequirements()
        {
            dataGridView2.DataSource = db.GetRequirements();
        }

       

        private void btn_inventary_Click(object sender, EventArgs e)
        {
            InventariesForm addInventories = new InventariesForm();
            addInventories.Show();
        }
    }
}
