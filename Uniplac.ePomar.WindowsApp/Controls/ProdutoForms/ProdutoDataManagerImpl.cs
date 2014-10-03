using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Aplicacao.ProdutoModule;
using Uniplac.ePomar.Modelo.ProdutoModule;
using Uniplac.ePomar.WindowsApp.Controls.Shared;

namespace Uniplac.ePomar.WindowsApp.Controls.ProdutoForms
{
    public class ProdutoDataManagerImpl : IDataManager
    {
        private IProdutoService _service;
        private ProdutoControl _control;

        public ProdutoDataManagerImpl()
        {
            _service = new ProdutoService();

            _control = new ProdutoControl(_service);
        }


        public void AddData()
        {
            var dialog = new ProdutoDialog();
            dialog.Produto = new Produto();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Add(dialog.Produto);
                _control.RefreshGrid();
            }
        }

        public void DeleteData()
        {
            Produto produto = _control.GetProduto();

            if (produto == null)
            {
                MessageBox.Show("Nenhum produto selecionado. Selecione um produto antes de solicitar a exclusão");
                return;
            }
            if (MessageBox.Show("Deseja remover o Produto selecionado?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(produto);
                    _control.RefreshGrid();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void EditData()
        {
            Produto Produto = _control.GetProduto();

            if (Produto == null)
            {
                MessageBox.Show("Nenhum Produto selecionado. Selecionar um Produto antes de solicitar a edição");
                return;
            }

            var dialog = new ProdutoDialog();
            dialog.Produto = Produto;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Update(dialog.Produto);
                _control.RefreshGrid();
            }
        }

        public UserControl GetControl()
        {
            if (_control != null)
                _control.RefreshGrid();

            return _control;
        }

        public string GetDescription()
        {
            return "Cadastro de produtos";
        }

        public ToolTipMessage GetToolTipMessage()
        {
            return new ToolTipMessage
            {
                Add = "Adiciona Produtos",
                Delete = "Exclui Produtos",
                Edit = "Atualiza o Produto selecionado",
                Report = "Apresenta o Relatório de produtos"
            };
        }

        public void ReportData() { }


        public StateButtons GetStateButtons()
        {
            return new StateButtons { Add = true, Edit = true, Delete = true, Report = true };
        }
    }
}
