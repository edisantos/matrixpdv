
namespace lemosinfotec.matrixErp.UI.View
{
    partial class FrmEstoqueProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHearder = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleHeaderProdutos = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpNovoEstoque = new System.Windows.Forms.GroupBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblEstMin = new System.Windows.Forms.Label();
            this.txtEstoqueMin = new System.Windows.Forms.TextBox();
            this.lblTipoMedida = new System.Windows.Forms.Label();
            this.cmbTipoProd = new System.Windows.Forms.ComboBox();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.lblContator = new System.Windows.Forms.Label();
            this.btnSalvarProdutos = new FontAwesome.Sharp.IconButton();
            this.lblMsgAlerta = new System.Windows.Forms.Label();
            this.grpListaEstoque = new System.Windows.Forms.GroupBox();
            this.grwListaEstoque = new System.Windows.Forms.DataGridView();
            this.EstoqueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExcluit = new FontAwesome.Sharp.IconButton();
            this.pnlHearder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.grpNovoEstoque.SuspendLayout();
            this.grpListaEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grwListaEstoque)).BeginInit();
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
            this.pnlHearder.Size = new System.Drawing.Size(1348, 63);
            this.pnlHearder.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
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
            this.lblTitleHeaderProdutos.Size = new System.Drawing.Size(269, 40);
            this.lblTitleHeaderProdutos.TabIndex = 0;
            this.lblTitleHeaderProdutos.Text = "Estoque de produtos";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Opencart;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 80;
            this.iconPictureBox3.Location = new System.Drawing.Point(25, 101);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(80, 80);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox3.TabIndex = 11;
            this.iconPictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(29, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "MATRIX";
            // 
            // grpNovoEstoque
            // 
            this.grpNovoEstoque.Controls.Add(this.lblFornecedor);
            this.grpNovoEstoque.Controls.Add(this.cmbFornecedor);
            this.grpNovoEstoque.Controls.Add(this.lblEstMin);
            this.grpNovoEstoque.Controls.Add(this.txtEstoqueMin);
            this.grpNovoEstoque.Controls.Add(this.lblTipoMedida);
            this.grpNovoEstoque.Controls.Add(this.cmbTipoProd);
            this.grpNovoEstoque.Controls.Add(this.lblValorUnit);
            this.grpNovoEstoque.Controls.Add(this.txtValorUnit);
            this.grpNovoEstoque.Controls.Add(this.lblQtd);
            this.grpNovoEstoque.Controls.Add(this.txtQuantidade);
            this.grpNovoEstoque.Controls.Add(this.lblProdutos);
            this.grpNovoEstoque.Controls.Add(this.cmbProdutos);
            this.grpNovoEstoque.Controls.Add(this.lblContator);
            this.grpNovoEstoque.Controls.Add(this.btnSalvarProdutos);
            this.grpNovoEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpNovoEstoque.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpNovoEstoque.Location = new System.Drawing.Point(132, 143);
            this.grpNovoEstoque.Name = "grpNovoEstoque";
            this.grpNovoEstoque.Size = new System.Drawing.Size(586, 438);
            this.grpNovoEstoque.TabIndex = 15;
            this.grpNovoEstoque.TabStop = false;
            this.grpNovoEstoque.Text = "Registro de Estoque";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(42, 264);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(109, 25);
            this.lblFornecedor.TabIndex = 26;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(158, 261);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(414, 33);
            this.cmbFornecedor.TabIndex = 25;
            // 
            // lblEstMin
            // 
            this.lblEstMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstMin.AutoSize = true;
            this.lblEstMin.Location = new System.Drawing.Point(79, 224);
            this.lblEstMin.Name = "lblEstMin";
            this.lblEstMin.Size = new System.Drawing.Size(76, 25);
            this.lblEstMin.TabIndex = 24;
            this.lblEstMin.Text = "Est Min";
            // 
            // txtEstoqueMin
            // 
            this.txtEstoqueMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstoqueMin.Location = new System.Drawing.Point(157, 220);
            this.txtEstoqueMin.Name = "txtEstoqueMin";
            this.txtEstoqueMin.Size = new System.Drawing.Size(414, 33);
            this.txtEstoqueMin.TabIndex = 23;
            // 
            // lblTipoMedida
            // 
            this.lblTipoMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoMedida.AutoSize = true;
            this.lblTipoMedida.Location = new System.Drawing.Point(106, 185);
            this.lblTipoMedida.Name = "lblTipoMedida";
            this.lblTipoMedida.Size = new System.Drawing.Size(49, 25);
            this.lblTipoMedida.TabIndex = 22;
            this.lblTipoMedida.Text = "Tipo";
            // 
            // cmbTipoProd
            // 
            this.cmbTipoProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoProd.FormattingEnabled = true;
            this.cmbTipoProd.Location = new System.Drawing.Point(157, 179);
            this.cmbTipoProd.Name = "cmbTipoProd";
            this.cmbTipoProd.Size = new System.Drawing.Size(414, 33);
            this.cmbTipoProd.TabIndex = 21;
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.Location = new System.Drawing.Point(55, 140);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(96, 25);
            this.lblValorUnit.TabIndex = 20;
            this.lblValorUnit.Text = "Valor (R$)";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorUnit.Location = new System.Drawing.Point(157, 137);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(414, 33);
            this.txtValorUnit.TabIndex = 19;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(107, 103);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(44, 25);
            this.lblQtd.TabIndex = 18;
            this.lblQtd.Text = "Qtd";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.Location = new System.Drawing.Point(157, 95);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(414, 33);
            this.txtQuantidade.TabIndex = 17;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(72, 60);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(81, 25);
            this.lblProdutos.TabIndex = 16;
            this.lblProdutos.Text = "Produto";
            this.lblProdutos.Click += new System.EventHandler(this.lblProdutos_Click);
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(157, 52);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(414, 33);
            this.cmbProdutos.TabIndex = 15;
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
            this.btnSalvarProdutos.Location = new System.Drawing.Point(157, 310);
            this.btnSalvarProdutos.Name = "btnSalvarProdutos";
            this.btnSalvarProdutos.Size = new System.Drawing.Size(414, 64);
            this.btnSalvarProdutos.TabIndex = 13;
            this.btnSalvarProdutos.Text = "Salvar";
            this.btnSalvarProdutos.UseVisualStyleBackColor = false;
            this.btnSalvarProdutos.Click += new System.EventHandler(this.btnSalvarProdutos_Click);
            // 
            // lblMsgAlerta
            // 
            this.lblMsgAlerta.AutoSize = true;
            this.lblMsgAlerta.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMsgAlerta.ForeColor = System.Drawing.Color.Red;
            this.lblMsgAlerta.Location = new System.Drawing.Point(139, 606);
            this.lblMsgAlerta.Name = "lblMsgAlerta";
            this.lblMsgAlerta.Size = new System.Drawing.Size(65, 25);
            this.lblMsgAlerta.TabIndex = 16;
            this.lblMsgAlerta.Text = "Alerta";
            this.lblMsgAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpListaEstoque
            // 
            this.grpListaEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpListaEstoque.Controls.Add(this.grwListaEstoque);
            this.grpListaEstoque.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpListaEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpListaEstoque.Location = new System.Drawing.Point(755, 143);
            this.grpListaEstoque.Name = "grpListaEstoque";
            this.grpListaEstoque.Size = new System.Drawing.Size(521, 236);
            this.grpListaEstoque.TabIndex = 17;
            this.grpListaEstoque.TabStop = false;
            this.grpListaEstoque.Text = "Produtos em Estoque";
            // 
            // grwListaEstoque
            // 
            this.grwListaEstoque.AllowUserToAddRows = false;
            this.grwListaEstoque.AllowUserToDeleteRows = false;
            this.grwListaEstoque.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.grwListaEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grwListaEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grwListaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grwListaEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstoqueId,
            this.DataRegistro,
            this.ProdutoNome,
            this.Quantidade,
            this.ValorUnit,
            this.EstoqueMin,
            this.FornecedorNome});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grwListaEstoque.DefaultCellStyle = dataGridViewCellStyle7;
            this.grwListaEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grwListaEstoque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.grwListaEstoque.Location = new System.Drawing.Point(3, 29);
            this.grwListaEstoque.Name = "grwListaEstoque";
            this.grwListaEstoque.ReadOnly = true;
            this.grwListaEstoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grwListaEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grwListaEstoque.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grwListaEstoque.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grwListaEstoque.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grwListaEstoque.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.grwListaEstoque.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grwListaEstoque.RowTemplate.Height = 25;
            this.grwListaEstoque.Size = new System.Drawing.Size(515, 204);
            this.grwListaEstoque.TabIndex = 0;
            // 
            // EstoqueId
            // 
            this.EstoqueId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstoqueId.DataPropertyName = "EstoqueId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EstoqueId.DefaultCellStyle = dataGridViewCellStyle2;
            this.EstoqueId.HeaderText = "Id";
            this.EstoqueId.Name = "EstoqueId";
            this.EstoqueId.ReadOnly = true;
            // 
            // DataRegistro
            // 
            this.DataRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataRegistro.DataPropertyName = "DataRegistro";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DataRegistro.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataRegistro.HeaderText = "Data";
            this.DataRegistro.Name = "DataRegistro";
            this.DataRegistro.ReadOnly = true;
            // 
            // ProdutoNome
            // 
            this.ProdutoNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdutoNome.DataPropertyName = "ProdutoNome";
            this.ProdutoNome.HeaderText = "Produto";
            this.ProdutoNome.Name = "ProdutoNome";
            this.ProdutoNome.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorUnit
            // 
            this.ValorUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorUnit.DataPropertyName = "ValorUnit";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0";
            this.ValorUnit.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValorUnit.HeaderText = "Valor";
            this.ValorUnit.Name = "ValorUnit";
            this.ValorUnit.ReadOnly = true;
            // 
            // EstoqueMin
            // 
            this.EstoqueMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstoqueMin.DataPropertyName = "EstoqueMin";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.EstoqueMin.DefaultCellStyle = dataGridViewCellStyle6;
            this.EstoqueMin.HeaderText = "Estoque Min";
            this.EstoqueMin.Name = "EstoqueMin";
            this.EstoqueMin.ReadOnly = true;
            // 
            // FornecedorNome
            // 
            this.FornecedorNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FornecedorNome.DataPropertyName = "FornecedorNome";
            this.FornecedorNome.HeaderText = "Fornecedor";
            this.FornecedorNome.Name = "FornecedorNome";
            this.FornecedorNome.ReadOnly = true;
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
            this.btnSearch.Location = new System.Drawing.Point(1171, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 36);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(755, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(413, 35);
            this.txtSearch.TabIndex = 18;
            // 
            // btnExcluit
            // 
            this.btnExcluit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluit.AutoSize = true;
            this.btnExcluit.FlatAppearance.BorderSize = 0;
            this.btnExcluit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluit.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnExcluit.IconColor = System.Drawing.Color.White;
            this.btnExcluit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluit.IconSize = 30;
            this.btnExcluit.Location = new System.Drawing.Point(1211, 89);
            this.btnExcluit.Name = "btnExcluit";
            this.btnExcluit.Size = new System.Drawing.Size(48, 36);
            this.btnExcluit.TabIndex = 20;
            this.btnExcluit.UseVisualStyleBackColor = true;
            this.btnExcluit.Click += new System.EventHandler(this.btnExcluit_Click);
            // 
            // FrmEstoqueProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1348, 744);
            this.Controls.Add(this.btnExcluit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grpListaEstoque);
            this.Controls.Add(this.lblMsgAlerta);
            this.Controls.Add(this.grpNovoEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.pnlHearder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstoqueProdutos";
            this.Text = "FrmEstoqueProdutos";
            this.Load += new System.EventHandler(this.FrmEstoqueProdutos_Load);
            this.pnlHearder.ResumeLayout(false);
            this.pnlHearder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.grpNovoEstoque.ResumeLayout(false);
            this.grpNovoEstoque.PerformLayout();
            this.grpListaEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grwListaEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHearder;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblTitleHeaderProdutos;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpNovoEstoque;
        private System.Windows.Forms.Label lblContator;
        private FontAwesome.Sharp.IconButton btnSalvarProdutos;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label lblValorUnit;
        private System.Windows.Forms.ComboBox cmbTipoProd;
        private System.Windows.Forms.Label lblTipoMedida;
        private System.Windows.Forms.TextBox txtEstoqueMin;
        private System.Windows.Forms.Label lblEstMin;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblMsgAlerta;
        private System.Windows.Forms.GroupBox grpListaEstoque;
        private System.Windows.Forms.DataGridView grwListaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorNome;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnExcluit;
    }
}