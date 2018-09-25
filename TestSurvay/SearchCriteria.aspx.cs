using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TestSurvay
{
    public partial class SearchCriteria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string search = "select from Register, Question_Answers";
            using (SqlConnection con = new SqlConnection("Data Source=SQL5027.site4now.net; Initial Catalog=DB_9AB8B7_D18DDA6011; User Id=DB_9AB8B7_D18DDA6011_admin;Password=2UwvrBNk"))
            {
                SqlCommand cmd = new SqlCommand(search, con);

                if (DropDownList1.Text == "First Name")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select first_name, last_name, gender, email, address, state, postcode from Register Where First Name like '" +TextBox1.Text + "%'", con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    GridView1.DataSource = data;
                }

                else if (DropDownList1.Text == "Last Name")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select first_name, last_name, gender, email, address, state, postcode from Register Where Last Name like '" + TextBox1.Text + "%'", con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    GridView1.DataSource = data;
                }

                else if (DropDownList1.Text == "Gender")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select first_name, last_name, gender, email, address, state, postcode from Register Where Gender like '" + TextBox1.Text + "%'", con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    GridView1.DataSource = data;
                }
                else if (DropDownList1.Text == "Address")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select first_name, last_name, gender, email, address, state, postcode from Register Where Address like '" + TextBox1.Text + "%'", con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    GridView1.DataSource = data;
                }
                else if (DropDownList1.Text == "State")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select first_name, last_name, gender, email, address, state, postcode from Register Where State like '" + TextBox1.Text + "%'", con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    GridView1.DataSource = data;
                }
                else if (DropDownList1.Text == "Postcode")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select first_name, last_name, gender, email, address, state, postcode from Register Where Postcode like '" + TextBox1.Text + "%'", con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    GridView1.DataSource = data;
                }
              /*  else if (DropDownList1.Text == "Bank Used")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select first_name, last_name, gender, email, address, state, postcode from Question_Answers Where Bank used like '" + TextBox1.Text + "%'", con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    GridView1.DataSource = data;
                }
                else if (DropDownList1.Text == "Bank Services")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select first_name, last_name, gender, email, address, state, postcode from Question_Answers Where Bank Services like '" + TextBox1.Text + "%'", con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    GridView1.DataSource = data;
                }
                else if (DropDownList1.Text == "Newspaper Read")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select first_name, last_name, gender, email, address, state, postcode from Question_Answers Where Newspaper Read like '" + TextBox1.Text + "%'", con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    GridView1.DataSource = data;
                }*/



                
                GridView1.DataBind();
                {
                }
            }
        }
    }
}