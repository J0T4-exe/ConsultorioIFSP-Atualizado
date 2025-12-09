using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;

namespace IFSPStore.App.Cadastros
{
    public partial class CategoryForm : BaseForm
    {
        private readonly IBaseService<Category> _categoryService;
        private List<CategoryModel>? categories;
        public CategoryForm(IBaseService<Category> categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
        }
        private void FormToObject(Category category)
        {
            category.Name = txtName.Text;
            category.Description = txtDescription.Text;
        }
        protected override void Save()
        {
            try {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var category = _categoryService.GetById<Category>(id);
                    FormToObject(category);
                    category = _categoryService.Update<Category, Category,
                        CategoryValidator>(category);
                } else
                {
                    var category = new Category();
                    FormToObject(category);
                    category = _categoryService.Add<Category, Category, CategoryValidator>(category);
                }
                tabControlRegister.SelectedIndex = 1;
                CarregaGrid();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _categoryService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            try
            {
                categories = _categoryService.Get<CategoryModel>().ToList();
                dataGridViewList.DataSource = categories;
                dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
            txtDescription.Text = record?.Cells["Description"].Value.ToString();
        }
    }
}
