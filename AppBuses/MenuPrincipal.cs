using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBuses
{
    public partial class MenuPrincipal : Form
    {

        TouristCompany tc = new TouristCompany();
        FormCompany formCompany;
        FormDriver formDriver;
        FormBus formBus;
        FormReserveSeat formReserveSeat;
        public MenuPrincipal()
        {
            InitializeComponent();
            // centrar menuPrincipal
            this.CenterToScreen();
            formCompany = new FormCompany("123", "Juan", "Cra 43 # 65 B 87", "3226549876");
            formDriver = new FormDriver();
            formBus = new FormBus();
            formReserveSeat = new FormReserveSeat();
        }

        private void btnOpcionEmpresa_Click(object sender, EventArgs e)
        {
            formCompany.Show();
        }

        private void btnOpcionConductor_Click(object sender, EventArgs e)
        {
            formDriver.Show();
        }

        private void btnOpcionBus_Click(object sender, EventArgs e)
        {
            formBus.LlenarLista(formDriver.drivers);
            formBus.Show();
        }

        private void btnOpcionReservaAsiento_Click(object sender, EventArgs e)
        {
            formReserveSeat.LlenarListaBuses(formBus.tc);
            formReserveSeat.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
