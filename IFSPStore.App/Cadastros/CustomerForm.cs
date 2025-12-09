using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
using MySqlX.XDevAPI;

namespace IFSPStore.App.Cadastros
{
    public partial class CustomerForm : BaseForm
    {
        private readonly IBaseService<Customer> _customerService;
        private readonly IBaseService<City> _cityService;

        private List<CustomerModel>? customers;
        public CustomerForm(IBaseService<Customer> clienteService, IBaseService<City> cidadeService)
        {
            _customerService = clienteService;
            _cityService = cidadeService;
            InitializeComponent();
            loadCombo();
        }
        private void loadCombo()
        {
            cboCity.ValueMember = "Id";
            cboCity.DisplayMember = "Name";
            cboCity.DataSource = _cityService.Get<CityModel>().ToList();
        }
        private void preencheObject(Customer customer)
        {
            customer.Nome = txtName.Text;
            customer.Address = txtAdress.Text;
            customer.District = txtDistrict.Text;
            customer.DocumentId = txtDocument.Text;
            if (int.TryParse(cboCity.SelectedValue?.ToString(), out var idCity))
                {
                //var city = _cityService.GetById<City>(idCategory);
                customer.CityId = idCity;
                customer.City = null;
                }
        }
        protected override void Save()
        {
            try 
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var customer = _customerService.GetById<Customer>(id);
                        preencheObject(customer);
                        _customerService.Update<Customer, Customer, CustomerValidator>(customer);
                    }
                } else
                {
                    var customer = new Customer();
                    preencheObject(customer);
                    _customerService.Add<Customer, Customer, CustomerValidator>(customer);
                }
                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Delete(int id)
        {
            try 
            {
                _customerService.Delete(id);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            customers = _customerService.Get<CustomerModel>(new[] { "City" }).ToList();
            dataGridViewList.DataSource = customers;
            dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["IdCity"]!.Visible = false;
        }
        protected override void loadList(DataGridViewRow? record)
        {
           txtId.Text = record!.Cells["Id"].Value.ToString();
           txtName.Text = record.Cells["Name"].Value.ToString();
           txtAdress.Text = record.Cells["Address"].Value.ToString();
           txtDistrict.Text = record.Cells["District"].Value.ToString();
           txtDocument.Text = record.Cells["Document"].Value?.ToString();
           cboCity.SelectedValue = record.Cells["IdCity"].Value;
        }
    }
}
