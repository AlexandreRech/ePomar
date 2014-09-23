using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Aplicacao.ProdutoModule;
using Uniplac.ePomar.Modelo.ProdutoModule;

namespace Uniplac.ePomar.WindowsApp.Controls.ProdutoForms
{
    public partial class ProdutoControl : UserControl
    {
        private readonly IProdutoService _service = null;

        public ProdutoControl()
        {
            InitializeComponent();
        }

        public ProdutoControl(IProdutoService service)
            : this()
        {
            _service = service;
        }

        public Produto GetProduto()
        {
            return listProdutos.SelectedItem as Produto;
        }

        public void RefreshGrid()
        {
            var produtos = _service.GetAll();

            listProdutos.Items.Clear();

            foreach (var Produto in produtos)
            {
                listProdutos.Items.Add(Produto);
            }
        }
    }
}
