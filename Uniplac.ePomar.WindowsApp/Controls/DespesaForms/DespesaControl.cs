using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Aplicacao.DespesaModule;
using Uniplac.ePomar.Modelo.DespesaModule;

namespace Uniplac.ePomar.WindowsApp.Controls.DespesaForms
{
    public partial class DespesaControl : UserControl
    {
        private readonly IDespesaService _service = null;

        public DespesaControl()
        {
            InitializeComponent();
        }

        public DespesaControl(IDespesaService service) : this()
        {
            _service = service;
        }

        public Despesa GetDespesa()
        {
            return listDespesas.SelectedItem as Despesa;
        }

        public void RefreshGrid()
        {
            var despesas = _service.GetAll();

            listDespesas.Items.Clear();

            foreach (var Despesa in despesas)
            {
                listDespesas.Items.Add(Despesa);
            }
        }
    }
}
