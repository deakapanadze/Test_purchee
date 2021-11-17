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
    public partial class AddRequirementsForm : Form
    {
        dbmanager db = new dbmanager();
        
        public AddRequirementsForm()
        {
           
            InitializeComponent();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            Requirements requirements = new Requirements();
            requirements.Quantity = Convert.ToInt32(txt_Quantity.Text);
            requirements.Date = Convert.ToDateTime(dtp_Date.Text);
            requirements.DepartmentID = Convert.ToInt32(cmb_Department.SelectedValue);
            requirements.InventoryId = Convert.ToInt32(cmb_inventary.SelectedValue);
            requirements.Description = Convert.ToString(txt_Description.Text);




            db.AddRequirements(requirements);
            this.Close();
        }

       
        private void AddRequirementsForm_Load(object sender, EventArgs e)
        {
            // ასარჩევი დეპარტამენტი Combox
            cmb_Department.DataSource = db.GetDepartament();
            cmb_Department.DisplayMember = "NameDep";
            cmb_Department.ValueMember = "Id";

            // ასარჩევი ინვენტარი Combox
            cmb_inventary.DataSource = db.Getinventary();
            cmb_inventary.DisplayMember = "NameInv";
            cmb_inventary.ValueMember = "Id";
        }
    }
}
