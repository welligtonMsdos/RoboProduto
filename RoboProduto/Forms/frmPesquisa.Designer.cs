
namespace RoboProduto.Forms
{
    partial class frmPesquisa
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
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.grpTitle = new System.Windows.Forms.GroupBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.gridPesquisa = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grpContainer.SuspendLayout();
            this.grpTitle.SuspendLayout();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // grpContainer
            // 
            this.grpContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpContainer.Controls.Add(this.gridPesquisa);
            this.grpContainer.Location = new System.Drawing.Point(157, 53);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(636, 393);
            this.grpContainer.TabIndex = 3;
            this.grpContainer.TabStop = false;
            // 
            // grpTitle
            // 
            this.grpTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTitle.Controls.Add(this.txtPesquisa);
            this.grpTitle.Controls.Add(this.lblPesquisa);
            this.grpTitle.Location = new System.Drawing.Point(8, -1);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(785, 57);
            this.grpTitle.TabIndex = 2;
            this.grpTitle.TabStop = false;
            // 
            // grpMenu
            // 
            this.grpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMenu.Controls.Add(this.btnExcluir);
            this.grpMenu.Controls.Add(this.btnEditar);
            this.grpMenu.Controls.Add(this.btnNovo);
            this.grpMenu.Location = new System.Drawing.Point(8, 52);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(145, 394);
            this.grpMenu.TabIndex = 2;
            this.grpMenu.TabStop = false;
            // 
            // gridPesquisa
            // 
            this.gridPesquisa.AllowUserToAddRows = false;
            this.gridPesquisa.AllowUserToDeleteRows = false;
            this.gridPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPesquisa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPesquisa.BackgroundColor = System.Drawing.Color.White;
            this.gridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisa.Location = new System.Drawing.Point(6, 13);
            this.gridPesquisa.MultiSelect = false;
            this.gridPesquisa.Name = "gridPesquisa";
            this.gridPesquisa.ReadOnly = true;
            this.gridPesquisa.Size = new System.Drawing.Size(624, 374);
            this.gridPesquisa.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(21, 29);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(98, 37);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(21, 95);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 37);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(21, 165);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 37);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(18, 23);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(35, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "label1";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(155, 20);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(624, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTitle);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.grpContainer);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPesquisa_Load);
            this.grpContainer.ResumeLayout(false);
            this.grpTitle.ResumeLayout(false);
            this.grpTitle.PerformLayout();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.GroupBox grpTitle;
        private System.Windows.Forms.GroupBox grpMenu;
        public System.Windows.Forms.DataGridView gridPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
    }
}