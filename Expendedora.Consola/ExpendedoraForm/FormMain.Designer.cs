
namespace ExpendedoraForm
{
    partial class FormMain
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
            this.btnListarLatas = new System.Windows.Forms.Button();
            this.btnAddLata = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListarLatas
            // 
            this.btnListarLatas.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarLatas.Location = new System.Drawing.Point(54, 100);
            this.btnListarLatas.Name = "btnListarLatas";
            this.btnListarLatas.Size = new System.Drawing.Size(200, 51);
            this.btnListarLatas.TabIndex = 0;
            this.btnListarLatas.Text = "Listar Latas";
            this.btnListarLatas.UseVisualStyleBackColor = true;
            this.btnListarLatas.Click += new System.EventHandler(this.btnListarLatas_Click);
            // 
            // btnAddLata
            // 
            this.btnAddLata.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLata.Location = new System.Drawing.Point(54, 157);
            this.btnAddLata.Name = "btnAddLata";
            this.btnAddLata.Size = new System.Drawing.Size(200, 51);
            this.btnAddLata.TabIndex = 1;
            this.btnAddLata.Text = "Agregar Lata";
            this.btnAddLata.UseVisualStyleBackColor = true;
            this.btnAddLata.Click += new System.EventHandler(this.btnAddLata_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expendedora";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddLata);
            this.Controls.Add(this.btnListarLatas);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarLatas;
        private System.Windows.Forms.Button btnAddLata;
        private System.Windows.Forms.Label label1;
    }
}

