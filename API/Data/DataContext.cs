using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext {

    // constroctor and it will look for the options we provide, 
    public DataContext(DbContextOptions options) : base(options)
    {

    }

    // Propertity --> It will present the table of database Users
    public DbSet <AppUser> Users { get; set; }


}