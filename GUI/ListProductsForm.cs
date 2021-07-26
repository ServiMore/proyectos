using System;
using System.Windows.Forms;
using BLL;

namespace GUI {
    public partial class ListProductsForm : Form {

        private ProductBL bl = new ProductBL();

        public ListProductsForm() {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e) {
            ProductsGrid.DataSource = bl.GetAll();
        }

    }
}
