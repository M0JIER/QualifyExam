using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace QualifExam
{
    public class DBFuncs: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = base.db");
        }

        public DBFuncs()
        {
            Database.EnsureCreated();
        }

        public DbSet<Movie> Movies { get; set; }

        public void Edit(int? Id, Movie newmov)
        {
            if (Id == null) { MessageBox.Show("Выберите фильм"); return; }

            var old = Movies.Find(Id);
            old.Name = newmov.Name;
            old.Year = newmov.Year;
            old.Author = newmov.Author;
            SaveChanges();
        }

        public void Delete(int? Id)
        {
            if (Id==null) { MessageBox.Show("Выберите фильм"); return; }
            var todel = Movies.Find(Id);
            Movies.Remove(todel);
            SaveChanges();
        }
    }
}
