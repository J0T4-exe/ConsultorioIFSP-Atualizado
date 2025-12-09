using ConsultorioIFSP.Domain.Base;
using IFSPStore.App.Base;

namespace IFSPStore.App.Cadastros
{
    // A classe ConsultaProdutoForm herda de BaseForm, mas ignora métodos de edição/salvamento.
    public partial class ConsultaProdutoForm : BaseForm
    {
        private readonly IBaseService<Product> _productService;
        private readonly IBaseService<Category> _categoryService;

        private List<ProductModel>? products;

        // Construtor: Injeção de dependência dos serviços necessários
        public ConsultaProdutoForm(IBaseService<Product> productService, IBaseService<Category> categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            InitializeComponent();

            loadCombo();
            // Carrega a grade com todos os dados na inicialização.
            CarregaGrid();
        }

        // Carrega o ComboBox de filtro com as categorias
        private void loadCombo()
        {
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";

            var categories = _categoryService.Get<CategoryModel>().ToList();

            // Adiciona a opção "Todas as Categorias" no início da lista para o filtro
            categories.Insert(0, new CategoryModel { Id = 0, Name = "Todas" });

            cboCategory.DataSource = categories;
            cboCategory.SelectedIndex = 0; // Seleciona "Todas" como padrão.
        }

        // -----------------------------------------------------------------
        // Métodos de Ação (Consulta)
        // -----------------------------------------------------------------

        // Método principal sobrescrito que coleta os filtros e carrega a grade.
        protected override void CarregaGrid()
        {
            try
            {
                // 1. Coleta e sanitiza os Filtros da Tela (Assumindo txtId, txtName, cboCategory)

                int? idFiltro = null;
                if (int.TryParse(txtId.Text, out int id) && id > 0)
                {
                    idFiltro = id;
                }

                string nomeFiltro = txtName.Text.Trim();

                int? idCategoriaFiltro = null;
                // Aplica filtro de categoria somente se um ID > 0 for selecionado
                if (cboCategory.SelectedValue != null &&
                    int.TryParse(cboCategory.SelectedValue.ToString(), out int idCat) &&
                    idCat > 0)
                {
                    idCategoriaFiltro = idCat;
                }

                // 2. Executa a busca filtrada
                products = BuscarProdutosFiltrados(idFiltro, nomeFiltro, idCategoriaFiltro).ToList();

                // 3. Exibe Resultados
                dataGridViewList.DataSource = products;

                // Oculta colunas de IDs internos
                if (dataGridViewList.Columns.Contains("IdCategory"))
                {
                    dataGridViewList.Columns["IdCategory"]!.Visible = false;
                }

                // Opcional: lblStatus.Text = $"Encontrados {products.Count} registros.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar/filtrar dados: " + ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Realiza a filtragem dos dados usando Linq
        private IEnumerable<ProductModel> BuscarProdutosFiltrados(int? id, string nome, int? idCategory)
        {
            // Busca a lista de produtos, incluindo o objeto Category (usado para o filtro e exibição)
            var query = _productService.Get<ProductModel>(new[] { "Category" }).AsQueryable();

            if (id.HasValue)
            {
                query = query.Where(p => p.Id == id.Value);
            }

            if (!string.IsNullOrEmpty(nome))
            {
                // Filtra por nome, verificando se contém a string inserida
                query = query.Where(p => p.Name.Contains(nome));
            }

            if (idCategory.HasValue)
            {
                query = query.Where(p => p.Category.Id == idCategory.Value);
            }

            return query;
        }

        // -----------------------------------------------------------------
        // Sobrescrita e Desabilitação de Métodos de CRUD
        // -----------------------------------------------------------------

        // Desabilita o método Save
        protected override void Save()
        {
            // Não faz nada, pois é um formulário de consulta.
        }

        // Desabilita o método Delete
        protected override void Delete(int id)
        {
            // Não faz nada, pois é um formulário de consulta.
        }

        // Desabilita o método loadList (ou adapte para abrir edição, se for o caso)
        protected override void loadList(DataGridViewRow? linha)
        {
            // Não preenche os campos do formulário (que neste contexto seriam campos de edição).
        }

        // -----------------------------------------------------------------
        // Manipuladores de Eventos (Assumidos no Designer)
        // -----------------------------------------------------------------

        // Este método deve ser associado ao Click do botão de Consultar/Filtrar
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        // Opcional: Método para Limpar os campos de filtro e recarregar
        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            cboCategory.SelectedIndex = 0; // Volta para "Todas"
            CarregaGrid(); // Recarrega a grade sem filtros
        }
    }
}