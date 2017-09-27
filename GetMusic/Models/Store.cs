namespace GetMusic.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Store : DbContext
    {
        // Your context has been configured to use a 'Store' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GetMusic.Models.Store' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Store' 
        // connection string in the application configuration file.
        public Store()
            : base("name=Store")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MyStore> MyStore { get; set; }
        public virtual DbSet<Album> MyAlbums { get; set; }
        public virtual DbSet<Artist> MyArtists { get; set; }
        public virtual DbSet<Track> MyTracks { get; set; }
        public virtual DbSet<User> MyUsers { get; set; }

        public System.Data.Entity.DbSet<GetMusic.Models.Searcher> Searchers { get; set; }
    }

    public class MyStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}