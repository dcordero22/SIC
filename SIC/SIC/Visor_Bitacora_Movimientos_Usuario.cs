﻿using Microsoft.Reporting.WinForms;
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
    public partial class Visor_Bitacora_Movimientos_Usuario : Form
    {
        public string Usuario { get; set; }
        public string Usua { get; set; }

        public Visor_Bitacora_Movimientos_Usuario()
        {
            InitializeComponent();
        }

        private void Visor_Bitacora_Movimientos_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SICDataSet1.Tab_Bitacora_Movimientos' Puede moverla o quitarla según sea necesario.
                this.Tab_Bitacora_MovimientosTableAdapter.Fill(this.SICDataSet1.Tab_Bitacora_Movimientos);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                parameters[1] = new ReportParameter("Usua", Usua.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
