namespace notas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasTeóricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasConLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primer_corte = new System.Windows.Forms.TextBox();
            this.segundo_corte = new System.Windows.Forms.TextBox();
            this.tercer_corte = new System.Windows.Forms.TextBox();
            this.laboratorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nota_final = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiasTeóricasToolStripMenuItem,
            this.materiasConLaboratorioToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 20);
            this.toolStripMenuItem1.Text = "Tipo de materia";
            // 
            // materiasTeóricasToolStripMenuItem
            // 
            this.materiasTeóricasToolStripMenuItem.Name = "materiasTeóricasToolStripMenuItem";
            this.materiasTeóricasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.materiasTeóricasToolStripMenuItem.Text = "Materias teóricas";
            this.materiasTeóricasToolStripMenuItem.Click += new System.EventHandler(this.materiasTeóricasToolStripMenuItem_Click);
            // 
            // materiasConLaboratorioToolStripMenuItem
            // 
            this.materiasConLaboratorioToolStripMenuItem.Name = "materiasConLaboratorioToolStripMenuItem";
            this.materiasConLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.materiasConLaboratorioToolStripMenuItem.Text = "Materias con laboratorio";
            this.materiasConLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.materiasConLaboratorioToolStripMenuItem_Click);
            // 
            // primer_corte
            // 
            this.primer_corte.Location = new System.Drawing.Point(106, 65);
            this.primer_corte.Name = "primer_corte";
            this.primer_corte.Size = new System.Drawing.Size(50, 20);
            this.primer_corte.TabIndex = 2;
            // 
            // segundo_corte
            // 
            this.segundo_corte.Location = new System.Drawing.Point(105, 115);
            this.segundo_corte.Name = "segundo_corte";
            this.segundo_corte.Size = new System.Drawing.Size(50, 20);
            this.segundo_corte.TabIndex = 4;
            // 
            // tercer_corte
            // 
            this.tercer_corte.Location = new System.Drawing.Point(105, 161);
            this.tercer_corte.Name = "tercer_corte";
            this.tercer_corte.Size = new System.Drawing.Size(50, 20);
            this.tercer_corte.TabIndex = 6;
            // 
            // laboratorio
            // 
            this.laboratorio.Enabled = false;
            this.laboratorio.Location = new System.Drawing.Point(105, 210);
            this.laboratorio.Name = "laboratorio";
            this.laboratorio.Size = new System.Drawing.Size(50, 20);
            this.laboratorio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Primer Corte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tercer Corte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Segundo Corte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Laboratorio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Su definitiva es:";
            // 
            // nota_final
            // 
            this.nota_final.AutoSize = true;
            this.nota_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota_final.Location = new System.Drawing.Point(88, 290);
            this.nota_final.Name = "nota_final";
            this.nota_final.Size = new System.Drawing.Size(45, 25);
            this.nota_final.TabIndex = 14;
            this.nota_final.Text = "0.0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tipo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 335);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nota_final);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laboratorio);
            this.Controls.Add(this.tercer_corte);
            this.Controls.Add(this.segundo_corte);
            this.Controls.Add(this.primer_corte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Calcular una definitiva";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem materiasTeóricasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasConLaboratorioToolStripMenuItem;
        private System.Windows.Forms.TextBox primer_corte;
        private System.Windows.Forms.TextBox segundo_corte;
        private System.Windows.Forms.TextBox tercer_corte;
        private System.Windows.Forms.TextBox laboratorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nota_final;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}