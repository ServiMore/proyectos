using System;
using System.Windows.Forms;
using BLL;
using Entities;

namespace GUI {
    public partial class CreateEmployeeForm : Form {

        private EmployeeBL bl = new EmployeeBL();

        public CreateEmployeeForm() {
            InitializeComponent();
        }

        public CreateEmployeeForm(Employee employee) : this() {
            LoadCurrentEmployee(employee);
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e) {
            cbBoss.DataSource = bl.GetAll();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            try {
                bl.Create(CreateEmployee());

                MessageBox.Show("Trabajador creado correctamente", "Trabajadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception exception) {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Employee CreateEmployee() {
            var employee = new Employee();
            employee.Codigo = txtCode.Text;
            employee.Nombre = txtName.Text;
            employee.Apellido = txtLastName.Text;
            employee.Salario = (double)numSalary.Value;
            employee.Jefe = (Employee)cbBoss.SelectedItem;
            return employee;
        }

        private void LoadCurrentEmployee(Employee employee) {
            txtCode.Text = employee.Codigo;
            txtName.Text = employee.Nombre;
            txtLastName.Text = employee.Apellido;
            numSalary.Value = (decimal)employee.Salario;
            cbBoss.SelectedItem = employee.Jefe;

            dgChildren.DataSource = bl.GetChildren(employee);
        }

    }
}
