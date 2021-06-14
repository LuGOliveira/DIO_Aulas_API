using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Aulas_API.Models
{
    public class ValidaCampoViewModelOutPut
    {
        public IEnumerable<string> Erros { get; set; }

        public ValidaCampoViewModelOutPut(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
