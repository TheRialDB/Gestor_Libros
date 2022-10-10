namespace Gestor_Libros
{
    partial class GestorLibros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorLibros));
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFiltroTitulo = new System.Windows.Forms.Label();
            this.txtFiltrarTitulo = new System.Windows.Forms.TextBox();
            this.txtFiltrarAutor = new System.Windows.Forms.TextBox();
            this.txtFiltrarEditorial = new System.Windows.Forms.TextBox();
            this.lblFiltroAutor = new System.Windows.Forms.Label();
            this.lblFiltroEditorial = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.epvTextos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.lblFiltroCodigo = new System.Windows.Forms.Label();
            this.txtFiltrarCodigo = new System.Windows.Forms.TextBox();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnGestor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(101, 91);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(100, 20);
            this.txtEditorial.TabIndex = 33;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(19, 94);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(44, 13);
            this.lblEditorial.TabIndex = 32;
            this.lblEditorial.Text = "Editorial";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(274, 12);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.Size = new System.Drawing.Size(539, 264);
            this.dgvBook.TabIndex = 25;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(22, 151);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "Cargar";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(101, 64);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 23;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(101, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 22;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(101, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 21;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(19, 67);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 20;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(19, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Título";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(19, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código";
            // 
            // lblFiltroTitulo
            // 
            this.lblFiltroTitulo.AutoSize = true;
            this.lblFiltroTitulo.Location = new System.Drawing.Point(176, 198);
            this.lblFiltroTitulo.Name = "lblFiltroTitulo";
            this.lblFiltroTitulo.Size = new System.Drawing.Size(63, 13);
            this.lblFiltroTitulo.TabIndex = 35;
            this.lblFiltroTitulo.Text = "Filtrar Título";
            // 
            // txtFiltrarTitulo
            // 
            this.txtFiltrarTitulo.Location = new System.Drawing.Point(12, 195);
            this.txtFiltrarTitulo.Name = "txtFiltrarTitulo";
            this.txtFiltrarTitulo.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrarTitulo.TabIndex = 36;
            this.txtFiltrarTitulo.TextChanged += new System.EventHandler(this.txtFiltrarTitulo_TextChanged);
            // 
            // txtFiltrarAutor
            // 
            this.txtFiltrarAutor.Location = new System.Drawing.Point(12, 221);
            this.txtFiltrarAutor.Name = "txtFiltrarAutor";
            this.txtFiltrarAutor.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrarAutor.TabIndex = 37;
            this.txtFiltrarAutor.TextChanged += new System.EventHandler(this.txtFiltrarAutor_TextChanged);
            // 
            // txtFiltrarEditorial
            // 
            this.txtFiltrarEditorial.Location = new System.Drawing.Point(12, 247);
            this.txtFiltrarEditorial.Name = "txtFiltrarEditorial";
            this.txtFiltrarEditorial.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrarEditorial.TabIndex = 38;
            this.txtFiltrarEditorial.TextChanged += new System.EventHandler(this.txtFiltrarEditorial_TextChanged);
            // 
            // lblFiltroAutor
            // 
            this.lblFiltroAutor.AutoSize = true;
            this.lblFiltroAutor.Location = new System.Drawing.Point(176, 224);
            this.lblFiltroAutor.Name = "lblFiltroAutor";
            this.lblFiltroAutor.Size = new System.Drawing.Size(60, 13);
            this.lblFiltroAutor.TabIndex = 39;
            this.lblFiltroAutor.Text = "Filtrar Autor";
            // 
            // lblFiltroEditorial
            // 
            this.lblFiltroEditorial.AutoSize = true;
            this.lblFiltroEditorial.Location = new System.Drawing.Point(176, 250);
            this.lblFiltroEditorial.Name = "lblFiltroEditorial";
            this.lblFiltroEditorial.Size = new System.Drawing.Size(72, 13);
            this.lblFiltroEditorial.TabIndex = 40;
            this.lblFiltroEditorial.Text = "Filtrar Editorial";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(126, 151);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 41;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // epvTextos
            // 
            this.epvTextos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epvTextos.ContainerControl = this;
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.Location = new System.Drawing.Point(274, 282);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(158, 23);
            this.btnPrestamos.TabIndex = 42;
            this.btnPrestamos.Text = "Prestar";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // lblFiltroCodigo
            // 
            this.lblFiltroCodigo.AutoSize = true;
            this.lblFiltroCodigo.Location = new System.Drawing.Point(176, 276);
            this.lblFiltroCodigo.Name = "lblFiltroCodigo";
            this.lblFiltroCodigo.Size = new System.Drawing.Size(68, 13);
            this.lblFiltroCodigo.TabIndex = 43;
            this.lblFiltroCodigo.Text = "Filtrar Código";
            // 
            // txtFiltrarCodigo
            // 
            this.txtFiltrarCodigo.Location = new System.Drawing.Point(12, 273);
            this.txtFiltrarCodigo.Name = "txtFiltrarCodigo";
            this.txtFiltrarCodigo.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrarCodigo.TabIndex = 44;
            this.txtFiltrarCodigo.TextChanged += new System.EventHandler(this.txtFiltrarCodigo_TextChanged);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.Location = new System.Drawing.Point(462, 282);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(158, 23);
            this.btnDevoluciones.TabIndex = 45;
            this.btnDevoluciones.Text = "Devolver";
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnGestor
            // 
            this.btnGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestor.Location = new System.Drawing.Point(655, 282);
            this.btnGestor.Name = "btnGestor";
            this.btnGestor.Size = new System.Drawing.Size(158, 23);
            this.btnGestor.TabIndex = 46;
            this.btnGestor.Text = "Gestor de Prestamos";
            this.btnGestor.UseVisualStyleBackColor = true;
            this.btnGestor.Click += new System.EventHandler(this.btnGestor_Click);
            // 
            // GestorLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(825, 316);
            this.Controls.Add(this.btnGestor);
            this.Controls.Add(this.btnDevoluciones);
            this.Controls.Add(this.txtFiltrarCodigo);
            this.Controls.Add(this.lblFiltroCodigo);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblFiltroEditorial);
            this.Controls.Add(this.lblFiltroAutor);
            this.Controls.Add(this.txtFiltrarEditorial);
            this.Controls.Add(this.txtFiltrarAutor);
            this.Controls.Add(this.txtFiltrarTitulo);
            this.Controls.Add(this.lblFiltroTitulo);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestorLibros";
            this.Text = "Gestor de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvTextos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFiltroTitulo;
        private System.Windows.Forms.TextBox txtFiltrarTitulo;
        private System.Windows.Forms.TextBox txtFiltrarAutor;
        private System.Windows.Forms.TextBox txtFiltrarEditorial;
        private System.Windows.Forms.Label lblFiltroAutor;
        private System.Windows.Forms.Label lblFiltroEditorial;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ErrorProvider epvTextos;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.TextBox txtFiltrarCodigo;
        private System.Windows.Forms.Label lblFiltroCodigo;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnGestor;
    }
}

