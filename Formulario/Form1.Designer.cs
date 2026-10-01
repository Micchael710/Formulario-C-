namespace Formulario
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
            components = new System.ComponentModel.Container();
            lblCodigo = new Label();
            lblNombres = new Label();
            lblApellidos = new Label();
            lblDireccion = new Label();
            lblCelular = new Label();
            lblCorreo = new Label();
            txtCodigo = new TextBox();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtDireccion = new TextBox();
            txtCelular = new TextBox();
            txtCorreo = new TextBox();
            btnGuardar = new Button();
            dgvEstudiante = new DataGridView();
            lblHoraActual = new Label();
            lblHoraTexto = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(72, 31);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(77, 25);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombres.Location = new Point(72, 78);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(94, 25);
            lblNombres.TabIndex = 1;
            lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellidos.Location = new Point(72, 129);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(94, 25);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(72, 177);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(96, 25);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Dirección";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCelular.Location = new Point(72, 228);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(74, 25);
            lblCelular.TabIndex = 4;
            lblCelular.Text = "Celular";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(493, 151);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(178, 25);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo Electrónico";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(155, 36);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(146, 23);
            txtCodigo.TabIndex = 6;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(172, 80);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(146, 23);
            txtNombres.TabIndex = 7;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(172, 131);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(146, 23);
            txtApellidos.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(172, 177);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(146, 23);
            txtDireccion.TabIndex = 9;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(155, 233);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(146, 23);
            txtCelular.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(493, 182);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(188, 23);
            txtCorreo.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(493, 227);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 32);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvEstudiante
            // 
            dgvEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstudiante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiante.Location = new Point(76, 292);
            dgvEstudiante.Name = "dgvEstudiante";
            dgvEstudiante.Size = new Size(712, 295);
            dgvEstudiante.TabIndex = 13;
            // 
            // lblHoraActual
            // 
            lblHoraActual.AutoSize = true;
            lblHoraActual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraActual.Location = new Point(555, 31);
            lblHoraActual.Name = "lblHoraActual";
            lblHoraActual.Size = new Size(0, 25);
            lblHoraActual.TabIndex = 14;
            // 
            // lblHoraTexto
            // 
            lblHoraTexto.AutoSize = true;
            lblHoraTexto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraTexto.Location = new Point(449, 31);
            lblHoraTexto.Name = "lblHoraTexto";
            lblHoraTexto.Size = new Size(120, 25);
            lblHoraTexto.TabIndex = 15;
            lblHoraTexto.Text = "Hora actual:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 633);
            Controls.Add(lblHoraTexto);
            Controls.Add(lblHoraActual);
            Controls.Add(dgvEstudiante);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(txtCelular);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(txtCodigo);
            Controls.Add(lblCorreo);
            Controls.Add(lblCelular);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombres);
            Controls.Add(lblCodigo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombres;
        private Label lblApellidos;
        private Label lblDireccion;
        private Label lblCelular;
        private Label lblCorreo;
        private TextBox txtCodigo;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtDireccion;
        private TextBox txtCelular;
        private TextBox txtCorreo;
        private Button btnGuardar;
        private DataGridView dgvEstudiante;
        private Label lblHoraActual;
        private Label lblHoraTexto;
        private System.Windows.Forms.Timer timer1;
    }
}
