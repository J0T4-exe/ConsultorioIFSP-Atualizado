using ConsultaIFSP.App.Base;
using ConsultorioIFSP.App.Models;
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;
namespace ConsultorioIFSP.App.Cadastros
{
    // Herda a classe base não genérica (BaseForm ou CadastroBase)
    public partial class ReceitaForm : BaseForm
    {
        // 1. Serviço e Lista específicos injetados
        private readonly IBaseService<Receita> _receitaService;
        private List<ReceitaModel>? receitas;

        // 2. Construtor para Injeção de Dependência
        public ReceitaForm(IBaseService<Receita> receitaService) : base()
        {
            _receitaService = receitaService;
            InitializeComponent();
        }

        // Método auxiliar para mapear UI -> Objeto
        private void PreencheObjeto(Receita receita)
        {
            // ATENÇÃO: Os campos txtPeriodo e txtQuantidade são esperados na UI

            // Periodo (DateTime)
            if (DateTime.TryParse(txtPeriodo.Text, out DateTime periodo))
            {
                receita.Periodo = periodo;
            }
            else
            {
                throw new Exception("Data de Período inválida.");
            }

            // Quantidade (int)
            if (int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                receita.Quantidade = quantidade;
            }
            else
            {
                throw new Exception("Quantidade inválida.");
            }
        }

        protected override void CarregaGrid()
        {
            try
            {
                // Carrega ReceitaModel para exibição (depende do AutoMapper)
                receitas = _receitaService.Get<ReceitaModel>().ToList();
                // Assumindo que o nome da DataGridView é dataGridViewConsulta
                dataGridViewList.DataSource = receitas;

                // Ajuste de coluna
                dataGridViewList.Columns["Periodo"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            // Mapeia os dados da linha selecionada para os campos do formulário para o modo "Editar"
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtPeriodo.Text = linha?.Cells["Periodo"].Value.ToString();
            txtQuantidade.Text = linha?.Cells["Quantidade"].Value.ToString();
        }
    }
}