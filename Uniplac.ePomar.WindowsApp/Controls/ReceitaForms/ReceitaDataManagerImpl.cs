using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Aplicacao.ReceitaModule;
using Uniplac.ePomar.Modelo.ClienteModule;
using Uniplac.ePomar.Modelo.ReceitaModule;
using Uniplac.ePomar.WindowsApp.Controls.Shared;

namespace Uniplac.ePomar.WindowsApp.Controls.ReceitaForms
{
    public class ReceitaDataManagerImpl : IDataManager
    {
        private IReceitaService _service;
        private ReceitaControl _control;

        public ReceitaDataManagerImpl()
        {
            _service = new ReceitaService();

          _control = new ReceitaControl(_service);
        
        }

        

        public void AddData()
        {
            List<Cliente> clientes = _service.GetAllClientes();
            var dialog = new ReceitaDialog(clientes);
            dialog.Receita = new Receita();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Add(dialog.Receita);
                _control.RefreshGrid();
            }
        }

        public void DeleteData()
        {
            Receita receita = _control.GetReceita();

            if (receita == null)
            {
                MessageBox.Show("Nenhuma receita selecionado. Selecione uma Receita antes de solicitar a exclusão");
                return;
            }
            if (MessageBox.Show("Deseja remover a Receita selecionada?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(receita);
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
            Receita Receita = _control.GetReceita();

            if (Receita == null)
            {
                MessageBox.Show("Nenhuma Receita selecionada. Selecionar uma Receita antes de solicitar a edição");
                return;
            }

            List<Cliente> clientes = _service.GetAllClientes();
            var dialog = new ReceitaDialog(clientes);
            dialog.Receita = Receita;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Update(dialog.Receita);
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
            return "Cadastro de receitas";
        }

        public ToolTipMessage GetToolTipMessage()
        {
            return new ToolTipMessage
            {
                Add = "Adiciona Receitas",
                Delete = "Exclui Receitas",
                Edit = "Atualiza a Receita selecionada",
                Report = "Apresenta o Relatório de Receita"
            };
        }

        public void ReportData() { }


        public StateButtons GetStateButtons()
        {
            return new StateButtons { Add = true, Edit = true, Delete = true, Report = true };
        }
    }
}
