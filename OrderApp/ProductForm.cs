using OrderApp.App.Dto;
using OrderApp.App.Interface;
using OrderApp.Validation;
using System;
using System.Windows.Forms;

namespace OrderApp
{
    public partial class ProductForm : Form
    {
        private readonly IProductService _productService;
        private ProductDto _product;

        public ProductForm(IProductService productService, ProductDto product)
        {
            InitializeComponent();
            _productService = productService;
            _product = product;
            if (_product != null)
            {
                EditBtn.Visible = true;
                NameTBox.Text = product.Name;
                QuantityNum.Value = product.Quantity;
                PriceNum.Value = (decimal)product.Price;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            _product.Name = NameTBox.Text;
            _product.Quantity = (int)QuantityNum.Value;
            _product.Price = Convert.ToDouble(PriceNum.Value);
            Confirm(true);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            _product = new ProductDto
            {
                Name = NameTBox.Text,
                Quantity = (int)QuantityNum.Value,
                Price = Convert.ToDouble(PriceNum.Value)
            };
            Confirm(false);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm(bool edit)
        {
            if ((new ProductValidation()).Validate(_product).IsValid)
            {
                switch (edit)
                {
                    case true:
                        _productService.EditProduct(_product);
                        break;

                    case false:
                        _productService.AddProductToList(_product);
                        break;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Wprowadziłeś złe dane!\n(Nazwa musi zawierać co najmniej jeden znak)" +
                    "\n(Ilość musi być większa lub równa 1)\n(Cena musi być większa lub równa 0)");
            }
        }
    }
}