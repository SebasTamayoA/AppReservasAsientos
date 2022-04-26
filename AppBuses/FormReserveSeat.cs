using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppBuses
{
    public partial class FormReserveSeat : Form
    {

        List<Bus> tc = new List<Bus>();
        List<Passenger> person = new List<Passenger>();
        public FormReserveSeat()
        {
            InitializeComponent();
            // Centrar formulario
            this.CenterToScreen();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void DeleteFieldsBus()
        {
            // Borrar campos de bus
            txtPassengerIdentification.Clear();
            txtPassengerName.Clear();
            txtPassengerLastName.Clear();
            txtPassengerPhone.Clear();
            txtPassengerBusPlate.Clear();
            txtPassengerBusRowSeat.Clear();
            txtPassengerBusColumnSeat.Clear();
        }

        private void btnConfirmReservation_Click(object sender, EventArgs e)
        {
            // Campos del formulario no pueden estar vacios
            if (txtPassengerIdentification.Text == "" || txtPassengerName.Text == "" || txtPassengerLastName.Text == "" || txtPassengerPhone.Text == "" || txtPassengerBusPlate.Text == "" || txtPassengerBusRowSeat.Text == "" || txtPassengerBusColumnSeat.Text == "")
            {
                MessageBox.Show("Por favor, digite información en todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Leer atributos de reserva asiento del formulario
                string passengerIdentification = txtPassengerIdentification.Text;
                string passengerName = txtPassengerName.Text;
                string passengerLastName = txtPassengerLastName.Text;
                string passengerPhone = txtPassengerPhone.Text;
                string passengerBusPlate = txtPassengerBusPlate.Text;
                string passengerBusRowSeat = txtPassengerBusRowSeat.Text;
                string passengerBusColumnSeat = txtPassengerBusColumnSeat.Text;

                bool bandera = false;
                Random rnd = new Random();
                var value = rnd.Next(1000, 9999);
                string mensaje = "";
                int colums = 0;
                int rows = 0;

                for (int i = 0; i < person.Count; i++)
                {
                    if (person[i].ReservationNumber == value)
                    {
                        value = rnd.Next(1000, 9999);
                        i = 0;
                    }
                }

                // Buscar bus en la lista
                for (int i = 0; i < tc.Count; i++)
                {
                    // Buscar asiento en la lista
                    if (tc[i].BusPlate.Equals(txtPassengerBusPlate.Text))
                    {
                        rows = Int32.Parse(passengerBusRowSeat) - 1;
                        colums = Int32.Parse(passengerBusColumnSeat) - 1;
                        if (tc[i].BusCapacity[rows, colums] == 0)
                        {
                            tc[i].BusCapacity[rows, colums] = value;
                        }
                        else
                        {
                            bandera = true;
                            mensaje += "El asiento ya está ocupado\n";
                        }
                    }
                }

                if (!bandera)
                {
                    String asiento = "Fila" + passengerBusRowSeat + ", Columna" + passengerBusColumnSeat;
                    Passenger objPerson = new Passenger
                    {
                        Identification = passengerIdentification,
                        Name = passengerName,
                        LastName = passengerLastName,
                        Phone = passengerPhone,
                        ReservationNumber = value,
                        BusPlate = passengerBusPlate,
                        Seat = asiento,
                        Row = rows,
                        Colum = colums,
                    };
                    person.Add(objPerson);
                    MessageBox.Show("Asiento reservado, con numero de ticket: " + value);
                }
                else
                {
                    MessageBox.Show("El asiento no ha sido reservado\n" + mensaje);
                }

                // Limpar campos
                DeleteFieldsBus();
            }
        }

        private void btnListBusCapacity_Click(object sender, EventArgs e)
        {
            // Limpiar lista
            dataGridReserva.Columns.Clear();
            dataGridReserva.Rows.Clear();

            // Agregar columnas 
            dataGridReserva.Columns.Add("BusDriver", "Conductor");
            dataGridReserva.Columns.Add("BusType", "Tipo");
            dataGridReserva.Columns.Add("Identification", "Nro de Identificación");
            dataGridReserva.Columns.Add("Name", "Nombre de la persona que reserva");
            dataGridReserva.Columns.Add("Seat", "Nro de Silla");
            dataGridReserva.Columns.Add("ReservationNumber", "Nro del ticket de reserva");

            // Mostrar datos en dataGrid
            for (int i = 0; i < person.Count; i++)
            {
                for (int j = 0; j < tc.Count; j++)
                {
                    if (person[i].BusPlate.Equals(tc[j].BusPlate))
                    {
                        dataGridReserva.Rows.Add(tc[j].Driver.Name, tc[j].BusType, person[i].Identification, person[i].Name, person[i].Seat, person[i].ReservationNumber);
                    }
                }
            }
        }

        public void LlenarListaBuses(List<Bus> bus)
        {
            tc = bus;
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            // Eliminar Reserva ingresando el número de ticket por inputBox
            string value = Interaction.InputBox("Ingrese el número de ticket a eliminar", "Eliminar Reserva", "", -1, -1);
            // value no puede ser vacío
            if (value == "" && FindReservation(value) == false)
            {
                MessageBox.Show("Por favor, ingrese número de ticket válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int reservation = Int32.Parse(value);
                int index = 0;
                for (int i = 0; i < person.Count; i++)
                {
                    if (person[i].ReservationNumber == reservation)
                    {
                        for (int j = 0; j < tc.Count; j++)
                        {
                            if (tc[j].BusPlate.Equals(person[i].BusPlate))
                            {
                                int row = person[i].Row;
                                int column = person[i].Colum;
                                tc[j].BusCapacity[row, column] = 0;
                                index = j;
                            }
                        }
                        person.RemoveAt(i);
                        MessageBox.Show("Se ha eliminado correctamente");
                        break;
                    }
                }
                // Graficar sillas del bus
                GraphicBus(index);
            }
        }

        private void btnFindReservation_Click(object sender, EventArgs e)
        {
            // Listar reservas registrados en dataGrid
            string passengerIdentification = Interaction.InputBox("Ingrese el número de identificación del pasajero", "Info de reserva", "", -1, -1);

            // Validar que no esté vacío
            if (passengerIdentification == "")
            {
                MessageBox.Show("Por favor, ingrese número de identificación válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Limpiar lista
                dataGridReserva.Columns.Clear();
                dataGridReserva.Rows.Clear();

                // Agregar columnas 
                dataGridReserva.Columns.Add("BusDriver", "Conductor");
                dataGridReserva.Columns.Add("BusType", "Tipo");
                dataGridReserva.Columns.Add("Identification", "Nro de Identificación");
                dataGridReserva.Columns.Add("Name", "Nombre de la persona que reserva");
                dataGridReserva.Columns.Add("Seat", "Nro de Silla");
                dataGridReserva.Columns.Add("ReservationNumber", "Nro del ticket de reserva");

                // Buscar pasajero en la lista y mostrarlo en dataGrid
                for (int i = 0; i < person.Count; i++)
                {
                    if (person[i].Identification.Equals(passengerIdentification))
                    {
                        for (int j = 0; j < tc.Count; j++)
                        {
                            if (person[i].BusPlate.Equals(tc[j].BusPlate))
                            {
                                dataGridReserva.Rows.Add(tc[j].Driver.Name, tc[j].BusType, person[i].Identification, person[i].Name, person[i].Seat, person[i].ReservationNumber);
                            }
                        }
                    }
                }
            }
        }
        public void GraphicBus(int index)
        {
            dataGridReserva.ColumnCount = tc[index].BusCapacity.GetLength(1);
            dataGridReserva.RowCount = tc[index].BusCapacity.GetLength(0);
            for (int i = 0; i < tc[index].BusCapacity.GetLength(0); i++)
            {
                for (int j = 0; j < tc[index].BusCapacity.GetLength(1); j++)
                {
                    dataGridReserva.Rows[i].Cells[j].Value = tc[index].BusCapacity[i, j];
                }
            }
        }

        // Método para buscar ticket
        public bool FindReservation(string reservation)
        {
            // buscar ticket en la lista
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].ReservationNumber.Equals(reservation))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
