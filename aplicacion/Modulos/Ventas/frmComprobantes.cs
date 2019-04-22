﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace xtraForm.Modulos.Elementos
{
    public partial class frmComprobantes : DevExpress.XtraEditors.XtraForm
    {
        Libreria.Entidad entidad = new Libreria.Entidad();
        Libreria.Proceso proceso = new Libreria.Proceso();
        Libreria.Maestra maestro = new Libreria.Maestra();
        public frmComprobantes()
        {
            InitializeComponent();
            entidad.tabla = "comprobante";
        }

        private void filtrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtros.frmFiltros filtro = new Filtros.frmFiltros();
            proceso.consultar("select campo,condicion,valor,[union] from filtro where tabla = '" + entidad.tabla + "'", entidad.tabla);
            //foreach (DataRow dr in proceso.ds.Tables[entidad.tabla].Rows)
            //{
            //    filtro.dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            //}
            //filtro.tabla = entidad.tabla;
            //filtro.Index0.DataSource = mapa;
            //filtro.cboxCampo.DisplayMember = "campos";
            //filtro.cboxCampo.ValueMember = "campos";
            filtro.pasar += new Filtros.frmFiltros.variables(condicion);
            filtro.StartPosition = FormStartPosition.CenterScreen;

            filtro.ShowDialog();
        }
        void condicion(string cadena)
        {
            entidad.sql =
            @"select * from(
            SELECT        
            dbo.Vva_Cp.Gestion, dbo.Vva_Cp.Fecha, dbo.Vva_Cp.hora, dbo.Vva_Cp.TpDoc As [Tipo Docum], dbo.Vva_Cp.NrDoc as [Num Documento], dbo.Vva_Cp.IDVendedor AS [Codigo Vendedor], 
            RTRIM(dbo.PERSONAL.Nombre) AS [nombre Vendedor], dbo.Vva_Cp.IDCliente AS [Codigo Cliente], RTRIM(dbo.Vva_Cliente.Nombre) AS [Nombre Cliente], 
            dbo.Vva_Cliente.Documento AS [Docum Identidad], RTRIM(dbo.Vva_Cliente.Direccion) AS Direccion, RTRIM(dbo.ZONA.Descripcion) AS [Zona Venta], 
            dbo.Vva_Cp.IDpedido AS [Num Pedido], dbo.Vva_Cp.NrDocRef AS [Docum Referencia], dbo.Vva_Cp.Comprobante, dbo.Vva_Cp.Credito, 
            SUM(dbo.Vva_ItemCp.Cantidad * dbo.Vva_ItemCp.Precio - dbo.Vva_ItemCp.igv) AS [Valor Venta], SUM(dbo.Vva_ItemCp.Cantidad * dbo.Vva_ItemCp.Precio) 
            AS [Valor Total], dbo.Vva_Cp.afecto, dbo.Vva_Cp.inafecto, dbo.Vva_Cp.igv, dbo.Vva_Cp.Anulado
            FROM            
            dbo.Vva_Cp INNER JOIN
            dbo.Vva_ItemCp ON dbo.Vva_Cp.NrDoc = dbo.Vva_ItemCp.NrDoc AND dbo.Vva_Cp.TpDoc = dbo.Vva_ItemCp.TpDoc INNER JOIN
            dbo.PERSONAL ON dbo.Vva_Cp.IDVendedor = dbo.PERSONAL.Personal INNER JOIN
            dbo.Vva_Cliente ON dbo.Vva_Cp.IDCliente = dbo.Vva_Cliente.Codigo INNER JOIN
            dbo.ZONA ON dbo.Vva_Cliente.Zona = dbo.ZONA.Zona
            GROUP BY 
            dbo.Vva_Cp.Gestion, dbo.Vva_Cp.Fecha, dbo.Vva_Cp.hora, dbo.Vva_Cp.TpDoc, dbo.Vva_Cp.NrDoc, dbo.Vva_Cp.IDVendedor, RTRIM(dbo.PERSONAL.Nombre), 
            dbo.Vva_Cp.IDCliente, RTRIM(dbo.Vva_Cliente.Nombre), dbo.Vva_Cliente.Documento, RTRIM(dbo.Vva_Cliente.Direccion), RTRIM(dbo.ZONA.Descripcion), 
            dbo.Vva_Cp.IDpedido, dbo.Vva_Cp.NrDocRef, dbo.Vva_Cp.Comprobante, dbo.Vva_Cp.Credito, dbo.Vva_Cp.afecto, dbo.Vva_Cp.inafecto, dbo.Vva_Cp.igv, 
            dbo.Vva_Cp.Anulado
            HAVING        (dbo.Vva_Cp.TpDoc IN ('F', 'B'))
            ) tabla";
            if (cadena.Length == 0)
            {
                proceso.consultar(entidad.sql, entidad.tabla);
                gridControl1.DataSource = proceso.ds.Tables[entidad.tabla];
                gridView1.OptionsView.ColumnAutoWidth = false;
                gridView1.OptionsBehavior.Editable = false;
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView1.OptionsView.ShowGroupPanel = false;
                gridView1.OptionsView.ShowFooter = true;
                gridView1.FooterPanelHeight = -2;
                gridView1.Columns["Valor Venta"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                gridView1.Columns["afecto"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                gridView1.Columns["inafecto"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                gridView1.Columns["igv"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                gridView1.Columns["Valor Total"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                gridView1.Columns["Credito"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
                gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                gridView1.GroupRowHeight = 1;
                gridView1.RowHeight = 1;
                gridView1.Appearance.Row.FontSizeDelta = 0;
                gridView1.BestFitColumns();
            }
            else
            {
                try
                {
                    proceso.consultar(entidad.sql + " where " + cadena, entidad.tabla);
                    gridControl1.DataSource = proceso.ds.Tables[entidad.tabla];
                    gridView1.OptionsView.ColumnAutoWidth = false;
                    gridView1.OptionsBehavior.Editable = false;
                    gridView1.OptionsBehavior.ReadOnly = true;
                    gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                    gridView1.OptionsView.ShowGroupPanel = false;
                    gridView1.OptionsView.ShowFooter = true;
                    gridView1.Columns["Valor Venta"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView1.Columns["afecto"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView1.Columns["inafecto"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView1.Columns["igv"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView1.Columns["Valor Total"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView1.Columns["Credito"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
                    gridView1.GroupRowHeight = 1;
                    gridView1.RowHeight = 1;
                    gridView1.Appearance.Row.FontSizeDelta = 0;
                    gridView1.BestFitColumns();
                }
                catch
                {
                    gridControl1.DataSource = null;
                    gridControl1.Refresh();
                }
            }

        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entidad.documento = gridView1.GetFocusedRowCellValue("Num Documento").ToString();
            entidad.tipodocumento = gridView1.GetFocusedRowCellValue("Tipo Docum").ToString();
            if (proceso.ConsultarCadena("estado", "documento", "Documento = '" + entidad.documento + "' and tipodoc = '" + entidad.tipodocumento + "'") != "A")
            {
                if (proceso.MensagePregunta("Desea Anular documento : " + entidad.documento) == DialogResult.Yes)
                {
                    if (proceso.actualizar("documento", "Estado = 'A'", "documento = '" + entidad.documento + "' and tipodoc = '" + entidad.tipodocumento + "'"))
                    {
                        MessageBox.Show("documento : " + entidad.documento + " se ha anulado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Documento se encuentra anulado");
            }
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elementos.frmComprobante frmcomprobante = new frmComprobante();
            frmcomprobante.StartPosition = FormStartPosition.CenterScreen;
            frmcomprobante.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elementos.frmComprobante frmcomprobante = new frmComprobante();
            frmcomprobante.StartPosition = FormStartPosition.CenterScreen;
            frmcomprobante.Show();
        }
    }
}