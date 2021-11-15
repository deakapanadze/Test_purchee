using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_purchee.Models;
using 

namespace Test_purchee
{

    public class dbmanager
    {
        public static string Purchase = ConfigurationManager.ConnectionStrings["Purchase"].ConnectionString;

        //მოთხოვნის წამოღების მეთოდი
        public List<Incomes> GetInComes()
        {
            List<Incomes> list = new List<Incomes>();

            SqlCommand cmd = new SqlCommand("[GetInComes]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Incomes In_Come = new Incomes();



                        In_Come.ID = Convert.ToInt32(reader["Id"]);
                        In_Come.InventoryId = Convert.ToInt32(reader["InventoryId"]);
                        In_Come.Quantity = Convert.ToInt32(reader["Quantity"]);
                        In_Come.DepartmentID = Convert.ToInt32(reader["DepartmentID"]);
                        In_Come.Date = Convert.ToDateTime(reader["Date"]);
                        In_Come.UserId = Convert.ToInt32(reader["UserId"]);
                        In_Come.RequirementId = Convert.ToInt32(reader["RequirementId"]);


                        list.Add(In_Come);

                    }
                    reader.Close();
                }
                return list.ToList();
            }
        }

       

        //შესყიდვების წამოღების მეთოდი

        public List<Requirements> GetRequirements()
        {
            List<Requirements> Requirements = new List<Requirements>();

            SqlCommand cmd = new SqlCommand("[GetRequirements]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Requirements Rqrnts= new Requirements();



                        Rqrnts.Id = Convert.ToInt32(reader["Id"]);
                        Rqrnts.InventoryId = Convert.ToInt32(reader["InventoryId"]);
                        Rqrnts.Quantity = Convert.ToInt32(reader["Quantity"]);
                        Rqrnts.DepartmentID = Convert.ToInt32(reader["DepartmentID"]);
                        Rqrnts.UserId = Convert.ToInt32(reader["UserId"]);
                        Rqrnts.Date = Convert.ToDateTime(reader["Date"]);
                        Rqrnts.Description = Convert.ToString(reader["Description"]);


                        Requirements.Add(Rqrnts);

                    }
                    reader.Close();
                }

                return Requirements.ToList();
            }
        }


        // ინვენტარის დამატების მეთოდი

        public void AddInventary(Inventories test)
        {
            SqlCommand cmd = new SqlCommand("AddInventary");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", test.Name);
            
            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
            }
        }



        // join


        public List<Requirements> GETpurchase()
        {
            List<Requirements> Requirements = new List<Requirements>();

            SqlCommand cmd = new SqlCommand("[GETpurchase]");
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlConnection conn = new SqlConnection(Purchase))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Requirements Rqrnts = new Requirements();



                        Rqrnts.Id = Convert.ToInt32(reader["Id"]);
                        Rqrnts.Name = Convert.ToString(reader["Name"]);
                        //Rqrnts.InventoryId = Convert.ToInt32(reader["InventoryId"]);
                        //Rqrnts.Quantity = Convert.ToInt32(reader["Quantity"]);
                        //Rqrnts.DepartmentID = Convert.ToInt32(reader["DepartmentID"]);
                        //Rqrnts.UserId = Convert.ToInt32(reader["UserId"]);
                        //Rqrnts.Date = Convert.ToDateTime(reader["Date"]);
                        //Rqrnts.Description = Convert.ToString(reader["Description"]);


                        Requirements.Add(Rqrnts);

                    }
                    reader.Close();
                }

                return Requirements.ToList();
            }
        }


    }
}
