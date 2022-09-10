using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Libros
{
    public partial class GestorLibros : Form
    {
        //creacion de listas para libros y codigos respectivamente
        List<string> listaCodigos = new List<string>();
        DataTable dtLibros = new DataTable();

        //creacion e inicializacion de los sumadores para cada tipo de libro
        int libroVocal = 0;
        int libroCons = 0;
        int libroNum = 0;

        const string ERROR_CODIGO_EXISTE = "Código existente, ingrese uno nuevo.";
        const string ERROR_CODIGO_BORRADO = "Libro no seleccionado";

        public GestorLibros()
        {
            InitializeComponent();
            
            dtLibros.Columns.Add("Código");
            dtLibros.Columns.Add("Título");
            dtLibros.Columns.Add("Autor");
            dtLibros.Columns.Add("Editorial");
        }

        //boton para cargar
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();

            libro.Codigo = txtCode.Text;
            libro.Titulo = txtTitle.Text;
            libro.Autor = txtAuthor.Text;
            libro.Editorial = txtEditorial.Text;
           
            epvTextos.Clear();

            //validacion para no repetir codigo
            if (Validar())
            {
                
            }
            else
            {
                if (listaCodigos.Contains(libro.Codigo))
                {
                    MessageBox.Show(ERROR_CODIGO_EXISTE);
                }
                else
                {
                    //agregamos objetos a las listas
                    listaCodigos.Add(libro.Codigo);

                    dtLibros.Rows.Add(new object[] { libro.Codigo, libro.Titulo, libro.Autor, libro.Editorial });

                    dgvBook.DataSource = null;
                    dgvBook.DataSource = dtLibros;

                    var titulo = libro.Titulo.ToLower();

                    libro.Analizar(titulo, ref libroVocal, ref libroNum, ref libroCons);

                    lblVocales.Text = libroVocal.ToString();
                    lblNumeros.Text = libroNum.ToString();
                    lblConso.Text = libroCons.ToString();

                    txtCode.Clear();
                    txtTitle.Clear();
                    txtAuthor.Clear();
                    txtEditorial.Clear();
                }
            }                 
        }       
        
        //filtros para buscar libros
        private void txtFiltrarTitulo_TextChanged(object sender, EventArgs e)
        {
            dtLibros.DefaultView.RowFilter = $"Título LIKE '{txtFiltrarTitulo.Text}%'";
        }

        private void txtFiltrarAutor_TextChanged(object sender, EventArgs e)
        {
            dtLibros.DefaultView.RowFilter = $"Autor LIKE '{txtFiltrarAutor.Text}%'";
        }

        private void txtFiltrarEditorial_TextChanged(object sender, EventArgs e)
        {
            dtLibros.DefaultView.RowFilter = $"Editorial LIKE '{txtFiltrarEditorial.Text}%'";
        }

        //boton para borrar filas
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow == null)
            {
                MessageBox.Show(ERROR_CODIGO_BORRADO);
            }
            else
            {
                string titulo = dgvBook.CurrentRow.Cells[1].Value.ToString();
                
                dgvBook.Rows.Remove(dgvBook.CurrentRow);

                Libro.Descontar(titulo, ref libroVocal, ref libroNum, ref libroCons);

                lblVocales.Text = libroVocal.ToString();
                lblNumeros.Text = libroNum.ToString();
                lblConso.Text = libroCons.ToString();
            }
        }

        //metodo para tener que llenar los campos
        private bool Validar()
        {
            bool validar = false;

            if (txtCode.Text == "")
            {
                epvTextos.SetError(txtCode, "llenar campo");
                validar = true;
            }
            if (txtTitle.Text == "")
            {
                epvTextos.SetError(txtTitle, "llenar campo");
                validar = true;
            }
            if (txtAuthor.Text == "")
            {
                epvTextos.SetError(txtAuthor, "llenar campo");
                validar = true;
            }
            if (txtEditorial.Text == "")
            {
                epvTextos.SetError(txtEditorial, "llenar campo");
                validar = true;
            }
            return validar;         
        }
    }
}
