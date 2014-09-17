using System.Windows.Forms;
using Uniplac.ePomar.Aplicacao.FornecedorModule;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.WindowsApp.Controls.FornecedorForms
{
    public partial class FornecedorControl : UserControl
    {

        private readonly IFornecedorService _service = null;
        
        public FornecedorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// É responsável por definir o repositório do UserControl
        /// Este método é chamado no constructor da classe FornecedorDataManager
        ///</summary>
        /// <param name="service"></param>
        public FornecedorControl(IFornecedorService service) : this()
        {
            _service = service;
        }

        /// <summary>
        /// É responsável por retornar a Fornecedor que está selecionada no ListBox
        /// Esta função é chamada nos métodos EditData e DeleteData da classe FornecedorDataManager
        /// </summary>
        /// <returns></returns>
        public Fornecedor GetFornecedor()
        {
            return listFornecedores.SelectedItem as Fornecedor;
        }

        /// <summary>
        /// É responsável por atualizar as Fornecedors que estão sendo mostradas no ListBox
        /// Esta função é chamada nos métodos AddData, EditData, DeleteData e na primeira vez
        /// que passa pelo método GetControl da classe FornecedorDataManager
        /// </summary>
        /// <returns></returns>
        public void RefreshGrid()
        {
            var fornecedores = _service.GetAll();

            listFornecedores.Items.Clear();

            foreach (var Fornecedor in fornecedores)
            {
                listFornecedores.Items.Add(Fornecedor);
            }
        }

        
    }
}