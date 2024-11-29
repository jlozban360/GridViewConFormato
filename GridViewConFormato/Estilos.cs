using System;
using System.Drawing;
using System.Windows.Forms;

namespace GridViewConFormato
{
    public class Estilos
    {
        private DataGridView dataGridView;

        // Constructor que recibe el DataGridView (la tabla) al que se le aplicarán los estilos.
        public Estilos(DataGridView dataGrid)
        {
            this.dataGridView = dataGrid;
            InicializarEstilos(); // Llama al método para inicializar los estilos.
        }

        // Método que configura los estilos personalizados para la tabla.
        private void InicializarEstilos()
        {
            // Estilo por defecto para todas las celdas: fondo blanco y texto negro.
            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.ForeColor = Color.Black;

            // Estilo para las filas alternas: fondo gris claro, texto negro, y colores diferentes al seleccionar.
            DataGridViewCellStyle estiloAlterno = new DataGridViewCellStyle();
            estiloAlterno.BackColor = Color.LightGray;
            estiloAlterno.ForeColor = Color.Black;
            estiloAlterno.SelectionBackColor = Color.DarkGray;
            estiloAlterno.SelectionForeColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle = estiloAlterno;

            // Estilo para la cabecera de la tabla: fondo azul, texto blanco, fuente negrita y centrada.
            DataGridViewCellStyle estiloCabecera = new DataGridViewCellStyle();
            estiloCabecera.BackColor = Color.Navy;
            estiloCabecera.ForeColor = Color.White;
            estiloCabecera.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            estiloCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle = estiloCabecera;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView.ColumnHeadersHeight = 40; // Altura de las cabeceras.
            dataGridView.EnableHeadersVisualStyles = false; // Desactiva el estilo visual predeterminado.

            // Estilo para la columna "Código": fondo azul claro, texto azul oscuro, fuente negrita y alineada a la derecha.
            DataGridViewCellStyle estiloCodigo = new DataGridViewCellStyle();
            estiloCodigo.BackColor = Color.LightBlue;
            estiloCodigo.ForeColor = Color.DarkBlue;
            estiloCodigo.Font = new Font("Arial", 9, FontStyle.Bold);
            estiloCodigo.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["Código"].DefaultCellStyle = estiloCodigo;

            // Estilo para la columna "Nombre": texto verde oscuro y fuente en cursiva.
            DataGridViewCellStyle estiloNombre = new DataGridViewCellStyle();
            estiloNombre.ForeColor = Color.DarkGreen;
            estiloNombre.Font = new Font("Tahoma", 9, FontStyle.Italic);
            dataGridView.Columns["Nombre"].DefaultCellStyle = estiloNombre;

            // Estilo para la columna "Apellido1": texto rojo oscuro.
            DataGridViewCellStyle estiloApellido1 = new DataGridViewCellStyle();
            estiloApellido1.ForeColor = Color.DarkRed;
            dataGridView.Columns["Apellido1"].DefaultCellStyle = estiloApellido1;

            // Estilo para la columna "Apellido2": texto púrpura.
            DataGridViewCellStyle estiloApellido2 = new DataGridViewCellStyle();
            estiloApellido2.ForeColor = Color.Purple;
            dataGridView.Columns["Apellido2"].DefaultCellStyle = estiloApellido2;

            // Estilo para la columna "Localidad": fondo amarillo claro, texto naranja oscuro.
            DataGridViewCellStyle estiloLocalidad = new DataGridViewCellStyle();
            estiloLocalidad.BackColor = Color.LightYellow;
            estiloLocalidad.ForeColor = Color.DarkOrange;
            dataGridView.Columns["Localidad"].DefaultCellStyle = estiloLocalidad;

            // Estilo para la columna "Fecha Alta": fondo rosa claro, texto magenta oscuro, formato de fecha (dd/MM/yyyy).
            DataGridViewCellStyle estiloFechaAlta = new DataGridViewCellStyle();
            estiloFechaAlta.BackColor = Color.LightPink;
            estiloFechaAlta.ForeColor = Color.DarkMagenta;
            estiloFechaAlta.Format = "dd/MM/yyyy"; // Formato de fecha.
            dataGridView.Columns["Fecha Alta"].DefaultCellStyle = estiloFechaAlta;

            // Estilo para la columna "TipoCliente": fondo cian claro, texto gris oscuro.
            DataGridViewCellStyle estiloTipoCliente = new DataGridViewCellStyle();
            estiloTipoCliente.BackColor = Color.LightCyan;
            estiloTipoCliente.ForeColor = Color.DarkSlateGray;
            dataGridView.Columns["TipoCliente"].DefaultCellStyle = estiloTipoCliente;

            // Estilo para la columna "SumaTotal": fondo verde claro, texto verde oscuro, formato numérico (dos decimales), alineado a la derecha.
            DataGridViewCellStyle estiloSumaTotal = new DataGridViewCellStyle();
            estiloSumaTotal.BackColor = Color.LightGreen;
            estiloSumaTotal.ForeColor = Color.DarkGreen;
            estiloSumaTotal.Format = "N2"; // Formato numérico con dos decimales.
            estiloSumaTotal.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["SumaTotal"].DefaultCellStyle = estiloSumaTotal;
        }
    }
}
