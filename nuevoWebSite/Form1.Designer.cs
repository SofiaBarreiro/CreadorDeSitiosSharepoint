namespace nuevoWebSite
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CrearSitio = new System.Windows.Forms.Button();
            this.CrearLink = new System.Windows.Forms.Button();
            this.CrearLista = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxSite = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.parametroURLLista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NombreLista = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CrearSitio
            // 
            this.CrearSitio.Location = new System.Drawing.Point(35, 80);
            this.CrearSitio.Name = "CrearSitio";
            this.CrearSitio.Size = new System.Drawing.Size(94, 28);
            this.CrearSitio.TabIndex = 0;
            this.CrearSitio.Text = "Crear sitio";
            this.CrearSitio.UseVisualStyleBackColor = true;
            this.CrearSitio.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrearLink
            // 
            this.CrearLink.Location = new System.Drawing.Point(35, 161);
            this.CrearLink.Name = "CrearLink";
            this.CrearLink.Size = new System.Drawing.Size(94, 28);
            this.CrearLink.TabIndex = 1;
            this.CrearLink.Text = "Crear link";
            this.CrearLink.UseVisualStyleBackColor = true;
            this.CrearLink.Click += new System.EventHandler(this.button2_Click);
            // 
            // CrearLista
            // 
            this.CrearLista.Location = new System.Drawing.Point(37, 228);
            this.CrearLista.Name = "CrearLista";
            this.CrearLista.Size = new System.Drawing.Size(94, 28);
            this.CrearLista.TabIndex = 2;
            this.CrearLista.Text = "Crear lista";
            this.CrearLista.UseVisualStyleBackColor = true;
            this.CrearLista.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "URL";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(611, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Site Collection URL";
            // 
            // TextBoxSite
            // 
            this.TextBoxSite.Location = new System.Drawing.Point(186, 35);
            this.TextBoxSite.Name = "TextBoxSite";
            this.TextBoxSite.Size = new System.Drawing.Size(227, 20);
            this.TextBoxSite.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(611, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del sitio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(292, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 20);
            this.textBox5.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Parámetro URL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Parámetro URL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // parametroURLLista
            // 
            this.parametroURLLista.Location = new System.Drawing.Point(292, 236);
            this.parametroURLLista.Name = "parametroURLLista";
            this.parametroURLLista.Size = new System.Drawing.Size(204, 20);
            this.parametroURLLista.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nombre de la lista";
            // 
            // NombreLista
            // 
            this.NombreLista.Location = new System.Drawing.Point(611, 240);
            this.NombreLista.Name = "NombreLista";
            this.NombreLista.Size = new System.Drawing.Size(204, 20);
            this.NombreLista.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(611, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 404);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.parametroURLLista);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NombreLista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.TextBoxSite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CrearLista);
            this.Controls.Add(this.CrearLink);
            this.Controls.Add(this.CrearSitio);
            this.Name = "Form1";
            this.Text = "Creador de Sitios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CrearSitio;
        private System.Windows.Forms.Button CrearLink;
        private System.Windows.Forms.Button CrearLista;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxSite;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox parametroURLLista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NombreLista;
        private System.Windows.Forms.TextBox textBox2;
    }
}

