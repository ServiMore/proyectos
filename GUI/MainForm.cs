using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void ShowEmployees_Click(object sender, EventArgs e) {
            using (var frm = new ListEmployeesForm()) {
                frm.ShowDialog();
            }
        }

        private void CreateEmployee_Click(object sender, EventArgs e) {
            using (var frm = new CreateEmployeeForm()) {
                frm.ShowDialog();
            }
        }

        private void ShowProducts_Click(object sender, EventArgs e) {
            using (var frm = new ListProductsForm()) {
                frm.ShowDialog();
            }
        }

        private void CreateProduct_Click(object sender, EventArgs e) {
            using (var frm = new CreateProductForm()) {
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
