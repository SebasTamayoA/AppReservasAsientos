namespace AppBuses
{
    partial class FormDriver
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
            this.btnUpdateDriver = new System.Windows.Forms.Button();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.btnDriverList = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.txtDriverPhone = new System.Windows.Forms.TextBox();
            this.txtDriverLastName = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtDriverIdentification = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridConductor = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConductor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conductor";
            // 
            // btnUpdateDriver
            // 
            this.btnUpdateDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDriver.Location = new System.Drawing.Point(116, 278);
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(140, 23);
            this.btnUpdateDriver.TabIndex = 88;
            this.btnUpdateDriver.Text = "Actualizar Conductor";
            this.btnUpdateDriver.UseVisualStyleBackColor = true;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDriver.Location = new System.Drawing.Point(392, 278);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteDriver.TabIndex = 85;
            this.btnDeleteDriver.Text = "Eliminar Cond.";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // btnDriverList
            // 
            this.btnDriverList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriverList.Location = new System.Drawing.Point(271, 278);
            this.btnDriverList.Name = "btnDriverList";
            this.btnDriverList.Size = new System.Drawing.Size(107, 23);
            this.btnDriverList.TabIndex = 84;
            this.btnDriverList.Text = "Listar Cond.";
            this.btnDriverList.UseVisualStyleBackColor = true;
            this.btnDriverList.Click += new System.EventHandler(this.btnDriverList_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDriver.Location = new System.Drawing.Point(3, 278);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(107, 23);
            this.btnAddDriver.TabIndex = 83;
            this.btnAddDriver.Text = "Crear Cond.";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // txtDriverPhone
            // 
            this.txtDriverPhone.Location = new System.Drawing.Point(207, 195);
            this.txtDriverPhone.Name = "txtDriverPhone";
            this.txtDriverPhone.Size = new System.Drawing.Size(149, 20);
            this.txtDriverPhone.TabIndex = 82;
            // 
            // txtDriverLastName
            // 
            this.txtDriverLastName.Location = new System.Drawing.Point(207, 154);
            this.txtDriverLastName.Name = "txtDriverLastName";
            this.txtDriverLastName.Size = new System.Drawing.Size(149, 20);
            this.txtDriverLastName.TabIndex = 81;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(219, 117);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(137, 20);
            this.txtDriverName.TabIndex = 80;
            // 
            // txtDriverIdentification
            // 
            this.txtDriverIdentification.Location = new System.Drawing.Point(243, 81);
            this.txtDriverIdentification.Name = "txtDriverIdentification";
            this.txtDriverIdentification.Size = new System.Drawing.Size(113, 20);
            this.txtDriverIdentification.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 78;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 77;
            this.label7.Text = "Apellidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "N. Identificación";
            // 
            // dataGridConductor
            // 
            this.dataGridConductor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridConductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConductor.Location = new System.Drawing.Point(29, 307);
            this.dataGridConductor.Name = "dataGridConductor";
            this.dataGridConductor.Size = new System.Drawing.Size(454, 131);
            this.dataGridConductor.TabIndex = 89;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(64, 49);
            this.btnAtras.TabIndex = 90;
            this.btnAtras.Text = "< Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dataGridConductor);
            this.Controls.Add(this.btnUpdateDriver);
            this.Controls.Add(this.btnDeleteDriver);
            this.Controls.Add(this.btnDriverList);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.txtDriverPhone);
            this.Controls.Add(this.txtDriverLastName);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.txtDriverIdentification);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "FormDriver";
            this.Text = "FormDriver";
            this.Load += new System.EventHandler(this.FormDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateDriver;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.Button btnDriverList;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.TextBox txtDriverPhone;
        private System.Windows.Forms.TextBox txtDriverLastName;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtDriverIdentification;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridConductor;
        private System.Windows.Forms.Button btnAtras;
    }
}