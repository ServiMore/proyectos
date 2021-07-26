using System;
using System.Windows.Forms;
using BLL;

namespace GUI {
    public partial class ListEmployeesForm : Form {

        private EmployeeBL bl = new EmployeeBL();

        public ListEmployeesForm() {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e) {
            EmployeesGrid.DataSource = bl.GetAll();
        }

        private void btnAbrir_Click(object sender, EventArgs e) {
            var code = EmployeesGrid.CurrentRow.Cells["Codigo"].Value.ToString();
            var employee = bl.GetOne(code); 

            using (var frm = new CreateEmployeeForm(employee)) {
                frm.ShowDialog();
            }
        }
    }
}
