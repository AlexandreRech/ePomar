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
using Uniplac.ePomar.Modelo.ReceitaModule;
using Uniplac.ePomar.WindowsApp.Controls.Extensions;


namespace Uniplac.ePomar.WindowsApp.Controls.ReceitaForms
{
    public partial class ReceitaDialog : Form
    {
        private Receita _receita;

        public ReceitaDialog(List<Cliente> clientes)
        {
            InitializeComponent();
            cmbCliente.Items.OverrideAll(clientes);
        }

        public Receita Receita
        {
            get { return _receita; }

            set
            {
                _receita = value;


                txtId.Text = _receita.Id.ToString();
                txtDescricao.Text = _receita.Descricao;
                nudValor.Value = Convert.ToInt32(_receita.Valor);
                dtpRecebimento.MinDate = Convert.ToDateTime(_receita.DataRecebimento);
                cmbTpPagamento.Text = _receita.TipoPagamento;
                cmbCategoria.Text = _receita.Categoria;
                txtObs.Text = _receita.ObservacoesCliente;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _receita.Id = Convert.ToInt32(txtId.Text);
                _receita.Descricao = txtDescricao.Text;
                _receita.Valor = Convert.ToInt32(nudValor.Value);
                _receita.DataRecebimento = Convert.ToDateTime(dtpRecebimento.Value);
                _receita.TipoPagamento = cmbTpPagamento.Text;
                _receita.Categoria = cmbCategoria.Text;
                _receita.Cliente = cmbCliente.SelectedItem as Cliente;
                _receita.ObservacoesCliente = txtObs.Text;

                _receita.Valida();
            }
            catch (ArgumentNullException exc)
            {
                Principal.Instance.ShowMessageInFooter(exc.Message);

                DialogResult = DialogResult.None;
            }
        }

       
    }
}
