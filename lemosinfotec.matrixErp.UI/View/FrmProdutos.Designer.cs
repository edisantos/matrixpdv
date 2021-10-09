
namespace lemosinfotec.matrixErp.UI.View
{
    partial class FrmProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHearder = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleHeaderProdutos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.txtNovoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarProdutos = new FontAwesome.Sharp.IconButton();
            this.grpNovoProdutos = new System.Windows.Forms.GroupBox();
            this.lblContator = new System.Windows.Forms.Label();
            this.lblMsgAlerta = new System.Windows.Forms.Label();
            this.grpListaProdutos = new System.Windows.Forms.GroupBox();
            this.grwListaProdutos = new System.Windows.Forms.DataGridView();
            this.ProdutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.pnlHearder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.grpNovoProdutos.SuspendLayout();
            this.grpListaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grwListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHearder
            // 
            this.pnlHearder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.pnlHearder.Controls.Add(this.iconPictureBox1);
            this.pnlHearder.Controls.Add(this.lblTitleHeaderProdutos);
            this.pnlHearder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHearder.Location = new System.Drawing.Point(0, 0);
            this.pnlHearder.Name = "pnlHearder";
            this.pnlHearder.Size = new System.Drawing.Size(1254, 63);
            this.pnlHearder.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 51;
            this.iconPictureBox1.Location = new System.Drawing.Point(9, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(51, 51);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblTitleHeaderProdutos
            // 
            this.lblTitleHeaderProdutos.AutoSize = true;
            this.lblTitleHeaderProdutos.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitleHeaderProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleHeaderProdutos.Location = new System.Drawing.Point(54, 9);
            this.lblTitleHeaderProdutos.Name = "lblTitleHeaderProdutos";
            this.lblTitleHeaderProdutos.Size = new System.Drawing.Size(287, 40);
            this.lblTitleHeaderProdutos.TabIndex = 0;
            this.lblTitleHeaderProdutos.Text = "Cadastro de Produtos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "MATRIX";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Opencart;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 80;
            this.iconPictureBox3.Location = new System.Drawing.Point(28, 153);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(80, 80);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox3.TabIndex = 10;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // txtNovoProduto
            // 
            this.txtNovoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNovoProduto.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNovoProduto.Location = new System.Drawing.Point(72, 146);
            this.txtNovoProduto.Name = "txtNovoProduto";
            this.txtNovoProduto.Size = new System.Drawing.Size(330, 54);
            this.txtNovoProduto.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adicione um novo produto para o estoque.";
            // 
            // btnSalvarProdutos
            // 
            this.btnSalvarProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarProdutos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvarProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarProdutos.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvarProdutos.IconColor = System.Drawing.Color.White;
            this.btnSalvarProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvarProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarProdutos.Location = new System.Drawing.Point(72, 206);
            this.btnSalvarProdutos.Name = "btnSalvarProdutos";
            this.btnSalvarProdutos.Size = new System.Drawing.Size(330, 64);
            this.btnSalvarProdutos.TabIndex = 13;
            this.btnSalvarProdutos.Text = "Salvar";
            this.btnSalvarProdutos.UseVisualStyleBackColor = false;
            this.btnSalvarProdutos.Click += new System.EventHandler(this.btnSalvarProdutos_Click);
            // 
            // grpNovoProdutos
            // 
            this.grpNovoProdutos.Controls.Add(this.lblContator);
            this.grpNovoProdutos.Controls.Add(this.btnSalvarProdutos);
            this.grpNovoProdutos.Controls.Add(this.label1);
            this.grpNovoProdutos.Controls.Add(this.txtNovoProduto);
            this.grpNovoProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpNovoProdutos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpNovoProdutos.Location = new System.Drawing.Point(128, 153);
            this.grpNovoProdutos.Name = "grpNovoProdutos";
            this.grpNovoProdutos.Size = new System.Drawing.Size(486, 351);
            this.grpNovoProdutos.TabIndex = 14;
            this.grpNovoProdutos.TabStop = false;
            this.grpNovoProdutos.Text = "Novos Produtos";
            // 
            // lblContator
            // 
            this.lblContator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContator.AutoSize = true;
            this.lblContator.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContator.ForeColor = System.Drawing.Color.White;
            this.lblContator.Location = new System.Drawing.Point(72, 288);
            this.lblContator.Name = "lblContator";
            this.lblContator.Size = new System.Drawing.Size(0, 29);
            this.lblContator.TabIndex = 14;
            // 
            // lblMsgAlerta
            // 
            this.lblMsgAlerta.AutoSize = true;
            this.lblMsgAlerta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsgAlerta.Location = new System.Drawing.Point(135, 522);
            this.lblMsgAlerta.Name = "lblMsgAlerta";
            this.lblMsgAlerta.Size = new System.Drawing.Size(0, 25);
            this.lblMsgAlerta.TabIndex = 13;
            this.lblMsgAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpListaProdutos
            // 
            this.grpListaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpListaProdutos.Controls.Add(this.grwListaProdutos);
            this.grpListaProdutos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpListaProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpListaProdutos.Location = new System.Drawing.Point(662, 153);
            this.grpListaProdutos.Name = "grpListaProdutos";
            this.grpListaProdutos.Size = new System.Drawing.Size(521, 236);
            this.grpListaProdutos.TabIndex = 15;
            this.grpListaProdutos.TabStop = false;
            this.grpListaProdutos.Text = "Lista de produtos";
            // 
            // grwListaProdutos
            // 
            this.grwListaProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.grwListaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grwListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grwListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grwListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutoId,
            this.Produto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grwListaProdutos.DefaultCellStyle = dataGridViewCellStyle4;
            this.grwListaProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grwListaProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.grwListaProdutos.Location = new System.Drawing.Point(3, 29);
            this.grwListaProdutos.Name = "grwListaProdutos";
            this.grwListaProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grwListaProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grwListaProdutos.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grwListaProdutos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grwListaProdutos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grwListaProdutos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.grwListaProdutos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grwListaProdutos.RowTemplate.Height = 25;
            this.grwListaProdutos.Size = new System.Drawing.Size(515, 204);
            this.grwListaProdutos.TabIndex = 0;
            // 
            // ProdutoId
            // 
            this.ProdutoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdutoId.DataPropertyName = "ProdutoId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProdutoId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProdutoId.HeaderText = "Id";
            this.ProdutoId.Name = "ProdutoId";
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produto.DataPropertyName = "ProdutoNome";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Produto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(662, 102);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(413, 35);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(1081, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 36);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1254, 783);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblMsgAlerta);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grpListaProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlHearder);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.grpNovoProdutos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProdutos";
            this.Text = "Cadastro de Produtos";
            this.pnlHearder.ResumeLayout(false);
            this.pnlHearder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.grpNovoProdutos.ResumeLayout(false);
            this.grpNovoProdutos.PerformLayout();
            this.grpListaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grwListaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHearder;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblTitleHeaderProdutos;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.TextBox txtNovoProduto;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnSalvarProdutos;
        private System.Windows.Forms.GroupBox grpNovoProdutos;
        private System.Windows.Forms.Label lblMsgAlerta;
        private System.Windows.Forms.GroupBox grpListaProdutos;
        private System.Windows.Forms.DataGridView grwListaProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.Label lblContator;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
    }
}