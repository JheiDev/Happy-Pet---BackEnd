﻿using Data;
using Entity.Models;

namespace Business
{
    public class DetalleVentaService
    {
        private readonly DetalleVentaDAO dao_dv;

        public DetalleVentaService(DetalleVentaDAO dao_dv)
        {
            this.dao_dv = dao_dv;
        }

        // Método para listar detalles de venta por ID de venta
        public List<DetalleVenta> ListarDetalleVenta(int id_venta)
        {
            try
            {
                if (id_venta <= 0)
                {
                    throw new Exception("Error: El ID de la venta no es valido.");
                }

                var listado = dao_dv.ObtenerDetallesVenta(id_venta);

                if (listado == null || listado.Count == 0)
                {
                    throw new Exception("Error: No se encontraron detalles de venta.");
                }

                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
