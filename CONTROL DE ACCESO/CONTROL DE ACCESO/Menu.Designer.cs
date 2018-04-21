namespace CONTROL_DE_ACCESO
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.Agregar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Buscar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_P = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_M = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(27, 280);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(92, 32);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(114, 35);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(157, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "UID";
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(114, 85);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(157, 20);
            this.txt_uid.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "Leer desde arduino";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(666, 35);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(115, 29);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(145, 280);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(112, 32);
            this.Eliminar.TabIndex = 9;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(653, 393);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 44);
            this.button7.TabIndex = 10;
            this.button7.Text = "Regresar al menu";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido Paterno";
            // 
            // txt_P
            // 
            this.txt_P.Location = new System.Drawing.Point(118, 132);
            this.txt_P.Name = "txt_P";
            this.txt_P.Size = new System.Drawing.Size(157, 20);
            this.txt_P.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Apellido Materno";
            // 
            // txt_M
            // 
            this.txt_M.Location = new System.Drawing.Point(118, 180);
            this.txt_M.Name = "txt_M";
            this.txt_M.Size = new System.Drawing.Size(155, 20);
            this.txt_M.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Departamento ";
            // 
            // txt_D
            // 
            this.txt_D.Location = new System.Drawing.Point(116, 232);
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(157, 20);
            this.txt_D.TabIndex = 15;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(405, 40);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(239, 20);
            this.txt_B.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(439, 278);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_M);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_P);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.Agregar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Button button3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_P;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_D;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}