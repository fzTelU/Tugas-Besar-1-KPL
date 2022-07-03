using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Tubes_KPL
{
    public partial class Pengguna : Form
    {
        // Init var.
        PenggunaModel penggunaModel = new PenggunaModel();
        DataTable dataTable = new DataTable();
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"../../../json/Pengguna.json";
        Automata.State posisi = Automata.State.INPUT_PENGGUNA, nextPosisi;

        // Constructor pengguna.
        public Pengguna()
        {
            InitializeComponent();
            CreateDataTable();
        }

        // Membaca data yang ada pada file JSON jika terdapat file JSON,
        // Jika tidak, maka buat file JSON dari method DummyData(),
        // Lalu tampilkan di dgvPengguna.
        private void CreateDataTable()
        {
            try
            {
                dataTable = Config.ReadFromJson<DataTable>(path + pathJSON);
            }
            catch
            {
                DummyData();
                Config.SaveToJson<DataTable>(dataTable, path + pathJSON);
            }

            dgvPengguna.DataSource = dataTable;
        }

        private void DummyData()
        {
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("No Telp");
            dataTable.Columns.Add("Alamat");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Password");

            dataTable.Rows.Add("rizky", "081321852944", "Bandung", "muhammad.rizky.khomeini@gmail.com", "rizky123");
            dataTable.Rows.Add("ricky", "082129211422", "Sumedang", "rickyrohaendi1@gmail.com", "ricky123");
            dataTable.Rows.Add("rafi", "089617841036", "Padang", "rafiridel@gmail.com", "rafi123");
            dataTable.Rows.Add("baso", "085241606196", "Makassar", "basoarif@gmail.com", "baso123");
            dataTable.Rows.Add("faza", "081234664826", "Solo", "fazaalexander@gmail.com", "faza123");
        }

        // Method yang dijalankan ketika Pengguna.cs dalam posisi show.
        private void Pengguna_Load(object sender, System.EventArgs e)
        {

        }

        // Ketika btnNew di klik, maka akan mengaktifkan sebagian tombol, kecuali btnNew.
        private void btnNew_Click(object sender, System.EventArgs e)
        {
            nextPosisi = Automata.State.REGISTRASI;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            Registrasi.setPosisiSebelum("pengguna");
            this.Hide();
        }

        // Ketika btnCancel di klik, maka mengosongkan semua textBox, 
        // menonaktifkan sebagian tombol, lalu menutup UI pengguna.
        // dan menampikan UI dashboard.
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            nextPosisi = Automata.State.DASHBOARD;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
        }

        // Menyembunyikan UI pengguna dan menampilkan UI dashboard..
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}


namespace Parsing
{
    private string str ="*g(ikh)(abcde3049000halo apa kabar? okeh5986edcbaio test*0iou";
    private int source = 2;
    private int destination = 2;
    private int trailer = 4;
    private int data = 15;
    private int crc = 4;
    private int hlen = 5;

    public Mainforce()
    {
        InitializeComponent();
        textBox1.Text = str;
    }

    void Parse()
    {
        string sou = str.Substring(13, source);
        string des = str.Substring(15, destination);
        string tra = str.Substring(37, trailer);
        string dat = str.Substring(22, data);
        string cr1 = str.Substring(41, crc);
        string hle = str.Substring(17, hlen);

        textBox2.Text = sou;
        textBox3.Text = des;
        textBox4.Text = tra;
        textBox5.Text = dat;
        textBox6.Text = cr1;
        textBox7.Text = hle;
    }
}