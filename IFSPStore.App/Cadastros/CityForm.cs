using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
namespace IFSPStore.App.Cadastros
{
    public partial class CityForm : BaseForm
    {
        private IBaseService<City> _cityService;
        private List<City> cities;
        public CityForm(IBaseService<City> cityService)
        {
            _cityService = cityService;
            InitializeComponent();
        }
        private void preencheObject(City city)
        {
            city.Name = txtName.Text;
            city.State = cboDistrict.Text;
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var city = _cityService.GetById<City>(id);
                       preencheObject(city);
                        city = _cityService.Update<City, City, CityValidator>(city);
                    }
                }
                else
                {
                    var city = new City();
                    preencheObject(city);
                    _cityService.Add<City, City, CityValidator>(city);

                }
                tabControlRegister.SelectedIndex = 1;
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Delete(int id)
        {
            try
            {
                _cityService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            cities = _cityService.Get<City>().ToList();
            dataGridViewList.DataSource = cities;
            dataGridViewList.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void loadList(DataGridViewRow? linha)
        {
            //aqui deve estar do mesmo jeito que o nome das colunas do datagridview
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Name"].Value.ToString();
            cboDistrict.Text = linha?.Cells["State"].Value.ToString();
        }
    }
}
