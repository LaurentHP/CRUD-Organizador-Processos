namespace OrgProcessosAPP
{
    partial class OrgProcessosForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.funcionarioTxtbox = new System.Windows.Forms.TextBox();
            this.interessadoTxtbox = new System.Windows.Forms.TextBox();
            this.assuntoTxtbox = new System.Windows.Forms.TextBox();
            this.anoTxtbox = new System.Windows.Forms.TextBox();
            this.descricaoTxtbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codprocessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interessadoprocessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoprocessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desprocessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoprocessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProcessosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdprocessosDataSet0 = new OrgProcessosAPP.bdprocessosDataSet0();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeForm = new System.Windows.Forms.Button();
            this.pesquisarTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.atualizarBtn = new System.Windows.Forms.Button();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbProcessosTableAdapter = new OrgProcessosAPP.bdprocessosDataSet0TableAdapters.tbProcessosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProcessosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprocessosDataSet0)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interessado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assunto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descrição:";
            // 
            // salvarBtn
            // 
            this.salvarBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.salvarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salvarBtn.Location = new System.Drawing.Point(13, 246);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(87, 23);
            this.salvarBtn.TabIndex = 6;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = false;
            this.salvarBtn.Click += new System.EventHandler(this.salvar_click);
            // 
            // excluirBtn
            // 
            this.excluirBtn.BackColor = System.Drawing.Color.Brown;
            this.excluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirBtn.Location = new System.Drawing.Point(292, 246);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(87, 23);
            this.excluirBtn.TabIndex = 7;
            this.excluirBtn.Text = "Excluir";
            this.excluirBtn.UseVisualStyleBackColor = false;
            this.excluirBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.limparBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparBtn.Location = new System.Drawing.Point(199, 246);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(87, 23);
            this.limparBtn.TabIndex = 8;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = false;
            this.limparBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // funcionarioTxtbox
            // 
            this.funcionarioTxtbox.Location = new System.Drawing.Point(105, 71);
            this.funcionarioTxtbox.Name = "funcionarioTxtbox";
            this.funcionarioTxtbox.Size = new System.Drawing.Size(274, 20);
            this.funcionarioTxtbox.TabIndex = 10;
            // 
            // interessadoTxtbox
            // 
            this.interessadoTxtbox.Location = new System.Drawing.Point(105, 104);
            this.interessadoTxtbox.Name = "interessadoTxtbox";
            this.interessadoTxtbox.Size = new System.Drawing.Size(274, 20);
            this.interessadoTxtbox.TabIndex = 11;
            // 
            // assuntoTxtbox
            // 
            this.assuntoTxtbox.Location = new System.Drawing.Point(105, 140);
            this.assuntoTxtbox.Name = "assuntoTxtbox";
            this.assuntoTxtbox.Size = new System.Drawing.Size(274, 20);
            this.assuntoTxtbox.TabIndex = 12;
            // 
            // anoTxtbox
            // 
            this.anoTxtbox.Location = new System.Drawing.Point(105, 175);
            this.anoTxtbox.Name = "anoTxtbox";
            this.anoTxtbox.Size = new System.Drawing.Size(274, 20);
            this.anoTxtbox.TabIndex = 13;
            // 
            // descricaoTxtbox
            // 
            this.descricaoTxtbox.Location = new System.Drawing.Point(105, 206);
            this.descricaoTxtbox.Name = "descricaoTxtbox";
            this.descricaoTxtbox.Size = new System.Drawing.Size(274, 20);
            this.descricaoTxtbox.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codprocessoDataGridViewTextBoxColumn,
            this.nmfuncionarioDataGridViewTextBoxColumn,
            this.interessadoprocessoDataGridViewTextBoxColumn,
            this.assuntoprocessoDataGridViewTextBoxColumn,
            this.desprocessoDataGridViewTextBoxColumn,
            this.anoprocessoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbProcessosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(409, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(631, 254);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codprocessoDataGridViewTextBoxColumn
            // 
            this.codprocessoDataGridViewTextBoxColumn.DataPropertyName = "cod_processo";
            this.codprocessoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.codprocessoDataGridViewTextBoxColumn.Name = "codprocessoDataGridViewTextBoxColumn";
            this.codprocessoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codprocessoDataGridViewTextBoxColumn.Width = 40;
            // 
            // nmfuncionarioDataGridViewTextBoxColumn
            // 
            this.nmfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "nm_funcionario";
            this.nmfuncionarioDataGridViewTextBoxColumn.HeaderText = "Funcionário";
            this.nmfuncionarioDataGridViewTextBoxColumn.Name = "nmfuncionarioDataGridViewTextBoxColumn";
            this.nmfuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nmfuncionarioDataGridViewTextBoxColumn.Width = 90;
            // 
            // interessadoprocessoDataGridViewTextBoxColumn
            // 
            this.interessadoprocessoDataGridViewTextBoxColumn.DataPropertyName = "interessado_processo";
            this.interessadoprocessoDataGridViewTextBoxColumn.HeaderText = "Interessado";
            this.interessadoprocessoDataGridViewTextBoxColumn.Name = "interessadoprocessoDataGridViewTextBoxColumn";
            this.interessadoprocessoDataGridViewTextBoxColumn.ReadOnly = true;
            this.interessadoprocessoDataGridViewTextBoxColumn.Width = 145;
            // 
            // assuntoprocessoDataGridViewTextBoxColumn
            // 
            this.assuntoprocessoDataGridViewTextBoxColumn.DataPropertyName = "assunto_processo";
            this.assuntoprocessoDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.assuntoprocessoDataGridViewTextBoxColumn.Name = "assuntoprocessoDataGridViewTextBoxColumn";
            this.assuntoprocessoDataGridViewTextBoxColumn.ReadOnly = true;
            this.assuntoprocessoDataGridViewTextBoxColumn.Width = 150;
            // 
            // desprocessoDataGridViewTextBoxColumn
            // 
            this.desprocessoDataGridViewTextBoxColumn.DataPropertyName = "des_processo";
            this.desprocessoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.desprocessoDataGridViewTextBoxColumn.Name = "desprocessoDataGridViewTextBoxColumn";
            this.desprocessoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anoprocessoDataGridViewTextBoxColumn
            // 
            this.anoprocessoDataGridViewTextBoxColumn.DataPropertyName = "ano_processo";
            this.anoprocessoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoprocessoDataGridViewTextBoxColumn.Name = "anoprocessoDataGridViewTextBoxColumn";
            this.anoprocessoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoprocessoDataGridViewTextBoxColumn.Width = 60;
            // 
            // tbProcessosBindingSource
            // 
            this.tbProcessosBindingSource.DataMember = "tbProcessos";
            this.tbProcessosBindingSource.DataSource = this.bdprocessosDataSet0;
            // 
            // bdprocessosDataSet0
            // 
            this.bdprocessosDataSet0.DataSetName = "bdprocessosDataSet0";
            this.bdprocessosDataSet0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.closeForm);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 32);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrgProcessosForm_MouseDown);
            // 
            // closeForm
            // 
            this.closeForm.FlatAppearance.BorderSize = 0;
            this.closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeForm.Location = new System.Drawing.Point(1017, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(36, 33);
            this.closeForm.TabIndex = 17;
            this.closeForm.Text = "X";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // pesquisarTxtbox
            // 
            this.pesquisarTxtbox.Location = new System.Drawing.Point(169, 283);
            this.pesquisarTxtbox.Name = "pesquisarTxtbox";
            this.pesquisarTxtbox.Size = new System.Drawing.Size(210, 20);
            this.pesquisarTxtbox.TabIndex = 17;
            this.pesquisarTxtbox.TextChanged += new System.EventHandler(this.pesquisarTxtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pesquisar (Funcionário):";
            // 
            // atualizarBtn
            // 
            this.atualizarBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.atualizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarBtn.Location = new System.Drawing.Point(106, 246);
            this.atualizarBtn.Name = "atualizarBtn";
            this.atualizarBtn.Size = new System.Drawing.Size(87, 23);
            this.atualizarBtn.TabIndex = 19;
            this.atualizarBtn.Text = "Alterar";
            this.atualizarBtn.UseVisualStyleBackColor = false;
            this.atualizarBtn.Click += new System.EventHandler(this.atualizarBtn_Click);
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(105, 39);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(51, 20);
            this.idTxtBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "ID:";
            // 
            // tbProcessosTableAdapter
            // 
            this.tbProcessosTableAdapter.ClearBeforeFill = true;
            // 
            // OrgProcessosForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 319);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.atualizarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pesquisarTxtbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.descricaoTxtbox);
            this.Controls.Add(this.anoTxtbox);
            this.Controls.Add(this.assuntoTxtbox);
            this.Controls.Add(this.interessadoTxtbox);
            this.Controls.Add(this.funcionarioTxtbox);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrgProcessosForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.OrgProcessosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProcessosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprocessosDataSet0)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.TextBox funcionarioTxtbox;
        private System.Windows.Forms.TextBox interessadoTxtbox;
        private System.Windows.Forms.TextBox assuntoTxtbox;
        private System.Windows.Forms.TextBox anoTxtbox;
        private System.Windows.Forms.TextBox descricaoTxtbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.TextBox pesquisarTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button atualizarBtn;
        private bdprocessosDataSet0 bdprocessosDataSet0;
        private System.Windows.Forms.BindingSource tbProcessosBindingSource;
        private bdprocessosDataSet0TableAdapters.tbProcessosTableAdapter tbProcessosTableAdapter;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprocessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interessadoprocessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoprocessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desprocessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoprocessoDataGridViewTextBoxColumn;
    }
}

