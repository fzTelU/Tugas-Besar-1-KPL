using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class Registrasi : Form
    {
        //Inisialisasi Variabel

        PenggunaModel penggunaModel = new PenggunaModel();
        DataTable dataTable = new DataTable();
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"../../../json/Pengguna.json";
        Automata.State posisi = Automata.State.REGISTRASI, nextPosisi;
        private static string posisiSebelum;

        public static void setPosisiSebelum(string posisiSblm)
        {
            posisiSebelum = posisiSblm;
        }

        public Registrasi()
        {
            InitializeComponent();
            CreateDataTable();
        }

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

        // Mengosongkan semua textbox.
        private void ClearTextBox()
        {
            tbUsername.Text = null;
            tbNoHP.Text = null;
            tbAlamat.Text = null;
            tbEmail.Text = null;
            tbPassword.Text = null;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (posisiSebelum == "login")
            {
                nextPosisi = Automata.State.LOGIN;
                Automata.setPosisi(posisi, nextPosisi);
                Automata.posisiTransition(nextPosisi);
                this.Hide();
            }
            else if (posisiSebelum == "pengguna")
            {
                nextPosisi = Automata.State.INPUT_PENGGUNA;
                Automata.setPosisi(posisi, nextPosisi);
                Automata.posisiTransition(nextPosisi);
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button Register
            List<PenggunaModel> listPenggunaModel = new List<PenggunaModel>();
            String username = tbUsername.Text;
            String noHP = tbNoHP.Text;
            String alamat = tbAlamat.Text;
            String email = tbEmail.Text;
            String kataSandi = tbPassword.Text;

            Debug.Assert(noHP.Length == 12 || noHP.Length == 13, "Nomor telp minimal 12 digit dan maksimal 13 digit.");
            Debug.Assert(email.Contains("@") && email.Contains("."), "Email harus mengandung karakter @ dan .");
            if (((noHP.Length == 12 || noHP.Length == 13) && (email.Contains("@") && email.Contains("."))) == false) ClearTextBox();
            else
            {
                this.Hide();
                if (posisiSebelum == "login")
                {
                    nextPosisi = Automata.State.LOGIN;
                    Automata.setPosisi(posisi, nextPosisi);
                    Automata.posisiTransition(nextPosisi);
                    this.Hide();
                } else if (posisiSebelum == "pengguna")
                {
                    nextPosisi = Automata.State.INPUT_PENGGUNA;
                    Automata.setPosisi(posisi, nextPosisi);
                    Automata.posisiTransition(nextPosisi);
                    this.Hide();
                }

                penggunaModel = new PenggunaModel(username, noHP, alamat, email, kataSandi);
                listPenggunaModel.Add(penggunaModel);

                for (int i = 0; i < listPenggunaModel.Count; i++)
                {
                    dataTable.Rows.Add(
                        listPenggunaModel[i].getUsername().ToString(),
                        listPenggunaModel[i].getNoHP().ToString(),
                        listPenggunaModel[i].getAlamatPengguna().ToString(),
                        listPenggunaModel[i].getEmail().ToString(),
                        listPenggunaModel[i].getKataSandi().ToString()
                        );
                }

                Config.SaveToJson<DataTable>(dataTable, path + pathJSON);
            }
        }
    }
}
