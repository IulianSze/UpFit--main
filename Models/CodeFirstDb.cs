using UpFit__main.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UpFit__main.Migrations;

namespace UpFit__main.Models
{
    public class CodeFirstDb : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Coach> coaches { get; set; }
        public DbSet<AlimentsModel> aliments { get; set; }

        public DbSet<UploadClass> videos { get; set; }

        public DbSet<Meal> meals { get; set; }
    }
}