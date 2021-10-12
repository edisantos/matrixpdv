
namespace lemosinfotec.matrixErp.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.BtnMaximinizar = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnRestaurar = new FontAwesome.Sharp.IconButton();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMenusControles = new System.Windows.Forms.Panel();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnFornecedores = new FontAwesome.Sharp.IconButton();
            this.btnEstoque = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnProdutos = new FontAwesome.Sharp.IconButton();
            this.btnVendas = new FontAwesome.Sharp.IconButton();
            this.btnContato = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlConteudos = new System.Windows.Forms.Panel();
            this.iconFinanceiro = new FontAwesome.Sharp.IconButton();
            this.pnlHeader.SuspendLayout();
            this.pnlMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.pnlMenusControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(244)))));
            this.pnlHeader.Controls.Add(this.lblNome);
            this.pnlHeader.Controls.Add(this.BtnMaximinizar);
            this.pnlHeader.Controls.Add(this.btnMenu);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnRestaurar);
            this.pnlHeader.Controls.Add(this.btnSair);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1488, 44);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(83, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 21);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome";
            // 
            // BtnMaximinizar
            // 
            this.BtnMaximinizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximinizar.AutoSize = true;
            this.BtnMaximinizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMaximinizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximinizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximinizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMaximinizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximinizar.IconColor = System.Drawing.Color.White;
            this.BtnMaximinizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximinizar.IconSize = 30;
            this.BtnMaximinizar.Location = new System.Drawing.Point(1398, 3);
            this.BtnMaximinizar.Name = "BtnMaximinizar";
            this.BtnMaximinizar.Size = new System.Drawing.Size(36, 36);
            this.BtnMaximinizar.TabIndex = 4;
            this.BtnMaximinizar.UseVisualStyleBackColor = true;
            this.BtnMaximinizar.Click += new System.EventHandler(this.BtnMaximinizar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(12, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(36, 36);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(1356, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.AutoSize = true;
            this.btnRestaurar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestaurar.IconColor = System.Drawing.Color.White;
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaurar.IconSize = 30;
            this.btnRestaurar.Location = new System.Drawing.Point(1398, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(36, 36);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.AutoSize = true;
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnSair.IconColor = System.Drawing.Color.White;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.IconSize = 30;
            this.btnSair.Location = new System.Drawing.Point(1440, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.pnlMenuLateral.Controls.Add(this.label1);
            this.pnlMenuLateral.Controls.Add(this.label5);
            this.pnlMenuLateral.Controls.Add(this.iconPictureBox3);
            this.pnlMenuLateral.Controls.Add(this.label2);
            this.pnlMenuLateral.Controls.Add(this.pnlMenusControles);
            this.pnlMenuLateral.Controls.Add(this.btnContato);
            this.pnlMenuLateral.Controls.Add(this.label3);
            this.pnlMenuLateral.Controls.Add(this.label4);
            this.pnlMenuLateral.Controls.Add(this.iconPictureBox2);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 44);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(260, 856);
            this.pnlMenuLateral.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(125, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sistema ERP";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Felix Titling", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "MATRIX";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Opencart;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 153;
            this.iconPictureBox3.Location = new System.Drawing.Point(0, 6);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(257, 153);
            this.iconPictureBox3.TabIndex = 12;
            this.iconPictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 812);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contato: (19) 98869-6402";
            // 
            // pnlMenusControles
            // 
            this.pnlMenusControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenusControles.Controls.Add(this.iconFinanceiro);
            this.pnlMenusControles.Controls.Add(this.btnAdmin);
            this.pnlMenusControles.Controls.Add(this.btnFornecedores);
            this.pnlMenusControles.Controls.Add(this.btnEstoque);
            this.pnlMenusControles.Controls.Add(this.btnClientes);
            this.pnlMenusControles.Controls.Add(this.btnProdutos);
            this.pnlMenusControles.Controls.Add(this.btnVendas);
            this.pnlMenusControles.Location = new System.Drawing.Point(8, 180);
            this.pnlMenusControles.Name = "pnlMenusControles";
            this.pnlMenusControles.Size = new System.Drawing.Size(237, 408);
            this.pnlMenusControles.TabIndex = 4;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAdmin.IconColor = System.Drawing.Color.White;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(14, 344);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(215, 46);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFornecedores.FlatAppearance.BorderSize = 0;
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnFornecedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFornecedores.IconChar = FontAwesome.Sharp.IconChar.City;
            this.btnFornecedores.IconColor = System.Drawing.Color.White;
            this.btnFornecedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedores.Location = new System.Drawing.Point(15, 233);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(215, 46);
            this.btnFornecedores.TabIndex = 7;
            this.btnFornecedores.Text = "   Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstoque.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnEstoque.IconColor = System.Drawing.Color.White;
            this.btnEstoque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(11, 181);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(215, 46);
            this.btnEstoque.TabIndex = 6;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(14, 136);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(215, 46);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProdutos.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.btnProdutos.IconColor = System.Drawing.Color.White;
            this.btnProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(14, 84);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(215, 46);
            this.btnProdutos.TabIndex = 4;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnVendas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVendas.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.btnVendas.IconColor = System.Drawing.Color.White;
            this.btnVendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(14, 32);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(215, 46);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Text = "  (PDV) - Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnContato
            // 
            this.btnContato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.btnContato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContato.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnContato.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContato.Location = new System.Drawing.Point(3, 808);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(32, 32);
            this.btnContato.TabIndex = 10;
            this.btnContato.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 791);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soluções em tecnologia";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Felix Titling", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(47, 769);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lemos Infotec";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Signature;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 70;
            this.iconPictureBox2.Location = new System.Drawing.Point(27, 731);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(123, 70);
            this.iconPictureBox2.TabIndex = 7;
            this.iconPictureBox2.TabStop = false;
            // 
            // pnlConteudos
            // 
            this.pnlConteudos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlConteudos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudos.Location = new System.Drawing.Point(260, 44);
            this.pnlConteudos.Name = "pnlConteudos";
            this.pnlConteudos.Size = new System.Drawing.Size(1228, 856);
            this.pnlConteudos.TabIndex = 2;
            // 
            // iconFinanceiro
            // 
            this.iconFinanceiro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFinanceiro.FlatAppearance.BorderSize = 0;
            this.iconFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconFinanceiro.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.iconFinanceiro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconFinanceiro.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconFinanceiro.IconColor = System.Drawing.Color.White;
            this.iconFinanceiro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconFinanceiro.Location = new System.Drawing.Point(14, 285);
            this.iconFinanceiro.Name = "iconFinanceiro";
            this.iconFinanceiro.Size = new System.Drawing.Size(215, 46);
            this.iconFinanceiro.TabIndex = 9;
            this.iconFinanceiro.Text = "Financeiro";
            this.iconFinanceiro.UseVisualStyleBackColor = true;
            this.iconFinanceiro.Click += new System.EventHandler(this.iconFinanceiro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 900);
            this.Controls.Add(this.pnlConteudos);
            this.Controls.Add(this.pnlMenuLateral);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.pnlMenusControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMenuLateral;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnRestaurar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton BtnMaximinizar;
        private FontAwesome.Sharp.IconButton btnVendas;
        private System.Windows.Forms.Panel pnlMenusControles;
        private FontAwesome.Sharp.IconButton btnProdutos;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnEstoque;
        private FontAwesome.Sharp.IconButton btnFornecedores;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox btnContato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel pnlConteudos;
        private System.Windows.Forms.Label lblNome;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton iconFinanceiro;
    }
}

