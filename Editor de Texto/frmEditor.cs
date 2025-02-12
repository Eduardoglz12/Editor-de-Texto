namespace Editor_de_Texto
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        //Variables
        bool archivoGuardado = false;
        string filePath = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (archivoGuardado == true)
            {
                this.Close();
            }
            else
            {
                DialogResult resultado;
                resultado = MessageBox.Show("¿Desea guardar los cambios?", "Salir", MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {
                    guardarToolStripMenuItem_Click(sender, e);
                    this.Close();
                }
                else if (resultado == DialogResult.No)
                {
                    this.Close();
                }
            }

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialogEditor.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialogEditor.FileName;

                try
                {
                    string texto = File.ReadAllText(filePath);
                    rtbEditor.Text = texto;
                    archivoGuardado = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }

            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (archivoGuardado == false && filePath == null)
            {
                resultado = saveFileDialogEditor.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    filePath = saveFileDialogEditor.FileName;
                    string texto = rtbEditor.Text;

                    try
                    {
                        File.WriteAllText(filePath, texto);
                        MessageBox.Show("Archivo guardado correctamente");
                        archivoGuardado = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                    }

                }
            }
            else if(archivoGuardado == true || filePath != null)
            {
                try
                {
                    string texto = rtbEditor.Text;
                    File.WriteAllText(filePath, texto);
                    MessageBox.Show("Archivo guardado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialogEditor_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            resultado = saveFileDialogEditor.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = saveFileDialogEditor.FileName;
                string texto = rtbEditor.Text;

                try
                {
                    File.WriteAllText(filePath, texto);
                    MessageBox.Show("Archivo guardado correctamente");
                    archivoGuardado = true;
                    //filePath = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }

            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoGuardado = false;
            filePath = null;

            rtbEditor.Clear();

        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            archivoGuardado = false;
        }
    }
}
