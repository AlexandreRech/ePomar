using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.ReceitaModule;

namespace Uniplac.ePomar.Modelo.RelatorioModule
{
    public class Relatorio
    {
        public Double RelatorioCategoriaGado { get; set; }
        public Double RelatorioCategoriaProducao { get; set; }
        public Double RelatorioCategoriaProagro { get; set; }
        public Double RelatorioCategoriaOutros { get; set; }

        //Gera relatorio por categoria
        public void MetodoRelatorioReceita(List<Receita> lista)
        {

            List<Receita> listaFixa = lista;            
                       
            foreach (var item in listaFixa)
            {
                if (item.Categoria == "Gado")
                {
                    RelatorioCategoriaGado += item.Valor;
                }
                if (item.Categoria == "Produção")
                {
                    RelatorioCategoriaProducao += item.Valor;
                }
                if (item.Categoria == "Proagro")
                {
                    RelatorioCategoriaProagro += item.Valor;
                }
                if (item.Categoria == "Outros")
                {
                    RelatorioCategoriaOutros += item.Valor;
                }   
            }            
        }
    }
}
