using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.Modelo.DespesaModule
{
    public class Despesa
    {
        public int Id { get; set; }
        public String Descricao { get; set; }
        public Double Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public String TipoPagamento { get; set; }       
        public String Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public string ObservaçõesFornecedor { get; set; }

        public void Valida()
        {
            if (Valor <= 0)
                throw new ArgumentNullException("O Valor deve ser maior do que zero.");

            if (Descricao == null)
                throw new ArgumentNullException("Adicione uma descrição para a despesa.");

            if (TipoPagamento == null)
                throw new ArgumentNullException("Adicione o tipo de pagamento.");

            if (Categoria == null)
                throw new ArgumentNullException("Adicione uma categoria para a despesa.");
        }

        public override string ToString()
        {
            return string.Format("Id: {0} - Descrição: {1} - Valor: {2} - Data do pagamento: {3} - Tipo de pagamento: {4} - Categoria: {5} - Fornecedor: {6} - Observações: {7}",
                Id, Descricao, Valor, DataPagamento, TipoPagamento, Categoria, Fornecedor.Nome, ObservaçõesFornecedor);
        }
    
    }
}
