namespace Musliw
{
    partial class Donnees
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
            this.tableau = new System.Windows.Forms.TabControl();
            this.Noeuds = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Liens = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new Musliw.DataSet1();
            this.iDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableau.SuspendLayout();
            this.Noeuds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Liens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableau
            // 
            this.tableau.Controls.Add(this.Noeuds);
            this.tableau.Controls.Add(this.Liens);
            this.tableau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableau.Location = new System.Drawing.Point(0, 0);
            this.tableau.Name = "tableau";
            this.tableau.SelectedIndex = 0;
            this.tableau.Size = new System.Drawing.Size(572, 381);
            this.tableau.TabIndex = 0;
            // 
            // Noeuds
            // 
            this.Noeuds.Controls.Add(this.dataGridView1);
            this.Noeuds.Location = new System.Drawing.Point(4, 22);
            this.Noeuds.Name = "Noeuds";
            this.Noeuds.Padding = new System.Windows.Forms.Padding(3);
            this.Noeuds.Size = new System.Drawing.Size(564, 355);
            this.Noeuds.TabIndex = 0;
            this.Noeuds.Text = "Noeuds";
            this.Noeuds.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDataGridViewTextBoxColumn1,
            this.numero,
            this.xiDataGridViewTextBoxColumn,
            this.yiDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataMember = "Nodes";
            this.dataGridView1.DataSource = this.dataSet11BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // Liens
            // 
            this.Liens.Controls.Add(this.dataGridView2);
            this.Liens.Location = new System.Drawing.Point(4, 22);
            this.Liens.Name = "Liens";
            this.Liens.Padding = new System.Windows.Forms.Padding(3);
            this.Liens.Size = new System.Drawing.Size(564, 355);
            this.Liens.TabIndex = 1;
            this.Liens.Text = "Tron�ons";
            this.Liens.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.iDataGridViewTextBoxColumn,
            this.jDataGridViewTextBoxColumn,
            this.line,
            this.lenDataGridViewTextBoxColumn,
            this.volume,
            this.temps,
            this.texte});
            this.dataGridView2.DataMember = "Links";
            this.dataGridView2.DataSource = this.dataSet11BindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(558, 349);
            this.dataGridView2.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // line
            // 
            this.line.DataPropertyName = "line";
            this.line.HeaderText = "line";
            this.line.Name = "line";
            // 
            // volume
            // 
            this.volume.DataPropertyName = "volume";
            this.volume.HeaderText = "volume";
            this.volume.Name = "volume";
            // 
            // temps
            // 
            this.temps.DataPropertyName = "temps";
            this.temps.HeaderText = "temps";
            this.temps.Name = "temps";
            // 
            // texte
            // 
            this.texte.DataPropertyName = "texte";
            this.texte.HeaderText = "texte";
            this.texte.Name = "texte";
            this.texte.Width = 500;
            // 
            // dataSet11BindingSource
            // 
            this.dataSet11BindingSource.DataSource = this.dataSet11;
            this.dataSet11BindingSource.Position = 0;
            this.dataSet11BindingSource.CurrentChanged += new System.EventHandler(this.dataSet11BindingSource_CurrentChanged);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
            // 
            // iDataGridViewTextBoxColumn
            // 
            this.iDataGridViewTextBoxColumn.DataPropertyName = "i";
            this.iDataGridViewTextBoxColumn.HeaderText = "i";
            this.iDataGridViewTextBoxColumn.Name = "iDataGridViewTextBoxColumn";
            // 
            // jDataGridViewTextBoxColumn
            // 
            this.jDataGridViewTextBoxColumn.DataPropertyName = "j";
            this.jDataGridViewTextBoxColumn.HeaderText = "j";
            this.jDataGridViewTextBoxColumn.Name = "jDataGridViewTextBoxColumn";
            // 
            // lenDataGridViewTextBoxColumn
            // 
            this.lenDataGridViewTextBoxColumn.DataPropertyName = "len";
            this.lenDataGridViewTextBoxColumn.HeaderText = "len";
            this.lenDataGridViewTextBoxColumn.Name = "lenDataGridViewTextBoxColumn";
            // 
            // linksBindingSource
            // 
            this.linksBindingSource.DataMember = "Links";
            this.linksBindingSource.DataSource = this.dataSet11;
            // 
            // iDataGridViewTextBoxColumn1
            // 
            this.iDataGridViewTextBoxColumn1.DataPropertyName = "i";
            this.iDataGridViewTextBoxColumn1.HeaderText = "i";
            this.iDataGridViewTextBoxColumn1.Name = "iDataGridViewTextBoxColumn1";
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "numero";
            this.numero.Name = "numero";
            // 
            // xiDataGridViewTextBoxColumn
            // 
            this.xiDataGridViewTextBoxColumn.DataPropertyName = "xi";
            this.xiDataGridViewTextBoxColumn.HeaderText = "xi";
            this.xiDataGridViewTextBoxColumn.Name = "xiDataGridViewTextBoxColumn";
            // 
            // yiDataGridViewTextBoxColumn
            // 
            this.yiDataGridViewTextBoxColumn.DataPropertyName = "yi";
            this.yiDataGridViewTextBoxColumn.HeaderText = "yi";
            this.yiDataGridViewTextBoxColumn.Name = "yiDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "texte";
            this.dataGridViewTextBoxColumn1.HeaderText = "texte";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 500;
            // 
            // Donnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 381);
            this.Controls.Add(this.tableau);
            this.Name = "Donnees";
            this.Text = "R�seau";
            this.Load += new System.EventHandler(this.donnees_Load);
            this.tableau.ResumeLayout(false);
            this.Noeuds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Liens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tableau;
        private System.Windows.Forms.TabPage Noeuds;
        private System.Windows.Forms.TabPage Liens;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource dataSet11BindingSource;
        private System.Windows.Forms.BindingSource linksBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn line;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn texte;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn xiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}