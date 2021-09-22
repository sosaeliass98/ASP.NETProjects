using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonicaDatos;
using TelefonicaEntidades;

namespace TelefonicaNegocio
{
    public class TerritoriosNegocio
    {
        private TerritorioDatos territorioDatos = new TerritorioDatos();

        public List<Territorios> ObtenerTerritorios()
        {
            return territorioDatos.ObtenerTerritorios();
        }
    }
}
