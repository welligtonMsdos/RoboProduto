
namespace RoboProduto
{
    partial class frmRobo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.gridContainer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFooter = new System.Windows.Forms.GroupBox();
            this.btnAcao = new System.Windows.Forms.Button();
            this.grpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainer)).BeginInit();
            this.grpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpContainer
            // 
            this.grpContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpContainer.Controls.Add(this.gridContainer);
            this.grpContainer.Location = new System.Drawing.Point(8, 2);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(785, 377);
            this.grpContainer.TabIndex = 0;
            this.grpContainer.TabStop = false;
            // 
            // gridContainer
            // 
            this.gridContainer.AllowUserToAddRows = false;
            this.gridContainer.AllowUserToDeleteRows = false;
            this.gridContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridContainer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridContainer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridContainer.BackgroundColor = System.Drawing.Color.White;
            this.gridContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContainer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.departamento});
            this.gridContainer.Location = new System.Drawing.Point(6, 10);
            this.gridContainer.MultiSelect = false;
            this.gridContainer.Name = "gridContainer";
            this.gridContainer.ReadOnly = true;
            this.gridContainer.Size = new System.Drawing.Size(773, 361);
            this.gridContainer.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            this.departamento.ReadOnly = true;
            // 
            // grpFooter
            // 
            this.grpFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFooter.Controls.Add(this.btnAcao);
            this.grpFooter.Location = new System.Drawing.Point(8, 385);
            this.grpFooter.Name = "grpFooter";
            this.grpFooter.Size = new System.Drawing.Size(785, 57);
            this.grpFooter.TabIndex = 1;
            this.grpFooter.TabStop = false;
            // 
            // btnAcao
            // 
            this.btnAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcao.Location = new System.Drawing.Point(681, 14);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(98, 37);
            this.btnAcao.TabIndex = 0;
            this.btnAcao.Text = "Iniciar";
            this.btnAcao.UseVisualStyleBackColor = true;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // frmRobo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpFooter);
            this.Controls.Add(this.grpContainer);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmRobo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robô Produto";
            this.Load += new System.EventHandler(this.frmRobo_Load);
            this.grpContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContainer)).EndInit();
            this.grpFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.GroupBox grpFooter;
        private System.Windows.Forms.Button btnAcao;
        public System.Windows.Forms.DataGridView gridContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
    }
}

