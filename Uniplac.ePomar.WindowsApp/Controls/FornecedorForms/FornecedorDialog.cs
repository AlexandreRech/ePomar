using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.WindowsApp.Controls.FornecedorForms
{
    public partial class FornecedorDialog : Form
    {
        private Fornecedor _fornecedor;

        public FornecedorDialog()
        {
            InitializeComponent();
        }

        public Fornecedor Fornecedor
        {
            get { return _fornecedor; }

            set
            {
                _fornecedor = value;

                
                txtId.Text = _fornecedor.Id.ToString();
                txtNome.Text = _fornecedor.Nome;
               
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                
                _fornecedor.Id = Convert.ToInt32(txtId.Text);
                _fornecedor.Nome = txtNome.Text;
                
                _fornecedor.Valida();
            }
            catch (ArgumentNullException exc)
            {
                Principal.Instance.ShowMessageInFooter(exc.Message);

                DialogResult = DialogResult.None;
            }

        }
    }
}