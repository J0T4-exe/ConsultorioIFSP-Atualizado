using ConsultaIFSP.App.Base;
using ConsultorioIFSP.Domain.Base;

namespace ConsultorioIFSP.App.Cadastros
{
    // A classe ConsultaForm herda de BaseForm, focada apenas em listagem/filtragem.
    public partial class ConsultaForm : BaseForm
    {
        private readonly IBaseService<Product> _productService;
        private private readonly IBaseService<Category> _categoryService;

        private List<ProductModel>? products;

        // Construtor: Injeção de dependência dos serviços.
        public ConsultaForm(IBaseService<Product> productService, IBaseService<Category> categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            InitializeComponent();

            loadCombo();
            // Carrega a grade com os dados iniciais.
            CarregaGrid();
        }

        // Carrega o ComboBox de filtro com as categorias
        private void loadCombo()
        {
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";

            var categories = _categoryService.Get<CategoryModel>().ToList();

            // Adiciona a opção "Todas as Categorias" no início
            categories.Insert(0, new CategoryModel { Id = 0, Name = "Todas" });

            cboCategory.DataSource = categories;
            cboCategory.SelectedIndex = 0; // Padrão: Todas
        }

        // -----------------------------------------------------------------
        // Métodos de Consulta
        // -----------------------------------------------------------------

        // Método principal sobrescrito que coleta os filtros e carrega a grade.
        protected override void CarregaGrid()
        {
            try
            {
                // 1. Coleta e sanitiza os Filtros da Tela
                int? idFiltro = null;
                if (int.TryParse(txtId.Text, out int id) && id > 0)
                {
                    idFiltro = id;
                }

                string nomeFiltro = txtName.Text.Trim();

                int? idCategoriaFiltro = null;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar/filtrar dados: " + ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Realiza a filtragem dos dados usando Linq
        private IEnumerable<ProductModel> BuscarProdutosFiltrados(int? id, string nome, int? idCategory)
        {
            // Busca a lista de produtos, incluindo o objeto Category
            var query = _productService.Get<ProductModel>(new[] { "Category" }).AsQueryable();

            if (id.HasValue)
            {
                query = query.Where(p => p.Id == id.Value);
            }

            if (!string.IsNullOrEmpty(nome))
            {
                // Filtra por nome (case-insensitive para melhor usabilidade)
                query = query.Where(p => p.Name.ToLower().Contains(nome.ToLower()));
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

        protected override void Save() { } // Desabilitado
        protected override void Delete(int id) { } // Desabilitado
        protected override void loadList(DataGridViewRow? linha) { } // Desabilitado

        // -----------------------------------------------------------------
        // Manipuladores de Eventos (Associados no Designer)
        // -----------------------------------------------------------------

        // Método associado ao Click do botão de Consultar/Filtrar
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        // Método para Limpar os campos de filtro e recarregar
        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            cboCategory.SelectedIndex = 0; // Volta para "Todas"
            CarregaGrid();
        }
    }
}