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
    public partial class GestorPrestamos : Form
    {
        //creacion del datatable para personas
        DataTable dtPersonas = new DataTable() { TableName = "personas" };

        //variables para validaciones
        private string dato;
        private string valor;
        public bool bandera { get; set; }

        //constantes de mensaje
        const string ERROR_LIBRO_PRESTADO = "El libro no se haya disponible";
        const string ERROR_CODIGO = "Libro no seleccionado";
        const string LIBRO_DEVUELTO = "El libro fue devuelto";
        const string LIBRO_PRESTADO = "El libro fue prestado";
        const string DIRECCION_XML = @"C:\Users\Usuario\OneDrive\Escritorio\FACU\PROGRAMACIÓN\vs2022\Gestor_Libros\";

        //constructor
        public GestorPrestamos(string codigo, string estado)
        {
            InitializeComponent();
            //variables de validacion
            bandera = false;

            dato = codigo;
            valor = estado;

            //columnas de la tabla
            dtPersonas.Columns.Add("Nombres");
            dtPersonas.Columns.Add("Apellidos");
            dtPersonas.Columns.Add("DNI");
            dtPersonas.Columns.Add("Código");

            //lectura y carga de datos
            Leer_DT();
            dgvPersonas.DataSource = dtPersonas;
        }
        public GestorPrestamos()
        {
            InitializeComponent();

            //columnas de la tabla
            dtPersonas.Columns.Add("Nombres");
            dtPersonas.Columns.Add("Apellidos");
            dtPersonas.Columns.Add("DNI");
            dtPersonas.Columns.Add("Código");

            //lectura y carga de datos
            Leer_DT();
            dgvPersonas.DataSource = dtPersonas;
        }

        //boton para prestar
        private void btnPrestar_Click(object sender, EventArgs e)
        {
            //creacion de nueva persona
            Persona persona = new Persona();

            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Dni = txtDni.Text;

            //limpieza de error provider
            epvPersonas.Clear();

            //validacion para llenar campos
            if (Validar())
            {

            }
            else
            {
                if (dato == null)
                {
                    MessageBox.Show(ERROR_CODIGO);
                }
                else
                {
                    //carga de prestamos
                    dtPersonas.Rows.Add(new object[] { persona.Nombre, persona.Apellido, persona.Dni, dato });
                    dtPersonas.WriteXml(DIRECCION_XML + "personitas.xml");

                    dgvPersonas.DataSource = null;
                    dgvPersonas.DataSource = dtPersonas;

                    MessageBox.Show(LIBRO_PRESTADO);
                    bandera = true;
                    this.Close();
                }
            }
        }

        //boton para devolver
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (valor == "Disponible")
            {
                MessageBox.Show(ERROR_LIBRO_PRESTADO);
            }
            else
            {
                int fila = BuscarCodigo(dato);
                if (fila != -1)
                {
                    dtPersonas.Rows[fila].Delete();
                    dtPersonas.WriteXml(DIRECCION_XML + "personitas.xml");

                    MessageBox.Show(LIBRO_DEVUELTO);
                    bandera = true;
                    this.Close();
                }
            }
        }

        //filtros para buscar personas
        private void txtFiltrarNombre_TextChanged(object sender, EventArgs e)
        {
            dtPersonas.DefaultView.RowFilter = $"Nombres LIKE '{txtFiltrarNombre.Text}%'";
        }

        private void txtFiltrarApellido_TextChanged(object sender, EventArgs e)
        {
            dtPersonas.DefaultView.RowFilter = $"Apellidos LIKE '{txtFiltrarApellido.Text}%'";
        }

        private void txtFiltrarDni_TextChanged(object sender, EventArgs e)
        {
            dtPersonas.DefaultView.RowFilter = $"DNI LIKE '{txtFiltrarDni.Text}%'";
        }

        private void txtFiltrarCodigo_TextChanged(object sender, EventArgs e)
        {
            dtPersonas.DefaultView.RowFilter = $"Código LIKE '{txtFiltrarCodigo.Text}%'";
        }

        //metodos utiles para llenar campos, leer tabla, y buscar codigo
        private bool Validar()
        {
            bool validar = false;

            if (txtNombre.Text == "")
            {
                epvPersonas.SetError(txtNombre, "llenar campo");
                validar = true;
            }
            if (txtApellido.Text == "")
            {
                epvPersonas.SetError(txtApellido, "llenar campo");
                validar = true;
            }
            if (txtDni.Text == "")
            {
                epvPersonas.SetError(txtDni, "llenar campo");
                validar = true;
            }
            return validar;
        }

        private void Leer_DT()
        {
            if (System.IO.File.Exists(DIRECCION_XML + "personitas.xml"))
            {
                dtPersonas.ReadXml(DIRECCION_XML + "personitas.xml");
            }
        }

        public int BuscarCodigo(string code)
        {
            int fila = -1;

            for (int i = 0; i < dtPersonas.Rows.Count; i++)
            {
                if (dtPersonas.Rows[i]["Código"].ToString() == code)
                {
                    fila = i;
                    break;
                }
            }

            return fila;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
