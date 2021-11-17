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
    public partial class DepartamentForm : Form
    {
        dbmanager db = new dbmanager();
        public DepartamentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departments dep = new Departments();
            dep.NameDep = textBox1.Text;
            db.Adddepartament(dep);
            this.Close();
          }


        private void GetDepartament()
        {
            dataGridView1.DataSource = db.GetDepartament();
        }

        private void DepartamentForm_Load(object sender, EventArgs e)
        {
            GetDepartament();
        }
    }
}
