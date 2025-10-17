using System;
using System.Data.SQLite;
using Dapper;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DatabaseManager
    {
        private static string _connectionString;

        public static void InitializeDatabase()
        {
            // 1. Definimos la ruta segura para los datos de la aplicación.
            string dbPath = Path.Combine(Application.LocalUserAppDataPath, "prestamos.db");
            _connectionString = $"Data Source={dbPath};Version=3;";

            // --- LA SOLUCIÓN MÁGICA ESTÁ AQUÍ ---
            // 2. Obtenemos la ruta del directorio que debe contener la base de datos.
            string directory = Path.GetDirectoryName(dbPath);

            // 3. Verificamos si ese directorio no existe.
            if (!Directory.Exists(directory))
            {
                // 4. Si no existe, lo creamos.
                Directory.CreateDirectory(directory);
            }
            // --- FIN DE LA SOLUCIÓN ---

            // Ahora, el resto del código funcionará porque la carpeta ya existe.
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            CreateTables();
        }

        // --- El resto de la clase no necesita ningún cambio ---

        private static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(_connectionString);
        }

        private static void CreateTables()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string createPersonasTableSql = @"
                CREATE TABLE IF NOT EXISTS Personas (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    Apellido TEXT NOT NULL
                );";

                string createPrestamosTableSql = @"
                CREATE TABLE IF NOT EXISTS Prestamos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    PersonaId INTEGER NOT NULL,
                    MontoPrestado REAL NOT NULL,
                    CantidadCuotas INTEGER NOT NULL,
                    TasaInteres REAL NOT NULL,
                    FechaInicio TEXT NOT NULL,
                    TipoDeCuota TEXT NOT NULL,
                    FOREIGN KEY (PersonaId) REFERENCES Personas(Id)
                );";

                string createCuotasTableSql = @"
                CREATE TABLE IF NOT EXISTS Cuotas (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    PrestamoId INTEGER NOT NULL,
                    NumeroCuota INTEGER NOT NULL,
                    Monto REAL NOT NULL,
                    Estado TEXT NOT NULL,
                    FechaVencimiento TEXT NOT NULL,
                    FechaDePago TEXT,
                    FOREIGN KEY (PrestamoId) REFERENCES Prestamos(Id)
                );";


                connection.Execute(createPersonasTableSql);
                connection.Execute(createPrestamosTableSql);
                connection.Execute(createCuotasTableSql);
            }
        }

        public static void SavePersona(Persona persona)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO Personas (Nombre, Apellido) VALUES (@nombre, @apellido);";
                connection.Execute(sql, persona);
            }
        }

        public static List<Persona> GetPersonas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM Personas;";
                return connection.Query<Persona>(sql).ToList();
            }
        }

        public static void SavePrestamo(Prestamo prestamo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string prestamoSql = @"INSERT INTO Prestamos 
                               (PersonaId, MontoPrestado, CantidadCuotas, TasaInteres, FechaInicio, TipoDeCuota) 
                               VALUES 
                               (@PersonaId, @MontoPrestado, @CantidadCuotas, @TasaInteres, @FechaInicio, @TipoDeCuota);
                               SELECT last_insert_rowid();"; // El comando mágico no cambia

                var prestamoId = connection.ExecuteScalar<int>(prestamoSql, prestamo);

                if (prestamo.PlanDePagos != null && prestamo.PlanDePagos.Any())
                {
                    string cuotaSql = @"INSERT INTO Cuotas (PrestamoId, NumeroCuota, Monto, Estado, FechaVencimiento, FechaDePago) VALUES (@PrestamoId, @NumeroCuota, @Monto, @Estado, @FechaVencimiento, @FechaDePago);";
                    foreach (var cuota in prestamo.PlanDePagos)
                    {
                        cuota.PrestamoId = prestamoId;
                        connection.Execute(cuotaSql, cuota);
                    }
                }
            }
        }

        public static void UpdateCuota(Cuota cuota)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = @"UPDATE Cuotas SET Estado = @Estado, FechaDePago = @FechaDePago WHERE Id = @Id;";
                connection.Execute(sql, cuota);
            }
        }

        public static List<Prestamo> GetPrestamos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM Prestamos;";
                return connection.Query<Prestamo>(sql).ToList();
            }
        }

        public static List<Cuota> GetCuotas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM Cuotas;";
                return connection.Query<Cuota>(sql).ToList();
            }
        }
    }
}