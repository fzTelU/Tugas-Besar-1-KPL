using System;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public class Automata
    {
        // Attribut pada state.
        public enum State { LOGIN, REGISTRASI, DASHBOARD, INPUT_PENGGUNA, DATA_JASA, INPUT_JASA, DATA_TRANSAKSI, INPUT_TRANSAKSI, LOGOUT, TEST }; // Faza (Menambahkan state REGISTRASI, DATA_JASA, DATA_TRANSAKSI, TEST)
        public static State posisi, nextPosisi; 

        public Automata() { }


        // Mensetter keadaan posisi pada automata.
        public static void setPosisi(State pos, State nextPos) 
        {
            posisi = pos;
            nextPosisi = nextPos;
        }

        // Mengambil data posisi.
        public static State getPosisi() 
        {
            return posisi;
        }

        public static void posisiTransition(State nextPos)
        {
            // Jika keadaan pada posisi masuk pada login.
            if (posisi == State.LOGIN) 
            {
                if (nextPos == State.DASHBOARD)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else if (nextPos == State.REGISTRASI) // Faza
                {
                    Registrasi registrasi = new Registrasi();
                    registrasi.Show();
                }
                else if (nextPos == State.TEST) // Faza
                {
                    // Automata untuk testing
                    Console.WriteLine("Transisi Berhasil");
                }
            }
            else if (posisi == State.REGISTRASI) // Faza
            {
                if (nextPos == State.LOGIN)
                {
                    Login login = new Login();
                    login.Show();
                } else if (nextPos == State.INPUT_PENGGUNA)
                {
                    Pengguna pengguna = new Pengguna();
                    pengguna.Show();
                }
            }
            // Kemudian jika tidak masuk posisi dashboard masuk ke tampilan input transaksi.
            else if (posisi == State.DASHBOARD) 
            {
                if (nextPos == State.INPUT_PENGGUNA)
                {
                    Pengguna pengguna = new Pengguna();
                    pengguna.Show();
                }
                // Kemudian jika tidak masuk posisi dashboard masuk ke tampilan data jasa.
                else if (nextPos == State.DATA_JASA) // Faza
                {
                    DataJasa dataJasa = new DataJasa();
                    dataJasa.Show();
                }
                // Kemudian jika tidak masuk posisi dashboard masuk ke tampilan data transaksi.
                else if (nextPos == State.DATA_TRANSAKSI) // Faza
                {
                    DataTransaksi dataTransaksi = new DataTransaksi();
                    dataTransaksi.Show();
                }
                // Maka jika tidak posisi dashboard masuk ke tampilan logout.
                else if (nextPos == State.LOGOUT) 
                {
                    DialogResult dialogResult = MessageBox.Show("Keluar?", "Logout", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Login login = new Login();
                        login.Show();
                    }
                }
            }
            else if (posisi == State.INPUT_PENGGUNA)
            {
                if (nextPos == State.REGISTRASI) // Faza
                {
                    Registrasi registrasi = new Registrasi();
                    registrasi.Show();
                } else if (nextPos == State.DASHBOARD)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
            else if (posisi == State.DATA_JASA) // Faza
            {
                if (nextPos == State.INPUT_JASA)
                {
                    InputJasa inputJasa = new InputJasa();
                    inputJasa.Show();
                } else if (nextPos == State.DASHBOARD)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
            else if (posisi == State.DATA_TRANSAKSI) // Faza
            {
                if (nextPos == State.INPUT_TRANSAKSI)
                {
                    InputTransaksi inputTransaksi = new InputTransaksi();
                    inputTransaksi.Show();
                }
                else if (nextPos == State.DASHBOARD)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
            else if (State.INPUT_JASA == posisi)
            {
                if (nextPos == State.DATA_JASA)
                {
                    DataJasa dataJasa = new DataJasa();
                    dataJasa.Show();
                }
            }
            else if ( State.INPUT_TRANSAKSI == posisi) 
            {
                if (nextPos == State.DATA_TRANSAKSI)
                {
                    DataTransaksi dataTransaksi = new DataTransaksi();
                    dataTransaksi.Show();
                }
            }
            else if (State.TEST == posisi) // Faza
            {
                // Automata khusus untuk Unit Testing.
                // Jika testing automata berhasil dilakukan, maka hal ini juga berlaku untuk seluruh State yang ada pada Automata.
                if (nextPos == State.LOGIN)
                {
                    Console.WriteLine("Transisi Berhasil");
                }
            }
        }

    }
}
