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
    public partial class Penyewaan : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataAdapter sdi = new SqlDataAdapter();
        SqlDataAdapter sdu = new SqlDataAdapter();
        SqlDataAdapter sdo = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataSet penyewa = new DataSet();
        DataSet bluray = new DataSet();
        DataSet search = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-CV0CUA6O\\SQLEXPRESS;Initial Catalog=TA_SBD;Integrated " +
            "Security = True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
                Penyewa();
                Bluray();
            }
        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from Penyewaan";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            ViewPenyewaan.DataSource = ds;
            ViewPenyewaan.DataBind();
            con.Close();
        }

        public void Penyewa()
        {
            penyewa = new DataSet();
            cmd.CommandText = "Select * from Penyewa";
            cmd.Connection = con;
            sdi = new SqlDataAdapter(cmd);
            sdi.Fill(penyewa);
            ViewPenyewa.DataSource = penyewa;
            ViewPenyewa.DataBind();
            con.Close();
        }

        public void Bluray()
        {
            bluray = new DataSet();
            cmd.CommandText = "Select * from Bluray";
            cmd.Connection = con;
            sdo = new SqlDataAdapter(cmd);
            sdo.Fill(bluray);
            ViewBluray.DataSource = bluray;
            ViewBluray.DataBind();
            con.Close();
        }

        public void SearchList()
        {
            search = new DataSet();
            cmd.CommandText = "Select * from Penyewaan where Nama like '%" + searchText.Text.ToString() + "%' " +
            "or Alamat like '%" + searchText.Text.ToString() + "%' " +
            "or Judul like '%" + searchText.Text.ToString() + "%' " +
            "or Tahun_Terbit like '%" + searchText.Text.ToString() + "%' " +
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

            if (txtJudul.Text.ToString() == "" || txtIdPenyewa.Text == "" || txtTahun.Text.ToString() == "" || txtIdBluray.Text == "" || txtIdToko.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage2", "alert('WARNING: Data yang Ditambahkan Invalid')", true);
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Insert Into Bluray(Id_Bluray, Judul, Tahun_Terbit, Id_Penyewa, Id_Toko)values('" + txtIdBluray.Text + "', '" + txtJudul.Text.ToString() + "','" + txtTahun.Text.ToString() + "','" + txtIdPenyewa.Text + "','" + txtIdToko.Text + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage1", "alert('Data Berhasil Ditambahkan')", true);
            }
            DataShow();
            Penyewa();
            Bluray();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Bluray set Judul='" +
            txtJudul.Text.ToString() + "', Tahun_Terbit = '" + txtTahun.Text.ToString() + "', Id_Penyewa= '" + txtIdPenyewa.Text + "', Id_Toko= '" + txtIdToko.Text + "' WHERE Id_Bluray = '" + txtIdBluray.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            DataShow();
            Penyewa();
            Bluray();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from Bluray where Id_Bluray = '" + txtIdBluray.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
            Penyewa();
            Bluray();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtIdPenyewa.Text = null;
            txtJudul.Text = null;
            txtTahun.Text = null;
            txtIdPenyewa.Text = null;
            txtIdToko.Text = null;
        }

        protected void btnPenyewa_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:56311/LIstPenyewa.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SearchList();

        }
        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:56311/Login.aspx");
        }
    }
}