using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Age { get; set; }
    }
}
