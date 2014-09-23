using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.Modelo.ProdutoModule;

namespace Uniplac.ePomar.WindowsApp.Controls.ProdutoForms
{
    public partial class ProdutoDialog : Form
    {
        private Produto _produto;

        public ProdutoDialog()
        {
            InitializeComponent();
        }

        public Produto Produto
        {
            get { return _produto; }

            set
            {
                _produto = value;


                txtId.Text = _produto.Id.ToString();
                txtDescricao.Text = _produto.Descricao;               
                nupValor.Value = Convert.ToInt32(_produto.Valor);
                dtpValidade.MinDate = Convert.ToDateTime(_produto.Validade);
                nupQuantidade.Text = _produto.Quantidade.ToString();
                txtNome.Text = _produto.Nome;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _produto.Id = Convert.ToInt32(txtId.Text);
                _produto.Descricao = txtDescricao.Text;
                _produto.Valor = Convert.ToInt32(nupValor.Value);
                _produto.Validade = Convert.ToDateTime(dtpValidade.Value);
                _produto.Quantidade = Convert.ToInt32(nupQuantidade.Text);
                _produto.Nome = txtNome.Text;

                _produto.Valida();
            }
            catch (ArgumentNullException exc)
            {
                Principal.Instance.ShowMessageInFooter(exc.Message);

                DialogResult = DialogResult.None;
            }
        }
               
    }
}
