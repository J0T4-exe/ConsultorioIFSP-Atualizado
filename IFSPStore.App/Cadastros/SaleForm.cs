using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
using MySqlX.XDevAPI;
using System.Globalization;
using System.Xml.Linq;

namespace IFSPStore.App.Cadastros
{
    public partial class SaleForm : BaseForm
    {
        private List<SaleItemModel> _saleItems = new List<SaleItemModel>();
        private readonly IBaseService<Sale> _saleService;
        private readonly IBaseService<User> _userService;
        private readonly IBaseService<Customer> _customerService;
        private readonly IBaseService<Product> _productService;
        private readonly IBaseService<Category> _categoryService;

        private List<SaleModel>? sales;
        public SaleForm(IBaseService<Sale> saleService,
                             IBaseService<User> userService,
                             IBaseService<Customer> customerService,
                             IBaseService<Product> productServic,
                             IBaseService<Category> categoryService)
        {
            _saleService = saleService;
            _userService = userService;
            _customerService = customerService;
            _productService = productServic;
            _categoryService = categoryService;
            InitializeComponent();
            _saleItems = new List<SaleItemModel>();
            loadCombo();
            CarregaGridItensSale();
            New();
            txtSaleDate.Text = DateTime.Now.ToString("d");
        }
        private void loadCombo()
        {
            cboUser.ValueMember = "Id";
            cboUser.DisplayMember = "Name";
            cboUser.DataSource = _userService.Get<User>().ToList();

            cboCustomer.ValueMember = "Id";
            cboCustomer.DisplayMember = "Nome";
            cboCustomer.DataSource = _customerService.Get<Customer>().ToList();

            cboProduct.ValueMember = "Id";
            cboProduct.DisplayMember = "Name";
            cboProduct.DataSource = _productService.Get<Product>().ToList();

            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";
            cboCategory.DataSource = _categoryService.Get<Category>().ToList();
        }
        private void PreencheObject(Sale sale)
        {
            if (DateTime.TryParse(txtSaleDate.Text, out var saleDate))
            {
                sale.SaleDate = saleDate;
            }

            if (cboUser.SelectedValue != null && int.TryParse(cboUser.SelectedValue.ToString(), out var idUser))
            {
                sale.SalesmanId = idUser;
                sale.Salesman = null;
            }

            if (cboCustomer.SelectedValue != null && int.TryParse(cboCustomer.SelectedValue.ToString(), out var idCustomer))
            {
                sale.CustomerId = idCustomer;
                sale.Customer = null;
            }

            sale.SaleTotal = _saleItems.Sum(x => x.TotalPrice);

            sale.SaleItens.Clear();
            foreach (var item in _saleItems)
            {
                var itemSale = new SaleItem
                {
                    Sale = sale,
                    ProductId = item.IdProduct,
                    Product = null,
                    
                    UnitPrice = item.UnitPrice,
                    Quantity = item.Quantity,
                    TotalPrice = item.TotalPrice
                };

                sale.SaleItens.Add(itemSale);
            }
            CalculateTotalSale(); 
            CarregaGridItensSale();
        }
        protected override void New()
        {
            base.New();
            _saleItems.Clear();
            CarregaGridItensSale();
            txtSaleDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var sale = _saleService.GetById<Sale>(id);
                        PreencheObject(sale);
                        sale = _saleService.Update<Sale, Sale, SaleValidator>(sale);
                    }
                }
                else
                {
                    var sale = new Sale();
                    PreencheObject(sale);
                    sale = _saleService.Add<Sale, Sale, SaleValidator>(sale);
                }
                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Delete(int id)
        {
            try
            {
                _saleService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            var includes = new List<string>() { "Customer", "Salesman", "SaleItens" };
            sales = _saleService.Get<SaleModel>(includes).ToList();
            dataGridViewList.DataSource = sales;
            dataGridViewList.Columns["IdUser"]!.Visible = false;
            dataGridViewList.Columns["IdCustomer"]!.Visible = false;
            if (dataGridViewList.Columns.Contains("Salesman"))
            {
                dataGridViewList.Columns["Salesman"]!.Visible = false;
            }
            dataGridViewList.Columns["Quantity"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewList.Columns["User"]!.HeaderText = "Salesman";
            dataGridViewList.Columns["SaleTotal"]!.DefaultCellStyle.Format = "C2"; // Formata como moeda
            dataGridViewList.Columns["SaleDate"]!.HeaderText = "Data Venda";
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridViewList.Columns["Price"].DefaultCellStyle.Format = "C2";
            //dataGridViewList.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        protected override void loadList(DataGridViewRow? linha)
        {
            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            cboUser.SelectedValue = linha?.Cells["IdUser"].Value;
            cboCustomer.SelectedValue = linha?.Cells["IdCustomer"].Value;
            txtSaleDate.Text = DateTime.TryParse(linha?.Cells["SaleDate"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";

            var includes = new List<string>() { "Customer", "Salesman", "SaleItens", "SaleItens.Product" };
            var sale = _saleService.GetById<Sale>(id, includes);
            _saleItems = new List<SaleItemModel>();
            foreach (var item in sale.SaleItens)
            {
                var vendaItem = new SaleItemModel
                {
                    Id = item.Id,
                    IdProduct = item.Product!.Id,
                    Product = item.Product!.Name,
                    TotalPrice = item.TotalPrice,
                    Quantity = item.Quantity,
                    SaleUnit = item.UnitPrice.ToString("N2"),
                };
                _saleItems.Add(vendaItem);
            }
            CarregaGridItensSale();

        }
        private void CarregaGridItensSale()
        {
            var source = new BindingSource();
            source.DataSource = _saleItems.ToArray();
            dataGridViewItens.DataSource = source;
            dataGridViewItens.Columns["Id"]!.Visible = false;
            dataGridViewItens.Columns["IdProduct"]!.HeaderText = @"Id.Product";
            dataGridViewItens.Columns["UnitPrice"]!.DefaultCellStyle.Format = "C2";
            dataGridViewItens.Columns["UnitPrice"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewItens.Columns["TotalPrice"]!.DefaultCellStyle.Format = "C2";
            dataGridViewItens.Columns["TotalPrice"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewItens.Columns["Quantity"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ItemValidator())
            {
                var saleItem = new SaleItemModel();
                if (cboProduct.SelectedValue != null &&
                    int.TryParse(cboProduct.SelectedValue.ToString(), out var idProduct))
                {
                    var product = _productService.GetById<Product>(idProduct);
                    saleItem.IdProduct = product.Id;
                    saleItem.Product = product.Name;
                    saleItem.SaleUnit = product.SalesUnit;
                }

                if (decimal.TryParse(txtQuantity.Text, out var quantity))
                {
                    saleItem.Quantity = quantity;
                }
                else
                {
                    saleItem.Quantity = 1;
                }

                string precoLimpo = txtPrice.Text.Replace("R$", "").Trim();
                if (decimal.TryParse(precoLimpo, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out var price))
                {
                    saleItem.UnitPrice = price;
                }

                saleItem.TotalPrice = saleItem.Quantity * saleItem.UnitPrice;

                _saleItems.Add(saleItem);

                CarregaGridItensSale();
                CalculateTotalSale();

                txtQuantity.Text = "";
                txtPrice.Text = "";
                txtTotalPrice.Text = "";
                txtSaleUnit.Text = "";
            }
        }
        private bool ItemValidator()
        {
            return true;
        }
        private void txtVlUnitario_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtSaleUnit.Text, out double value))
                txtSaleUnit.Text = string.Format(CultureInfo.CurrentCulture, @"{0:C2}", value);
            else
                txtSaleUnit.Text = string.Empty;

            CalculateTotalItem();
        }
        private void CalculateTotalItem()
        {
            var convVlr = float.TryParse(txtSaleUnit.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float vlUnitario);
            var convQtd = int.TryParse(txtPrice.Text, out int quantidade);
            if (convVlr && convQtd)
            {
                var valorTotal = quantidade * vlUnitario;
                txtTotalPrice.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            }
        }
        private void CalculateTotalSale()
        {
            decimal totalVenda = _saleItems.Sum(x => x.TotalPrice);
            lblTotalPrice.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "Valor Total: {0:C2}", totalVenda);

            decimal totalQtd = _saleItems.Sum(x => x.Quantity);
            lblQtdItens.Text = $"Qtd. Produtos: {totalQtd}";
        }
        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            CalculateTotalItem();
        }

        private void cboProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboProduct.SelectedValue != null)
            {
                var product = (Product)cboProduct.SelectedItem;

                txtSaleUnit.Text = product.SalesUnit;

                txtPrice.Text = product.Price.ToString("N2");

                cboCategory.SelectedValue = product.CategoryId;
            }
        }
        private void CalcularTotalItem()
        {
            if (!decimal.TryParse(txtQuantity.Text, out decimal quantidade))
            {
                quantidade = 0;
            }
            string precoLimpo = txtPrice.Text.Replace("R$", "").Trim();

            if (!decimal.TryParse(precoLimpo, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out decimal preco))
            {
                preco = 0;
            }

            decimal total = quantidade * preco;

            txtTotalPrice.Text = total.ToString("C2");
        }

        private void txtQuantity_Leave_1(object sender, EventArgs e)
        {
            CalcularTotalItem();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Se for letra ou símbolo não escreve nada
                e.Handled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                var index = dataGridViewItens.SelectedRows[0].Index;

                _saleItems.RemoveAt(index);
                CarregaGridItensSale();
                CalculateTotalSale();
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }
    }
}
