using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantClientes : Form
    {
        public Frm_MantClientes()
        {
            InitializeComponent();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            estado.Items.Add("Activo");
            estado.Items.Add("Inactivo");
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            codigocliente.Enabled = true;
            nombrecliente.Enabled = true;
            telefono.Enabled = true;
            fechanacimiento.Enabled = true;
            membresia.Enabled = true;
            estado.Enabled = true;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {/*
            OdbcDataReader jornada = logic.modificarClientes(Txt_codigoJornada.Text, Txt_nombreJornada.Text, Txt_horasJornada.Text, Cbo_estadoJornada.Text);
            MessageBox.Show("Datos modificados correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
        */
        }
    }
}
