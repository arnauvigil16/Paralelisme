using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Paralelisme {
    class Usuari {
        public string dni { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public bool comprova_dni() {
            string lletres = "TRWAGMYFPDXBNJZSQVHLCKE";

            int nums = Convert.ToInt32(dni.Substring(0, 8));
            string lletraDNI = dni.Substring(8, 1);

            int residu = nums % 23;

            return lletres.Substring(residu, 1) == lletraDNI ? true : false;
        }

        public bool comprova_mail() {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool comprova_nom() {
            return name.Length == 0 ? false : true;
        }
    }
}
