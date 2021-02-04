using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Models;

namespace Test.Models
{
    /**
     * 
     * DatabaseContext is the connection to the MySQL database
     * for each table in the MySQL database, there must be a separate DbSet declared as below with a class corresponding to the Table in the MySQL database (eg, each column is a separate variable that matches the name of each
     * variable exactly, including capitalisation
     */
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<questionanswerexample> TestTables { get; set; }

        public DbSet<jsonstore> JsonHandler { get; set; }

        public DbSet<questionnaires> QuestionnairesHandler { get; set; }

        public DbSet<logininfo> Login { get; set; }



    }

}
