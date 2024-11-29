namespace GridViewConFormato
{
    public partial class Form1 : Form
    {
        // Constructor de la ventana principal del formulario.
        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        // Evento que se ejecuta cuando el formulario se carga.
        private void Form1_Load(object sender, EventArgs e)
        {
            // **Columna "Código"**: Configura una columna de tipo texto con valores numéricos.
            DataGridViewTextBoxColumn codigoCol = new DataGridViewTextBoxColumn();
            codigoCol.Name = "Código"; // Nombre interno de la columna.
            codigoCol.HeaderText = "Código"; // Texto que aparece en el encabezado.
            codigoCol.ValueType = typeof(int); // Tipo de datos que acepta la columna (entero).
            codigoCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alineación a la derecha.
            dataGridView1.Columns.Add(codigoCol); // Añade la columna al DataGridView.

            // **Columna "Nombre"**: Configura una columna para texto.
            DataGridViewTextBoxColumn nombreCol = new DataGridViewTextBoxColumn();
            nombreCol.Name = "Nombre";
            nombreCol.HeaderText = "Nombre";
            nombreCol.ValueType = typeof(string);
            dataGridView1.Columns.Add(nombreCol);

            // **Columna "Apellido1"**: Otra columna para texto.
            DataGridViewTextBoxColumn apellido1Col = new DataGridViewTextBoxColumn();
            apellido1Col.Name = "Apellido1";
            apellido1Col.HeaderText = "Apellido1";
            apellido1Col.ValueType = typeof(string);
            dataGridView1.Columns.Add(apellido1Col);

            // **Columna "Apellido2"**: Una columna adicional para texto.
            DataGridViewTextBoxColumn apellido2Col = new DataGridViewTextBoxColumn();
            apellido2Col.Name = "Apellido2";
            apellido2Col.HeaderText = "Apellido2";
            apellido2Col.ValueType = typeof(string);
            dataGridView1.Columns.Add(apellido2Col);

            // **Columna "Localidad"**: Otra columna de texto para localidades.
            DataGridViewTextBoxColumn localidadCol = new DataGridViewTextBoxColumn();
            localidadCol.Name = "Localidad";
            localidadCol.HeaderText = "Localidad";
            localidadCol.ValueType = typeof(string);
            dataGridView1.Columns.Add(localidadCol);

            // **Columna "Fecha Alta"**: Columna para fechas con formato específico.
            DataGridViewTextBoxColumn fechaAltaCol = new DataGridViewTextBoxColumn();
            fechaAltaCol.Name = "Fecha Alta";
            fechaAltaCol.HeaderText = "Fecha Alta";
            fechaAltaCol.ValueType = typeof(DateTime); // Tipo de datos de fecha.
            fechaAltaCol.DefaultCellStyle.Format = "dd/MM/yyyy"; // Formato de visualización para las fechas.
            dataGridView1.Columns.Add(fechaAltaCol);

            // **Columna "TipoCliente"**: Una columna de tipo ComboBox con opciones predefinidas.
            DataGridViewComboBoxColumn tipoClienteCol = new DataGridViewComboBoxColumn();
            tipoClienteCol.Name = "TipoCliente";
            tipoClienteCol.HeaderText = "TipoCliente";
            tipoClienteCol.Items.AddRange("A", "B", "C"); // Valores posibles: A, B o C.
            dataGridView1.Columns.Add(tipoClienteCol);

            // **Columna "SumaTotal"**: Columna para valores decimales con formato numérico.
            DataGridViewTextBoxColumn sumaTotalCol = new DataGridViewTextBoxColumn();
            sumaTotalCol.Name = "SumaTotal";
            sumaTotalCol.HeaderText = "SumaTotal";
            sumaTotalCol.ValueType = typeof(decimal); // Tipo decimal.
            sumaTotalCol.DefaultCellStyle.Format = "N2"; // Formato con 2 decimales.
            sumaTotalCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alineación a la derecha.
            dataGridView1.Columns.Add(sumaTotalCol);

            // Aplica los estilos personalizados definidos en la clase Estilos.
            Estilos estilos = new Estilos(dataGridView1);

            // Llama al método para generar datos falsos (50 filas de ejemplo).
            falseandoDatos(50);
        }

        // Método para generar datos falsos en la tabla.
        private void falseandoDatos(int nDatos)
        {
            DataGridView dgv = dataGridView1; // Referencia al DataGridView.

            // Bucle para crear `nDatos` filas de datos falsos.
            for (int i = 0; i < nDatos; i++)
            {
                DataGridViewRow fila = new DataGridViewRow(); // Crea una nueva fila vacía.
                fila.CreateCells(dgv); // Asocia la fila al DataGridView.

                // **Rellenar valores en las celdas de la fila:**
                fila.Cells[0].Value = 100 + i; // Código (número incremental).
                fila.Cells[1].Value = "Nombre " + i; // Nombre.
                fila.Cells[2].Value = "Apellido1 " + i; // Apellido1.
                fila.Cells[3].Value = "Apellido2 " + i; // Apellido2.
                fila.Cells[4].Value = "Localidad " + i; // Localidad.
                fila.Cells[5].Value = DateTime.Now.AddDays(-i); // Fecha Alta (hoy menos `i` días).
                fila.Cells[6].Value = i % 3 == 0 ? "A" : i % 2 == 0 ? "B" : "C"; // TipoCliente: alterna entre A, B y C.
                fila.Cells[7].Value = 1000 + i * 1.5m; // SumaTotal: valor incremental.

                dgv.Rows.Add(fila); // Añade la fila al DataGridView.
            }
        }
    }
}
