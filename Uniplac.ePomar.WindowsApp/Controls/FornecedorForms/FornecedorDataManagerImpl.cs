using System;
using System.Windows.Forms;
using Uniplac.ePomar.WindowsApp.Controls.Shared;
using Uniplac.ePomar.Modelo.FornecedorModule;

using Uniplac.ePomar.Aplicacao.FornecedorModule;

namespace Uniplac.ePomar.WindowsApp.Controls.FornecedorForms
{
    public class FornecedorDataManagerImpl : IDataManager
    {
        private IFornecedorService _service;
        private FornecedorControl _control;

        public FornecedorDataManagerImpl()
        {
            _service = new FornecedorService();

            _control = new FornecedorControl(_service);
        }

        #region IDataManager Members

        public void AddData()
        {
            var dialog = new FornecedorDialog();
            dialog.Fornecedor = new Fornecedor();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Add(dialog.Fornecedor);
                _control.RefreshGrid();
            }
        }

        public void EditData()
        {
            Fornecedor Fornecedor = _control.GetFornecedor();

            if (Fornecedor == null)
            {
                MessageBox.Show("Nenhum Fornecedor selecionado. Selecionar um Fornecedor antes de solicitar a edição");
                return;
            }

            var dialog = new FornecedorDialog();
            dialog.Fornecedor = Fornecedor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Update(dialog.Fornecedor);
                _control.RefreshGrid();
            }
        }

        public void DeleteData()
        {
            Fornecedor fornecedor = _control.GetFornecedor();

            if (fornecedor == null)
            {
                MessageBox.Show("Nenhuma Fornecedor selecionado. Selecione um Fornecedor antes de solicitar a exclusão");
                return;
            }
            if (MessageBox.Show("Deseja remover o Fornecedor selecionado?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(fornecedor);
                    _control.RefreshGrid();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
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
            return "Cadastro de Fornecedores";
        }

        public ToolTipMessage GetToolTipMessage()
        {
            return new ToolTipMessage
                       {
                           Add = "Adiciona Fornecedores",
                           Delete = "Exclui Fornecedores",
                           Edit = "Atualiza a Fornecedor selecionada"
                       };
        }

        #endregion
    }
}