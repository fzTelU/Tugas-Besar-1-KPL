using System.Windows.Forms;

namespace Tubes_KPL
{
    //Adamnn.
    class Automata
    {
        // Attribut pada state.
        public enum State { LOGIN, REGISTRASI, DASHBOARD, INPUT_PENGGUNA, DATA_JASA, INPUT_JASA, DATA_TRANSAKSI, INPUT_TRANSAKSI, LOGOUT }; 
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
                else if (nextPos == State.REGISTRASI)
                {
                    Registrasi registrasi = new Registrasi();
                    registrasi.Show();
                }
            }
            else if (posisi == State.REGISTRASI)
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
                // Kemudian jika tidak masuk posisi dashboard masuk ke tampilan input jasa.
                else if (nextPos == State.DATA_JASA) 
                {
                    DataJasa dataJasa = new DataJasa();
                    dataJasa.Show();
                }
                // Kemudian jika tidak masuk posisi dashboard masuk ke tampilan input transaksi.
                else if (nextPos == State.DATA_TRANSAKSI)
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
                if (nextPos == State.REGISTRASI)
                {
                    Registrasi registrasi = new Registrasi();
                    registrasi.Show();
                } else if (nextPos == State.DASHBOARD)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
            else if (posisi == State.DATA_JASA)
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
            else if (posisi == State.DATA_TRANSAKSI)
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
        }

    }
}
