﻿using System.Data.Entity;
using NgTodoList.Domain;
using NgTodoList.Data.Mapping;

namespace NgTodoList.Data.Context
{
    public class NgTodoListDataContext : DbContext
    {
        public NgTodoListDataContext()
            : base("NgTodoListConnectionString")
        {      
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new TodoMap());
        }
    }

}
