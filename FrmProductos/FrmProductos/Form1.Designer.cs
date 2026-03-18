namespace FrmProductos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtId = new TextBox();
            rtbVistaPrevia = new RichTextBox();
            btnAgregar = new Button();
            dgvProductos = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnExportarTexto = new Button();
            btnRBinario = new Button();
            btnVistaPrevia = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(36, 54);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // rtbVistaPrevia
            // 
            rtbVistaPrevia.Location = new Point(346, 12);
            rtbVistaPrevia.Name = "rtbVistaPrevia";
            rtbVistaPrevia.Size = new Size(125, 319);
            rtbVistaPrevia.TabIndex = 2;
            rtbVistaPrevia.Text = "";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(36, 347);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(488, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(300, 319);
            dgvProductos.TabIndex = 4;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(109, 395);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(169, 347);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnExportarTexto
            // 
            btnExportarTexto.Location = new Point(377, 347);
            btnExportarTexto.Name = "btnExportarTexto";
            btnExportarTexto.Size = new Size(94, 29);
            btnExportarTexto.TabIndex = 7;
            btnExportarTexto.Text = "Exportar";
            btnExportarTexto.UseVisualStyleBackColor = true;
            btnExportarTexto.Click += btnExportarTexto_Click;
            // 
            // btnRBinario
            // 
            btnRBinario.Location = new Point(377, 417);
            btnRBinario.Name = "btnRBinario";
            btnRBinario.Size = new Size(94, 29);
            btnRBinario.TabIndex = 8;
            btnRBinario.Text = "Respaldo";
            btnRBinario.UseVisualStyleBackColor = true;
            btnRBinario.Click += btnRBinario_Click;
            // 
            // btnVistaPrevia
            // 
            btnVistaPrevia.Location = new Point(377, 382);
            btnVistaPrevia.Name = "btnVistaPrevia";
            btnVistaPrevia.Size = new Size(94, 29);
            btnVistaPrevia.TabIndex = 9;
            btnVistaPrevia.Text = "Vista";
            btnVistaPrevia.UseVisualStyleBackColor = true;
            btnVistaPrevia.Click += btnVistaPrevia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(36, 123);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(36, 190);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 11;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(36, 258);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 12;
            label4.Text = "Cantidad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(109, 187);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 14;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(109, 255);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVistaPrevia);
            Controls.Add(btnRBinario);
            Controls.Add(btnExportarTexto);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dgvProductos);
            Controls.Add(btnAgregar);
            Controls.Add(rtbVistaPrevia);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private RichTextBox rtbVistaPrevia;
        private Button btnAgregar;
        private DataGridView dgvProductos;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnExportarTexto;
        private Button btnRBinario;
        private Button btnVistaPrevia;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
    }
}
