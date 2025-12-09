using ConsultorioIFSP.Domain.Base;
using IFSPStore.App.Base;


namespace IFSPStore.App.Cadastros
{
    // A classe agora foca em consultar e exibir dados, não em edição ou salvamento.
    public partial class ConsultaProdutoForm : BaseForm
    {
        private readonly IBaseService<Product> _productService;
        private readonly IBaseService<Category> _categoryService; // Mantido para carregar o ComboBox de filtros

        // Lista de produtos para a grade.
        private List<ProductModel>? products;

        // Os controles de filtro (txtId, cboCategory, etc.) são esperados no Designer.
        // O controle de resultados (dataGridViewList) também é esperado.

        public ConsultaProdutoForm(IBaseService<Product> productService, IBaseService<Category> categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            InitializeComponent();

            // Carrega os dados da grade e o ComboBox ao iniciar.
            loadCombo();
            CarregaGrid();

            // Configurações de UI: um formulário de consulta geralmente começa na aba de lista.
            // tabControlRegister.SelectedIndex = 0; // Se você tiver abas
        }

        private void loadCombo()
        {
            // O combo box é usado aqui como um filtro de Categoria.
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";

            // Adiciona uma opção "Todos" no início do ComboBox de filtro
            var categories = _categoryService.Get<CategoryModel>().ToList();
            categories.Insert(0, new CategoryModel { Id = 0, Name = "Todas as Categorias" });

            cboCategory.DataSource = categories;
        }

        // -----------------------------------------------------------------
        // Métodos de Consulta/Filtro
        // -----------------------------------------------------------------

        // Adaptação da função CarregaGrid para aceitar filtros.
        protected override void CarregaGrid()
        {
            // Este método será chamado na inicialização e pelo botão 'Consultar'.
            try
            {
                // 1. Coleta os Filtros da Tela
                int? idFiltro = null;
                if (int.TryParse(txtId.Text, out int id))
                {
                    idFiltro = id;
                }

                int? idCategoriaFiltro = null;
                // Verifica se há um SelectedValue e se ele não é a opção "Todas as Categorias" (Id=0)
                if (cboCategory.SelectedValue != null &&
                    int.TryParse(cboCategory.SelectedValue.ToString(), out int idCat) &&
                    idCat > 0)
                {
                    idCategoriaFiltro = idCat;
                }

                // **Filtro de Status/Ativo:** // Assumindo que você tem RadioButtons: rbAtivoSim, rbAtivoNao, rbAtivoTodos
                bool? ativoFiltro = null;
                if (rbAtivoSim.Checked)
                {
                    ativoFiltro = true;
                }
                else if (rbAtivoNao.Checked)
                {
                    ativoFiltro = false;
                }
                // Se rbAtivoTodos estiver checado, 'ativoFiltro' permanece 'null', buscando todos.

                // 2. Chama a função de busca com os filtros
                products = BuscarProdutos(idFiltro, idCategoriaFiltro, ativoFiltro).ToList();

                // 3. Exibe Resultados
                dataGridViewList.DataSource = products;

                // Esconde a coluna de ID de Categoria, se ela existir no ProductModel
                dataGridViewList.Columns["IdCategory"]!.Visible = false;

                // Opcional: Exibir uma mensagem de status.
                // lblStatus.Text = $"Encontrados {products.Count} registros.";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar/filtrar dados: " + ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que realiza a filtragem na memória (se a lista for pequena) ou chama um método filtrado do serviço.
        private IEnumerable<ProductModel> BuscarProdutos(int? id, int? idCategory, bool? ativo)
        {
            // Idealmente, esta busca deveria ser feita no banco de dados (no serviço): 
            // return _productService.Get<ProductModel>(p => p.Id == id && p.CategoryId == idCategory && p.Active == ativo);

            // Para simplificar e demonstrar a lógica no Form, simulamos a busca completa e filtramos.
            // Atenção: Este método é ineficiente para grandes volumes de dados!
            var todosProdutos = _productService.Get<ProductModel>(new[] { "Category" });

            var query = todosProdutos.AsQueryable();

            if (id.HasValue)
            {
                query = query.Where(p => p.Id == id.Value);
            }

            if (idCategory.HasValue)
            {
                query = query.Where(p => p.Category.Id == idCategory.Value);
            }

            // Assumindo que ProductModel tem uma propriedade 'IsActive' ou similar
            // if (ativo.HasValue)
            // {
            //     query = query.Where(p => p.IsActive == ativo.Value);
            // }

            return query.ToList();
        }

        // -----------------------------------------------------------------
        // Sobrescrita de Métodos de Ação (Apenas para Reverter a Ação Padrão)
        // -----------------------------------------------------------------

        // O método Save não é necessário em um formulário de consulta, por isso ele pode ser removido 
        // ou deixar vazio se for exigido pela BaseForm.
        // protected override void Save() { /* Não faz nada */ }

        // O método Delete não é necessário em um formulário de consulta.
        // protected override void Delete(int id) { /* Não faz nada */ }

        // O loadList só é útil se a consulta permitir dar dois cliques para abrir a edição,
        // mas em um formulário puro de consulta, ele é desnecessário.
        // protected override void loadList(DataGridViewRow? linha) { /* Não faz nada */ }

        // -----------------------------------------------------------------
        // Manipuladores de Eventos (Botões)
        // -----------------------------------------------------------------

        // Você precisará de um botão no seu designer (btnFiltrar ou btnConsultar)
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregaGrid(); // Chama o método de filtro principal
        }

        // Você precisará de um botão para limpar (btnLimparFiltros)
        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            cboCategory.SelectedIndex = 0; // Volta para "Todas as Categorias"
            // rbAtivoTodos.Checked = true; // Se usar RadioButtons
            CarregaGrid(); // Recarrega a grade sem filtros
        }

    }
}