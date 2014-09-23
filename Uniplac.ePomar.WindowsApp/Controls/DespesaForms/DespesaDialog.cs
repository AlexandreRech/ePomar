using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Modelo.DespesaModule;
using Uniplac.ePomar.Modelo.FornecedorModule;
using Uniplac.ePomar.WindowsApp.Controls.Extensions;

namespace Uniplac.ePomar.WindowsApp.Controls.DespesaForms
{
    public partial class DespesaDialog : Form
    {
        private Despesa _despesa;

        public DespesaDialog(List<Fornecedor> fornecedores)
        {
            InitializeComponent();
            cmbFornecedor.Items.OverrideAll(fornecedores);
        }


        public Despesa Despesa
        {
            get { return _despesa; }

            set
            {
                _despesa = value;


                txtId.Text = _despesa.Id.ToString();
                txtDescricao.Text = _despesa.Descricao;
                nudValor.Value = Convert.ToInt32(_despesa.Valor);
                dtPagamento.MinDate = Convert.ToDateTime(_despesa.DataPagamento);
                cmbTpPagamento.Text = _despesa.TipoPagamento;
                cmbCategoria.Text = _despesa.Categoria;
                txtObs.Text = _despesa.ObservaçõesFornecedor;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _despesa.Id = Convert.ToInt32(txtId.Text);
                _despesa.Descricao = txtDescricao.Text;
                _despesa.Valor = Convert.ToInt32(nudValor.Value);
                _despesa.DataPagamento = Convert.ToDateTime(dtPagamento.Value);
                _despesa.TipoPagamento = cmbTpPagamento.Text;
                _despesa.Categoria = cmbCategoria.Text;
                _despesa.Fornecedor = cmbFornecedor.SelectedItem as Fornecedor;
                _despesa.ObservaçõesFornecedor = txtObs.Text;

                _despesa.Valida();
            }
            catch (ArgumentNullException exc)
            {
                Principal.Instance.ShowMessageInFooter(exc.Message);

                DialogResult = DialogResult.None;
            }
        }
    }
}
