using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppBuses
{
    public partial class FormBus : Form
    {
        // crear Listas
        public List<Bus> buses = new List<Bus>();
        List<Driver> drivers = new List<Driver>();
        int[,] Sillas;
        public FormBus()
        {
            InitializeComponent();
            // centrar formulario
            this.CenterToScreen();
            dataGridViewGraficaBus.Visible = false; // ocultar datagridview
            this.btnGraficarBus.Enabled = true; // habilitar boton graficar
        }

        // Método para llenar lista de conductores
        public void LlenarLista(List<Driver> driver)
        {
            drivers = driver;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Método para limpar campos de bus
        public void DeleteFieldsBus()
        {
            // borrar campos de bus
            txtBusPlate.Clear();
            txtBusRows.Clear();
            txtBusColumns.Clear();
            txtBusDriverIdentification.Clear();
        }

        // Método para crear bus
        private void btnAddBus_Click(object sender, EventArgs e)
        {
            // campos del formulario no pueden estar vacios
            if (txtBusPlate.Text == "" || txtBusRows.Text == "" || txtBusColumns.Text == "" || txtBusDriverIdentification.Text == "")
            {
                MessageBox.Show("Por favor, digite información en todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Leer atributos del bus del formulario
                string busPlate = txtBusPlate.Text;
                string busType = comboBoxBusType.Text;
                // Leer capacidad del bus como arreglo bidimensional del formulario con filas y columnas
                int busRows = Convert.ToInt32(txtBusRows.Text);
                int busColumns = Convert.ToInt32(txtBusColumns.Text);
                Sillas = new int[busRows, busColumns];
                int busCapacity1 = busRows * busColumns;

                bool bandera = false;
                Driver driver = null;

                // Buscar conductor en la lista de conductores
                for (int i = 0; i < drivers.Count; i++)
                {
                    if (drivers[i].Identification.Equals(txtBusDriverIdentification.Text))
                    {
                        driver = drivers[i];
                        bandera = true;
                    }
                }

                // Validar que el conductor exista
                if (bandera)
                {
                    Bus objBus = new Bus
                    {
                        BusPlate = busPlate,
                        BusType = busType,
                        BusCapacity = Sillas,
                        BusCapacity1 = busCapacity1,
                        Driver = driver
                    };
                    buses.Add(objBus);
                    MessageBox.Show("Bus creado correctamente");
                }
                else
                {
                    MessageBox.Show("El conductor no existe");
                }

                // Limpar campos
                DeleteFieldsBus();
            }
        }

        // Método para listar buses
        private void btnBusList_Click(object sender, EventArgs e)
        {
            // Limpiar lista
            dataGridBus.Columns.Clear();
            dataGridBus.Rows.Clear();

            // Agregar columnas 
            dataGridBus.Columns.Add("BusPlate", "Placa");
            dataGridBus.Columns.Add("BusType", "Tipo");
            dataGridBus.Columns.Add("BusDriver", "Identificación");
            dataGridBus.Columns.Add("BusDriver", "Conductor");
            dataGridBus.Columns.Add("BusCapacity1", "Capacidad");


            // Agregar filas recorriendo lista tc
            for (int i = 0; i < buses.Count; i++)
            {
                dataGridBus.Rows.Add(buses[i].BusPlate, buses[i].BusType, buses[i].Driver.Identification, buses[i].Driver.Name, buses[i].BusCapacity1 + " Pasajeros");
            }
        }

        // Método para actualizar buses
        private void btnUpdateBus_Click(object sender, EventArgs e)
        {
            // Actualizar datos del bus tomando el número de placa y las filas y columnas
            string busPlate = txtBusPlate.Text;
            bool bandera = false;
            // campos del formulario no pueden estar vacios
            if (txtBusPlate.Text == "" || txtBusRows.Text == "" || txtBusColumns.Text == "" || txtBusDriverIdentification.Text == "")
            {
                MessageBox.Show("Por favor, digite información en todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // filas y columnas
                int busRows = Convert.ToInt32(txtBusRows.Text);
                int busColumns = Convert.ToInt32(txtBusColumns.Text);
                int busCapacity1 = busRows * busColumns;
                Sillas = new int[busRows, busColumns];

                for (int i = 0; i < drivers.Count; i++)
                {
                    if (buses.Count == 0)
                    {
                        MessageBox.Show("No hay buses registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (buses[i].BusPlate.Equals(busPlate))
                    {
                        buses[i].BusType = comboBoxBusType.Text;
                        buses[i].BusPlate = txtBusPlate.Text;
                        buses[i].Driver = drivers[i];
                        // actualizar matriz de capacidad
                        buses[i].BusCapacity = Sillas;
                        buses[i].BusCapacity1 = busCapacity1;
                        bandera = true;
                        break;
                    }
                }
            }

            if (bandera)
            {
                MessageBox.Show("Los datos se actualizaron correctamente");
            }
            else
            {
                MessageBox.Show("No se encontro el bus con la placa: " + busPlate);
            }

            // Limpiar campos
            DeleteFieldsBus();
        }

        // Método para eliminar buses
        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            // Eliminar bus ingresando el numero de placa del bus por inputBox
            string busPlate = Interaction.InputBox("Ingrese el numero de placa de la bus a eliminar", "Eliminar Bus", "", -1, -1);
            bool bandera = false;
            // Buscar bus en la lista
            for (int i = 0; i < buses.Count; i++)
            {
                if (buses[i].BusPlate.Equals(busPlate))
                {
                    buses.RemoveAt(i);
                    bandera = true;
                    break;
                }
            }

            if (bandera)
            {
                MessageBox.Show("El bus se eliminó correctamente");
            }
            else
            {
                MessageBox.Show("No se encontró el bus con la placa: " + busPlate);
            }
        }

        // Botón para graficar sillas del bus
        public void btnGraficarBus_Click(object sender, EventArgs e)
        {

            dataGridViewGraficaBus.Visible = true;
            // graficar filas y columnas del bus segun su placa
            string busPlate = Interaction.InputBox("Ingrese el número de placa del bus", "Graficar Bus", "", -1, -1);
            if (busPlate.Equals(""))
            {
                MessageBox.Show("Ingrese un numero de placa existente");
            }
            else
            {
                for (int i = 0; i < buses.Count; i++)
                {
                    if (buses[i].BusPlate.Equals(busPlate))
                    {
                        dataGridViewGraficaBus.ColumnCount = buses[i].BusCapacity.GetLength(1);
                        dataGridViewGraficaBus.RowCount = buses[i].BusCapacity.GetLength(0);
                        for (int j = 0; j < buses[i].BusCapacity.GetLength(0); j++)
                        {
                            for (int k = 0; k < buses[i].BusCapacity.GetLength(1); k++)
                            {
                                dataGridViewGraficaBus.Rows[j].Cells[k].Value = buses[i].BusCapacity[j, k];
                            }
                        }
                        break;
                    }
                }
            }
        }

        // Método para graficar sillas del bus
        public void GraphicBus()
        {

            dataGridViewGraficaBus.ColumnCount = Sillas.GetLength(1);
            dataGridViewGraficaBus.RowCount = Sillas.GetLength(0);
            for (int i = 0; i < Sillas.GetLength(0); i++)
            {
                for (int j = 0; j < Sillas.GetLength(1); j++)
                {
                    dataGridViewGraficaBus.Rows[i].Cells[j].Value = Sillas[i, j].ToString();
                }
            }
        }

        //  Actualizar filas de matriz de capacidad
        private void txtBusRows_TextChanged(object sender, EventArgs e)
        {
            // Actualizar matriz de capacidad
            string filas = txtBusRows.Text;
            string columnas = txtBusColumns.Text;
            if (!filas.Equals("") && !columnas.Equals(""))
            {
                int rows = Int32.Parse(filas);
                int columns = Int32.Parse(columnas);
                Sillas = new int[rows, columns];
                LlenarMatriz();
            }
        }

        // Actualizar columnas de matriz de capacidad
        private void txtBusColumns_TextChanged(object sender, EventArgs e)
        {

            string filas = txtBusRows.Text;
            string columnas = txtBusColumns.Text;
            if (!filas.Equals("") && !columnas.Equals(""))
            {
                int rows = Int32.Parse(filas);
                int columns = Int32.Parse(columnas);
                Sillas = new int[rows, columns];
                LlenarMatriz();
            }
        }

        // Método para llenar matriz de capacidad
        public void LlenarMatriz()
        {
            for (int i = 0; i < Sillas.GetLength(0); i++)
            {
                for (int j = 0; j < Sillas.GetLength(1); j++)
                {
                    Sillas[i, j] = 0;
                }
            }
        }

        // Botón para inhabilitar sillas del bus
        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            string filaInhabilitada = txtInhabilitarFila.Text;
            string columnaInhabilitada = txtInhabilitarColumna.Text;
            if (!filaInhabilitada.Equals("") && !columnaInhabilitada.Equals(""))
            {
                Sillas[Int32.Parse(filaInhabilitada) - 1, Int32.Parse(columnaInhabilitada) - 1] = -1;
                GraphicBus();
            }
            else
            {
                MessageBox.Show("Ingrese correctamente los datos");
            }
        }
    }
}
