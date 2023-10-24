using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace carSharingApp
{
    public partial class User : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cs1"].ConnectionString;
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(cs);
                String query = "select * from Users where uName=@uname";
                SqlCommand cmd = new SqlCommand(query, con);
                string value = Session["userName"].ToString();
                cmd.Parameters.AddWithValue("@uname", value);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                table.Append("<table border='1px solid blue' cellpadding='4' cellspacing='4' style='color:blue'>");
                table.Append("<tr><th>ID</th><th>User Name</th><th>Full Name</th><th>Last Name</th><th>Gender</th>");
                table.Append("</tr>");
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        table.Append("<tr>");
                        table.Append("<td>" + rd[0] + "</td>");
                        table.Append("<td>" + rd[1] + "</td>");
                        table.Append("<td>" + rd[2] + "</td>");
                        table.Append("<td>" + rd[3] + "</td>");
                        table.Append("<td>" + rd[4] + "</td>");
                        table.Append("</tr>");
                    }
                }
                table.Append("</table>");
                PlaceHolder.Controls.Add(new Literal { Text = table.ToString() });
                table.Clear();
                rd.Close();
                con.Close();

                SqlConnection con2 = new SqlConnection(cs);
                String query2 = "select * from Carpool where ([by]=@uname)";
                SqlCommand cmd2 = new SqlCommand(query2, con2);
                cmd2.Parameters.AddWithValue("@uname", value);
                con2.Open();
                SqlDataReader rd2 = cmd2.ExecuteReader();
                table.Append("<table border='1px solid blue' cellpadding='4' cellspacing='4' style='color:blue'>");
                table.Append("<tr><th>ID</th><th>Vehicle Name</th><th>From</th><th>To</th><th>By</th><th>Max</th><th>With</th><th>travelling Date</th>");
                table.Append("</tr>");
                if (rd2.HasRows)
                {
                    while (rd2.Read())
                    {
                        table.Append("<tr>");
                        table.Append("<td>" + rd2[0] + "</td>");
                        table.Append("<td>" + rd2[1] + "</td>");
                        table.Append("<td>" + rd2[2] + "</td>");
                        table.Append("<td>" + rd2[3] + "</td>");
                        table.Append("<td>" + rd2[4] + "</td>");
                        table.Append("<td>" + rd2[5] + "</td>");
                        table.Append("<td>" + rd2[6] + "</td>");
                        table.Append("<td>" + rd2[7] + "</td>");
                        table.Append("</tr>");
                    }
                }
                table.Append("</table>");
                PlaceHolder2.Controls.Add(new Literal { Text = table.ToString() });
                table.Clear();
                rd2.Close();
                con2.Close();

                SqlConnection con4 = new SqlConnection(cs);
                String query4 = "select * from Request where ([From]=@uname)";
                SqlCommand cmd4 = new SqlCommand(query4, con4);
                cmd4.Parameters.AddWithValue("@uname", value);
                con4.Open();
                SqlDataReader rd4 = cmd4.ExecuteReader();
                table.Append("<table border='1px solid blue' cellpadding='4' cellspacing='4' style='color:blue'>");
                table.Append("<tr><th>ID</th><th>TO</th><th>Status</th>");
                table.Append("</tr>");
                if (rd4.HasRows)
                {
                    while (rd4.Read())
                    {
                        table.Append("<tr>");
                        table.Append("<td>" + rd4[0] + "</td>");
                        table.Append("<td>" + rd4[2] + "</td>");
                        table.Append("<td>" + rd4[3] + "</td>");
                        table.Append("</tr>");
                    }
                }
                table.Append("</table>");
                PlaceHolder3.Controls.Add(new Literal { Text = table.ToString() });
                table.Clear();
                rd4.Close();
                con4.Close();

                SqlConnection con3 = new SqlConnection(cs);
                String query3 = "select * from Request where ([To]=@uname)";
                SqlCommand cmd3 = new SqlCommand(query3, con3);
                cmd3.Parameters.AddWithValue("@uname", value);
                con3.Open();
                SqlDataReader rd3 = cmd3.ExecuteReader();
                table.Append("<table border='1px solid blue' cellpadding='4' cellspacing='4' style='color:blue'>");
                table.Append("<tr><th>ID</th><th>From</th><th>Status</th><th>Vehicle Id</th>");
                table.Append("</tr>");
                if (rd3.HasRows)
                {
                    while (rd3.Read())
                    {
                        table.Append("<tr>");
                        table.Append("<td>" + rd3[0] + "</td>");
                        table.Append("<td>" + rd3[1] + "</td>");
                        table.Append("<td>" + rd3[3] + "</td>");
                        table.Append("<td>" + rd3[4] + "</td>");
                        table.Append("</tr>");
                    }
                }
                table.Append("</table>");
                PlaceHolder4.Controls.Add(new Literal { Text = table.ToString() });
                table.Clear();
                rd3.Close();
                con3.Close();

                SqlConnection con1 = new SqlConnection(cs);
                String query1 = "select * from Users where uName=@uname";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                cmd1.Parameters.AddWithValue("@uname", value);
                con1.Open();
                SqlDataReader rd1 = cmd1.ExecuteReader();
                String first = "", last = "", gender = "";
                if (rd1.HasRows)
                {
                    while (rd1.Read())
                    {
                        first = rd1[2].ToString();
                        last = rd1[3].ToString();
                        gender = rd1[4].ToString();
                    }
                }
                rd.Close();
                Label1.Text = "Hello  " + first + " " + last;
                Label2.Text = "Gender :" + gender;
                con1.Close();

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "delete from Carpool where userName=@uname";
            SqlCommand cmd = new SqlCommand(query, con);
            string value = Session["userName"].ToString();
            cmd.Parameters.AddWithValue("@uname", value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            deleteInSignUp();
        }
        void deleteInSignUp()
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "delete from Users where userName=@uname";
            SqlCommand cmd = new SqlCommand(query, con);
            string value = Session["userName"].ToString();
            cmd.Parameters.AddWithValue("@uname", value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
            Session["userName"] = null;
            //Response.Write("Record deleted successfully");
            //Response.Redirect("Login.aspx");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('SignUp Successfully ') </script>");
            Page_Load(null,null);

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                Response.Redirect("New.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
    }
}