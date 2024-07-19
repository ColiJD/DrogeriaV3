using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drogueria_proyecto
{
    public class DCorreoSoporte: SecurityPass
    {
        public DCorreoSoporte()
        {

            remitenteCorreo = "colindresj9@gmail.com";  // Dirección de correo del remitente
            password = "khfc htqn mrwd trio";           // Contraseña del correo del remitente
            hots = "smtp.gmail.com";                    // Servidor SMTP de Gmail
            port = 587;                                 // Puerto SMTP para comunicación
            ssl = true;                                 // Indica que se usará SSL/TLS
            initializeSetClient();                      // Inicializa o configura el cliente de correo

        }
    }
}
