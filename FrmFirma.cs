namespace pryEmilianoFernandezEtapa1
{
    public partial class FrmFirma : Form
    {
        //variables
        public bool Click = false;
        Point PuntoAnterior;
        private Bitmap FirmaB = new Bitmap(372, 284);

        //constructor
        public FrmFirma()
        {
            InitializeComponent();

            using (Graphics papel = Graphics.FromImage(FirmaB))
            {
                papel.Clear(Color.White);
            }
            PctFirma.Image = FirmaB;
        }

        //metodos y procedimientos
        private void PctFirma_MouseDown(object sender, MouseEventArgs e)
        {
            Click = true;
            PuntoAnterior = e.Location;
        }

        private void PctFirma_MouseUp(object sender, MouseEventArgs e)
        {
            Click = false;
        }

        private void PctFirma_MouseMove(object sender, MouseEventArgs e)
        {
            //Pregunto si esta dibujando
            if (Click)
            {
                // En caso de pasar la condicion llamo a la clase graphics y creo el objeto "papelFirma" y el asigno el "pctFirma"
                using (Graphics papelFirma = Graphics.FromImage(FirmaB))
                {
                    // Creo el lapiz para hacer la firma
                    Pen lapizFirma = new Pen(Color.Black);
                    papelFirma.DrawLine(lapizFirma, PuntoAnterior, e.Location);
                    PuntoAnterior = e.Location;
                }
                PctFirma.Refresh();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            using (Graphics papel = Graphics.FromImage(FirmaB))
            {
                papel.Clear(Color.White);
            }
            PctFirma.Refresh();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres guardar la firma?", "Confirmación", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                // Obtener la ruta de la carpeta "Firmas" en relación con la ubicación del ejecutable
                string carpetaFirmas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Firmas");

                // Verificar si la carpeta "Firmas" existe, si no, crearla
                if (!Directory.Exists(carpetaFirmas))
                {
                    Directory.CreateDirectory(carpetaFirmas);
                }

                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;

                // Construir el nombre de archivo con la fecha y hora actual
                string nombreArchivo = $"{fechaActual:yyyyMMdd_HHmm}.jpg";

                // Combinar la ruta de la carpeta "Firmas" con el nombre de archivo
                string rutaCompleta = Path.Combine(carpetaFirmas, nombreArchivo);

                // Guardar la imagen en la ruta especificada
                FirmaB.Save(rutaCompleta, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Limpiar la firma en pantalla
                using (Graphics papel = Graphics.FromImage(FirmaB))
                {
                    papel.Clear(Color.White);
                }
                PctFirma.Refresh();
            }
        }
    }
}
