using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace Drogueria_proyecto
{
    public class SecurityPass
    {
        private SmtpClient smtpClient;

        protected string remitenteCorreo { get; set; }
        protected string password { get; set; }
        protected string hots { get; set; }
        protected bool ssl { get; set; }
        protected int port { get; set; }

        protected void initializeSetClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(remitenteCorreo, password);
            smtpClient.Host = hots;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }
        public void sendMail(string subject, string body, List<string> destinatarioCorreo)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(remitenteCorreo);
                foreach (string mail in destinatarioCorreo)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex) { }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
        public string recoverPassword(string usuarioSolicitado)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = cls_Conexion.conexion;
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM [dbo].[Empleado] WHERE username = @username OR correo = @correo";
                    command.Parameters.AddWithValue("@username", usuarioSolicitado);
                    command.Parameters.AddWithValue("@correo", usuarioSolicitado);
                    command.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombreUsuario = reader.GetString(reader.GetOrdinal("username"));
                            string correoUsuario = reader.GetString(reader.GetOrdinal("correo"));
                            string cuentaContrasena = reader.GetString(reader.GetOrdinal("password"));

                            var mailService = new DCorreoSoporte();
             
                            mailService.sendMail(
                                subject: "Sistema De Drogeria: Solicitud de recuperación de contraseña",
                                body: "Hola, " + nombreUsuario + "\nUsted solicitó recuperar su contraseña.\n" +
                                "\nSu Contraseña es: "+ cuentaContrasena +
                                      "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema...",
                                destinatarioCorreo: new List<string> { correoUsuario }
                                


                            );
                            
                            return "Hola, " + nombreUsuario +
                                   "\nPor favor revise su correo "+
                                   "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema...";
                        }
                        else
                        {
                            return "Lo sentimos, no tiene una cuenta con ese correo o nombre de usuario.";
                        }
                    }
                }
            }
        }
    }
}
