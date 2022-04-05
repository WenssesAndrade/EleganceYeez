
namespace Diseño_Yeez
{
    partial class frm_menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbcitas = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbinventario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbventas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbinventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbventas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbventas);
            this.panel1.Controls.Add(this.pbcitas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pbinventario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1138, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 576);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Control de Citas";
            // 
            // pbcitas
            // 
            this.pbcitas.Image = global::Diseño_Yeez.Properties.Resources.cita;
            this.pbcitas.Location = new System.Drawing.Point(58, 437);
            this.pbcitas.Name = "pbcitas";
            this.pbcitas.Size = new System.Drawing.Size(106, 103);
            this.pbcitas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcitas.TabIndex = 4;
            this.pbcitas.TabStop = false;
            this.pbcitas.Click += new System.EventHandler(this.pbcitas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Control de Inventario";
            // 
            // pbinventario
            // 
            this.pbinventario.Image = global::Diseño_Yeez.Properties.Resources.inventario;
            this.pbinventario.Location = new System.Drawing.Point(58, 243);
            this.pbinventario.Name = "pbinventario";
            this.pbinventario.Size = new System.Drawing.Size(106, 103);
            this.pbinventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbinventario.TabIndex = 2;
            this.pbinventario.TabStop = false;
            this.pbinventario.Click += new System.EventHandler(this.pbinventario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de Ventas";
            // 
            // pbventas
            // 
            this.pbventas.Image = global::Diseño_Yeez.Properties.Resources.venta;
            this.pbventas.Location = new System.Drawing.Point(58, 69);
            this.pbventas.Name = "pbventas";
            this.pbventas.Size = new System.Drawing.Size(106, 103);
            this.pbventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbventas.TabIndex = 0;
            this.pbventas.TabStop = false;
            this.pbventas.Click += new System.EventHandler(this.pbventas_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diseño_Yeez.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 660);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EYHola";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbinventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbcitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbinventario;
        private System.Windows.Forms.Label label1;
    }
}