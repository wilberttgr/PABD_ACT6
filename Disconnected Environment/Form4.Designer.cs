namespace Disconnected_Environment
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.NamaMahasiswa = new System.Windows.Forms.Label();
            this.NIM = new System.Windows.Forms.Label();
            this.StatusMahasiswa = new System.Windows.Forms.Label();
            this.TahunMasuk = new System.Windows.Forms.Label();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.disconnectedEnvironmentDataSet = new Disconnected_Environment.DisconnectedEnvironmentDataSet();
            this.statusmahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status_mahasiswaTableAdapter = new Disconnected_Environment.DisconnectedEnvironmentDataSetTableAdapters.status_mahasiswaTableAdapter();
            this.txtNIM = new System.Windows.Forms.Label();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new Disconnected_Environment.DisconnectedEnvironmentDataSetTableAdapters.mahasiswaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectedEnvironmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(598, 31);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 35);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(506, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(506, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(506, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NamaMahasiswa
            // 
            this.NamaMahasiswa.AutoSize = true;
            this.NamaMahasiswa.Location = new System.Drawing.Point(164, 283);
            this.NamaMahasiswa.Name = "NamaMahasiswa";
            this.NamaMahasiswa.Size = new System.Drawing.Size(115, 16);
            this.NamaMahasiswa.TabIndex = 5;
            this.NamaMahasiswa.Text = "Nama Mahasiswa";
            this.NamaMahasiswa.Click += new System.EventHandler(this.label1_Click);
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(164, 321);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(154, 16);
            this.NIM.TabIndex = 6;
            this.NIM.Text = "Nomor Induk Mahasiswa";
            this.NIM.Click += new System.EventHandler(this.NIM_Click);
            // 
            // StatusMahasiswa
            // 
            this.StatusMahasiswa.AutoSize = true;
            this.StatusMahasiswa.Location = new System.Drawing.Point(164, 357);
            this.StatusMahasiswa.Name = "StatusMahasiswa";
            this.StatusMahasiswa.Size = new System.Drawing.Size(115, 16);
            this.StatusMahasiswa.TabIndex = 7;
            this.StatusMahasiswa.Text = "Status Mahasiswa";
            this.StatusMahasiswa.Click += new System.EventHandler(this.StatusMahasiswa_Click);
            // 
            // TahunMasuk
            // 
            this.TahunMasuk.AutoSize = true;
            this.TahunMasuk.Location = new System.Drawing.Point(164, 393);
            this.TahunMasuk.Name = "TahunMasuk";
            this.TahunMasuk.Size = new System.Drawing.Size(88, 16);
            this.TahunMasuk.TabIndex = 8;
            this.TahunMasuk.Text = "Tahun Masuk";
            this.TahunMasuk.Click += new System.EventHandler(this.TahunMasuk_Click);
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(345, 280);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(121, 24);
            this.cbxNama.TabIndex = 9;
            this.cbxNama.SelectedIndexChanged += new System.EventHandler(this.cbxNama_SelectedIndexChanged);
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Items.AddRange(new object[] {
            "Aktif",
            "Tidak aktif"});
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(345, 354);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(121, 24);
            this.cbxStatusMahasiswa.TabIndex = 10;
            this.cbxStatusMahasiswa.SelectedIndexChanged += new System.EventHandler(this.cbxStatusMahasiswa_SelectedIndexChanged);
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(345, 390);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(121, 24);
            this.cbxTahunMasuk.TabIndex = 11;
            this.cbxTahunMasuk.SelectedIndexChanged += new System.EventHandler(this.cbxTahunMasuk_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 13;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // disconnectedEnvironmentDataSet
            // 
            this.disconnectedEnvironmentDataSet.DataSetName = "DisconnectedEnvironmentDataSet";
            this.disconnectedEnvironmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusmahasiswaBindingSource
            // 
            this.statusmahasiswaBindingSource.DataMember = "status_mahasiswa";
            this.statusmahasiswaBindingSource.DataSource = this.disconnectedEnvironmentDataSet;
            // 
            // status_mahasiswaTableAdapter
            // 
            this.status_mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.Location = new System.Drawing.Point(342, 321);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(43, 16);
            this.txtNIM.TabIndex = 14;
            this.txtNIM.Text = "txtNIM";
            this.txtNIM.Click += new System.EventHandler(this.txtNIM_Click);
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.disconnectedEnvironmentDataSet;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(447, 224);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.TahunMasuk);
            this.Controls.Add(this.StatusMahasiswa);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.NamaMahasiswa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "Data Status Mahasiswa";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disconnectedEnvironmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label NamaMahasiswa;
        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label StatusMahasiswa;
        private System.Windows.Forms.Label TahunMasuk;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.Button button5;
        private DisconnectedEnvironmentDataSet disconnectedEnvironmentDataSet;
        private System.Windows.Forms.BindingSource statusmahasiswaBindingSource;
        private DisconnectedEnvironmentDataSetTableAdapters.status_mahasiswaTableAdapter status_mahasiswaTableAdapter;
        private System.Windows.Forms.Label txtNIM;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private DisconnectedEnvironmentDataSetTableAdapters.mahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}