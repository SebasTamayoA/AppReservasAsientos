namespace AppBuses
{
    partial class FormReserveSeat
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
            this.txtPassengerBusRowSeat = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPassengerBusPlate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.btnFindReservation = new System.Windows.Forms.Button();
            this.btnConfirmReservation = new System.Windows.Forms.Button();
            this.txtPassengerPhone = new System.Windows.Forms.TextBox();
            this.txtPassengerLastName = new System.Windows.Forms.TextBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtPassengerIdentification = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnListBusCapacity = new System.Windows.Forms.Button();
            this.dataGridReserva = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtPassengerBusColumnSeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reserva de Asiento";
            // 
            // txtPassengerBusRowSeat
            // 
            this.txtPassengerBusRowSeat.Location = new System.Drawing.Point(230, 216);
            this.txtPassengerBusRowSeat.Name = "txtPassengerBusRowSeat";
            this.txtPassengerBusRowSeat.Size = new System.Drawing.Size(140, 20);
            this.txtPassengerBusRowSeat.TabIndex = 90;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(135, 220);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 16);
            this.label18.TabIndex = 89;
            this.label18.Text = "Silla Fila";
            // 
            // txtPassengerBusPlate
            // 
            this.txtPassengerBusPlate.Location = new System.Drawing.Point(230, 181);
            this.txtPassengerBusPlate.Name = "txtPassengerBusPlate";
            this.txtPassengerBusPlate.Size = new System.Drawing.Size(140, 20);
            this.txtPassengerBusPlate.TabIndex = 88;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(135, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 16);
            this.label17.TabIndex = 87;
            this.label17.Text = "Placa Bus";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(135, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 84;
            this.label14.Text = "Nombre";
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservation.Location = new System.Drawing.Point(433, 285);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(126, 23);
            this.btnCancelReservation.TabIndex = 83;
            this.btnCancelReservation.Text = "Cancelar Reserva";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // btnFindReservation
            // 
            this.btnFindReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindReservation.Location = new System.Drawing.Point(320, 285);
            this.btnFindReservation.Name = "btnFindReservation";
            this.btnFindReservation.Size = new System.Drawing.Size(107, 23);
            this.btnFindReservation.TabIndex = 82;
            this.btnFindReservation.Text = "Buscar Reserva";
            this.btnFindReservation.UseVisualStyleBackColor = true;
            this.btnFindReservation.Click += new System.EventHandler(this.btnFindReservation_Click);
            // 
            // btnConfirmReservation
            // 
            this.btnConfirmReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReservation.Location = new System.Drawing.Point(12, 285);
            this.btnConfirmReservation.Name = "btnConfirmReservation";
            this.btnConfirmReservation.Size = new System.Drawing.Size(120, 23);
            this.btnConfirmReservation.TabIndex = 81;
            this.btnConfirmReservation.Text = "Confirmar Reserva";
            this.btnConfirmReservation.UseVisualStyleBackColor = true;
            this.btnConfirmReservation.Click += new System.EventHandler(this.btnConfirmReservation_Click);
            // 
            // txtPassengerPhone
            // 
            this.txtPassengerPhone.Location = new System.Drawing.Point(230, 141);
            this.txtPassengerPhone.Name = "txtPassengerPhone";
            this.txtPassengerPhone.Size = new System.Drawing.Size(140, 20);
            this.txtPassengerPhone.TabIndex = 80;
            // 
            // txtPassengerLastName
            // 
            this.txtPassengerLastName.Location = new System.Drawing.Point(230, 112);
            this.txtPassengerLastName.Name = "txtPassengerLastName";
            this.txtPassengerLastName.Size = new System.Drawing.Size(140, 20);
            this.txtPassengerLastName.TabIndex = 79;
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(230, 79);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(140, 20);
            this.txtPassengerName.TabIndex = 78;
            // 
            // txtPassengerIdentification
            // 
            this.txtPassengerIdentification.Location = new System.Drawing.Point(242, 53);
            this.txtPassengerIdentification.Name = "txtPassengerIdentification";
            this.txtPassengerIdentification.Size = new System.Drawing.Size(128, 20);
            this.txtPassengerIdentification.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(135, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 76;
            this.label11.Text = "Teléfono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(135, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 75;
            this.label12.Text = "Apellidos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(135, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 74;
            this.label13.Text = "N. Identificación";
            // 
            // btnListBusCapacity
            // 
            this.btnListBusCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListBusCapacity.Location = new System.Drawing.Point(138, 285);
            this.btnListBusCapacity.Name = "btnListBusCapacity";
            this.btnListBusCapacity.Size = new System.Drawing.Size(161, 23);
            this.btnListBusCapacity.TabIndex = 73;
            this.btnListBusCapacity.Text = "Listar Reservas";
            this.btnListBusCapacity.UseVisualStyleBackColor = true;
            this.btnListBusCapacity.Click += new System.EventHandler(this.btnListBusCapacity_Click);
            // 
            // dataGridReserva
            // 
            this.dataGridReserva.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReserva.Location = new System.Drawing.Point(48, 314);
            this.dataGridReserva.Name = "dataGridReserva";
            this.dataGridReserva.Size = new System.Drawing.Size(454, 131);
            this.dataGridReserva.TabIndex = 92;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 24);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(64, 49);
            this.btnAtras.TabIndex = 93;
            this.btnAtras.Text = "< Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtPassengerBusColumnSeat
            // 
            this.txtPassengerBusColumnSeat.Location = new System.Drawing.Point(230, 245);
            this.txtPassengerBusColumnSeat.Name = "txtPassengerBusColumnSeat";
            this.txtPassengerBusColumnSeat.Size = new System.Drawing.Size(140, 20);
            this.txtPassengerBusColumnSeat.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Silla Columna";
            // 
            // FormReserveSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassengerBusColumnSeat);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dataGridReserva);
            this.Controls.Add(this.txtPassengerBusRowSeat);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtPassengerBusPlate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.btnFindReservation);
            this.Controls.Add(this.btnConfirmReservation);
            this.Controls.Add(this.txtPassengerPhone);
            this.Controls.Add(this.txtPassengerLastName);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.txtPassengerIdentification);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnListBusCapacity);
            this.Controls.Add(this.label1);
            this.Name = "FormReserveSeat";
            this.Text = "FormReserveSeat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassengerBusRowSeat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPassengerBusPlate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnFindReservation;
        private System.Windows.Forms.Button btnConfirmReservation;
        private System.Windows.Forms.TextBox txtPassengerPhone;
        private System.Windows.Forms.TextBox txtPassengerLastName;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.TextBox txtPassengerIdentification;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnListBusCapacity;
        private System.Windows.Forms.DataGridView dataGridReserva;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtPassengerBusColumnSeat;
        private System.Windows.Forms.Label label2;
    }
}