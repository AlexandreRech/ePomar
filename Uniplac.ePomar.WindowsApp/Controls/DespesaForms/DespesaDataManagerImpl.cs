using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Aplicacao.DespesaModule;
using Uniplac.ePomar.Modelo.DespesaModule;
using Uniplac.ePomar.Modelo.FornecedorModule;
using Uniplac.ePomar.WindowsApp.Controls.Shared;

namespace Uniplac.ePomar.WindowsApp.Controls.DespesaForms
{
    public class DespesaDataManagerImpl : IDataManager
    {
        private IDespesaService _service;
        private DespesaControl _control;

        public DespesaDataManagerImpl()
        {
            _service = new DespesaService();

          _control = new DespesaControl(_service);
        
        }

        public void AddData()
        {
            List<Fornecedor> fornecedores = _service.GetAllFornecedor();
            var dialog = new DespesaDialog(fornecedores);
            dialog.Despesa = new Despesa();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Add(dialog.Despesa);
                _control.RefreshGrid();
            }
        }

        public void DeleteData()
        {
            Despesa despesa = _control.GetDespesa();

            if (despesa == null)
            {
                MessageBox.Show("Nenhuma despesa selecionada. Selecione uma Despesa antes de solicitar a exclusão");
                return;
            }
            if (MessageBox.Show("Deseja remover a Despesa selecionada?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(despesa);
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
            Despesa Despesa = _control.GetDespesa();

            if (Despesa == null)
            {
                MessageBox.Show("Nenhuma Receita selecionada. Selecionar uma Receita antes de solicitar a edição");
                return;
            }

            List<Fornecedor> fornecedores = _service.GetAllFornecedor();
            var dialog = new DespesaDialog(fornecedores);
            dialog.Despesa = Despesa;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Update(dialog.Despesa);
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
            return "Cadastro de despesas";
        }

        public ToolTipMessage GetToolTipMessage()
        {
            return new ToolTipMessage
            {
                Add = "Adiciona Despesas",
                Delete = "Exclui Despesas",
                Edit = "Atualiza a Despesa selecionada",
                Report = "Apresenta o Relatório de Despesas"
            };
        }

        public void ReportData() { }


        public StateButtons GetStateButtons()
        {
            return new StateButtons { Add = true, Edit = true, Delete = true, Report = true };
        }
    }
}
