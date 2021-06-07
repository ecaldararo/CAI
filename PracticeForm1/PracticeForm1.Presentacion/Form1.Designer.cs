
using System.Windows.Forms;

namespace PracticeForm1.Presentacion
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnFrm2 = new System.Windows.Forms.Button();
            this.chkBoxActivo = new System.Windows.Forms.CheckBox();
            this.cmbEC = new System.Windows.Forms.ComboBox();
            this.lvlEC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(36, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(36, 109);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 22);
            this.txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(33, 89);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(239, 37);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(352, 148);
            this.lstClientes.TabIndex = 5;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(239, 208);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(177, 30);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "Borrar Lista";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(239, 254);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(177, 30);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Recargar Lista";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnFrm2
            // 
            this.btnFrm2.Location = new System.Drawing.Point(491, 242);
            this.btnFrm2.Name = "btnFrm2";
            this.btnFrm2.Size = new System.Drawing.Size(100, 42);
            this.btnFrm2.TabIndex = 8;
            this.btnFrm2.Text = "Otro Formulario";
            this.btnFrm2.UseVisualStyleBackColor = true;
            this.btnFrm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkBoxActivo
            // 
            this.chkBoxActivo.AutoSize = true;
            this.chkBoxActivo.Location = new System.Drawing.Point(34, 208);
            this.chkBoxActivo.Name = "chkBoxActivo";
            this.chkBoxActivo.Size = new System.Drawing.Size(68, 21);
            this.chkBoxActivo.TabIndex = 9;
            this.chkBoxActivo.Text = "Activo";
            this.chkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // cmbEC
            // 
            this.cmbEC.FormattingEnabled = true;
            this.cmbEC.Location = new System.Drawing.Point(36, 161);
            this.cmbEC.Name = "cmbEC";
            this.cmbEC.Size = new System.Drawing.Size(151, 24);
            this.cmbEC.TabIndex = 10;
            this.cmbEC.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lvlEC
            // 
            this.lvlEC.AutoSize = true;
            this.lvlEC.Location = new System.Drawing.Point(33, 140);
            this.lvlEC.Name = "lvlEC";
            this.lvlEC.Size = new System.Drawing.Size(81, 17);
            this.lvlEC.TabIndex = 11;
            this.lvlEC.Text = "Estado Civil";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 308);
            this.Controls.Add(this.lvlEC);
            this.Controls.Add(this.cmbEC);
            this.Controls.Add(this.chkBoxActivo);
            this.Controls.Add(this.btnFrm2);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "txtNombre";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnFrm2;
        private System.Windows.Forms.CheckBox chkBoxActivo;
        private System.Windows.Forms.ComboBox cmbEC;
        private System.Windows.Forms.Label lvlEC;

    }
}

