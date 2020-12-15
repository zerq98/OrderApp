using System.Windows.Forms;

namespace OrderApp.App.Observer
{
    public class Observer : IObserver
    {
        private readonly DataGridView _gridView;

        public Observer(DataGridView gridView)
        {
            _gridView = gridView;
        }

        /// <summary>
        /// Method responsible for update product list, invoked when new product is added, edited or deleted
        /// </summary>
        public void Update()
        {
            _gridView.DataSource = null;
            _gridView.DataSource = ActualOrder.Products;
        }
    }
}