namespace Proyecto_Final___Frontend
{
    partial class ListaObjeto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_Nombre = new System.Windows.Forms.Label();
            this.LB_Descripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LB_Nombre
            // 
            this.LB_Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LB_Nombre.Location = new System.Drawing.Point(157, 19);
            this.LB_Nombre.Name = "LB_Nombre";
            this.LB_Nombre.Size = new System.Drawing.Size(478, 23);
            this.LB_Nombre.TabIndex = 1;
            this.LB_Nombre.Text = "Nombre";
            // 
            // LB_Descripcion
            // 
            this.LB_Descripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LB_Descripcion.Location = new System.Drawing.Point(157, 57);
            this.LB_Descripcion.Name = "LB_Descripcion";
            this.LB_Descripcion.Size = new System.Drawing.Size(478, 50);
            this.LB_Descripcion.TabIndex = 2;
            this.LB_Descripcion.Text = "Descripcion";
            // 
            // ListaObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LB_Descripcion);
            this.Controls.Add(this.LB_Nombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListaObjeto";
            this.Size = new System.Drawing.Size(756, 124);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_Nombre;
        private System.Windows.Forms.Label LB_Descripcion;
    }
}
