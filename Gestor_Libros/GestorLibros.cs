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
        //creacion de listas para libros
        DataTable dtLibros = new DataTable() { TableName = "libros" };

        //mensajes de error
        const string ERROR_CODIGO_EXISTE = "Código existente, ingrese uno nuevo.";
        const string ERROR_CODIGO_BORRADO = "Libro no seleccionado";
        const string ERROR_CODIGO_PRESTADO = "Libro no seleccionado";
        const string ERROR_LIBRO_PRESTADO = "El libro no se haya disponible";
        const string DIRECCION_XML = @"C:\Users\Usuario\OneDrive\Escritorio\FACU\PROGRAMACIÓN\vs2022\Gestor_Libros\";

        string estado;

        //constructor
        public GestorLibros()
        {
            InitializeComponent();

            //columnas de mi tabla
            dtLibros.Columns.Add("Código");
            dtLibros.Columns.Add("Título");
            dtLibros.Columns.Add("Autor");
            dtLibros.Columns.Add("Editorial");
            dtLibros.Columns.Add("Estado");

            //lectura y carga de datos del dto
            Leer_DT();
            dgvBook.DataSource = dtLibros;

        }

        //boton para cargar
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //creacion de nuevo libro con sus atributos
            Libro libro = new Libro();

            libro.Codigo = txtCode.Text;
            libro.Titulo = txtTitle.Text;
            libro.Autor = txtAuthor.Text;
            libro.Editorial = txtEditorial.Text;

            //limpieza del error provider
            epvTextos.Clear();

            ////validacion para llenar los campos
            if (Validar())
            {

            }
            else
            {
                int fila = BuscarCodigo(libro.Codigo);
                if (fila != -1)
                {
                    MessageBox.Show(ERROR_CODIGO_EXISTE);
                }
                else
                {
                    estado = "Disponible";

                    //agregamos el nuevo libro a la lista
                    dtLibros.Rows.Add(new object[] { libro.Codigo, libro.Titulo, libro.Autor, libro.Editorial, estado });
                    dtLibros.WriteXml(DIRECCION_XML + "librito.xml");

                    dgvBook.DataSource = null;
                    dgvBook.DataSource = dtLibros;

                    //limpieza de txts
                    txtCode.Clear();
                    txtTitle.Clear();
                    txtAuthor.Clear();
                    txtEditorial.Clear();
                }
            }
        }

        //boton para borrar filas
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //validacion de codigo no encontrado
            if (dgvBook.CurrentRow == null)
            {
                MessageBox.Show(ERROR_CODIGO_BORRADO);
            }
            else
            {
                int fila = BuscarCodigo(dgvBook.CurrentRow.Cells[0].Value.ToString());

                if (fila != -1)
                {
                    dtLibros.Rows[fila].Delete();
                    dtLibros.WriteXml(DIRECCION_XML + "librito.xml");
                }
            }
        }

        //boton de prestamos
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            //validacion de codigo
            if (dgvBook.CurrentRow == null)
            {
                MessageBox.Show(ERROR_CODIGO_PRESTADO);
            }
            else
            {
                //validacion de disponibilidad
                string disponibilidad = dgvBook.CurrentRow.Cells[4].Value.ToString();
                if (disponibilidad == "Prestado")
                {
                    MessageBox.Show(ERROR_LIBRO_PRESTADO);
                }
                else
                {
                    //abrimos el 2do form con el codigo y la disponibilidad
                    GestorPrestamos gestorPrestamos = new GestorPrestamos(dgvBook.CurrentRow.Cells[0].Value.ToString(), disponibilidad);
                    gestorPrestamos.ShowDialog();

                    //cambio de la disponibilidad en caso de cambio
                    if (gestorPrestamos.bandera)
                    {
                        string codigo = dgvBook.CurrentRow.Cells[0].Value.ToString();
                        string titulo = dgvBook.CurrentRow.Cells[1].Value.ToString();
                        string autor = dgvBook.CurrentRow.Cells[2].Value.ToString();
                        string editorial = dgvBook.CurrentRow.Cells[3].Value.ToString();
                        estado = "Prestado";
                        dgvBook.Rows.Remove(dgvBook.CurrentRow);
                        dtLibros.Rows.Add(new object[] { codigo, titulo, autor, editorial, estado });
                    }
                }
            }
        }

        //boton de devoluciones
        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            //validacion de codigo
            if (dgvBook.CurrentRow == null)
            {
                MessageBox.Show(ERROR_CODIGO_PRESTADO);
            }
            else
            {
                //validacion de disponibilidad
                string disponibilidad = dgvBook.CurrentRow.Cells[4].Value.ToString();
                if (disponibilidad == "Disponible")
                {
                    MessageBox.Show(ERROR_LIBRO_PRESTADO);
                }
                else
                {
                    //abrimos el 2do form con el codigo y la disponibilidad
                    GestorPrestamos gestorPrestamos = new GestorPrestamos(dgvBook.CurrentRow.Cells[0].Value.ToString(), disponibilidad);
                    gestorPrestamos.ShowDialog();

                    //cambio de la disponibilidad en caso de cambio
                    if (gestorPrestamos.bandera)
                    {
                        string codigo = dgvBook.CurrentRow.Cells[0].Value.ToString();
                        string titulo = dgvBook.CurrentRow.Cells[1].Value.ToString();
                        string autor = dgvBook.CurrentRow.Cells[2].Value.ToString();
                        string editorial = dgvBook.CurrentRow.Cells[3].Value.ToString();
                        estado = "Disponible";
                        dgvBook.Rows.Remove(dgvBook.CurrentRow);
                        dtLibros.Rows.Add(new object[] { codigo, titulo, autor, editorial, estado });
                    }
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

        private void txtFiltrarCodigo_TextChanged(object sender, EventArgs e)
        {
            dtLibros.DefaultView.RowFilter = $"Código LIKE '{txtFiltrarCodigo.Text}%'";
        }

        //metodo para buscar codigo
        public int BuscarCodigo(string code)
        {
            int fila = -1;

            for (int i = 0; i < dtLibros.Rows.Count; i++)
            {
                if (dtLibros.Rows[i]["Código"].ToString() == code)
                {
                    fila = i;
                    break;
                }
            }

            return fila;
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
        //metodo para leer el datatable
        private void Leer_DT()
        {
            if (System.IO.File.Exists(DIRECCION_XML + "librito.xml"))
            {
                dtLibros.ReadXml(DIRECCION_XML + "librito.xml");
            }
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            GestorPrestamos gestorPrestamos = new GestorPrestamos();
            gestorPrestamos.ShowDialog();
        }

        //TODO:programar button1
    }
}
