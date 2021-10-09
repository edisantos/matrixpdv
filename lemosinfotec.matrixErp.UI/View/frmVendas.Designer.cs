
namespace lemosinfotec.matrixErp.UI.View
{
    partial class frmVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHearder = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleHeaderProdutos = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlInformacoes = new System.Windows.Forms.Panel();
            this.btnAtivarCaixa = new System.Windows.Forms.Button();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.cmbCaixa = new System.Windows.Forms.ComboBox();
            this.lblStatusCaixa = new System.Windows.Forms.Label();
            this.lblMsgAlerta = new System.Windows.Forms.Label();
            this.grpTotalItem = new System.Windows.Forms.GroupBox();
            this.lblTotalItem = new System.Windows.Forms.Label();
            this.grpValorUnitario = new System.Windows.Forms.GroupBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.grpListaItem = new System.Windows.Forms.GroupBox();
            this.grwListaItem = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpScanCore = new System.Windows.Forms.GroupBox();
            this.txtCodeItem = new System.Windows.Forms.TextBox();
            this.grpTotalRecebido = new System.Windows.Forms.GroupBox();
            this.lblTotalRecebido = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.pnlValoresRecebidos = new System.Windows.Forms.Panel();
            this.gbrTroco = new System.Windows.Forms.GroupBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.grpSubTotal = new System.Windows.Forms.GroupBox();
            this.gprFormaPagamento = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblTitleGreen = new System.Windows.Forms.Label();
            this.grpTeclaAtalhos = new System.Windows.Forms.GroupBox();
            this.linkPagamento = new FontAwesome.Sharp.IconButton();
            this.btnRemoverItem = new FontAwesome.Sharp.IconButton();
            this.pnlHearder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.pnlInformacoes.SuspendLayout();
            this.grpTotalItem.SuspendLayout();
            this.grpValorUnitario.SuspendLayout();
            this.grpListaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grwListaItem)).BeginInit();
            this.grpScanCore.SuspendLayout();
            this.grpTotalRecebido.SuspendLayout();
            this.pnlValoresRecebidos.SuspendLayout();
            this.gbrTroco.SuspendLayout();
            this.grpSubTotal.SuspendLayout();
            this.gprFormaPagamento.SuspendLayout();
            this.grpTeclaAtalhos.SuspendLayout();
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
            this.pnlHearder.Size = new System.Drawing.Size(1217, 63);
            this.pnlHearder.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
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
            this.lblTitleHeaderProdutos.Size = new System.Drawing.Size(184, 40);
            this.lblTitleHeaderProdutos.TabIndex = 0;
            this.lblTitleHeaderProdutos.Text = "Caixas - PDV";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Chartreuse;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.AppleAlt;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Chartreuse;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 197;
            this.iconPictureBox3.Location = new System.Drawing.Point(21, 159);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(209, 197);
            this.iconPictureBox3.TabIndex = 12;
            this.iconPictureBox3.TabStop = false;
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInformacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlInformacoes.Controls.Add(this.btnAtivarCaixa);
            this.pnlInformacoes.Controls.Add(this.lblCaixa);
            this.pnlInformacoes.Controls.Add(this.cmbCaixa);
            this.pnlInformacoes.Controls.Add(this.lblStatusCaixa);
            this.pnlInformacoes.Location = new System.Drawing.Point(21, 86);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(1166, 67);
            this.pnlInformacoes.TabIndex = 13;
            // 
            // btnAtivarCaixa
            // 
            this.btnAtivarCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtivarCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnAtivarCaixa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtivarCaixa.ForeColor = System.Drawing.Color.White;
            this.btnAtivarCaixa.Location = new System.Drawing.Point(1000, 14);
            this.btnAtivarCaixa.Name = "btnAtivarCaixa";
            this.btnAtivarCaixa.Size = new System.Drawing.Size(145, 32);
            this.btnAtivarCaixa.TabIndex = 3;
            this.btnAtivarCaixa.Text = "Ativar Caixa";
            this.btnAtivarCaixa.UseVisualStyleBackColor = false;
            this.btnAtivarCaixa.Click += new System.EventHandler(this.btnAtivarCaixa_Click);
            // 
            // lblCaixa
            // 
            this.lblCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.lblCaixa.Location = new System.Drawing.Point(24, 17);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(87, 32);
            this.lblCaixa.TabIndex = 2;
            this.lblCaixa.Text = "CAIXA";
            // 
            // cmbCaixa
            // 
            this.cmbCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCaixa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCaixa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbCaixa.FormattingEnabled = true;
            this.cmbCaixa.Location = new System.Drawing.Point(117, 14);
            this.cmbCaixa.Name = "cmbCaixa";
            this.cmbCaixa.Size = new System.Drawing.Size(253, 40);
            this.cmbCaixa.TabIndex = 1;
            // 
            // lblStatusCaixa
            // 
            this.lblStatusCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusCaixa.AutoSize = true;
            this.lblStatusCaixa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.lblStatusCaixa.Location = new System.Drawing.Point(377, 17);
            this.lblStatusCaixa.Name = "lblStatusCaixa";
            this.lblStatusCaixa.Size = new System.Drawing.Size(106, 32);
            this.lblStatusCaixa.TabIndex = 0;
            this.lblStatusCaixa.Text = "ABERTO";
            // 
            // lblMsgAlerta
            // 
            this.lblMsgAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsgAlerta.AutoSize = true;
            this.lblMsgAlerta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsgAlerta.Location = new System.Drawing.Point(23, 723);
            this.lblMsgAlerta.Name = "lblMsgAlerta";
            this.lblMsgAlerta.Size = new System.Drawing.Size(51, 21);
            this.lblMsgAlerta.TabIndex = 20;
            this.lblMsgAlerta.Text = "Alerta";
            // 
            // grpTotalItem
            // 
            this.grpTotalItem.Controls.Add(this.lblTotalItem);
            this.grpTotalItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpTotalItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpTotalItem.Location = new System.Drawing.Point(268, 159);
            this.grpTotalItem.Name = "grpTotalItem";
            this.grpTotalItem.Size = new System.Drawing.Size(236, 97);
            this.grpTotalItem.TabIndex = 21;
            this.grpTotalItem.TabStop = false;
            this.grpTotalItem.Text = "TOTAL DE ITEM";
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalItem.AutoSize = true;
            this.lblTotalItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.lblTotalItem.Location = new System.Drawing.Point(78, 46);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalItem.Size = new System.Drawing.Size(28, 32);
            this.lblTotalItem.TabIndex = 1;
            this.lblTotalItem.Text = "0";
            this.lblTotalItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpValorUnitario
            // 
            this.grpValorUnitario.Controls.Add(this.lblValorUnitario);
            this.grpValorUnitario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpValorUnitario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpValorUnitario.Location = new System.Drawing.Point(268, 271);
            this.grpValorUnitario.Name = "grpValorUnitario";
            this.grpValorUnitario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpValorUnitario.Size = new System.Drawing.Size(236, 97);
            this.grpValorUnitario.TabIndex = 22;
            this.grpValorUnitario.TabStop = false;
            this.grpValorUnitario.Text = "VALOR UNITÁRIO";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.lblValorUnitario.Location = new System.Drawing.Point(78, 43);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblValorUnitario.Size = new System.Drawing.Size(28, 32);
            this.lblValorUnitario.TabIndex = 0;
            this.lblValorUnitario.Text = "0";
            this.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpListaItem
            // 
            this.grpListaItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpListaItem.Controls.Add(this.grwListaItem);
            this.grpListaItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpListaItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpListaItem.Location = new System.Drawing.Point(530, 159);
            this.grpListaItem.Name = "grpListaItem";
            this.grpListaItem.Size = new System.Drawing.Size(657, 447);
            this.grpListaItem.TabIndex = 23;
            this.grpListaItem.TabStop = false;
            this.grpListaItem.Text = "LISTA DE ITENS";
            // 
            // grwListaItem
            // 
            this.grwListaItem.AllowUserToAddRows = false;
            this.grwListaItem.AllowUserToDeleteRows = false;
            this.grwListaItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grwListaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grwListaItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProdutoNome,
            this.ValorVenda,
            this.Peso,
            this.dataGridViewTextBoxColumn1});
            this.grwListaItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grwListaItem.GridColor = System.Drawing.Color.WhiteSmoke;
            this.grwListaItem.Location = new System.Drawing.Point(3, 29);
            this.grwListaItem.Name = "grwListaItem";
            this.grwListaItem.ReadOnly = true;
            this.grwListaItem.RowTemplate.Height = 25;
            this.grwListaItem.Size = new System.Drawing.Size(651, 415);
            this.grwListaItem.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "N° Registro";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ProdutoNome
            // 
            this.ProdutoNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdutoNome.DataPropertyName = "ProdutoNome";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.ProdutoNome.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProdutoNome.HeaderText = "Item";
            this.ProdutoNome.Name = "ProdutoNome";
            this.ProdutoNome.ReadOnly = true;
            // 
            // ValorVenda
            // 
            this.ValorVenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorVenda.DataPropertyName = "ValorVenda";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ValorVenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValorVenda.HeaderText = "Valor Pago";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Peso.DataPropertyName = "Peso";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.Peso.DefaultCellStyle = dataGridViewCellStyle4;
            this.Peso.HeaderText = "Peso em G";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TotalItem";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Total Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // grpScanCore
            // 
            this.grpScanCore.Controls.Add(this.txtCodeItem);
            this.grpScanCore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpScanCore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpScanCore.Location = new System.Drawing.Point(23, 378);
            this.grpScanCore.Name = "grpScanCore";
            this.grpScanCore.Size = new System.Drawing.Size(481, 97);
            this.grpScanCore.TabIndex = 23;
            this.grpScanCore.TabStop = false;
            this.grpScanCore.Text = "SCAN ITEM";
            // 
            // txtCodeItem
            // 
            this.txtCodeItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCodeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.txtCodeItem.Location = new System.Drawing.Point(22, 39);
            this.txtCodeItem.Name = "txtCodeItem";
            this.txtCodeItem.Size = new System.Drawing.Size(436, 43);
            this.txtCodeItem.TabIndex = 0;
            this.txtCodeItem.TextChanged += new System.EventHandler(this.txtCodeItem_TextChanged);
            // 
            // grpTotalRecebido
            // 
            this.grpTotalRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpTotalRecebido.Controls.Add(this.lblTotalRecebido);
            this.grpTotalRecebido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpTotalRecebido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpTotalRecebido.Location = new System.Drawing.Point(419, 10);
            this.grpTotalRecebido.Name = "grpTotalRecebido";
            this.grpTotalRecebido.Size = new System.Drawing.Size(236, 64);
            this.grpTotalRecebido.TabIndex = 23;
            this.grpTotalRecebido.TabStop = false;
            this.grpTotalRecebido.Text = "TOTAL RECEBIDO";
            // 
            // lblTotalRecebido
            // 
            this.lblTotalRecebido.AutoSize = true;
            this.lblTotalRecebido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalRecebido.Location = new System.Drawing.Point(39, 35);
            this.lblTotalRecebido.Name = "lblTotalRecebido";
            this.lblTotalRecebido.Size = new System.Drawing.Size(23, 25);
            this.lblTotalRecebido.TabIndex = 1;
            this.lblTotalRecebido.Text = "0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(37, 36);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(23, 25);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "0";
            // 
            // pnlValoresRecebidos
            // 
            this.pnlValoresRecebidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlValoresRecebidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.pnlValoresRecebidos.Controls.Add(this.gbrTroco);
            this.pnlValoresRecebidos.Controls.Add(this.grpSubTotal);
            this.pnlValoresRecebidos.Controls.Add(this.grpTotalRecebido);
            this.pnlValoresRecebidos.Location = new System.Drawing.Point(23, 621);
            this.pnlValoresRecebidos.Name = "pnlValoresRecebidos";
            this.pnlValoresRecebidos.Size = new System.Drawing.Size(1164, 92);
            this.pnlValoresRecebidos.TabIndex = 24;
            // 
            // gbrTroco
            // 
            this.gbrTroco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbrTroco.Controls.Add(this.lblTroco);
            this.gbrTroco.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbrTroco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbrTroco.Location = new System.Drawing.Point(704, 10);
            this.gbrTroco.Name = "gbrTroco";
            this.gbrTroco.Size = new System.Drawing.Size(236, 64);
            this.gbrTroco.TabIndex = 24;
            this.gbrTroco.TabStop = false;
            this.gbrTroco.Text = "TROCO";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTroco.Location = new System.Drawing.Point(17, 34);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(23, 25);
            this.lblTroco.TabIndex = 2;
            this.lblTroco.Text = "0";
            // 
            // grpSubTotal
            // 
            this.grpSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpSubTotal.Controls.Add(this.lblSubTotal);
            this.grpSubTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSubTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpSubTotal.Location = new System.Drawing.Point(132, 10);
            this.grpSubTotal.Name = "grpSubTotal";
            this.grpSubTotal.Size = new System.Drawing.Size(236, 64);
            this.grpSubTotal.TabIndex = 24;
            this.grpSubTotal.TabStop = false;
            this.grpSubTotal.Text = "SUBTOTAL";
            // 
            // gprFormaPagamento
            // 
            this.gprFormaPagamento.Controls.Add(this.btnFinalizar);
            this.gprFormaPagamento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gprFormaPagamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gprFormaPagamento.Location = new System.Drawing.Point(23, 481);
            this.gprFormaPagamento.Name = "gprFormaPagamento";
            this.gprFormaPagamento.Size = new System.Drawing.Size(481, 134);
            this.gprFormaPagamento.TabIndex = 22;
            this.gprFormaPagamento.TabStop = false;
            this.gprFormaPagamento.Text = "FINALIZAR VENDAS";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizar.Location = new System.Drawing.Point(22, 38);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(445, 75);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // lblTitleGreen
            // 
            this.lblTitleGreen.AutoSize = true;
            this.lblTitleGreen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleGreen.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTitleGreen.Location = new System.Drawing.Point(76, 314);
            this.lblTitleGreen.Name = "lblTitleGreen";
            this.lblTitleGreen.Size = new System.Drawing.Size(92, 32);
            this.lblTitleGreen.TabIndex = 25;
            this.lblTitleGreen.Text = "GREEN";
            // 
            // grpTeclaAtalhos
            // 
            this.grpTeclaAtalhos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTeclaAtalhos.Controls.Add(this.linkPagamento);
            this.grpTeclaAtalhos.Controls.Add(this.btnRemoverItem);
            this.grpTeclaAtalhos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpTeclaAtalhos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpTeclaAtalhos.Location = new System.Drawing.Point(23, 748);
            this.grpTeclaAtalhos.Name = "grpTeclaAtalhos";
            this.grpTeclaAtalhos.Size = new System.Drawing.Size(521, 100);
            this.grpTeclaAtalhos.TabIndex = 26;
            this.grpTeclaAtalhos.TabStop = false;
            this.grpTeclaAtalhos.Text = "Teclas de Atalhos";
            // 
            // linkPagamento
            // 
            this.linkPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.linkPagamento.FlatAppearance.BorderSize = 0;
            this.linkPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.linkPagamento.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.linkPagamento.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.linkPagamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.linkPagamento.IconSize = 30;
            this.linkPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPagamento.Location = new System.Drawing.Point(13, 32);
            this.linkPagamento.Name = "linkPagamento";
            this.linkPagamento.Size = new System.Drawing.Size(234, 37);
            this.linkPagamento.TabIndex = 3;
            this.linkPagamento.Text = "Pagamento - F1";
            this.linkPagamento.UseVisualStyleBackColor = false;
            this.linkPagamento.Click += new System.EventHandler(this.linkPagamento_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnRemoverItem.FlatAppearance.BorderSize = 0;
            this.btnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnRemoverItem.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnRemoverItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnRemoverItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoverItem.IconSize = 30;
            this.btnRemoverItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverItem.Location = new System.Drawing.Point(245, 32);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(234, 37);
            this.btnRemoverItem.TabIndex = 2;
            this.btnRemoverItem.Text = "Remover Item - F2";
            this.btnRemoverItem.UseVisualStyleBackColor = false;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1217, 860);
            this.Controls.Add(this.grpTeclaAtalhos);
            this.Controls.Add(this.lblTitleGreen);
            this.Controls.Add(this.gprFormaPagamento);
            this.Controls.Add(this.pnlValoresRecebidos);
            this.Controls.Add(this.grpScanCore);
            this.Controls.Add(this.grpListaItem);
            this.Controls.Add(this.grpValorUnitario);
            this.Controls.Add(this.grpTotalItem);
            this.Controls.Add(this.lblMsgAlerta);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.pnlHearder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVendas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVendas_KeyDown_1);
            this.pnlHearder.ResumeLayout(false);
            this.pnlHearder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            this.grpTotalItem.ResumeLayout(false);
            this.grpTotalItem.PerformLayout();
            this.grpValorUnitario.ResumeLayout(false);
            this.grpValorUnitario.PerformLayout();
            this.grpListaItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grwListaItem)).EndInit();
            this.grpScanCore.ResumeLayout(false);
            this.grpScanCore.PerformLayout();
            this.grpTotalRecebido.ResumeLayout(false);
            this.grpTotalRecebido.PerformLayout();
            this.pnlValoresRecebidos.ResumeLayout(false);
            this.gbrTroco.ResumeLayout(false);
            this.gbrTroco.PerformLayout();
            this.grpSubTotal.ResumeLayout(false);
            this.grpSubTotal.PerformLayout();
            this.gprFormaPagamento.ResumeLayout(false);
            this.grpTeclaAtalhos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHearder;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblTitleHeaderProdutos;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel pnlInformacoes;
        private System.Windows.Forms.Label lblStatusCaixa;
        private System.Windows.Forms.Label lblMsgAlerta;
        private System.Windows.Forms.ComboBox cmbCaixa;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.GroupBox grpTotalItem;
        private System.Windows.Forms.GroupBox grpValorUnitario;
        private System.Windows.Forms.GroupBox grpListaItem;
        private System.Windows.Forms.GroupBox grpScanCore;
        private System.Windows.Forms.TextBox txtCodeItem;
        private System.Windows.Forms.GroupBox grpTotalRecebido;
        private System.Windows.Forms.Panel pnlValoresRecebidos;
        private System.Windows.Forms.GroupBox grpSubTotal;
        private System.Windows.Forms.GroupBox gbrTroco;
        private System.Windows.Forms.GroupBox gprFormaPagamento;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblTitleGreen;
        private System.Windows.Forms.DataGridView grwListaItem;
        private System.Windows.Forms.Label lblTotalItem;
        private System.Windows.Forms.Button btnAtivarCaixa;
        private System.Windows.Forms.GroupBox grpTeclaAtalhos;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private FontAwesome.Sharp.IconButton btnRemoverItem;
        private FontAwesome.Sharp.IconButton linkPagamento;
        private System.Windows.Forms.Label lblTotalRecebido;
        private System.Windows.Forms.Label lblTroco;
    }
}