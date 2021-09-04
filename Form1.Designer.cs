
namespace MICRUD
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(329, 70);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(196, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(329, 96);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(196, 20);
            this.txt_direccion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cedula";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(329, 122);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(141, 20);
            this.txt_cedula.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(329, 148);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(118, 20);
            this.txt_telefono.TabIndex = 6;
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(231, 197);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_insertar.TabIndex = 8;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(390, 197);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 9;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(471, 197);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(312, 197);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(115, 239);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(572, 199);
            this.dataView.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Documento";
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(347, 40);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(100, 20);
            this.txt_documento.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_documento;
    }
}

