using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Uniplac.ePomar.Aplicacao.ReceitaModule;
using Uniplac.ePomar.Modelo.ReceitaModule;
using Uniplac.ePomar.Modelo.RelatorioModule;

namespace Uniplac.ePomar.WindowsApp.Controls.RelatorioForms
{
    public partial class RelatorioProdutosDialog : Form
    {
        Relatorio relatorioClass = new Relatorio();
        ReceitaService receita = new ReceitaService();
        

        public RelatorioProdutosDialog()
        {
            InitializeComponent();

            chart.Series.Add("Gado");
            chart.Series.Add("Proagro");
            chart.Series.Add("Producao");
            chart.Series.Add("Outros");
            List<Receita> listaReceita = receita.GetAllReceitas();
            relatorioClass.MetodoRelatorioReceita(listaReceita);
            
            
            chart.Series[0].Points.AddY(relatorioClass.RelatorioCategoriaGado);
            chart.Series[1].Points.AddY(relatorioClass.RelatorioCategoriaProagro);
            chart.Series[2].Points.AddY(relatorioClass.RelatorioCategoriaProducao);
            chart.Series[3].Points.AddY(relatorioClass.RelatorioCategoriaOutros);

            chart.ChartAreas["ChartArea1"].AxisY.Interval = 10;
            
                                             
        }

       
    }
}
