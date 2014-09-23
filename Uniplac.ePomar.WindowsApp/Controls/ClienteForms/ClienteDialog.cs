using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Modelo.ClienteModule;

namespace Uniplac.ePomar.WindowsApp.Controls.ClienteForms
{
    public partial class ClienteDialog : Form
    {
        private Cliente _cliente;

        public ClienteDialog()
        {
            InitializeComponent();
        }

        public Cliente Cliente
        {
            get { return _cliente; }

            set
            {
                _cliente = value;


                txtId.Text = _cliente.Id.ToString();
                txtNome.Text = _cliente.Nome;
                txtContato.Text = _cliente.Contato;
                txtNota.Text = _cliente.Nota;

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                _cliente.Id = Convert.ToInt32(txtId.Text);
                _cliente.Nome = txtNome.Text;
                _cliente.Contato = txtContato.Text;
                _cliente.Nota = txtNota.Text;

                _cliente.Valida();
            }
            catch (ArgumentNullException exc)
            {
                Principal.Instance.ShowMessageInFooter(exc.Message);

                DialogResult = DialogResult.None;
            }
        }
    
}
}
