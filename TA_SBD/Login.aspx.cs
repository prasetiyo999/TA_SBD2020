using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TA_SBD
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-CV0CUA6O\\SQLEXPRESS;Initial Catalog=TA_SBD;Integrated " +
            "Security = True";
            con.Open();
            if (!Page.IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtNama.Text.ToString() == "" || txtPassword.Text.ToString() == "" )
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage2", "alert('Data yang dimasukkan Invalid')", true);
            }

            else
            {
                dt = new DataTable();
                cmd.CommandText = "select * from Pengguna where Nama='" + txtNama.Text + "' and Password=CONVERT(NVARCHAR(32),HashBytes('MD5','" + txtPassword.Text + "'),2)";
                cmd.Connection = con;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    string data = Convert.ToString(dr["Level"]);
                    if ( data == "Admin")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage4", "alert('Selamat datamg sebagai Admin')", true);
                        Response.Redirect("http://localhost:56311/Penyimpanan.aspx");
                    }
                    else if (data == "User")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage5", "alert('Selamat datamg sebagai User')", true);
                        Response.Redirect("http://localhost:56311/Penyewaan.aspx");
                    }
                    
                }

                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage1", "alert('WARNING: Username atau Password Salah')", true);
                }

            }

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:56311/Registration.aspx");
        }
    }
}