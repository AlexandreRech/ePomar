using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniplac.ePomar.WindowsApp.Controls.ClienteForms;
using Uniplac.ePomar.WindowsApp.Controls.DespesaForms;
using Uniplac.ePomar.WindowsApp.Controls.FornecedorForms;
using Uniplac.ePomar.WindowsApp.Controls.ProdutoForms;
using Uniplac.ePomar.WindowsApp.Controls.ReceitaForms;
using Uniplac.ePomar.WindowsApp.Controls.RelatorioForms;
using Uniplac.ePomar.WindowsApp.Controls.Shared;

namespace Uniplac.ePomar.WindowsApp
{
    public partial class Principal : Form
    {
        private static Principal _instance;
        private IDataManager _dataManager;
        private UserControl _control;
        Timer time = new Timer();

        public Principal()
        {
            InitializeComponent();
            _instance = this;
        }

        public static Principal Instance
        {
            get
            {
                return _instance;
            }
        }

        public void ShowMessageInFooter(string message)
        {
            lblStatus.Text = message;
        }

        /// <summary>
        /// O Método LoadDataManager() é responsável por definir o contexto de cadastro da tela principal,
        /// ou seja, quando o usuário seleciona uma opção da barra de menu, esta operação carrega o UserControl
        /// correspondente, atualiza o título da janela e também os Tooltips dos botões.
        /// </summary>
        /// <param name="manager"></param>
        private void LoadDataManager(IDataManager manager)
        {
            try
            {
                if (_dataManager != null && _dataManager.GetType() == manager.GetType())
                    return;

                if (_control != null)
                {
                    panControl.Controls.Clear();
                }

                _dataManager = manager;

                _control = _dataManager.GetControl();

                _control.Dock = DockStyle.Fill;

                panControl.Controls.Add(_control);

                tituloLabel.Text = _dataManager.GetDescription();

                btnAdd.ToolTipText = _dataManager.GetToolTipMessage().Add;
                btnEdit.ToolTipText = _dataManager.GetToolTipMessage().Edit;
                btnReport.ToolTipText = _dataManager.GetToolTipMessage().Delete;

                toolbar.Enabled = _dataManager != null;
            }
            catch (Exception be)
            {
                MessageBox.Show(be.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _dataManager.AddData();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                _dataManager.EditData();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                _dataManager.ReportData();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _dataManager.DeleteData();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void fornecedoresMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataManager(new FornecedorDataManagerImpl());
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataManager(new ReceitaDataManagerImpl());
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataManager(new DespesaDataManagerImpl());
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataManager(new ProdutoDataManagerImpl());
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {                    
        
            LoadDataManager(new ClienteDataManagerImpl());
       
         }

        private void button1_Click(object sender, EventArgs e)
        {
            
                RelatorioProdutosDialog relatorioProdutos = new RelatorioProdutosDialog();
                relatorioProdutos.ShowDialog();            

           
        }

       

            
    }
}
    

