using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class DataTransaksi : Form
    {
        Automata.State posisi = Automata.State.DATA_TRANSAKSI, nextPosisi;
        DataTable dtTransaksi = new DataTable(), dtJasa;
        public string pathDir = Environment.CurrentDirectory;
        public string pathTransaksi = @"../../../json/InputTransaksi.json";
        public string pathJasa = @"../../../json/InputJasa.json";
        public string pathMoney = @"../../../json/MoneyConfig.json";
        private moneyConfig money;

        public DataTransaksi()
        {
            InitializeComponent();

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
            dgvTransaksi.DataSource = dtTransaksi;

            // Membaca file MoneyConfig.json dan menyimpan ke var money.
            money = Config.ReadFromJson<moneyConfig>(pathDir + pathMoney);

            // Set tampilan text pada LbMoney.
            if (money.getMoneyConfig() == "Rupiah")
            {
                lbMataUang.Text = "Mata Uang : Rupiah";
            }
            else
            {
                lbMataUang.Text = "Mata Uang : USD";
            }
            convertMataUang();
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

        private void btAddNew_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.INPUT_TRANSAKSI;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void DataTransaksi_Load(object sender, EventArgs e)
        {
           
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.DASHBOARD;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        // Untuk mengubah mata uang dari Rupiah ke USD dan sebaliknya.
        public void convertMataUang()
        {
            // Membaca file MoneyConfig.json.
            money = Config.ReadFromJson<moneyConfig>(pathDir + pathMoney);

            // Merubah data ongkir dan total dari Rupiah ke USD atau sebaliknya.
            if (money.getMoneyConfig() == "USD")
            {
                for (int i = 0; i < dgvTransaksi.RowCount - 1; i++)
                {
                    dgvTransaksi.Rows[i].Cells[5].Value = (Double.Parse(dgvTransaksi.Rows[0 + i].Cells[5].Value.ToString()) / 14000).ToString().Substring(0, 4);
                    dgvTransaksi.Rows[i].Cells[6].Value = (Double.Parse(dgvTransaksi.Rows[0 + i].Cells[6].Value.ToString()) / 14000).ToString().Substring(0, 4);
                }
            }
        }
    }
}
