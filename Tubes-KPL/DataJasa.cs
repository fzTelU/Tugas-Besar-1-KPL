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
    public partial class DataJasa : Form
    {
        DataTable dtJasa = new DataTable();
        Automata.State posisi = Automata.State.DATA_JASA, nextPosisi;
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"../../../json/InputJasa.json";
        private string pathMoney = @"../../../json/MoneyConfig.json";
        private moneyConfig money;

        public DataJasa()
        {
            InitializeComponent();

            // Memanggil data dari json (Deserialisasi) untuk ditampilkan pada tabrl data grid view.
            try
            {
                dtJasa = Config.ReadFromJson<DataTable>(path + pathJSON);
            }
            catch
            {
                DummyData();
                Config.SaveToJson<DataTable>(dtJasa, path + pathJSON);
            }

            dgvJasa.DataSource = dtJasa;
            convertMataUang();

            money = Config.ReadFromJson<moneyConfig>(path + pathMoney);
            if (money.getMoneyConfig() == "Rupiah")
            {
                lbMataUang.Text = "Mata Uang : Rupiah";
            }
            else
            {
                lbMataUang.Text = "Mata Uang : USD";
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

            dtJasa.Rows.Add("Laundry Sukapura", "Jasa Laundry Sukapura", "5500", "1", "Laundry 1 hari jadi ygy");
        }

        // Mengonversi nilai atau value dari data number menjadi USD yang secara default adalah rupiah.
        public void convertMataUang()
        {
            money = Config.ReadFromJson<moneyConfig>(path + pathMoney);
            if (money.getMoneyConfig() == "USD")
            {
                for (int i = 0; i < dgvJasa.RowCount - 1; i++)
                {
                    dgvJasa.Rows[i].Cells[2].Value = (Double.Parse(dgvJasa.Rows[0 + i].Cells[2].Value.ToString()) / 14000).ToString().Substring(0, 4);
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.INPUT_JASA;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.DASHBOARD;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }
    }
}
