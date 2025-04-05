using EL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public static class BusControlRepository
    {
        public static void AgregarChofer(string nombre, string apellido, DateTime fechaNacimiento, string cedula)
        {
            using (var db = new DatabaseHelper())
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();
                    var query = "INSERT INTO Choferes (Nombre, Apellido, FechaNacimiento, Cedula) VALUES (@Nombre, @Apellido, @FechaNacimiento, @Cedula)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                        command.Parameters.AddWithValue("@Cedula", cedula);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void AgregarAutobus(string marca, string modelo, string placa, string color, int ano)
        {
            using (var db = new DatabaseHelper())
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();
                    var query = "INSERT INTO Autobuses (Marca, Modelo, Placa, Color, Ano) VALUES (@Marca, @Modelo, @Placa, @Color, @Ano)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Marca", marca);
                        command.Parameters.AddWithValue("@Modelo", modelo);
                        command.Parameters.AddWithValue("@Placa", placa);
                        command.Parameters.AddWithValue("@Color", color);
                        command.Parameters.AddWithValue("@Ano", ano);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void AgregarRuta(string nombreRuta)
        {
            using (var db = new DatabaseHelper())
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();
                    var query = "INSERT INTO Rutas (NombreRuta) VALUES (@NombreRuta)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreRuta", nombreRuta);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        //public static void AsignarChoferAutobusRuta(int choferID, int autobusID, int rutaID)
        //{
        //    using (var db = new DatabaseHelper())
        //    {
        //        using (var connection = db.GetConnection())
        //        {
        //            connection.Open();
        //            var query = "INSERT INTO Asignaciones (ChoferID, AutobusID, RutaID) VALUES (@ChoferID, @AutobusID, @RutaID)";
        //            using (var command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@ChoferID", choferID);
        //                command.Parameters.AddWithValue("@AutobusID", autobusID);
        //                command.Parameters.AddWithValue("@RutaID", rutaID);
        //                command.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //}

        public static List<Chofer> ObtenerChoferes()
        {
            var choferes = new List<Chofer>();

            using (var db = new DatabaseHelper())
            using (var connection = db.GetConnection())
            {
                connection.Open();
                var query = "SELECT ChoferID, Nombre, Apellido, FechaNacimiento, Cedula FROM Choferes";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        choferes.Add(new Chofer { 
                            ID = (int)reader["ChoferID"], 
                            Nombre = (string)reader["Nombre"], 
                            Apellido = (string)reader["Apellido"],
                            FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                            Cedula = (string)reader["Cedula"]
                        });
                    }
                }
            }

            return choferes;
        }

        public static List<Autobus> ObtenerAutobuses()
        {
            var autobuses = new List<Autobus>();

            using (var db = new DatabaseHelper())
            using (var connection = db.GetConnection())
            {
                connection.Open();
                var query = "SELECT AutobusID, Marca, Modelo,Placa, Color, Ano FROM Autobuses";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        autobuses.Add(new Autobus {
                            ID = (int)reader["AutobusID"],
                            Marca = (string)reader["Marca"],
                            Modelo = (string)reader["Modelo"],
                            Placa = (string)reader["Placa"],
                            Color = (string)reader["Color"],
                            Ano = (int)reader["Ano"]
                        });
                    }
                }
            }

            return autobuses;
        }

        public static List<Ruta> ObtenerRutas()
        {
            var rutas = new List<Ruta>();

            using (var db = new DatabaseHelper())
            using (var connection = db.GetConnection())
            {
                connection.Open();
                var query = "SELECT RutaID, NombreRuta FROM Rutas";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rutas.Add(new Ruta { 
                            ID = (int)reader["RutaID"], 
                            NombreRuta = (string)reader["NombreRuta"]
                        });
                    }
                }
            }

            return rutas;
        }

        public static List<Asignacion> ObtenerAsiganciones()
        {
            var rutas = new List<Asignacion>();

            using (var db = new DatabaseHelper())
            using (var connection = db.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Asignaciones";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rutas.Add(new Asignacion
                        {
                            ID = (int)reader["AsignacionID"],
                            ChoferID = (int)reader["ChoferID"],
                            AutobusID = (int)reader["AutobusID"],
                            RutaID = (int)reader["RutaID"]
                        });
                    }
                }
            }

            return rutas;
        }






        //------------------------
        public static bool EstaChoferDisponible(int choferID)
        {
            using (var db = new DatabaseHelper())
            using (var connection = db.GetConnection())
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM Asignaciones WHERE ChoferID = @ChoferID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ChoferID", choferID);
                    return (int)command.ExecuteScalar() == 0;
                }
            }
        }

        public static bool EstaAutobusDisponible(int autobusID)
        {
            using (var db = new DatabaseHelper())
            using (var connection = db.GetConnection())
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM Asignaciones WHERE AutobusID = @AutobusID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AutobusID", autobusID);
                    return (int)command.ExecuteScalar() == 0;
                }
            }
        }

        public static bool EstaRutaDisponible(int rutaID)
        {
            using (var db = new DatabaseHelper())
            using (var connection = db.GetConnection())
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM Asignaciones WHERE RutaID = @RutaID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RutaID", rutaID);
                    return (int)command.ExecuteScalar() == 0;
                }
            }
        }

        public static void AsignarChoferAutobusRuta(int choferID, int autobusID, int rutaID)
        {
            using (var db = new DatabaseHelper())
            using (var connection = db.GetConnection())
            {
                connection.Open();

                // Verificar disponibilidad
                if (!EstaChoferDisponible(choferID))
                {
                    throw new InvalidOperationException("El chofer ya está asignado a otra ruta.");
                }

                if (!EstaAutobusDisponible(autobusID))
                {
                    throw new InvalidOperationException("El autobús ya está asignado a otra ruta.");
                }

                if (!EstaRutaDisponible(rutaID))
                {
                    throw new InvalidOperationException("La ruta ya tiene asignado un chofer y un autobús.");
                }

                var query = "INSERT INTO Asignaciones (ChoferID, AutobusID, RutaID) VALUES (@ChoferID, @AutobusID, @RutaID)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ChoferID", choferID);
                    command.Parameters.AddWithValue("@AutobusID", autobusID);
                    command.Parameters.AddWithValue("@RutaID", rutaID);
                    command.ExecuteNonQuery();
                }
            }
        }
        //-------------------------------
    }
}


