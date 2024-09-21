using MD.Entidades;
using MD.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class FrmMarcacion : Form
    {
        bool isActivo = true;
        public bool isAbiertoDesdeLogin = false;
        RepositorioMarcaciones repoMarcaciones = new RepositorioMarcaciones();
        public FrmMarcacion()
        {
            InitializeComponent();
        }

        private void FrmMarcacion_Load(object sender, EventArgs e)
        {


            Task.Run(() => GetHora());
            txtId.Focus();
        }

        private void GetHora()
        {
            try
            {
                while (isActivo)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    this.Invoke(() =>
                    {
                        this.lblFecha.Text = DateTime.Now.Date.ToString("yyyy/MM/dd");
                        this.lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
                    });
                };

            }
            catch (Exception)
            {
            }
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text.Length == 0)
            {
                this.txtId.Focus();
            }
        }


        async Task<bool> Marcar()
        {
            try
            {
                Empleado empleado = repoMarcaciones.GuardarMarcacionesPorCedula(txtId.Text);
                if (empleado != null)
                {
                    MostrarEmpleado(empleado);
                    return true;
                }
                else
                {
                    this.txtId.Text = "";
                    txtId.Focus();
                    return false;
                }
            }
            catch (Exception)
            {
                this.txtId.Text = "";
                txtId.Focus();
                return false;
            }
        }


        async private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (await Marcar())
                {
                    this.gbMarcacion.Visible = true;
                };
            }
        }

        private void MostrarEmpleado(Empleado? empleado)
        {
            if (empleado != null)
            {
                this.Invoke(async () =>
                {
                    this.gbMarcacion.Visible = true;
                    this.lblEmpleado.Text = empleado == null ? "" : empleado.NombreEmpleado;
                    this.lblSucursalNombre.Text = empleado == null ? "" : empleado.Sucursal.Nombre;
                    await Task.Delay(5000);
                    this.gbMarcacion.Visible = false;
                    this.txtId.Text = "";
                    txtId.Focus();
                });
            };

        }

        private void FrmMarcacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAbiertoDesdeLogin)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
