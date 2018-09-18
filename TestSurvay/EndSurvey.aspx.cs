using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace TestSurvay
{
    public partial class EndSurvey : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var dateSurvey = DateCompletion().Date;
                var ListOfAnswer = (List<String>)Session["ListOfAnswer"];
                string id = Session["User"].ToString();
                var ListOfQuestion = (List<String>)Session["ListOfQuestion"];
                for (int i = 0; i < ListOfAnswer.Count; i++)
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=SQL5027.site4now.net; Initial Catalog=DB_9AB8B7_D18DDA6011; User Id=DB_9AB8B7_D18DDA6011_admin;Password=2UwvrBNk"))
                    {
                        string sql = "INSERT INTO  Question_Answer (answer,q_id, ip_address,user_id,completedDate) VALUES('" + ListOfAnswer[i] + "','" + ListOfQuestion[i] + "','" + user_IP_address() + "','" + id + "','" + dateSurvey.ToString("yyyy-MM-dd") + "'); ";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        conn.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                        }
                    }
                }
            }
            catch (Exception error)
            {
                System.Diagnostics.Debug.WriteLine("Error: "+ error);
            }
        }
        protected string user_IP_address()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
        protected DateTime DateCompletion()
        {
            DateTime dateTime = DateTime.Now;

            return dateTime;
        }
 
    }
}