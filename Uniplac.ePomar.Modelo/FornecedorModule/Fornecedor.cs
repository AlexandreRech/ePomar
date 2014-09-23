using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniplac.ePomar.Modelo.FornecedorModule
{
    public class Fornecedor
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Contato { get; set; }

        public string Nota { get; set; }

        public void Valida()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new ArgumentNullException("O nome do fornecedor não pode estar branco.");
        }

        public override string ToString()
        {
            return string.Format("Id: {0} - Nome: {1} - Contato: {2} - Nota: {3}", Id, Nome, Contato, Nota);
        }
    }
}