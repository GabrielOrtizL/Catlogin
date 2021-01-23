
namespace Catlogin
{
    partial class Catcandy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catcandy));
            this.btnleer = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactalizar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.dulceDataSet = new Catlogin.dulceDataSet();
            this.dulceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dulceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dulceDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnleer
            // 
            this.btnleer.BackColor = System.Drawing.Color.BlueViolet;
            this.btnleer.Location = new System.Drawing.Point(194, 45);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(75, 23);
            this.btnleer.TabIndex = 8;
            this.btnleer.Text = "Leer";
            this.btnleer.UseVisualStyleBackColor = false;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.BlueViolet;
            this.btneliminar.Location = new System.Drawing.Point(194, 88);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactalizar
            // 
            this.btnactalizar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnactalizar.Location = new System.Drawing.Point(94, 88);
            this.btnactalizar.Name = "btnactalizar";
            this.btnactalizar.Size = new System.Drawing.Size(75, 23);
            this.btnactalizar.TabIndex = 6;
            this.btnactalizar.Text = "Actualizar";
            this.btnactalizar.UseVisualStyleBackColor = false;
            this.btnactalizar.Click += new System.EventHandler(this.btnactalizar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.Color.BlueViolet;
            this.btninsertar.Location = new System.Drawing.Point(94, 45);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 5;
            this.btninsertar.Text = "Crear ";
            this.btninsertar.UseVisualStyleBackColor = false;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // dulceDataSet
            // 
            this.dulceDataSet.DataSetName = "dulceDataSet";
            this.dulceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dulceDataSetBindingSource
            // 
            this.dulceDataSetBindingSource.DataSource = this.dulceDataSet;
            this.dulceDataSetBindingSource.Position = 0;
            // 
            // Catcandy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(364, 167);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactalizar);
            this.Controls.Add(this.btninsertar);
            this.Name = "Catcandy";
            this.Text = "Almacen";
            ((System.ComponentModel.ISupportInitialize)(this.dulceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dulceDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactalizar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.BindingSource dulceDataSetBindingSource;
        private dulceDataSet dulceDataSet;
    }
}