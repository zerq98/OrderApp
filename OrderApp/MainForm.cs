using OrderApp.App.Dto;
using OrderApp.App.Interface;
using OrderApp.App.Observer;
using OrderApp.App.Service;
using OrderApp.Validation;
using System;
using System.Windows.Forms;

namespace OrderApp
{
    public partial class MainForm : Form
    {
        private ProductService _productService;
        private readonly OrderService _orderService;
        private int selectedIndex;

        public MainForm()
        {
            InitializeComponent();
            _productService = new ProductService(new Observer(ProductGrid));
            _orderService = (OrderService)Program.Container.GetInstance<IOrderService>();
        }

        private void ProductDetails_Click(object sender, EventArgs e)
        {
            ProductForm form = null;
            switch ((sender as Button).Tag)
            {
                case "Add":
                    form = new ProductForm(_productService, null);
                    break;

                case "Edit":
                    form = new ProductForm(_productService, _productService.GetProduct(selectedIndex));
                    break;
            }
            form.ShowDialog();
        }

        private void ProductGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductGrid.SelectedRows.Count > 0)
            {
                selectedIndex = ProductGrid.SelectedRows[0].Index;
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            _productService.RemoveProduct(selectedIndex);
        }

        private async void DbSaveBtn_ClickAsync(object sender, EventArgs e)
        {
            var order = CreateOrder();
            if (new OrderValidation().Validate(order).IsValid)
            {
                if (await _orderService.SaveToDb(order))
                {
                    MessageBox.Show("Pomyślnie dodano do bazy danych");
                    ClearContorls();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania do bazy");
                }
            }
            else
            {
                MessageBox.Show("Wprowadziłeś złe dane!\n(Imie musi zawierać co najmniej jeden znak)" +
                    "\n(Nazwisko musi zawierać co najmniej jeden znak)\n(Data urodzenia powinna być w formacie dd.mm.rrrr)");
            }
        }

        private void XmlSaveBtn_Click(object sender, EventArgs e)
        {
            var order = CreateOrder();
            if (new OrderValidation().Validate(order).IsValid)
            {
                if (_orderService.SaveToXml(order))
                {
                    MessageBox.Show("Pomyślnie zapisano w pliku");
                    ClearContorls();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisu do pliku");
                }
            }
            else
            {
                MessageBox.Show("Wprowadziłeś złe dane!\n(Imie musi zawierać co najmniej jeden znak)" +
                    "\n(Nazwisko musi zawierać co najmniej jeden znak)\n(Data urodzenia powinna być w formacie dd.mm.rrrr)");
            }
        }

        /// <summary>
        /// Method responsible for save data to new dto
        /// </summary>
        /// <returns>New dto with data</returns>
        private OrderDto CreateOrder()
        {
            return new OrderDto()
            {
                FirstName = NameTBox.Text,
                Surname = SurnameTBox.Text,
                BirthDate = BirthTBox.Text
            };
        }

        /// <summary>
        /// Method which clears all text boxes and list of products
        /// </summary>
        private void ClearContorls()
        {
            NameTBox.Text = "";
            SurnameTBox.Text = "";
            BirthTBox.Text = "";
            _productService.ClearList();
        }
    }
}