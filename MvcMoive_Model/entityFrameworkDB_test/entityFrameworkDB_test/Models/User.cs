using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace entityFrameworkDB_test.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string username { get; set; }
        public int level { get; set; }
    }

    public class UserContest : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
