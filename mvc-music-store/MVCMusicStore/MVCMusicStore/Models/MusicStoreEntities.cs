﻿using System.Data.Entity;

namespace MVCMusicStore.Models
{
    public class MusicStoreEntities : DbContext 
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MVCMusicStore.Models.Artist> Artists { get; set; }
    }
}