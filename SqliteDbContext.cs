using RegistroGrupos;
using Microsoft.EntityFrameworkCore;


namespace RegistroGrupos;

class SqliteDbContext : DbContext
{
    //Definir las propiedades que se conviertan en tablas 
    public DbSet<Alumno> Alumnos { get; set; }

    public DbSet<Carrera> Carreras { get; set; }
    
    public DbSet<Grupo> Grupos { get; set; }
    
    public DbSet<GrupoAlumno> GruposAlumnos { get; set; }
    
    public DbSet<Tutor> Tutores { get; set; }

    //Definir el controlador y la conexion a la base de datos 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=Db/Bd.db");
        base.OnConfiguring(optionsBuilder);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(alum =>
            alum.HasMany<GrupoAlumno>(a => a.GrupoAlumnos)
                .WithOne(ga => ga.Alumno));

        modelBuilder.Entity<Carrera>(car =>
            car.HasMany<Grupo>(c => c.Grupos)
                .WithOne(g => g.Carrera));
        
        modelBuilder.Entity<Tutor>(tut =>
            tut.HasMany<Grupo>(c => c.Grupos)
                .WithOne(g => g.Tutores));
        
        modelBuilder.Entity<Grupo>(gru =>
            gru.HasMany<GrupoAlumno>(g => g.GrupoAlumnos)
                .WithOne(ga => ga.Grupo));
        
        
        modelBuilder.Entity<GrupoAlumno>(alum =>
        alum.HasOne<Alumno>(ga => ga.Alumno)
               .WithMany(a => a.GrupoAlumnos));
        
        modelBuilder.Entity<Grupo>(grup =>
            grup.HasOne<Carrera>(g => g.Carrera)
                .WithMany(a => a.Grupos));
        
        modelBuilder.Entity<Grupo>(grup =>
            grup.HasOne<Tutor>(ga => ga.Tutores)
                .WithMany(a => a.Grupos));
        
        modelBuilder.Entity<GrupoAlumno>(alum =>
            alum.HasOne<Alumno>(ga => ga.Alumno)
                .WithMany(a => a.GrupoAlumnos));
        
        base.OnModelCreating(modelBuilder);
    }

}

   
