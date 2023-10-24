using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace carSharingApp
{
    public partial class Req : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cs1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Request values(@by,@to,@stat, @Vehilc)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Vehilc", vehTextBox.Text);
            cmd.Parameters.AddWithValue("@to", ToTextBox.Text);
            cmd.Parameters.AddWithValue("@stat", "NO");
            cmd.Parameters.AddWithValue("@by", Session["userName"]);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('Requested Successfully ') </script>");


            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('Request Failed ') </script>");
            }

            con.Close();

        }
    }
}