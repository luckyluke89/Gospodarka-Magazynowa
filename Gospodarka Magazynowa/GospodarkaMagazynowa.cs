using System;
using System.Data.Entity;
using System.Linq;
using Gospodarka_Magazynowa.Models;

namespace Gospodarka_Magazynowa
{
    public class GospodarkaMagazynowa : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Gospodarka_Magazynowa.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public GospodarkaMagazynowa()
            : base("name=GospodarkaMagazynowa")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<Operacja> Operacja { get; set; }
        public DbSet<Magazyn> Magazyn { get; set; }
        public DbSet<ElementMagazynu> ElementMagazynu { get; set; }
        public DbSet<Klient> Klient { get; set; }
        public DbSet<Slownik> Slownik { get; set; }
        public DbSet<LokalizacjaWMagazynie> LokalizacjaWMagazynie { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}