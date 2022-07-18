namespace Proyecto_Final___Frontend
{
    partial class ListaDeContactos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeContactos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.DGV_Contactos_Contactos = new System.Windows.Forms.DataGridView();
            this.CT_Tab_Contacto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_Busqueda_Contacto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Contactos_Contactos)).BeginInit();
            this.CT_Tab_Contacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(453, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 52;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGV_Contactos_Contactos
            // 
            this.DGV_Contactos_Contactos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DGV_Contactos_Contactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Contactos_Contactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Contactos_Contactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Contactos_Contactos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Contactos_Contactos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DGV_Contactos_Contactos.Location = new System.Drawing.Point(22, 92);
            this.DGV_Contactos_Contactos.Name = "DGV_Contactos_Contactos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Contactos_Contactos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Contactos_Contactos.Size = new System.Drawing.Size(491, 842);
            this.DGV_Contactos_Contactos.TabIndex = 51;
            this.DGV_Contactos_Contactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CT_Tab_Contacto
            // 
            this.CT_Tab_Contacto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.CT_Tab_Contacto.Name = "CT_Tab_Contacto";
            this.CT_Tab_Contacto.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem1.Image")));
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem1.Image")));
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // TB_Busqueda_Contacto
            // 
            this.TB_Busqueda_Contacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_Busqueda_Contacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Busqueda_Contacto.Font = new System.Drawing.Font("Gill Sans MT", 20F);
            this.TB_Busqueda_Contacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TB_Busqueda_Contacto.Location = new System.Drawing.Point(22, 39);
            this.TB_Busqueda_Contacto.Multiline = true;
            this.TB_Busqueda_Contacto.Name = "TB_Busqueda_Contacto";
            this.TB_Busqueda_Contacto.Size = new System.Drawing.Size(410, 42);
            this.TB_Busqueda_Contacto.TabIndex = 58;
            this.TB_Busqueda_Contacto.Text = "Buscar...";
            this.TB_Busqueda_Contacto.Click += new System.EventHandler(this.TB_Busqueda_Contacto_Click);
            this.TB_Busqueda_Contacto.TextChanged += new System.EventHandler(this.TB_Nombre_Agregar_TextChanged);
            // 
            // ListaDeContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(540, 960);
            this.Controls.Add(this.TB_Busqueda_Contacto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_Contactos_Contactos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaDeContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDeContactos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaDeContactos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Contactos_Contactos)).EndInit();
            this.CT_Tab_Contacto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV_Contactos_Contactos;
        private System.Windows.Forms.ContextMenuStrip CT_Tab_Contacto;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.TextBox TB_Busqueda_Contacto;
    }
}