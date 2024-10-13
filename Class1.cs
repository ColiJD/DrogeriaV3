using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace Drogueria_proyecto
{
    class Class1
    {
        public bool validarLetras(String text, String msj)
        {
            if (text.FirstOrDefault() == char.Parse(" "))
            {
                return true;
            }
            foreach (Char letra in text)
            {
                if (Regex.IsMatch(letra.ToString(), "^[\f\\s\n\r\t\vA-Za-zñ]") == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool validarNumeros(String text, String msj)
        {

            foreach (Char letra in text)
            {
                if (Regex.IsMatch(letra.ToString(), "^[0-9]") == false)
                {
                    return true;
                }
            }

            return false;
        }
        public bool validarMinimoOchoCaracteres(String text, String msj)
        {
            if (text.Length >= 8)
            {
                return false; // Si tiene 8 o más caracteres, retorna true
            }
            return true; // Si tiene menos de 8 caracteres, retorna false
        }
      

        public bool validarprecio(String text, String msj)
        {

            foreach (Char letra in text)
            {
                if (Regex.IsMatch(letra.ToString(), "^[0-9\\d\\.]") == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool validartipo_u(String text, String msj)
        {
            if (text.FirstOrDefault() == char.Parse(" "))
            {
                return true;
            }

            foreach (Char letra in text)
            {
                if (Regex.IsMatch(letra.ToString(), "^[1-3]") == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool validarcatgopro(String text, String msj)
        {
            if (text.FirstOrDefault() == char.Parse(" "))
            {
                return true;
            }

            foreach (Char letra in text)
            {
                if (Regex.IsMatch(letra.ToString(), "^[0-9]") == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool validarLetrasyNumeros(String text, String msj)
        {
 
            if (text.FirstOrDefault() ==char.Parse(" ")) {
                return true;
                }

            foreach (Char letra in text)
            {
                if (Regex.IsMatch(letra.ToString(), "^[\f\n\\s\r\t\vA-Za-z0-9ñ#]") == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool validarlogin(String text, String msj)
        {

            if (text.FirstOrDefault() == char.Parse(" "))
            {
                return true;
            }

            foreach (Char letra in text)
            {
                if (Regex.IsMatch(letra.ToString(), "^[\f\n\r\t\vA-Za-z0-9]") == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool validarcorreo(String text, String msj)
        {
            if (text.FirstOrDefault() == char.Parse(" "))
            {
                return true;
            }
            foreach (Char letra in text)
            {
                if (Regex.IsMatch(letra.ToString(), "^[\f\n\r\t\va-za-z0-9_@.]") == false) 
                {
                    return true;
                }
            }

            return false;
        }

        public bool validarEmpty(String text, String msj)
        {
            var chr = text[0];

            if (text==String.Empty ||  chr.ToString()==" ")
            {
                MessageBox.Show(msj, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }

}
