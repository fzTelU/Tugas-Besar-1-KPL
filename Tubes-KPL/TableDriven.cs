namespace Tubes_KPL
{
    class TableDriven
    {
        public enum Username { root, admin, user, ricky, baso, rizky, faza, rafi };
        public static string[] password = { "root123", "admin123", "user123", "ricky123", "baso123", "rizky123", "faza123", "rafi123" };

        public static Username getUsername(string user)
        {
            Username username = (Username)System.Enum.Parse(typeof(Username), user);
            return username;
        }

        public static string getPassword(string user)
        {
            Username username = (Username)System.Enum.Parse(typeof(Username), user);
            return password[(int)username];
        }
    }
}
