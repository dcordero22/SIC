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
    public partial class Visor_Reporte_Expediente_Estado : Form
    {
        public string Usuario { get; set; }
        public Visor_Reporte_Expediente_Estado()
        {
            InitializeComponent();
        }

        private void Visor_Reporte_Expediente_Estado_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'SICDataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
                this.DataTable1TableAdapter.Fill(this.SICDataSet1.DataTable1);
                ReportParameter[] parameters = new ReportParameter[1];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
