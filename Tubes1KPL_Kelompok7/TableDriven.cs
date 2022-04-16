namespace Tubes1KPL_Kelompok7
{
    class TableDriven
    {
        public enum Username { root, admin, user, ricky, baso, rizky, faza, rafi };
        public static string[] password = { "root123", "admin123", "user123", "ricky123", "baso123", "rizky123", "faza123", "rafi123" };

        public static string getKodeUser(Username username)
        {
            return password[(int)username];
        }
    }
}
