using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drogueria_proyecto
{
    public class NrecuperarPassword
    {
        public string recoverPassword(string userRequesing)
        {
            return new SecurityPass().recoverPassword(userRequesing);
        }
    }
}
