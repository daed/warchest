namespace DatabaseFrontEnd
{
    public class Database
    {
        private string connString { get; set; }

        public Database(string _connString)
        {
            connString = _connString;
        }
    }
}
