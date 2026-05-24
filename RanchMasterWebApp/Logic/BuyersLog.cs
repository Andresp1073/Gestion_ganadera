using Data;
using Model;
using Microsoft.EntityFrameworkCore; // Asegúrate de tener esta referencia
using System;

namespace Logic
{
    public class BuyersLog
    {
        // Actualiza un comprador existente con mejor manejo de errores
        public string UpdateBuyers(BuyersEntity objbuyers)
        {
            try
            {
                using (var db = new RanchMasterContext())
                {
                    var existingBuyer = db.Buyers.Find(objbuyers.IdBuyer);
                    if (existingBuyer == null)
                    {
                        return $"Comprador con ID {objbuyers.IdBuyer} no encontrado.";
                    }

                    db.Entry(existingBuyer).CurrentValues.SetValues(objbuyers);
                    db.Entry(existingBuyer).State = EntityState.Modified;

                    int affectedRows = db.SaveChanges();

                    if (affectedRows > 0)
                        return "OK";
                    else
                        return "No se detectaron cambios para actualizar.";
                }
            }
            catch (DbUpdateException ex)
            {
                return $"Error de base de datos: {ex.InnerException?.Message ?? ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Error inesperado: {ex.Message}";
            }
        }


        // Métodos existentes (mantenemos los mismos pero con mejor manejo de errores)
        public List<BuyersEntity> BuyersList()
        {
            try
            {
                using (var db = new RanchMasterContext())
                {
                    return db.Buyers.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener lista de compradores: {ex.Message}");
                return new List<BuyersEntity>();
            }
        }

        public static void CreateBuyers(BuyersEntity objbuyers)
        {
            try
            {
                using (var db = new RanchMasterContext())
                {
                    db.Buyers.Add(objbuyers);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear comprador: {ex.Message}");
                throw; // Relanzamos la excepción para manejarla en el componente
            }
        }

        public BuyersEntity? GetBuyerById(int id)
        {
            try
            {
                using (var db = new RanchMasterContext())
                {
                    return db.Buyers.FirstOrDefault(b => b.IdBuyer == id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener comprador por ID: {ex.Message}");
                return null;
            }
        }
    }
}