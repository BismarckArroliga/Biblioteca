namespace capaPresentacion
{
    partial class frmSistema
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
            this.pnlOpciones = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnDevoluciones = new FontAwesome.Sharp.IconButton();
            this.frmPrestamos = new FontAwesome.Sharp.IconButton();
            this.btnLlbros = new FontAwesome.Sharp.IconButton();
            this.btnEstudiantes = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlOpciones.Controls.Add(this.btnUsuarios);
            this.pnlOpciones.Controls.Add(this.btnEmpleados);
            this.pnlOpciones.Controls.Add(this.btnDevoluciones);
            this.pnlOpciones.Controls.Add(this.frmPrestamos);
            this.pnlOpciones.Controls.Add(this.btnLlbros);
            this.pnlOpciones.Controls.Add(this.btnEstudiantes);
            this.pnlOpciones.Controls.Add(this.btnInicio);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.ShadowDecoration.Parent = this.pnlOpciones;
            this.pnlOpciones.Size = new System.Drawing.Size(250, 661);
            this.pnlOpciones.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUsuarios.IconSize = 24;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 400);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(250, 50);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 30;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 350);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(250, 50);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevoluciones.FlatAppearance.BorderSize = 0;
            this.btnDevoluciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnDevoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnDevoluciones.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.btnDevoluciones.IconColor = System.Drawing.Color.White;
            this.btnDevoluciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevoluciones.IconSize = 24;
            this.btnDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevoluciones.Location = new System.Drawing.Point(0, 300);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnDevoluciones.Size = new System.Drawing.Size(250, 50);
            this.btnDevoluciones.TabIndex = 3;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // frmPrestamos
            // 
            this.frmPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.frmPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmPrestamos.FlatAppearance.BorderSize = 0;
            this.frmPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.frmPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.frmPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmPrestamos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmPrestamos.ForeColor = System.Drawing.Color.White;
            this.frmPrestamos.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.frmPrestamos.IconColor = System.Drawing.Color.White;
            this.frmPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.frmPrestamos.IconSize = 24;
            this.frmPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frmPrestamos.Location = new System.Drawing.Point(0, 250);
            this.frmPrestamos.Name = "frmPrestamos";
            this.frmPrestamos.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.frmPrestamos.Size = new System.Drawing.Size(250, 50);
            this.frmPrestamos.TabIndex = 2;
            this.frmPrestamos.Text = "Prestamos";
            this.frmPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frmPrestamos.UseVisualStyleBackColor = false;
            this.frmPrestamos.Click += new System.EventHandler(this.frmPrestamos_Click);
            // 
            // btnLlbros
            // 
            this.btnLlbros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLlbros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLlbros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLlbros.FlatAppearance.BorderSize = 0;
            this.btnLlbros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnLlbros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLlbros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlbros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlbros.ForeColor = System.Drawing.Color.White;
            this.btnLlbros.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnLlbros.IconColor = System.Drawing.Color.White;
            this.btnLlbros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLlbros.IconSize = 24;
            this.btnLlbros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLlbros.Location = new System.Drawing.Point(0, 200);
            this.btnLlbros.Name = "btnLlbros";
            this.btnLlbros.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnLlbros.Size = new System.Drawing.Size(250, 50);
            this.btnLlbros.TabIndex = 1;
            this.btnLlbros.Text = "Libros";
            this.btnLlbros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLlbros.UseVisualStyleBackColor = false;
            this.btnLlbros.Click += new System.EventHandler(this.btnLlbros_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnEstudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnEstudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnEstudiantes.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnEstudiantes.IconColor = System.Drawing.Color.White;
            this.btnEstudiantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstudiantes.IconSize = 25;
            this.btnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.Location = new System.Drawing.Point(0, 150);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnEstudiantes.Size = new System.Drawing.Size(250, 50);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.Image = global::capaPresentacion.Properties.Resources.udem;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.ShadowDecoration.Parent = this.btnInicio;
            this.btnInicio.Size = new System.Drawing.Size(250, 150);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Tag = "";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(250, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.ShadowDecoration.Parent = this.pnlPrincipal;
            this.pnlPrincipal.Size = new System.Drawing.Size(934, 661);
            this.pnlPrincipal.TabIndex = 1;
            this.pnlPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPrincipal_MouseDown);
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlOpciones);
            this.MinimumSize = new System.Drawing.Size(1120, 700);
            this.Name = "frmSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmSistema_Load);
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlOpciones;
        private Guna.UI2.WinForms.Guna2Panel pnlPrincipal;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private FontAwesome.Sharp.IconButton btnEstudiantes;
        private FontAwesome.Sharp.IconButton btnLlbros;
        private FontAwesome.Sharp.IconButton frmPrestamos;
        private Guna.UI2.WinForms.Guna2PictureBox btnInicio;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnDevoluciones;
    }
}

