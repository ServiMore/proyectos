using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;

namespace GUI {
    public partial class CreateProductForm : Form {

        private ProductBL bl = new ProductBL();

        public CreateProductForm() {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            try {
                var product = new Product();
                product.Codigo = txtCode.Text;
                product.Nombre = txtName.Text;
                product.Precio = (double)numPrice.Value;
                bl.Create(product);

                MessageBox.Show("Producto creado correctamente", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception exception) {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
