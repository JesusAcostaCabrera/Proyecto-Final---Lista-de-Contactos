namespace Proyecto_Final___Frontend
{
    partial class UserControl1
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
            this.PB_Imagen_UserControl = new System.Windows.Forms.PictureBox();
            this.Lb_Nombre_UserControl = new System.Windows.Forms.Label();
            this.LB_Descripcion_UserControl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Imagen_UserControl)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Imagen_UserControl
            // 
            this.PB_Imagen_UserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Imagen_UserControl.ErrorImage = null;
            this.PB_Imagen_UserControl.InitialImage = global::Proyecto_Final___Frontend.Properties.Resources.user;
            this.PB_Imagen_UserControl.Location = new System.Drawing.Point(26, 20);
            this.PB_Imagen_UserControl.Name = "PB_Imagen_UserControl";
            this.PB_Imagen_UserControl.Size = new System.Drawing.Size(100, 100);
            this.PB_Imagen_UserControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Imagen_UserControl.TabIndex = 0;
            this.PB_Imagen_UserControl.TabStop = false;
            // 
            // Lb_Nombre_UserControl
            // 
            this.Lb_Nombre_UserControl.AutoSize = true;
            this.Lb_Nombre_UserControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Nombre_UserControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Lb_Nombre_UserControl.Location = new System.Drawing.Point(230, 43);
            this.Lb_Nombre_UserControl.Name = "Lb_Nombre_UserControl";
            this.Lb_Nombre_UserControl.Size = new System.Drawing.Size(64, 18);
            this.Lb_Nombre_UserControl.TabIndex = 1;
            this.Lb_Nombre_UserControl.Text = "Nombre";
            // 
            // LB_Descripcion_UserControl
            // 
            this.LB_Descripcion_UserControl.AutoSize = true;
            this.LB_Descripcion_UserControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Descripcion_UserControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.LB_Descripcion_UserControl.Location = new System.Drawing.Point(230, 104);
            this.LB_Descripcion_UserControl.Name = "LB_Descripcion_UserControl";
            this.LB_Descripcion_UserControl.Size = new System.Drawing.Size(92, 18);
            this.LB_Descripcion_UserControl.TabIndex = 2;
            this.LB_Descripcion_UserControl.Text = "Descripción";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 2);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(193, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(193, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LB_Descripcion_UserControl);
            this.Controls.Add(this.Lb_Nombre_UserControl);
            this.Controls.Add(this.PB_Imagen_UserControl);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(478, 150);
            this.MouseEnter += new System.EventHandler(this.ucRequest_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucRequest_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Imagen_UserControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Imagen_UserControl;
        private System.Windows.Forms.Label Lb_Nombre_UserControl;
        private System.Windows.Forms.Label LB_Descripcion_UserControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
