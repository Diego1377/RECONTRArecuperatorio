using AgenciaDeCambioPOO.Entidades;

namespace AgenciaDeCambioPOO.Windows.Helpers
{
    public static class GridHelper
    {
        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView dgv) where T : class
        {
            LimpiarGrilla(dgv);
            // Filtrar si la lista es de tipo Divisa
            var listaFiltrada = lista;
            if (typeof(T) == typeof(Divisa))
            {
                /*
                 * Razón para usar Cast<Divisa>()
                    List<T> es genérico
                    T puede ser cualquier tipo de objeto, no necesariamente Divisa.

                    Where(d => d.Abreviatura != "ARS") necesita acceder a Abreviatura

                    Si T no es Divisa, el compilador no sabe que los elementos tienen la propiedad Abreviatura.
                    Evitar errores de compilación
                    Cast<Divisa>() le dice al compilador que trate los elementos como Divisa, lo que permite usar d.Abreviatura.
                    El último Cast<T>() convierte la lista filtrada de nuevo a T.
                 */
                listaFiltrada = lista.Cast<Divisa>().Where(d => d.Abreviatura != "ARS").Cast<T>().ToList();
            }

            foreach (var item in listaFiltrada)
            {
                var r = ConstruirFila(dgv);
                SetearFila(r, item);
                AgregarFila(r, dgv);
            }
        }
        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Divisa divisa:
                    r.Cells[0].Value = divisa.Nombre;
                    r.Cells[1].Value = divisa.Abreviatura;
                    r.Cells[2].Value=divisa.Cantidad;
                    r.Cells[3].Value = divisa.CotizacionCompra.ToString("C");
                    r.Cells[4].Value = divisa.CotizacionVenta.ToString("C");
                    break;
                //case Transaccion transaccion:
                //    r.Cells[0].Value = transaccion.Fecha.ToShortDateString();
                //    r.Cells[1].Value = transaccion.Abreviatura;
                //    r.Cells[2].Value = transaccion.GetType().Name;
                //    r.Cells[3].Value = transaccion.Cotizacion.ToString("C");
                //    r.Cells[4].Value = transaccion.Cantidad;
                //    r.Cells[5].Value = transaccion.Total.ToString("C");
                //    break;
                default:
                    break;
            }

            r.Tag = obj;
        }

        public static void AgregarFila(DataGridViewRow r,
            DataGridView grid)
        {
            grid.Rows.Add(r);
        }
        public static void QuitarFila(DataGridViewRow r,
            DataGridView grid)
        {
            grid.Rows.Remove(r);
        }

        public static int ObtenerRowIndex(DataGridView dgv, int id)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var row = dgv.Rows[i];
                if ((int)row.Cells[0].Value == id)
                {
                    return i;
                }
            }
            return -1;

        }

        public static void MarcarRow(DataGridView dgvDatos, int rowIndex)
        {
            if (rowIndex >= 0)
            {
                dgvDatos.Rows[rowIndex].Selected = true;
                dgvDatos.FirstDisplayedScrollingRowIndex = rowIndex;
            }

        }


    }

}
