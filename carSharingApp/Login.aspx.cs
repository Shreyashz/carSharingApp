using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace carSharingApp
{
    public partial class Login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cs1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                Response.Redirect("Home.aspx");
            }

        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Users where uName=@uname and password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uname", UnameTextBox.Text);
            cmd.Parameters.AddWithValue("@pass", PassTextBox.Text);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["userName"] = UnameTextBox.Text;
                Response.Write("<script> alert('Login SuccessFully') ; </script>");
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("<script> alert('Please Eneter Correct Uname ans password') ; </script>");
            }
            con.Close();
        }
    }
}