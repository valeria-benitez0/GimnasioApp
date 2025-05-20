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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarClase));
            this.txtIDClase = new System.Windows.Forms.TextBox();
            this.btnEliminarClase = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDClase
            // 
            this.txtIDClase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDClase.Location = new System.Drawing.Point(264, 49);
            this.txtIDClase.Name = "txtIDClase";
            this.txtIDClase.Size = new System.Drawing.Size(190, 27);
            this.txtIDClase.TabIndex = 0;
            // 
            // btnEliminarClase
            // 
            this.btnEliminarClase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarClase.BackColor = System.Drawing.Color.White;
            this.btnEliminarClase.Location = new System.Drawing.Point(259, 167);
            this.btnEliminarClase.Name = "btnEliminarClase";
            this.btnEliminarClase.Size = new System.Drawing.Size(199, 50);
            this.btnEliminarClase.TabIndex = 1;
            this.btnEliminarClase.Text = "Eliminar Clase";
            this.btnEliminarClase.UseVisualStyleBackColor = false;
            this.btnEliminarClase.Click += new System.EventHandler(this.btnEliminarClase_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54875F));
            this.tableLayoutPanel1.Controls.Add(this.txtIDClase, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminarClase, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 142);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.41861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.5814F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 259);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(41, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 89);
            this.panel2.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Location = new System.Drawing.Point(14, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(689, 54);
            this.label15.TabIndex = 4;
            this.label15.Text = "Eliminar Clase";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEliminarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmEliminarClase";
            this.Text = "FrmEliminarClase";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDClase;
        private System.Windows.Forms.Button btnEliminarClase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
    }
}