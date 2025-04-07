using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresYPruebas.Dominio.Excepciones;
public class NoMasNumerosException : Exception
{
    public NoMasNumerosException(string mensaje) : base(mensaje)
    {
        
    }
}
