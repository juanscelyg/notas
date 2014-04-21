namespace notas
{
    partial class Form3
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tipoDeMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasTeoricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasConLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.primer_corte = new System.Windows.Forms.Label();
            this.segundo_corte = new System.Windows.Forms.Label();
            this.tercer_corte = new System.Windows.Forms.Label();
            this.laboratorio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nota_ne = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeMateriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(335, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tipoDeMateriaToolStripMenuItem
            // 
            this.tipoDeMateriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiasTeoricasToolStripMenuItem,
            this.materiasConLaboratorioToolStripMenuItem});
            this.tipoDeMateriaToolStripMenuItem.Name = "tipoDeMateriaToolStripMenuItem";
            this.tipoDeMateriaToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.tipoDeMateriaToolStripMenuItem.Text = "Tipo de materia";
            // 
            // materiasTeoricasToolStripMenuItem
            // 
            this.materiasTeoricasToolStripMenuItem.Name = "materiasTeoricasToolStripMenuItem";
            this.materiasTeoricasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.materiasTeoricasToolStripMenuItem.Text = "Materias Teoricas";
            this.materiasTeoricasToolStripMenuItem.Click += new System.EventHandler(this.materiasTeoricasToolStripMenuItem_Click);
            // 
            // materiasConLaboratorioToolStripMenuItem
            // 
            this.materiasConLaboratorioToolStripMenuItem.Name = "materiasConLaboratorioToolStripMenuItem";
            this.materiasConLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.materiasConLaboratorioToolStripMenuItem.Text = "Materias con laboratorio";
            this.materiasConLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.materiasConLaboratorioToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción de materia";
            // 
            // primer_corte
            // 
            this.primer_corte.AutoSize = true;
            this.primer_corte.Location = new System.Drawing.Point(22, 177);
            this.primer_corte.Name = "primer_corte";
            this.primer_corte.Size = new System.Drawing.Size(63, 13);
            this.primer_corte.TabIndex = 4;
            this.primer_corte.Text = "Primer corte";
            // 
            // segundo_corte
            // 
            this.segundo_corte.AutoSize = true;
            this.segundo_corte.Location = new System.Drawing.Point(22, 207);
            this.segundo_corte.Name = "segundo_corte";
            this.segundo_corte.Size = new System.Drawing.Size(77, 13);
            this.segundo_corte.TabIndex = 5;
            this.segundo_corte.Text = "Segundo corte";
            // 
            // tercer_corte
            // 
            this.tercer_corte.AutoSize = true;
            this.tercer_corte.Location = new System.Drawing.Point(22, 237);
            this.tercer_corte.Name = "tercer_corte";
            this.tercer_corte.Size = new System.Drawing.Size(66, 13);
            this.tercer_corte.TabIndex = 6;
            this.tercer_corte.Text = "Tercer Corte";
            // 
            // laboratorio
            // 
            this.laboratorio.AutoSize = true;
            this.laboratorio.Location = new System.Drawing.Point(22, 267);
            this.laboratorio.Name = "laboratorio";
            this.laboratorio.Size = new System.Drawing.Size(60, 13);
            this.laboratorio.TabIndex = 7;
            this.laboratorio.Text = "Laboratorio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 263);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "La nota que ud necesita para aprobar la materia es:";
            // 
            // nota_ne
            // 
            this.nota_ne.AutoSize = true;
            this.nota_ne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota_ne.Location = new System.Drawing.Point(85, 339);
            this.nota_ne.Name = "nota_ne";
            this.nota_ne.Size = new System.Drawing.Size(45, 25);
            this.nota_ne.TabIndex = 13;
            this.nota_ne.Text = "0.0";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tercer Corte";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(147, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Laboratorio";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 374);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.nota_ne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.laboratorio);
            this.Controls.Add(this.tercer_corte);
            this.Controls.Add(this.segundo_corte);
            this.Controls.Add(this.primer_corte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Estimar una nota neceseria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasTeoricasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasConLaboratorioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label primer_corte;
        private System.Windows.Forms.Label segundo_corte;
        private System.Windows.Forms.Label tercer_corte;
        private System.Windows.Forms.Label laboratorio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nota_ne;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
    }
}