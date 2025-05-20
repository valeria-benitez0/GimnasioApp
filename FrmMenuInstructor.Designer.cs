namespace GimnasioApp
{
    partial class FrmMenuInstructor
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
            this.btnRegistrarClase = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarClase
            // 
            this.btnRegistrarClase.Location = new System.Drawing.Point(325, 177);
            this.btnRegistrarClase.Name = "btnRegistrarClase";
            this.btnRegistrarClase.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarClase.TabIndex = 0;
            this.btnRegistrarClase.Text = "btnRegistrarClase";
            this.btnRegistrarClase.UseVisualStyleBackColor = true;
            this.btnRegistrarClase.Click += new System.EventHandler(this.btnRegistrarClase_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(325, 241);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "button2";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // FrmMenuInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnRegistrarClase);
            this.Name = "FrmMenuInstructor";
            this.Text = "FrmMenuInstructor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarClase;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}