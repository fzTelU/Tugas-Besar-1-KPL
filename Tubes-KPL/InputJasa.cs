using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class InputJasa : Form
    {
        // Inisialisasi variabel dan memberikan value pada variabel tertentu.
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"../../../json/InputJasa.json";
        DataTable dtJasa = new DataTable();
        Automata.State posisi = Automata.State.INPUT_JASA, nextPosisi;

        public InputJasa()
        {
            InitializeComponent();

            // Memanggil data dari json (Deserialisasi) untuk ditampilkan pada tabel data grid view.
            try
            {
                dtJasa = Config.ReadFromJson<DataTable>(path + pathJSON);
            }
            catch
            {
                DummyData();
                Config.SaveToJson<DataTable>(dtJasa, path + pathJSON);
            }
        }

        // Menggunakan dummy data untuk menampilkan data jika tidak ada file export (Serialisasi).
        private void DummyData()
        {
            dtJasa.Columns.Add("Nama Toko");
            dtJasa.Columns.Add("Nama Jasa");
            dtJasa.Columns.Add("Harga");
            dtJasa.Columns.Add("Jumlah Paket");
            dtJasa.Columns.Add("Deskripsi Jasa");

            dtJasa.Rows.Add("Laundry Sukapura", "Jasa Laundry", "5500", "1", "Laundry 1 hari jadi ygy");
        }

        // Action pada button batal untuk membatalkan inputan jasa dan kembali ke dashboard.
        private void btnBatal_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.DATA_JASA;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void InputJasa_Load(object sender, EventArgs e)
        {

        }

        // Memberikan action menyimpan data yang telah terisi pada form untuk diserialisasi (Export).
        // Kedalam bentuk json dan menampilkan data dari form ke table data grid view.
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            List<InputJasaModel> jasa = new List<InputJasaModel>();

            // Menyimpan isi dari textbox ke dalam variabel baru
            String namaToko = tbNamaToko.Text;
            String namaJasa = tbNamaJasa.Text;
            int harga = Int32.Parse(tbHarga.Text);
            int jumlahPaket = Int32.Parse(tbJlhPaket.Text);
            String deskripsi = tbDeskripsi.Text;
            if (jumlahPaket < 2 || harga < 5000)
            {
                tbHarga.Text = String.Empty;
                tbJlhPaket.Text = String.Empty;
                tbHarga.Focus();
            }
            else
            {
                // Masukan data kedalam list.
                jasa.Add(new InputJasaModel("Rupiah", namaToko, namaJasa, harga, jumlahPaket, deskripsi));

                for (int i = 0; i < jasa.Count; i++)
                {

                    dtJasa.Rows.Add(
                        jasa[i].getNamaToko().ToString(),
                        jasa[i].getNamaJasa().ToString(),
                        jasa[i].getHargaPerPaket().ToString(),
                        jasa[i].getJumlahPaket().ToString(),
                        jasa[i].getDeskripsi().ToString()
                        );
                }
                Config.SaveToJson<DataTable>(dtJasa, path + pathJSON);
            }
            nextPosisi = Automata.State.DATA_JASA;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }    

    }
}
