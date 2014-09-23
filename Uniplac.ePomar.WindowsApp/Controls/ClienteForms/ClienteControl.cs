using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Modelo.ClienteModule;
using Uniplac.ePomar.Aplicacao.ClienteModule;

namespace Uniplac.ePomar.WindowsApp.Controls.ClienteForms
{
    public partial class ClienteControl : UserControl
    {
        private readonly IClienteService _service = null;

        public ClienteControl()
        {
            InitializeComponent();
        }

        public ClienteControl(IClienteService service) : this()
        {
            _service = service;
        }

        public Cliente GetCliente()
        {
            return listClientes.SelectedItem as Cliente;
        }

        public void RefreshGrid()
        {
            var clientes = _service.GetAll();

            listClientes.Items.Clear();

            foreach (var Cliente in clientes)
            {
                listClientes.Items.Add(Cliente);
            }
        }
    }
}
