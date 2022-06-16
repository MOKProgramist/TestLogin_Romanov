namespace TestLogin_Romanov
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public Users() { }
        public Users(string log, string pass)
        {
            login = log;
            password = pass;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string login { get; set; }

        [StringLength(20)]
        public string password { get; set; }
    }
}