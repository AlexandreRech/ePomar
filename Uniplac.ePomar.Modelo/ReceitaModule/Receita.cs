using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.ClienteModule;

namespace Uniplac.ePomar.Modelo.ReceitaModule
{
    public class Receita
    {

        public int Id { get; set; }
        public String Descricao { get; set; }
        public Double Valor { get; set; }
        public DateTime DataRecebimento { get; set; }
        public String TipoPagamento { get; set; }
        public String Categoria { get; set; }
        public Cliente Cliente { get; set; }
        public string ObservacoesCliente { get; set; }

        public void Valida()
        {
            if (Valor <= 0)
                throw new ArgumentNullException("O Valor deve ser maior do que zero.");

            if (Descricao == null)
                throw new ArgumentNullException("Adicione uma descrição para a receita.");

            if (TipoPagamento == null)
                throw new ArgumentNullException("Adicione o tipo de pagamento.");

            if (Categoria == null)
                throw new ArgumentNullException("Adicione uma categoria para a receita.");
        }

        public override string ToString()
        {
            return string.Format("Id: {0} - Descrição: {1} - Valor: {2} - Data do recebimento: {3} - Tipo de pagamento: {4} - Categoria: {5} - Cliente: {6} - Observações: {7}",
                Id, Descricao, Valor, DataRecebimento, TipoPagamento, Categoria, Cliente.Nome, ObservacoesCliente);
        }
    }
}
