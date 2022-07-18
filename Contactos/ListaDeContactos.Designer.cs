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
            this.button1 = new System.Windows.Forms.Button();
            this.TB_Busqueda_Contacto = new System.Windows.Forms.TextBox();
            this.contactosDataSet = new Proyecto_Final___Frontend.ContactosDataSet();
            this.contactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactosTableAdapter = new Proyecto_Final___Frontend.ContactosDataSetTableAdapters.ContactosTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.contactosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contactosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactosDataSet1 = new Proyecto_Final___Frontend.ContactosDataSet1();
            this.contactosTableAdapter1 = new Proyecto_Final___Frontend.ContactosDataSet1TableAdapters.ContactosTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(443, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 52;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_Busqueda_Contacto
            // 
            this.TB_Busqueda_Contacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_Busqueda_Contacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Busqueda_Contacto.Font = new System.Drawing.Font("Gill Sans MT", 20F);
            this.TB_Busqueda_Contacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TB_Busqueda_Contacto.Location = new System.Drawing.Point(12, 27);
            this.TB_Busqueda_Contacto.Multiline = true;
            this.TB_Busqueda_Contacto.Name = "TB_Busqueda_Contacto";
            this.TB_Busqueda_Contacto.Size = new System.Drawing.Size(410, 42);
            this.TB_Busqueda_Contacto.TabIndex = 58;
            this.TB_Busqueda_Contacto.Text = "Buscar...";
            // 
            // contactosDataSet
            // 
            this.contactosDataSet.DataSetName = "ContactosDataSet";
            this.contactosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactosBindingSource
            // 
            this.contactosBindingSource.DataMember = "Contactos";
            this.contactosBindingSource.DataSource = this.contactosDataSet;
            // 
            // contactosTableAdapter
            // 
            this.contactosTableAdapter.ClearBeforeFill = true;
            // 
            // contactosBindingSource2
            // 
            this.contactosBindingSource2.DataMember = "Contactos";
            this.contactosBindingSource2.DataSource = this.contactosDataSet1BindingSource;
            // 
            // contactosDataSet1BindingSource
            // 
            this.contactosDataSet1BindingSource.DataSource = this.contactosDataSet1;
            this.contactosDataSet1BindingSource.Position = 0;
            // 
            // contactosDataSet1
            // 
            this.contactosDataSet1.DataSetName = "ContactosDataSet1";
            this.contactosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactosTableAdapter1
            // 
            this.contactosTableAdapter1.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(502, 860);
            this.flowLayoutPanel1.TabIndex = 59;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // ListaDeContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(540, 960);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TB_Busqueda_Contacto);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaDeContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDeContactos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaDeContactos_FormClosing);
            this.Load += new System.EventHandler(this.ListaDeContactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB_Busqueda_Contacto;
        private ContactosDataSet contactosDataSet;
        private System.Windows.Forms.BindingSource contactosBindingSource;
        private ContactosDataSetTableAdapters.ContactosTableAdapter contactosTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private ContactosDataSet1 contactosDataSet1;
        private ContactosDataSet1TableAdapters.ContactosTableAdapter contactosTableAdapter1;
        private System.Windows.Forms.BindingSource contactosBindingSource2;
        private System.Windows.Forms.BindingSource contactosDataSet1BindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}