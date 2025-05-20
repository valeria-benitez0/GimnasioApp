namespace GimnasioApp
{
    partial class FrmMenu
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnInstructores = new System.Windows.Forms.Button();
            this.btnClases = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(372, 106);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "button1";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnInstructores
            // 
            this.btnInstructores.Location = new System.Drawing.Point(372, 174);
            this.btnInstructores.Name = "btnInstructores";
            this.btnInstructores.Size = new System.Drawing.Size(75, 23);
            this.btnInstructores.TabIndex = 1;
            this.btnInstructores.Text = "button2";
            this.btnInstructores.UseVisualStyleBackColor = true;
            this.btnInstructores.Click += new System.EventHandler(this.btnInstructores_Click_1);
            // 
            // btnClases
            // 
            this.btnClases.Location = new System.Drawing.Point(372, 257);
            this.btnClases.Name = "btnClases";
            this.btnClases.Size = new System.Drawing.Size(75, 23);
            this.btnClases.TabIndex = 2;
            this.btnClases.Text = "button3";
            this.btnClases.UseVisualStyleBackColor = true;
            this.btnClases.Click += new System.EventHandler(this.btnClases_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClases);
            this.Controls.Add(this.btnInstructores);
            this.Controls.Add(this.btnLogin);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnInstructores;
        private System.Windows.Forms.Button btnClases;
    }
}