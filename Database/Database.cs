using Database.Repositories;
namespace DatabaseFrontEnd
{
    public class Database
    {
        private string connString { get; set; }

        public Users Users { get; set; }

        public Database(string _connString)
        {
            connString = _connString;
            Users = new Users(connString);
        }
    }
}
