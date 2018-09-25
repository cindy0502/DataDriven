using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace TestSurvay
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["User"] = "Anonymous";
            Response.Redirect("Survay.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox10.Text == "" || TextBox4.Text == "" || TextBox7.Text == "" || TextBox9.Text == "" || TextBox8.Text == "")
                lblFail.Text = "Please fill in all the fields";
            else
            {
                using (SqlConnection conn = new SqlConnection("Data Source=SQL5027.site4now.net; Initial Catalog=DB_9AB8B7_D18DDA6011; User Id=DB_9AB8B7_D18DDA6011_admin;Password=2UwvrBNk"))
                {
                    string sql = "INSERT INTO  Register (first_name,last_name,email,age_range, gender,address, postcode, state) VALUES('" + TextBox1 + "','" + TextBox10 + "','" + TextBox4 + "','" + DropDownList1 + "','" + DropDownList2 + "','" + TextBox7 + "', '" + TextBox9 + "', '" + TextBox8 + "'); ";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Clear();
                    lblSucces.Text = "You have succefully been registred";
                    Session["User"] = "Anonymous";
                    Response.Redirect("Survay.aspx");

                }

            } 

        }
        void Clear()
        {
            TextBox1.Text = TextBox10.Text = TextBox4.Text = TextBox7.Text = TextBox9.Text = TextBox8.Text = "";
            lblSucces.Text = lblFail.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

    }
}