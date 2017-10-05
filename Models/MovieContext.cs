




publi class MovieContext : DbContext
    {
        public Dbset<User> User{ get, set; }
        public Dbset<User> User{ get, set; }

        public MovieContext(DbContextOptions<MovieContext>)
            :base(options)
            {

            }
        protected override void OnModelCreationg(ModelBuilder ModelBuilder)
        {
            base.OnmodelCreating(ModelBuilder);

            new UserMapping(modelBuilder.Entity<User>());
            new UserMapping(modelBuilder.Entity<User>());

        }
        

    }