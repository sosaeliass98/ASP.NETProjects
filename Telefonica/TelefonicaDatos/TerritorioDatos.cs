using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonicaDatos.EntityFramework;
using TelefonicaEntidades;

namespace TelefonicaDatos
{
    public class TerritorioDatos
    {
        private BBQEntities entities = new BBQEntities();

        public List<Territorios> ObtenerTerritorios()
        {
            var query = entities.telefonos
                .Where(x => x.Estado == "Disponible")
                .Take(10)
                .Select(td => new Territorios
                {
                    Numero = td.Numero,
                    Territorio = (int)td.Territorio,
                    Estado = td.Estado,
                    Observaciones = td.Observaciones
                });

            return query.ToList();
        }

    }
}
