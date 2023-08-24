using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace justin_mahaffay.Models
{
    public class Author
    {
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public DateTime JoiningDate { get; set; }
        //public int Age { get; set;  }
        public int ID { get; set; }
        public string author { get; set; }
        public DateTime time { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
    }

    public class AuthorDBContext : DbContext
    {
        public AuthorDBContext()
        {

        }
        public DbSet<Author> Authors { get; set; }
    }
}
