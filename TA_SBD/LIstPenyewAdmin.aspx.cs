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
    public partial class LIstPenyewAdmin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataAdapter sdi = new SqlDataAdapter();
        SqlDataAdapter sdu = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataSet search = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-CV0CUA6O\\SQLEXPRESS;Initial Catalog=TA_SBD;Integrated " +
            "Security = True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }
        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from Penyewa";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            ViewPenyewa.DataSource = ds;
            ViewPenyewa.DataBind();
            con.Close();
        }

        public void SearchList()
        {
            search = new DataSet();
            cmd.CommandText = "Select * from Penyewa where Nama like '%" + searchText.Text.ToString() + "%' " +
            "or Alamat like '%" + searchText.Text.ToString() + "%' " +
            " or Email like '%" + searchText.Text.ToString() + "%';";
            cmd.Connection = con;
            sdu = new SqlDataAdapter(cmd);
            sdu.Fill(search);
            SearchView.DataSource = search;
            SearchView.DataBind();
            con.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtNama.Text.ToString() == "" || txtIdPenyewa.Text == "" || txtEmail.Text.ToString() == "" || txtAlamat.Text.ToString() == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage2", "alert('WRNING: Data yang Ditambahkan Invalid')", true);
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Insert Into Penyewa(Id_Penyewa, Nama, Alamat, Email)values('" + txtIdPenyewa.Text + "', '" + txtNama.Text.ToString() + "','" + txtAlamat.Text.ToString() + "','" + txtEmail.Text.ToString() + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage1", "alert('Data Berhasil Ditambahkan')", true);
            }
            DataShow();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Penyewa set Nama='" +
            txtNama.Text.ToString() + "', Alamat = '" + txtAlamat.Text.ToString() + "', Email= '" + txtEmail.Text.ToString() + "' WHERE Id_Penyewa = '" + txtIdPenyewa.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            DataShow();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from Penyewa where Id_Penyewa = '" + txtIdPenyewa.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtIdPenyewa.Text = null;
            txtNama.Text = null;
            txtAlamat.Text = null;
            txtEmail.Text = null;
        }

        protected void btnPenyewaan_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:56311/PenyewaanAdmin.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SearchList();

        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:56311/Login.aspx");
        }

        protected void btnPenyimpanan_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:56311/Penyimpanan.aspx");
        }
    }
}