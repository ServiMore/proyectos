namespace GUI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ShowEmployees = new System.Windows.Forms.Button();
            this.CreateEmployee = new System.Windows.Forms.Button();
            this.CreateProduct = new System.Windows.Forms.Button();
            this.ShowProducts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowEmployees
            // 
            this.ShowEmployees.Location = new System.Drawing.Point(50, 38);
            this.ShowEmployees.Name = "ShowEmployees";
            this.ShowEmployees.Size = new System.Drawing.Size(94, 67);
            this.ShowEmployees.TabIndex = 0;
            this.ShowEmployees.Text = "Ver trabajadores";
            this.ShowEmployees.UseVisualStyleBackColor = true;
            this.ShowEmployees.Click += new System.EventHandler(this.ShowEmployees_Click);
            // 
            // CreateEmployee
            // 
            this.CreateEmployee.Location = new System.Drawing.Point(174, 38);
            this.CreateEmployee.Name = "CreateEmployee";
            this.CreateEmployee.Size = new System.Drawing.Size(94, 67);
            this.CreateEmployee.TabIndex = 1;
            this.CreateEmployee.Text = "Crear trabajador";
            this.CreateEmployee.UseVisualStyleBackColor = true;
            this.CreateEmployee.Click += new System.EventHandler(this.CreateEmployee_Click);
            // 
            // CreateProduct
            // 
            this.CreateProduct.Location = new System.Drawing.Point(174, 120);
            this.CreateProduct.Name = "CreateProduct";
            this.CreateProduct.Size = new System.Drawing.Size(94, 67);
            this.CreateProduct.TabIndex = 3;
            this.CreateProduct.Text = "Crear producto";
            this.CreateProduct.UseVisualStyleBackColor = true;
            this.CreateProduct.Click += new System.EventHandler(this.CreateProduct_Click);
            // 
            // ShowProducts
            // 
            this.ShowProducts.Location = new System.Drawing.Point(50, 120);
            this.ShowProducts.Name = "ShowProducts";
            this.ShowProducts.Size = new System.Drawing.Size(94, 67);
            this.ShowProducts.TabIndex = 2;
            this.ShowProducts.Text = "Ver productos";
            this.ShowProducts.UseVisualStyleBackColor = true;
            this.ShowProducts.Click += new System.EventHandler(this.ShowProducts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver Categorias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateProduct);
            this.Controls.Add(this.ShowProducts);
            this.Controls.Add(this.CreateEmployee);
            this.Controls.Add(this.ShowEmployees);
            this.Name = "MainForm";
            this.Text = "Nomina";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowEmployees;
        private System.Windows.Forms.Button CreateEmployee;
        private System.Windows.Forms.Button CreateProduct;
        private System.Windows.Forms.Button ShowProducts;
        private System.Windows.Forms.Button button1;
    }
}

