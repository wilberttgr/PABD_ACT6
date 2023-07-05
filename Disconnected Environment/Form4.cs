﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Form4 : Form
    {
        private string stringConnection = "data source=LAPTOP-QCHTG94R\\W_TGR;Initial Catalog=DisconnectedEnvironment;Persist Security Info=True;User ID=sa;Password=123";
        private SqlConnection koneksi;


        private void refreshform()
        {
            cbxNama.Enabled = false;
            cbxStatusMahasiswa.Enabled = false;
            cbxTahunMasuk.Enabled = false;
            cbxNama.SelectedIndex = -1;
            cbxStatusMahasiswa.SelectedIndex = -1;
            cbxTahunMasuk.SelectedIndex = -1;
            txtNIM.Visible = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }

        public Form4()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();

        }
        

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.status_mahasiswa";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }


        private void cbNama()
        {
            koneksi.Open();
            string str = "SELECT nama_mahasiswa FROM Mahasiswa";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxNama.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();
        }



        private void cbTahunMasuk()
        {
            int y = DateTime.Now.Year - 2010;
            string[] type = new string[y];
            int i = 0;
            for (i = 0; i - 1 < type.Length; i++)
            {
                if (i == 0)
                {
                    cbxTahunMasuk.Items.Add("2010");
                }
                else
                {
                    int l = 2010 + i;
                    cbxTahunMasuk.Items.Add(l.ToString());
                }
            }
        }


        private void cbxNama_Click(object sender, EventArgs e)
        {
            string selectedName = cbxNama.SelectedItem.ToString();


            koneksi.Open();
            string str = "SELECT nim FROM mahasiswa WHERE nama_mahasiswa = @nama_mahasiswa";
            SqlCommand cm = new SqlCommand(str, koneksi);
            cm.Parameters.AddWithValue("@nama_mahasiswa", selectedName);
            SqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                string nim = dr.GetString(0);
                txtNIM.Text = nim;
            }
            else
            {
                txtNIM.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
          

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxTahunMasuk.Enabled = true;
            cbxNama.Enabled = true;
            cbxStatusMahasiswa.Enabled = true;
            txtNIM.Visible = true;
            cbTahunMasuk();
            cbNama();
            btnClear.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string nim = txtNIM.Text;
            string statusMahasiswa = cbxStatusMahasiswa.Text;
            string tahunMasuk = cbxTahunMasuk.Text;
            int count = 0;
            string tempKodeStatus = "";
            string kodeStatus = "";
            koneksi.Open();

            string str = "select count (*) from dbo.status_mahasiswa";
            SqlCommand cm = new SqlCommand(str, koneksi);
            count = (int)cm.ExecuteScalar();
            if (count == 0)
            {
                kodeStatus = "1";
            }
            else
            {
                string querryString = "SELECT TOP 1 id_status FROM dbo.status_mahasiswa ORDER BY id_status DESC";
                cm = new SqlCommand(querryString, koneksi);
                SqlCommand cmStatusMahasiswa = new SqlCommand(querryString, koneksi);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    tempKodeStatus = dr.GetString(0);
                }
                dr.Close();
                int tempKode = int.Parse(tempKodeStatus);
                tempKode++;
                kodeStatus = tempKode.ToString();
            }
            string queryString = "INSERT INTO dbo.status_mahasiswa (id_status, nim, status_mahasiswa, tahun_masuk) VALUES (@id_status, @nim, @status_mahasiswa, @tahun_masuk)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id_status", kodeStatus));
            cmd.Parameters.Add(new SqlParameter("NIM", nim));
            cmd.Parameters.Add(new SqlParameter("status_mahasiswa", statusMahasiswa));
            cmd.Parameters.Add(new SqlParameter("tahun_masuk", tahunMasuk));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil disimpan", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
            dataGridView();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxNama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxStatusMahasiswa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTahunMasuk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNIM_Click(object sender, EventArgs e)
        {

        }

        private void NIM_Click(object sender, EventArgs e)
        {

        }

        private void StatusMahasiswa_Click(object sender, EventArgs e)
        {

        }

        private void TahunMasuk_Click(object sender, EventArgs e)
        {

        }
    }
}
