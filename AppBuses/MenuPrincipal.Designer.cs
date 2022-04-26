namespace AppBuses
{
    partial class MenuPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpcionEmpresa = new System.Windows.Forms.Button();
            this.btnOpcionConductor = new System.Windows.Forms.Button();
            this.btnOpcionBus = new System.Windows.Forms.Button();
            this.btnOpcionReservaAsiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a JF && Tours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btnOpcionEmpresa
            // 
            this.btnOpcionEmpresa.Location = new System.Drawing.Point(136, 85);
            this.btnOpcionEmpresa.Name = "btnOpcionEmpresa";
            this.btnOpcionEmpresa.Size = new System.Drawing.Size(163, 47);
            this.btnOpcionEmpresa.TabIndex = 2;
            this.btnOpcionEmpresa.Text = "Opciones de Empresa";
            this.btnOpcionEmpresa.UseVisualStyleBackColor = true;
            this.btnOpcionEmpresa.Click += new System.EventHandler(this.btnOpcionEmpresa_Click);
            // 
            // btnOpcionConductor
            // 
            this.btnOpcionConductor.Location = new System.Drawing.Point(136, 169);
            this.btnOpcionConductor.Name = "btnOpcionConductor";
            this.btnOpcionConductor.Size = new System.Drawing.Size(163, 47);
            this.btnOpcionConductor.TabIndex = 3;
            this.btnOpcionConductor.Text = "Opciones de Conductor";
            this.btnOpcionConductor.UseVisualStyleBackColor = true;
            this.btnOpcionConductor.Click += new System.EventHandler(this.btnOpcionConductor_Click);
            // 
            // btnOpcionBus
            // 
            this.btnOpcionBus.Location = new System.Drawing.Point(136, 261);
            this.btnOpcionBus.Name = "btnOpcionBus";
            this.btnOpcionBus.Size = new System.Drawing.Size(163, 47);
            this.btnOpcionBus.TabIndex = 4;
            this.btnOpcionBus.Text = "Opciones de Bus";
            this.btnOpcionBus.UseVisualStyleBackColor = true;
            this.btnOpcionBus.Click += new System.EventHandler(this.btnOpcionBus_Click);
            // 
            // btnOpcionReservaAsiento
            // 
            this.btnOpcionReservaAsiento.Location = new System.Drawing.Point(136, 345);
            this.btnOpcionReservaAsiento.Name = "btnOpcionReservaAsiento";
            this.btnOpcionReservaAsiento.Size = new System.Drawing.Size(163, 47);
            this.btnOpcionReservaAsiento.TabIndex = 5;
            this.btnOpcionReservaAsiento.Text = "Reserva de Asiento";
            this.btnOpcionReservaAsiento.UseVisualStyleBackColor = true;
            this.btnOpcionReservaAsiento.Click += new System.EventHandler(this.btnOpcionReservaAsiento_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.btnOpcionReservaAsiento);
            this.Controls.Add(this.btnOpcionBus);
            this.Controls.Add(this.btnOpcionConductor);
            this.Controls.Add(this.btnOpcionEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpcionEmpresa;
        private System.Windows.Forms.Button btnOpcionConductor;
        private System.Windows.Forms.Button btnOpcionBus;
        private System.Windows.Forms.Button btnOpcionReservaAsiento;
    }
}