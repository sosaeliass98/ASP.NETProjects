using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TelefonicaEntidades;
using TelefonicaNegocio;

namespace Telefonica
{
    public partial class _Default : Page
    {
        private TerritoriosNegocio telefonicaNegocio = new TerritoriosNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<Territorios> territorios = telefonicaNegocio.ObtenerTerritorios();
                //Territorios territorios1 = territorios[0];
                //txtNumero1.Text = territorios1.Numero.ToString();

                //Territorios territorios2 = territorios[1];
                //txtNumero2.Text = territorios2.Numero.ToString();

                lstTerritorios.DataSource = telefonicaNegocio.ObtenerTerritorios();
                lstTerritorios.DataBind();

                //Territorios territorios3 = territorios[2];
                //txtNumero.Text = territorios3.Numero.ToString();

                //Territorios territorios4 = territorios[3];
                //txtNumero.Text = territorios4.Numero.ToString();

                //Territorios territorios5 = territorios[4];
                //txtNumero.Text = territorios5.Numero.ToString();

                //Territorios territorios6 = territorios[5];
                //txtNumero.Text = territorios6.Numero.ToString();

                //Territorios territorios7 = territorios[6];
                //txtNumero.Text = territorios7.Numero.ToString();

                //Territorios territorios8 = territorios[7];
                //txtNumero.Text = territorios8.Numero.ToString();

                //Territorios territorios9 = territorios[8];
                //txtNumero.Text = territorios9.Numero.ToString();

                //Territorios territorios10 = territorios[9];
                //txtNumero.Text = territorios10.Numero.ToString();
            }
        }
    }
}