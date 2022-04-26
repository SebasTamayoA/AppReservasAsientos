namespace AppBuses
{
    partial class FormBus
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
            this.txtBusDriverIdentification = new System.Windows.Forms.TextBox();
            this.txtBusColumns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBusType = new System.Windows.Forms.ComboBox();
            this.txtBusRows = new System.Windows.Forms.TextBox();
            this.lblBusCapacity = new System.Windows.Forms.Label();
            this.txtBusPlate = new System.Windows.Forms.TextBox();
            this.lblBusType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateBus = new System.Windows.Forms.Button();
            this.btnBusList = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.dataGridBus = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnGraficarBus = new System.Windows.Forms.Button();
            this.dataGridViewGraficaBus = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInhabilitarColumna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInhabilitarFila = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraficaBus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bus";
            // 
            // txtBusDriverIdentification
            // 
            this.txtBusDriverIdentification.Location = new System.Drawing.Point(342, 185);
            this.txtBusDriverIdentification.Name = "txtBusDriverIdentification";
            this.txtBusDriverIdentification.Size = new System.Drawing.Size(44, 20);
            this.txtBusDriverIdentification.TabIndex = 86;
            // 
            // txtBusColumns
            // 
            this.txtBusColumns.Location = new System.Drawing.Point(270, 154);
            this.txtBusColumns.Name = "txtBusColumns";
            this.txtBusColumns.Size = new System.Drawing.Size(116, 20);
            this.txtBusColumns.TabIndex = 85;
            this.txtBusColumns.TextChanged += new System.EventHandler(this.txtBusColumns_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Columnas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "N. Identificación de conductor";
            // 
            // comboBoxBusType
            // 
            this.comboBoxBusType.FormattingEnabled = true;
            this.comboBoxBusType.Items.AddRange(new object[] {
            "Particular",
            "Microbús",
            "Buseta",
            "Autobús"});
            this.comboBoxBusType.Location = new System.Drawing.Point(270, 100);
            this.comboBoxBusType.Name = "comboBoxBusType";
            this.comboBoxBusType.Size = new System.Drawing.Size(116, 21);
            this.comboBoxBusType.TabIndex = 80;
            // 
            // txtBusRows
            // 
            this.txtBusRows.Location = new System.Drawing.Point(270, 127);
            this.txtBusRows.Name = "txtBusRows";
            this.txtBusRows.Size = new System.Drawing.Size(116, 20);
            this.txtBusRows.TabIndex = 79;
            this.txtBusRows.TextChanged += new System.EventHandler(this.txtBusRows_TextChanged);
            // 
            // lblBusCapacity
            // 
            this.lblBusCapacity.AutoSize = true;
            this.lblBusCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusCapacity.Location = new System.Drawing.Point(154, 127);
            this.lblBusCapacity.Name = "lblBusCapacity";
            this.lblBusCapacity.Size = new System.Drawing.Size(36, 16);
            this.lblBusCapacity.TabIndex = 78;
            this.lblBusCapacity.Text = "Filas";
            // 
            // txtBusPlate
            // 
            this.txtBusPlate.Location = new System.Drawing.Point(270, 66);
            this.txtBusPlate.Name = "txtBusPlate";
            this.txtBusPlate.Size = new System.Drawing.Size(116, 20);
            this.txtBusPlate.TabIndex = 77;
            // 
            // lblBusType
            // 
            this.lblBusType.AutoSize = true;
            this.lblBusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusType.Location = new System.Drawing.Point(153, 101);
            this.lblBusType.Name = "lblBusType";
            this.lblBusType.Size = new System.Drawing.Size(107, 16);
            this.lblBusType.TabIndex = 76;
            this.lblBusType.Text = "Tipo de vehículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 75;
            this.label5.Text = "Placa";
            // 
            // btnUpdateBus
            // 
            this.btnUpdateBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBus.Location = new System.Drawing.Point(157, 228);
            this.btnUpdateBus.Name = "btnUpdateBus";
            this.btnUpdateBus.Size = new System.Drawing.Size(107, 23);
            this.btnUpdateBus.TabIndex = 90;
            this.btnUpdateBus.Text = "Actualizar Bus";
            this.btnUpdateBus.UseVisualStyleBackColor = true;
            this.btnUpdateBus.Click += new System.EventHandler(this.btnUpdateBus_Click);
            // 
            // btnBusList
            // 
            this.btnBusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusList.Location = new System.Drawing.Point(290, 228);
            this.btnBusList.Name = "btnBusList";
            this.btnBusList.Size = new System.Drawing.Size(107, 23);
            this.btnBusList.TabIndex = 89;
            this.btnBusList.Text = "Listar Buses";
            this.btnBusList.UseVisualStyleBackColor = true;
            this.btnBusList.Click += new System.EventHandler(this.btnBusList_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBus.Location = new System.Drawing.Point(418, 228);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteBus.TabIndex = 88;
            this.btnDeleteBus.Text = "Eliminar Bus";
            this.btnDeleteBus.UseVisualStyleBackColor = true;
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // btnAddBus
            // 
            this.btnAddBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBus.Location = new System.Drawing.Point(37, 228);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(100, 23);
            this.btnAddBus.TabIndex = 87;
            this.btnAddBus.Text = "Crear Bus";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // dataGridBus
            // 
            this.dataGridBus.BackgroundColor = System.Drawing.Color.White;
            this.dataGridBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBus.Location = new System.Drawing.Point(46, 257);
            this.dataGridBus.Name = "dataGridBus";
            this.dataGridBus.Size = new System.Drawing.Size(454, 131);
            this.dataGridBus.TabIndex = 91;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 20);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(64, 49);
            this.btnAtras.TabIndex = 92;
            this.btnAtras.Text = "< Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGraficarBus
            // 
            this.btnGraficarBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficarBus.Location = new System.Drawing.Point(418, 152);
            this.btnGraficarBus.Name = "btnGraficarBus";
            this.btnGraficarBus.Size = new System.Drawing.Size(100, 23);
            this.btnGraficarBus.TabIndex = 93;
            this.btnGraficarBus.Text = "Graficar Bus";
            this.btnGraficarBus.UseVisualStyleBackColor = true;
            this.btnGraficarBus.Click += new System.EventHandler(this.btnGraficarBus_Click);
            // 
            // dataGridViewGraficaBus
            // 
            this.dataGridViewGraficaBus.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGraficaBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGraficaBus.Location = new System.Drawing.Point(558, 127);
            this.dataGridViewGraficaBus.Name = "dataGridViewGraficaBus";
            this.dataGridViewGraficaBus.Size = new System.Drawing.Size(217, 261);
            this.dataGridViewGraficaBus.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 95;
            this.label4.Text = "Puestos a inhabilitar";
            // 
            // txtInhabilitarColumna
            // 
            this.txtInhabilitarColumna.Location = new System.Drawing.Point(599, 55);
            this.txtInhabilitarColumna.Name = "txtInhabilitarColumna";
            this.txtInhabilitarColumna.Size = new System.Drawing.Size(116, 20);
            this.txtInhabilitarColumna.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 98;
            this.label6.Text = "Columnas";
            // 
            // txtInhabilitarFila
            // 
            this.txtInhabilitarFila.Location = new System.Drawing.Point(599, 28);
            this.txtInhabilitarFila.Name = "txtInhabilitarFila";
            this.txtInhabilitarFila.Size = new System.Drawing.Size(116, 20);
            this.txtInhabilitarFila.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(526, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "Filas";
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(615, 94);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(100, 23);
            this.btnInhabilitar.TabIndex = 100;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // FormBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.txtInhabilitarColumna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInhabilitarFila);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewGraficaBus);
            this.Controls.Add(this.btnGraficarBus);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dataGridBus);
            this.Controls.Add(this.btnUpdateBus);
            this.Controls.Add(this.btnBusList);
            this.Controls.Add(this.btnDeleteBus);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.txtBusDriverIdentification);
            this.Controls.Add(this.txtBusColumns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBusType);
            this.Controls.Add(this.txtBusRows);
            this.Controls.Add(this.lblBusCapacity);
            this.Controls.Add(this.txtBusPlate);
            this.Controls.Add(this.lblBusType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FormBus";
            this.Text = "FormBus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraficaBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusDriverIdentification;
        private System.Windows.Forms.TextBox txtBusColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBusType;
        private System.Windows.Forms.TextBox txtBusRows;
        private System.Windows.Forms.Label lblBusCapacity;
        private System.Windows.Forms.TextBox txtBusPlate;
        private System.Windows.Forms.Label lblBusType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateBus;
        private System.Windows.Forms.Button btnBusList;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.DataGridView dataGridBus;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGraficarBus;
        private System.Windows.Forms.DataGridView dataGridViewGraficaBus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInhabilitarColumna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInhabilitarFila;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInhabilitar;
    }
}