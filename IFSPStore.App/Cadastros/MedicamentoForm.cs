using ConsultorioIFSP.App.Models;
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities; // Importa a entidade Medicamento
using ConsultorioIFSP.Domain.Validators;
using IFSPStore.App.Base;

namespace IFSPStore.App.Cadastros
{
    public partial class MedicamentoForm : BaseForm
    {
        // 1. Mudança de serviço: IBaseService<Product> -> IBaseService<Medicamento>
        private readonly IBaseService<Medicamento> _medicamentoService;

        // 2. Remoção de dependências de Product/Category
        // private readonly IBaseService<Category> _categoryService; // Removido

        // 3. Mudança do modelo de lista
        private List<MedicamentoModel>? medicamentos;

        // 4. Mudança do Construtor para aceitar apenas o serviço de Medicamento
        public MedicamentoForm(IBaseService<Medicamento> medicamentoService)
        {
            _medicamentoService = medicamentoService;
            InitializeComponent();

            // Removendo lógica de Produto/Venda
            // loadCombo(); // Removido
            // txtSaleDate.Text = DateTime.Now.ToString("d"); // Removido
        }

        // Removendo loadCombo, pois Medicamento não tem relação com Categoria.
        /* private void loadCombo()
         {
             // ...
         } */

        // 5. Adaptação do método para preencher o objeto Medicamento
        private void PreencheObject(Medicamento medicamento)
        {
            medicamento.Nome = txtName.Text;

            // Assumindo que você tem um campo 'txtNomeGenerico' para a propriedade 'Nome_Generico'
            // Nota: Se a propriedade Nome_Generico for mapeada como String no banco (MedicamentoMap.cs), 
            // este uso é correto.
            medicamento.Nome_Generico = txtNomeGenerico.Text;

            // Removendo todas as propriedades de Produto: Price, PurchaseDate, SalesUnit, Quantity, CategoryId.
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var medicamento = _medicamentoService.GetById<Medicamento>(id);
                        PreencheObject(medicamento);

                        // Usando Medicamento e MedicamentoValidator (assumido existir)
                        medicamento = _medicamentoService.Update<Medicamento, Medicamento, MedicamentoValidator>(medicamento);
                    }
                }
                else
                {
                    var medicamento = new Medicamento();
                    PreencheObject(medicamento);

                    // Usando Medicamento e MedicamentoValidator (assumido existir)
                    _medicamentoService.Add<Medicamento, Medicamento, MedicamentoValidator>(medicamento);

                }
                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                // Alterado para refletir o nome do projeto
                MessageBox.Show(ex.Message, @"Consultorio IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                // Usando _medicamentoService
                _medicamentoService.Delete(id);
            }
            catch (Exception ex)
            {
                // Alterado para refletir o nome do projeto
                MessageBox.Show(ex.Message, @"Consultorio IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            // Usando MedicamentoModel (assumido existir, sem includes)
            medicamentos = _medicamentoService.Get<MedicamentoModel>().ToList();
            dataGridViewList.DataSource = medicamentos;

            // Configurando as colunas para as propriedades de Medicamento
            dataGridViewList.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Assumindo que o MedicamentoModel tem a propriedade Nome_Generico
            dataGridViewList.Columns["Nome_Generico"]!.HeaderText = "Nome Genérico";

            // Removendo a linha de coluna invisível de produto:
            // dataGridViewList.Columns["IdCategory"]!.Visible = false;
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            // Mapeando dados do grid para os campos de Medicamento
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Nome"].Value.ToString();

            // Assumindo txtNomeGenerico
            txtNomeGenerico.Text = linha?.Cells["Nome_Generico"].Value.ToString();

        }
    }
}