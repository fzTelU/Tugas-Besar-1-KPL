using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class InputTransaksi : Form
    {
        // Init var.
        DataTable dtTransaksi = new DataTable(), dtJasa;
        DateTime tglSekarang = DateTime.Now;
        public string pathDir = Environment.CurrentDirectory;
        public string pathTransaksi = @"../../../json/InputTransaksi.json";
        public string pathJasa = @"../../../json/InputJasa.json";
        public string pathMoney = @"../../../json/MoneyConfig.json";
        Automata.State posisi = Automata.State.INPUT_TRANSAKSI, nextPosisi;

        public InputTransaksi()
        {
            InitializeComponent();
            tbTanggal.Text = tglSekarang.ToString();
            setComboboxNamaJasa();

            // Membaca file InputTransaksi.json.
            try
            {
                dtTransaksi = Config.ReadFromJson<DataTable>(pathDir + pathTransaksi);
            }
            // Membuat file InputTransaksi.json jika file tersebut belum tersedia.
            catch
            {
                // Set dummy data.
                DummyData();

                Config.SaveToJson<DataTable>(dtTransaksi, pathDir + pathTransaksi);
            }

            // Tampilkan data dari InputTransaksi.json
        }

        // Membuat Data palsu untuk JSON.
        private void DummyData()
        {
            dtTransaksi.Columns.Add("Tanggal");
            dtTransaksi.Columns.Add("ID Transaksi");
            dtTransaksi.Columns.Add("Nama Jasa");
            dtTransaksi.Columns.Add("Deskripsi");
            dtTransaksi.Columns.Add("Berat (Kg)");
            dtTransaksi.Columns.Add("Ongkir");
            dtTransaksi.Columns.Add("Total Bayar");
            dtTransaksi.Rows.Add(DateTime.Now, "1", "Jasa Laundry Sukapura", "Baju", "2", "2000", "12000");
        }

        // Method yang dijalankan ketika InputTransaksi.cs dalam posisi show.
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Untuk mencari harga jasa.
        private int cariHargaJasa()
        {
            // Membaca file InputJasa.json dan me-return harga.
            dtJasa = Config.ReadFromJson<DataTable>(pathDir + pathJasa);
            int harga = Int32.Parse(dtJasa.Rows[cbNamaJasa.SelectedIndex][2].ToString());
            return harga;
        }

        private int hitungOngkir(int berat)
        {
            int ongkir = berat * 1000;
            return ongkir;
        }

        // Untuk menghitung total bayar.
        private int hitungTotal(int berat, int harga, int ongkir)
        {
            int total = berat * harga + ongkir;
            return total;
        }

        // Set data combobox nama jasa.
        private void setComboboxNamaJasa()
        {
            // Membaca file InputJasa.json.
            try
            {
                dtJasa = Config.ReadFromJson<DataTable>(pathDir + pathJasa);
            }
            // Membuat file InputJasa.json jika file tersebut belum tersedia.
            catch
            {
                // Membuat tabel data
                dtJasa = new DataTable();
                dtJasa.Columns.Add("Nama Toko");
                dtJasa.Columns.Add("Nama Jasa");
                dtJasa.Columns.Add("Harga");
                dtJasa.Columns.Add("Jumlah Paket");
                dtJasa.Columns.Add("Deskripsi Jasa");
                Config.SaveToJson<DataTable>(dtJasa, pathDir + pathJasa);
            }

            // Set data combobox nama jasa.
            cbNamaJasa.DataSource = dtJasa;
            cbNamaJasa.DisplayMember = "Nama Jasa";
        }


        // Ketika btnSimpan di klik, akan menyimpan data yang diinput kedalam dgvTransaksi.
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Membuat List.
            List<InputTransaksiModel> transaksi = new List<InputTransaksiModel>();

            // Set dan ambil nilai dari input user.
            int idTransaksi = Int32.Parse(tbIDTransaksi.Text);
            String namaJasa = cbNamaJasa.Text;
            String deskripsi = tbDeskripsi.Text;
            int berat = Int32.Parse(tbBerat.Text);
            int totalOngkir = hitungOngkir(berat);
            int totalBayar = hitungTotal(berat, cariHargaJasa(), totalOngkir);

            // Memasukan data kedalam list.
            transaksi.Add(new InputTransaksiModel(tglSekarang, idTransaksi, namaJasa, deskripsi,
                berat, totalOngkir, totalBayar));

            // Mengisi tabel data dengan data dari list.
            for (int i = 0; i < transaksi.Count; i++)
            {
                dtTransaksi.Rows.Add(
                    transaksi[i].getTanggal().ToString(),
                    transaksi[i].getIdTransaksi().ToString(),
                    transaksi[i].getNamaJasa().ToString(),
                    transaksi[i].getDeskripsiCucian().ToString(),
                    transaksi[i].getBeratCucian().ToString(),
                    transaksi[i].getOngkir().ToString(),
                    transaksi[i].getTotalBayar().ToString()
                    );
            }
            // Simpan dan update data ke file InputTransaksi.json.
            Config.SaveToJson<DataTable>(dtTransaksi, pathDir + pathTransaksi);

            nextPosisi = Automata.State.DATA_TRANSAKSI;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        // Ketika btnBatal di klik, maka mengosongkan semua textBox, menonaktifkan sebagian tombol,
        // lalu menutup UI InputTransaksi dan menampikan UI dashboard.
        private void btnBatal_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.DATA_TRANSAKSI;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

    }
}
