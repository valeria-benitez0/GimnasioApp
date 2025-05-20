namespace GimnasioApp
{
    partial class FrmEliminarClase
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
            this.txtIDClase = new System.Windows.Forms.TextBox();
            this.btnEliminarClase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIDClase
            // 
            this.txtIDClase.Location = new System.Drawing.Point(215, 125);
            this.txtIDClase.Name = "txtIDClase";
            this.txtIDClase.Size = new System.Drawing.Size(100, 20);
            this.txtIDClase.TabIndex = 0;
            // 
            // btnEliminarClase
            // 
            this.btnEliminarClase.Location = new System.Drawing.Point(215, 191);
            this.btnEliminarClase.Name = "btnEliminarClase";
            this.btnEliminarClase.Size = new System.Drawing.Size(136, 23);
            this.btnEliminarClase.TabIndex = 1;
            this.btnEliminarClase.Text = "Eliminar Clase";
            this.btnEliminarClase.UseVisualStyleBackColor = true;
            this.btnEliminarClase.Click += new System.EventHandler(this.btnEliminarClase_Click);
            // 
            // FrmEliminarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarClase);
            this.Controls.Add(this.txtIDClase);
            this.Name = "FrmEliminarClase";
            this.Text = "FrmEliminarClase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDClase;
        private System.Windows.Forms.Button btnEliminarClase;
    }
}