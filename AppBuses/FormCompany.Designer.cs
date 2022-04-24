namespace AppBuses
{
    partial class FormCompany
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(163, 274);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 20);
            this.txtPhone.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(168, 227);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(149, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(221, 185);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 14;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(150, 138);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(171, 20);
            this.txtNit.TabIndex = 13;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(101, 275);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 16);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Teléfono";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(101, 228);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 16);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Dirección";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(101, 185);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(114, 16);
            this.lblCompanyName.TabIndex = 10;
            this.lblCompanyName.Text = "Nombre Empresa";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(101, 139);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(29, 16);
            this.lblNit.TabIndex = 9;
            this.lblNit.Text = "NIT";
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCompany.Location = new System.Drawing.Point(150, 309);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(140, 23);
            this.btnUpdateCompany.TabIndex = 77;
            this.btnUpdateCompany.Text = "Actualizar Empresa";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 25);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(64, 49);
            this.btnAtras.TabIndex = 91;
            this.btnAtras.Text = "< Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 399);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnUpdateCompany);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.label1);
            this.Name = "FormCompany";
            this.Text = "FormCompany";
            this.Load += new System.EventHandler(this.FormCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Button btnAtras;
    }
}