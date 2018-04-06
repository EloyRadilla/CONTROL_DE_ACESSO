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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_P = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_M = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(265, 66);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "UID";
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(265, 328);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(100, 20);
            this.txt_uid.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Verificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "Leer desde arduino";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "Consultar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 48);
            this.button5.TabIndex = 8;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 52);
            this.button6.TabIndex = 9;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 304);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 44);
            this.button7.TabIndex = 10;
            this.button7.Text = "Regresar al menu";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido Paterno";
            // 
            // txt_P
            // 
            this.txt_P.Location = new System.Drawing.Point(265, 132);
            this.txt_P.Name = "txt_P";
            this.txt_P.Size = new System.Drawing.Size(100, 20);
            this.txt_P.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Apellido Materno";
            // 
            // txt_M
            // 
            this.txt_M.Location = new System.Drawing.Point(265, 193);
            this.txt_M.Name = "txt_M";
            this.txt_M.Size = new System.Drawing.Size(100, 20);
            this.txt_M.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Departamento ";
            // 
            // txt_D
            // 
            this.txt_D.Location = new System.Drawing.Point(265, 262);
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(100, 20);
            this.txt_D.TabIndex = 15;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_M);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_P);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_P;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_D;
    }
}