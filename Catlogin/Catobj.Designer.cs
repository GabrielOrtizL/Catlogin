
namespace Catlogin
{
    partial class Catobj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catobj));
            this.btninsertar = new System.Windows.Forms.Button();
            this.catcandyDataSet = new Catlogin.catcandyDataSet();
            this.catcandyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catusersTableAdapter = new Catlogin.catcandyDataSetTableAdapters.catusersTableAdapter();
            this.btnactalizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.catusersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnleer = new System.Windows.Forms.Button();
            this.catusersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dulceDataSet = new Catlogin.dulceDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Catlogin.dulceDataSetTableAdapters.usuariosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.catcandyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catcandyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catusersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catusersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dulceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btninsertar.Location = new System.Drawing.Point(22, 22);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 0;
            this.btninsertar.Text = "Crear ";
            this.btninsertar.UseVisualStyleBackColor = false;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // catcandyDataSet
            // 
            this.catcandyDataSet.DataSetName = "catcandyDataSet";
            this.catcandyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catcandyDataSetBindingSource
            // 
            this.catcandyDataSetBindingSource.DataSource = this.catcandyDataSet;
            this.catcandyDataSetBindingSource.Position = 0;
            // 
            // catusersBindingSource
            // 
            this.catusersBindingSource.DataMember = "catusers";
            this.catusersBindingSource.DataSource = this.catcandyDataSet;
            // 
            // catusersTableAdapter
            // 
            this.catusersTableAdapter.ClearBeforeFill = true;
            // 
            // btnactalizar
            // 
            this.btnactalizar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnactalizar.Location = new System.Drawing.Point(220, 22);
            this.btnactalizar.Name = "btnactalizar";
            this.btnactalizar.Size = new System.Drawing.Size(75, 23);
            this.btnactalizar.TabIndex = 2;
            this.btnactalizar.Text = "Actualizar";
            this.btnactalizar.UseVisualStyleBackColor = false;
            this.btnactalizar.Click += new System.EventHandler(this.btnactalizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.Location = new System.Drawing.Point(320, 22);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // catusersBindingSource1
            // 
            this.catusersBindingSource1.DataMember = "catusers";
            this.catusersBindingSource1.DataSource = this.catcandyDataSet;
            // 
            // btnleer
            // 
            this.btnleer.BackColor = System.Drawing.Color.Lime;
            this.btnleer.Location = new System.Drawing.Point(122, 22);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(75, 23);
            this.btnleer.TabIndex = 4;
            this.btnleer.Text = "Leer";
            this.btnleer.UseVisualStyleBackColor = false;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // catusersBindingSource2
            // 
            this.catusersBindingSource2.DataMember = "catusers";
            this.catusersBindingSource2.DataSource = this.catcandyDataSet;
            // 
            // dulceDataSet
            // 
            this.dulceDataSet.DataSetName = "dulceDataSet";
            this.dulceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dulceDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 224);
            this.dataGridView1.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "user";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // Catobj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 324);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactalizar);
            this.Controls.Add(this.btninsertar);
            this.Name = "Catobj";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Catobj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catcandyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catcandyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catusersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catusersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dulceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.BindingSource catcandyDataSetBindingSource;
        private catcandyDataSet catcandyDataSet;
        private System.Windows.Forms.BindingSource catusersBindingSource;
        private catcandyDataSetTableAdapters.catusersTableAdapter catusersTableAdapter;
        private System.Windows.Forms.Button btnactalizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.BindingSource catusersBindingSource1;
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.BindingSource catusersBindingSource2;
        private dulceDataSet dulceDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private dulceDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}