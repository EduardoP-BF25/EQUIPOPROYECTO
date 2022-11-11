using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base (options) {

    }   

    protected override void OnModelCreating(ModelBuilder builder){
     
    }
 
     public DbSet<Psicologo> Psicologo { get; set; } = default!;

    public DbSet<Paciente> Paciente { get; set; } = default!;

    public DbSet<Test> Test { get; set; } = default!;

}