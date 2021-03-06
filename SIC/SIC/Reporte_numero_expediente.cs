﻿using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIC
{
    public partial class Reporte_numero_expediente : Form
    {
        Gestor Negocios;
        public string usuario { get; set; }
        public Reporte_numero_expediente()
        {
            InitializeComponent();
        }

        private void Reporte_numero_expediente_Load(object sender, EventArgs e)
        {
            try
            {
                this.dat_expediente.ReadOnly = true;
                Negocios = new Gestor();
                this.dat_expediente.DataSource = Negocios.llenar_expedientes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_generar_cedula_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_cedula.Text != "")
                { 
                    Negocios = new Gestor();
                    this.dat_expediente.DataSource = Negocios.llenar_expedientes(int.Parse(this.txt_cedula.Text));
                }else
                {
                    MessageBox.Show("Debe digitar la cedula!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_cedula_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_cedula.Text!="")
                {
                    Visor_Reporte_Expediente_Cedula frm = new Visor_Reporte_Expediente_Cedula();
                    frm.Usuario = usuario;
                    frm.Cedula = int.Parse(this.txt_cedula.Text);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }else
                {
                    MessageBox.Show("Debe digitar la cedula!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_generar_expediente_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_expediente.DataSource = Negocios.llenar_expedientes(this.txt_num_expediente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_expediente_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_num_expediente.Text != "")
                {
                    Visor_Reporte_Expediente_Numero frm = new Visor_Reporte_Expediente_Numero();
                    frm.Usuario = usuario;
                    frm.Num_Expediente=this.txt_num_expediente.Text;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Debe digitar el numero de expediente!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_generar_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_nombre.Text!=""||this.txt_apellido1.Text!="" ||this.txt_apellido2.Text!="")
                {
                    Negocios = new Gestor();
                    this.dat_expediente.DataSource = Negocios.llenar_expedientes(this.txt_nombre.Text,this.txt_apellido1.Text,this.txt_apellido2.Text);
                }
                else
                {
                    MessageBox.Show("Debe llenar los campos!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_nombre.Text != "" || this.txt_apellido1.Text != "" || this.txt_apellido2.Text != "")
                {
                    Visor_Reporte_Expedientes_Nombre frm = new Visor_Reporte_Expedientes_Nombre();
                    frm.Usuario = usuario;
                    frm.Nombre = this.txt_nombre.Text;
                    frm.Apellido1 = this.txt_apellido1.Text;
                    frm.Apellido2 = this.txt_apellido2.Text;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Debe llenar los campos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Visor_Reporte_Expediente frm = new Visor_Reporte_Expediente();
                frm.Usuario = usuario;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
