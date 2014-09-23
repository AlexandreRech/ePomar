using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Modelo.ReceitaModule;
using Uniplac.ePomar.Aplicacao.ReceitaModule;

namespace Uniplac.ePomar.WindowsApp.Controls.ReceitaForms
{
    public partial class ReceitaControl : UserControl
    {
        private readonly IReceitaService _service = null;

        public ReceitaControl()
        {
            InitializeComponent();
        }

        public ReceitaControl(IReceitaService service) : this()
        {
            _service = service;
        }

        public Receita GetReceita()
        {
            return listReceitas.SelectedItem as Receita;
        }

        public void RefreshGrid()
        {
            var receitas = _service.GetAll();

            listReceitas.Items.Clear();

            foreach (var Receita in receitas)
            {
                listReceitas.Items.Add(Receita);
            }
        }
    }
    }
