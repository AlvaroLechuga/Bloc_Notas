using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloc_Notas
{
    public partial class Bloc_Notas : Form
    {
        string fichero = "";
        public Bloc_Notas()
        {
            InitializeComponent();
        }

        private void mNuevo_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                DialogResult boton = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (boton == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Archivos texto(*.txt/*.rtf)|*.txt;*.rtf;";
                    sfd.Title = "Guardar un archivo";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter escritura = null; 
                        string ruta = sfd.FileName;
                        escritura = File.AppendText(ruta);
                        escritura.Write(txtResultado.Text);
                        escritura.Flush();
                        txtResultado.Text = "";
                    }
                }
                else
                {
                    txtResultado.Text = "";
                    fichero = "";

                }
            }
        }

        private void mAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos texto(*.txt/*.rtf)|*.txt;*.rtf;";
            ofd.Title = "Abrir un archivo";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader lectura = null;
                string ruta = ofd.FileName;
                lectura = File.OpenText(ruta);
                txtResultado.Text = lectura.ReadToEnd();
            }
            ofd.Dispose();
        }

        private void mGuardar_Click(object sender, EventArgs e)
        {
            if (fichero == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivos texto(*.txt/*.rtf)|*.txt;*.rtf;";
                sfd.Title = "Guardar un archivo";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter escritura = null;
                    string ruta = sfd.FileName;
                    escritura = File.AppendText(ruta);
                    escritura.Write(txtResultado.Text);
                    escritura.Flush();
                }
                sfd.Dispose();
            }
            
        }

        private void mSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mCortar_Click(object sender, EventArgs e)
        {
            txtResultado.Cut();
        }

        private void mCopiar_Click(object sender, EventArgs e)
        {
            txtResultado.Copy();
        }

        private void mPegar_Click(object sender, EventArgs e)
        {
            txtResultado.Paste();
        }

        private void mBuscar_Click(object sender, EventArgs e)
        {
            string cadena = Microsoft.VisualBasic.Interaction.InputBox("Ingresa un Dato:");

            if (txtResultado.Text.Contains(cadena))
            {

                int pos = txtResultado.Text.LastIndexOf(cadena);
                txtResultado.SelectionStart = pos;

                txtResultado.SelectionLength = cadena.Length;

            }

        }

        private void mFuente_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                txtResultado.SelectionFont = font.Font;
            }
        }

        private void mColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                txtResultado.SelectionColor = color.Color;
            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            mNuevo_Click(sender, e);
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            mAbrir_Click(sender, e);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            mGuardar_Click(sender, e);
        }

        private void Cortar_Click(object sender, EventArgs e)
        {
            mCortar_Click(sender, e);
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            mCopiar_Click(sender, e);
        }

        private void Pegar_Click(object sender, EventArgs e)
        {
            mPegar_Click(sender, e);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            mBuscar_Click(sender, e);
        }

        private void Fuente_Click(object sender, EventArgs e)
        {
            mFuente_Click(sender, e);
        }

        private void Color_Click(object sender, EventArgs e)
        {
            mColor_Click(sender, e);
        }
	}
}
