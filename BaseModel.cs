using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestLogin_Romanov
{
    public partial class BaseModel : DbContext
    {
        private static BaseModel _context;
        public static BaseModel GetContext()
        {
            if (_context == null)
                _context = new BaseModel();
            return _context;
        }
        public BaseModel()
            : base("name=BaseModel")
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
