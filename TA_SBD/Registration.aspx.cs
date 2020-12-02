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
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
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

        protected void btnSignUp_Click(object sender, EventArgs e)
        {

            if (txtNama.Text.ToString() == ""  || txtPassword.Text.ToString() == "" || txtLevel.Text.ToString() == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage2", "alert('WARNING: Data yang Ditambahkan Invalid')", true);
            }

            else if (txtLevel.Text.ToString() != "Admin" && txtLevel.Text.ToString() != "User")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage3", "alert('WARNING: Data yang dimassukkan harus berupa Admin atau User')", true);
            }

            else
            {
                dt = new DataTable();
                cmd.CommandText = "insert into Pengguna(Nama,Password,Level)values('" + txtNama.Text + "',CONVERT(NVARCHAR(32),HashBytes('MD5','" + txtPassword.Text + "'),2),'" + txtLevel.Text.ToString() + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage1", "alert('Pengguna Berhasil Ditambahkan')", true);
            }

        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:56311/Login.aspx");
        }
    }
    
}