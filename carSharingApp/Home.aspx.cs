using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace carSharingApp
{
    public partial class Home : System.Web.UI.Page
    {

        string cs = ConfigurationManager.ConnectionStrings["cs1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            UserButton.Text = Session["userName"].ToString();
            //string cs = ConfigurationManager.ConnectionStrings["cs1"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "select VehicalName, \"From\" as \"Satrting Location\", \"To\" as \"Destination\", \"firstname\" as \"By\", gender as \"Gender\" , \"date\" as \"Trip Date\" from Carpool INNER JOIN Users on \"By\" = \"uName\";";
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //ds = new DataSet();
            //try
            //{
            //    using (con)
            //    {
            //        con.Open();
            //        da.Fill(ds, "Carpool");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //GridView1.DataSource = ds.Tables["Carpool"];
            //GridView1.DataBind();

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
        protected void Logout_Leave(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void User_Leave(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                Response.Redirect("User.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
    }
}