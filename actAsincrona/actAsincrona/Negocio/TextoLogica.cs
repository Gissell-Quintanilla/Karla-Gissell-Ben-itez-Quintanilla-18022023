using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actAsincrona.Negocio
{
    internal class TextoLogica
    {
        public int contador(String texto)
        {
            int contador = 0;

            for (int i = 0; i <= texto.Length - 1; i++)
            {
                if (!(texto[i] == ' '))
                {
                    contador += 1;
                }
            }

            return contador;
        }
    }
}
