using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseño.Mantenimientos;
using CapaDiseño.Procesos;
using CapaLogica;
using Recursos_Humanos;

namespace CapaDiseño
{
   
    public partial class MDIFilmagic : Form
    {
        Logica logic = new Logica();
        string susuario="usuario";
        private int childFormNumber = 0;

        public MDIFilmagic()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        

     
       
        bool ventanaSolicitudEmpleadoN = false;
        Frm_SolicitudEmpleadoN solicitudEmpleado = new Frm_SolicitudEmpleadoN();
        private void solicitudEmpleadoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_SolicitudEmpleadoN);
            if (ventanaSolicitudEmpleadoN == false || frmC == null)
            {
                if (frmC == null)
                {
                    solicitudEmpleado = new Frm_SolicitudEmpleadoN();
                }

                solicitudEmpleado.MdiParent = this;
                solicitudEmpleado.Show();
                Application.DoEvents();
                ventanaSolicitudEmpleadoN = true;
            }
            else
            {
                solicitudEmpleado.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        

        bool ventanaPreseleccion = false;
        Frm_preSeleccion preseleccion = new Frm_preSeleccion();
        private void PreseleccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_preSeleccion);
            if (ventanaPreseleccion == false || frmC == null)
            {
                if (frmC == null)
                {
                    preseleccion = new Frm_preSeleccion();
                }

                preseleccion.MdiParent = this;
                preseleccion.Show();
                Application.DoEvents();
                ventanaPreseleccion = true;
            }
            else
            {
                preseleccion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

       

        bool ventanaJornada = false;
        Frm_MantJornada jornadas = new Frm_MantJornada("");
        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantJornada);
            if (ventanaJornada == false || frmC == null)
            {
                if (frmC == null)
                {
                    jornadas = new Frm_MantJornada(susuario);
                }

                jornadas.MdiParent = this;
                jornadas.Show();
                Application.DoEvents();
                ventanaJornada = true;
            }
            else
            {
                jornadas.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

    }
}

