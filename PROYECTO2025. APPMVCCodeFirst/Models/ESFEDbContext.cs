using Microsoft.EntityFrameworkCore;
namespace PROYECTO2025._APPMVCCodeFirst.Models
{
    public class ESFEDbContext: DbContext 
    {
        public ESFEDbContext(DbContextOptions<ESFEDbContext> options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}