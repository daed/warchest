using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Objects
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Passphrase { get; set; }
    }
}
