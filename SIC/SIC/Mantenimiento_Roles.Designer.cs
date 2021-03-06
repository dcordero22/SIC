﻿namespace SIC
{
    partial class Mantenimiento_Roles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Roles));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_acpetar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id_rol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clb_procedimientos = new System.Windows.Forms.CheckedListBox();
            this.chb_Procedimientos = new System.Windows.Forms.CheckBox();
            this.chb_movimientos = new System.Windows.Forms.CheckBox();
            this.chb_sesiones = new System.Windows.Forms.CheckBox();
            this.clb_Casos = new System.Windows.Forms.CheckedListBox();
            this.chb_Casos = new System.Windows.Forms.CheckBox();
            this.clb_funcionarios = new System.Windows.Forms.CheckedListBox();
            this.chb_funcionarios = new System.Windows.Forms.CheckBox();
            this.clb_usuarios = new System.Windows.Forms.CheckedListBox();
            this.chb_usuarios = new System.Windows.Forms.CheckBox();
            this.clb_Roles = new System.Windows.Forms.CheckedListBox();
            this.chb_Roles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIC.Properties.Resources.IMG_Cliente_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(507, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btn_acpetar
            // 
            this.btn_acpetar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Check;
            this.btn_acpetar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acpetar.Location = new System.Drawing.Point(177, 386);
            this.btn_acpetar.Name = "btn_acpetar";
            this.btn_acpetar.Size = new System.Drawing.Size(47, 43);
            this.btn_acpetar.TabIndex = 1;
            this.btn_acpetar.UseVisualStyleBackColor = true;
            this.btn_acpetar.Click += new System.EventHandler(this.btn_acpetar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(452, 386);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 43);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_id_rol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del perfil";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(6, 82);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_id_rol
            // 
            this.txt_id_rol.Location = new System.Drawing.Point(6, 33);
            this.txt_id_rol.Name = "txt_id_rol";
            this.txt_id_rol.Size = new System.Drawing.Size(100, 20);
            this.txt_id_rol.TabIndex = 0;
            this.txt_id_rol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_rol_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre del rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id del rol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clb_procedimientos);
            this.groupBox2.Controls.Add(this.chb_Procedimientos);
            this.groupBox2.Controls.Add(this.chb_movimientos);
            this.groupBox2.Controls.Add(this.chb_sesiones);
            this.groupBox2.Controls.Add(this.clb_Casos);
            this.groupBox2.Controls.Add(this.chb_Casos);
            this.groupBox2.Controls.Add(this.clb_funcionarios);
            this.groupBox2.Controls.Add(this.chb_funcionarios);
            this.groupBox2.Controls.Add(this.clb_usuarios);
            this.groupBox2.Controls.Add(this.chb_usuarios);
            this.groupBox2.Controls.Add(this.clb_Roles);
            this.groupBox2.Controls.Add(this.chb_Roles);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 231);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos";
            // 
            // clb_procedimientos
            // 
            this.clb_procedimientos.Enabled = false;
            this.clb_procedimientos.FormattingEnabled = true;
            this.clb_procedimientos.Items.AddRange(new object[] {
            "Agrergar",
            "Actualizar",
            "Borrar",
            "Consultar"});
            this.clb_procedimientos.Location = new System.Drawing.Point(2, 150);
            this.clb_procedimientos.Name = "clb_procedimientos";
            this.clb_procedimientos.Size = new System.Drawing.Size(86, 64);
            this.clb_procedimientos.TabIndex = 9;
            // 
            // chb_Procedimientos
            // 
            this.chb_Procedimientos.AutoSize = true;
            this.chb_Procedimientos.Location = new System.Drawing.Point(2, 127);
            this.chb_Procedimientos.Name = "chb_Procedimientos";
            this.chb_Procedimientos.Size = new System.Drawing.Size(185, 17);
            this.chb_Procedimientos.TabIndex = 8;
            this.chb_Procedimientos.Text = "Mantenimiento de Procedimientos";
            this.chb_Procedimientos.UseVisualStyleBackColor = true;
            this.chb_Procedimientos.CheckedChanged += new System.EventHandler(this.chb_Procedimientos_CheckedChanged);
            // 
            // chb_movimientos
            // 
            this.chb_movimientos.AutoSize = true;
            this.chb_movimientos.Location = new System.Drawing.Point(352, 128);
            this.chb_movimientos.Name = "chb_movimientos";
            this.chb_movimientos.Size = new System.Drawing.Size(141, 17);
            this.chb_movimientos.TabIndex = 11;
            this.chb_movimientos.Text = "Bitacora de movimientos";
            this.chb_movimientos.UseVisualStyleBackColor = true;
            // 
            // chb_sesiones
            // 
            this.chb_sesiones.AutoSize = true;
            this.chb_sesiones.Location = new System.Drawing.Point(193, 127);
            this.chb_sesiones.Name = "chb_sesiones";
            this.chb_sesiones.Size = new System.Drawing.Size(124, 17);
            this.chb_sesiones.TabIndex = 10;
            this.chb_sesiones.Text = "Bitacora de sesiones";
            this.chb_sesiones.UseVisualStyleBackColor = true;
            // 
            // clb_Casos
            // 
            this.clb_Casos.FormattingEnabled = true;
            this.clb_Casos.Items.AddRange(new object[] {
            "Agrergar",
            "Actualizar",
            "Borrar",
            "Consultar"});
            this.clb_Casos.Location = new System.Drawing.Point(521, 56);
            this.clb_Casos.Name = "clb_Casos";
            this.clb_Casos.Size = new System.Drawing.Size(86, 64);
            this.clb_Casos.TabIndex = 7;
            // 
            // chb_Casos
            // 
            this.chb_Casos.AutoSize = true;
            this.chb_Casos.Location = new System.Drawing.Point(521, 33);
            this.chb_Casos.Name = "chb_Casos";
            this.chb_Casos.Size = new System.Drawing.Size(142, 17);
            this.chb_Casos.TabIndex = 6;
            this.chb_Casos.Text = "Mantenimiento de Casos";
            this.chb_Casos.UseVisualStyleBackColor = true;
            this.chb_Casos.CheckedChanged += new System.EventHandler(this.chb_Casos_CheckedChanged);
            // 
            // clb_funcionarios
            // 
            this.clb_funcionarios.FormattingEnabled = true;
            this.clb_funcionarios.Items.AddRange(new object[] {
            "Agrergar",
            "Actualizar",
            "Borrar",
            "Consultar"});
            this.clb_funcionarios.Location = new System.Drawing.Point(334, 56);
            this.clb_funcionarios.Name = "clb_funcionarios";
            this.clb_funcionarios.Size = new System.Drawing.Size(86, 64);
            this.clb_funcionarios.TabIndex = 5;
            // 
            // chb_funcionarios
            // 
            this.chb_funcionarios.AutoSize = true;
            this.chb_funcionarios.Location = new System.Drawing.Point(334, 33);
            this.chb_funcionarios.Name = "chb_funcionarios";
            this.chb_funcionarios.Size = new System.Drawing.Size(173, 17);
            this.chb_funcionarios.TabIndex = 4;
            this.chb_funcionarios.Text = "Mantenimiento de Funcionarios";
            this.chb_funcionarios.UseVisualStyleBackColor = true;
            this.chb_funcionarios.CheckedChanged += new System.EventHandler(this.chb_funcionarios_CheckedChanged);
            // 
            // clb_usuarios
            // 
            this.clb_usuarios.FormattingEnabled = true;
            this.clb_usuarios.Items.AddRange(new object[] {
            "Agrergar",
            "Actualizar",
            "Borrar",
            "Consultar"});
            this.clb_usuarios.Location = new System.Drawing.Point(165, 56);
            this.clb_usuarios.Name = "clb_usuarios";
            this.clb_usuarios.Size = new System.Drawing.Size(86, 64);
            this.clb_usuarios.TabIndex = 3;
            // 
            // chb_usuarios
            // 
            this.chb_usuarios.AutoSize = true;
            this.chb_usuarios.Location = new System.Drawing.Point(165, 33);
            this.chb_usuarios.Name = "chb_usuarios";
            this.chb_usuarios.Size = new System.Drawing.Size(154, 17);
            this.chb_usuarios.TabIndex = 2;
            this.chb_usuarios.Text = "Mantenimiento de Usuarios";
            this.chb_usuarios.UseVisualStyleBackColor = true;
            this.chb_usuarios.CheckedChanged += new System.EventHandler(this.chb_usuarios_CheckedChanged);
            // 
            // clb_Roles
            // 
            this.clb_Roles.Enabled = false;
            this.clb_Roles.FormattingEnabled = true;
            this.clb_Roles.Items.AddRange(new object[] {
            "Agrergar",
            "Actualizar",
            "Borrar",
            "Consultar"});
            this.clb_Roles.Location = new System.Drawing.Point(6, 56);
            this.clb_Roles.Name = "clb_Roles";
            this.clb_Roles.Size = new System.Drawing.Size(86, 64);
            this.clb_Roles.TabIndex = 1;
            // 
            // chb_Roles
            // 
            this.chb_Roles.AutoSize = true;
            this.chb_Roles.Location = new System.Drawing.Point(6, 33);
            this.chb_Roles.Name = "chb_Roles";
            this.chb_Roles.Size = new System.Drawing.Size(135, 17);
            this.chb_Roles.TabIndex = 0;
            this.chb_Roles.Text = "Mantenimiento de roles";
            this.chb_Roles.UseVisualStyleBackColor = true;
            this.chb_Roles.CheckedChanged += new System.EventHandler(this.chb_Roles_CheckedChanged);
            // 
            // Mantenimiento_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(695, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_acpetar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mantenimiento_Roles";
            this.Text = "Mantenimiento de roles";
            this.Load += new System.EventHandler(this.Mantenimiento_Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_acpetar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chb_movimientos;
        private System.Windows.Forms.CheckBox chb_sesiones;
        private System.Windows.Forms.CheckedListBox clb_Casos;
        private System.Windows.Forms.CheckBox chb_Casos;
        private System.Windows.Forms.CheckedListBox clb_funcionarios;
        private System.Windows.Forms.CheckBox chb_funcionarios;
        private System.Windows.Forms.CheckedListBox clb_usuarios;
        private System.Windows.Forms.CheckBox chb_usuarios;
        private System.Windows.Forms.CheckedListBox clb_Roles;
        private System.Windows.Forms.CheckBox chb_Roles;
        private System.Windows.Forms.CheckedListBox clb_procedimientos;
        private System.Windows.Forms.CheckBox chb_Procedimientos;
    }
}