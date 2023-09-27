using RegistroGrupos;
using SQLitePCL;


CrearBaseDeDatos();
RegistrarPrimerGrupo();

static void CrearBaseDeDatos()
{
    //Resources tienen metodos para abrir y cerrar acciones
    using ( var db = new SqliteDbContext()) 
    {
       db.Database.EnsureCreated();
    }
}

static void RegistrarPrimerGrupo()
{
    var Grupo = new Grupo
    {
        Nombre = "Sistemas",
        CarreraId = 0,
        Periodo = "2022", 
        CicloEscolar = "2323",
        
        
    };
    using (var db = new SqliteDbContext())
    {
        db.Grupos.Add(Grupo);
        db.SaveChanges();
    }
}