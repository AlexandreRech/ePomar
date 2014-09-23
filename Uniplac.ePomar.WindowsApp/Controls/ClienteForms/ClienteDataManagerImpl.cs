using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Aplicacao.ClienteModule;
using Uniplac.ePomar.Modelo.ClienteModule;
using Uniplac.ePomar.WindowsApp.Controls.Shared;

namespace Uniplac.ePomar.WindowsApp.Controls.ClienteForms
{
    public class ClienteDataManagerImpl : IDataManager
    {
        private IClienteService _service;
        private ClienteControl _control;

        public ClienteDataManagerImpl()
        {
            _service = new ClienteService();

            _control = new ClienteControl(_service);

        }

        public void AddData()
        {
            var dialog = new ClienteDialog();
            dialog.Cliente = new Cliente();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Add(dialog.Cliente);
                _control.RefreshGrid();
            }
        }

        public void DeleteData()
        {
            Cliente cliente = _control.GetCliente();

            if (cliente == null)
            {
                MessageBox.Show("Nenhum cliente selecionado. Selecione um Cliente antes de solicitar a exclusão");
                return;
            }
            if (MessageBox.Show("Deseja remover o Cliente selecionado?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(cliente);
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
            Cliente Cliente = _control.GetCliente();

            if (Cliente == null)
            {
                MessageBox.Show("Nenhum Cliente selecionado. Selecionar um Cliente antes de solicitar a edição");
                return;
            }

            var dialog = new ClienteDialog();
            dialog.Cliente = Cliente;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.Update(dialog.Cliente);
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
            return "Cadastro de clientes";
        }

        public ToolTipMessage GetToolTipMessage()
        {
            return new ToolTipMessage
            {
                Add = "Adiciona Clientes",
                Delete = "Exclui Clientes",
                Edit = "Atualiza o Cliente selecionado"
            };
        }
    }
}

