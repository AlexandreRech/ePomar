using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniplac.ePomar.Modelo.ProdutoModule
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Validade { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
          

        public void Valida()
        {
            if (Valor <= 0)
                throw new ArgumentNullException("O Valor deve ser maior do que zero.");

            if (Nome == null)
                throw new ArgumentNullException("Adicione um nome para o Produto.");

            if (Quantidade <= 0)
                throw new ArgumentNullException("Adicione a quantidade de produtos.");

            if (Validade <= DateTime.Now)
                throw new ArgumentNullException("A data de validade deve ser maior que a data atual.");
        }

        public override string ToString()
        {
            return string.Format("Id: {0} - Nome: {1} - Valor: {2} - Validade: {3} - Quantidade: {4} - Descrição: {5}",
                Id, Nome, Valor, Validade, Quantidade, Descricao);
        }
    }
}
