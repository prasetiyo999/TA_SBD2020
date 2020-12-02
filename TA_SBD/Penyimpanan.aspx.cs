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
    public partial class Penyimpanan : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataAdapter sdi = new SqlDataAdapter();
        SqlDataAdapter sdu = new SqlDataAdapter();
        SqlDataAdapter sdo = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataSet toko = new DataSet();
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
                Toko();
                Bluray();
            }
        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from Penyimpanan";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            ViewPenyimpanan.DataSource = ds;
            ViewPenyimpanan.DataBind();
            con.Close();
        }

        public void Toko()
        {
            toko = new DataSet();
            cmd.CommandText = "Select * from Toko";
            cmd.Connection = con;
            sdi = new SqlDataAdapter(cmd);
            sdi.Fill(toko);
            ViewToko.DataSource = toko;
            ViewToko.DataBind();
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
            cmd.CommandText = "Select * from Penyimpanan where Nama like '%" + searchText.Text.ToString() + "%' " +
            "or Alamat like '%" + searchText.Text.ToString() + "%' " +
            "or Judul like '%" + searchText.Text.ToString() + "%' " +
            "or Tahun_Terbit like '%" + searchText.Text.ToString() + "%' " +
            " or Telepon like '%" + searchText.Text.ToString() + "%';";
            cmd.Connection = con;
            sdu = new SqlDataAdapter(cmd);
            sdu.Fill(search);
            SearchView.DataSource = search;
            SearchView.DataBind();
            con.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtNama.Text.ToString() == "" || txtIdToko.Text == "" || txtAlamat.Text.ToString() == "" || txtTelepon.Text.ToString() == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage2", "alert('WARNING: Data yang Ditambahkan Invalid')", true);
            }
            else
            {
                dt = new DataTable();
                cmd.CommandText = "Insert Into Toko(Id_Toko, Nama, Alamat, Telepon)values('" + txtIdToko.Text + "', '" + txtNama.Text.ToString() + "','" + txtAlamat.Text.ToString() + "','" + txtTelepon.Text.ToString() + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage1", "alert('Data Berhasil Ditambahkan')", true);
            }
            DataShow();
            Toko();
            Bluray();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Toko set Nama='" +
            txtNama.Text.ToString() + "', Alamat = '" + txtAlamat.Text.ToString() + "', Telepon= '" + txtTelepon.Text.ToString() + "' WHERE Id_Toko = '" + txtIdToko.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            DataShow();
            Toko();
            Bluray();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from Toko where Id_Toko = '" + txtIdToko.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
            Toko();
            Bluray();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtIdToko.Text = null;
            txtNama.Text = null;
            txtAlamat.Text = null;
            txtTelepon.Text = null;
        }

        protected void btnPenyewa_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:56311/LIstPenyewAdmin.aspx");
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
    }
}