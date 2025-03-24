namespace Login_hash
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.bntLogin = new System.Windows.Forms.Button();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.lbl_passwordlogin = new System.Windows.Forms.Label();
            this.lbl_nameUser = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.TabPage();
            this.bntRegistar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.lblSenhaRegistro = new System.Windows.Forms.Label();
            this.lblUsuarioRegistro = new System.Windows.Forms.Label();
            this.Banco_Dados = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.configuração = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenhaEmailSMTP = new System.Windows.Forms.TextBox();
            this.txtEmailUsuarioSMTP = new System.Windows.Forms.TextBox();
            this.nupPortaSMTP = new System.Windows.Forms.NumericUpDown();
            this.txtEnderecoSMTP = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.Login.SuspendLayout();
            this.Registro.SuspendLayout();
            this.Banco_Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.configuração.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPortaSMTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.Registro);
            this.tabControl1.Controls.Add(this.Banco_Dados);
            this.tabControl1.Controls.Add(this.configuração);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.bntLogin);
            this.Login.Controls.Add(this.txtSenhaLogin);
            this.Login.Controls.Add(this.txtUsuarioLogin);
            this.Login.Controls.Add(this.lbl_passwordlogin);
            this.Login.Controls.Add(this.lbl_nameUser);
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(619, 427);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // bntLogin
            // 
            this.bntLogin.Location = new System.Drawing.Point(131, 177);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(75, 23);
            this.bntLogin.TabIndex = 4;
            this.bntLogin.Text = "Login";
            this.bntLogin.UseVisualStyleBackColor = true;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(129, 111);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaLogin.TabIndex = 3;
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(131, 50);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(98, 20);
            this.txtUsuarioLogin.TabIndex = 2;
            // 
            // lbl_passwordlogin
            // 
            this.lbl_passwordlogin.AutoSize = true;
            this.lbl_passwordlogin.Location = new System.Drawing.Point(26, 114);
            this.lbl_passwordlogin.Name = "lbl_passwordlogin";
            this.lbl_passwordlogin.Size = new System.Drawing.Size(38, 13);
            this.lbl_passwordlogin.TabIndex = 1;
            this.lbl_passwordlogin.Text = "Senha";
            // 
            // lbl_nameUser
            // 
            this.lbl_nameUser.AutoSize = true;
            this.lbl_nameUser.Location = new System.Drawing.Point(26, 53);
            this.lbl_nameUser.Name = "lbl_nameUser";
            this.lbl_nameUser.Size = new System.Drawing.Size(43, 13);
            this.lbl_nameUser.TabIndex = 0;
            this.lbl_nameUser.Text = "Usuário";
            // 
            // Registro
            // 
            this.Registro.Controls.Add(this.bntRegistar);
            this.Registro.Controls.Add(this.txtEmail);
            this.Registro.Controls.Add(this.txtConfirmarSenha);
            this.Registro.Controls.Add(this.txtSenha);
            this.Registro.Controls.Add(this.txtUsuario);
            this.Registro.Controls.Add(this.lblEmail);
            this.Registro.Controls.Add(this.lblConfirmar);
            this.Registro.Controls.Add(this.lblSenhaRegistro);
            this.Registro.Controls.Add(this.lblUsuarioRegistro);
            this.Registro.Location = new System.Drawing.Point(4, 22);
            this.Registro.Name = "Registro";
            this.Registro.Padding = new System.Windows.Forms.Padding(3);
            this.Registro.Size = new System.Drawing.Size(619, 427);
            this.Registro.TabIndex = 1;
            this.Registro.Text = "Registro";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // bntRegistar
            // 
            this.bntRegistar.Location = new System.Drawing.Point(357, 115);
            this.bntRegistar.Name = "bntRegistar";
            this.bntRegistar.Size = new System.Drawing.Size(75, 23);
            this.bntRegistar.TabIndex = 8;
            this.bntRegistar.Text = "Registrar";
            this.bntRegistar.UseVisualStyleBackColor = true;
            this.bntRegistar.Click += new System.EventHandler(this.bntRegistar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(148, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(148, 135);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmarSenha.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(148, 92);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(148, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(43, 142);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(51, 13);
            this.lblConfirmar.TabIndex = 2;
            this.lblConfirmar.Text = "Confirmar";
            // 
            // lblSenhaRegistro
            // 
            this.lblSenhaRegistro.AutoSize = true;
            this.lblSenhaRegistro.Location = new System.Drawing.Point(43, 92);
            this.lblSenhaRegistro.Name = "lblSenhaRegistro";
            this.lblSenhaRegistro.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaRegistro.TabIndex = 1;
            this.lblSenhaRegistro.Text = "Senha";
            // 
            // lblUsuarioRegistro
            // 
            this.lblUsuarioRegistro.AutoSize = true;
            this.lblUsuarioRegistro.Location = new System.Drawing.Point(43, 45);
            this.lblUsuarioRegistro.Name = "lblUsuarioRegistro";
            this.lblUsuarioRegistro.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioRegistro.TabIndex = 0;
            this.lblUsuarioRegistro.Text = "Usuário";
            // 
            // Banco_Dados
            // 
            this.Banco_Dados.Controls.Add(this.bindingNavigator1);
            this.Banco_Dados.Controls.Add(this.dataGridView1);
            this.Banco_Dados.Location = new System.Drawing.Point(4, 22);
            this.Banco_Dados.Name = "Banco_Dados";
            this.Banco_Dados.Padding = new System.Windows.Forms.Padding(3);
            this.Banco_Dados.Size = new System.Drawing.Size(619, 427);
            this.Banco_Dados.TabIndex = 2;
            this.Banco_Dados.Text = "Banco de Dados";
            this.Banco_Dados.UseVisualStyleBackColor = true;
            this.Banco_Dados.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(613, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // configuração
            // 
            this.configuração.Controls.Add(this.label8);
            this.configuração.Controls.Add(this.label7);
            this.configuração.Controls.Add(this.label6);
            this.configuração.Controls.Add(this.label5);
            this.configuração.Controls.Add(this.txtSenhaEmailSMTP);
            this.configuração.Controls.Add(this.txtEmailUsuarioSMTP);
            this.configuração.Controls.Add(this.nupPortaSMTP);
            this.configuração.Controls.Add(this.txtEnderecoSMTP);
            this.configuração.Location = new System.Drawing.Point(4, 22);
            this.configuração.Name = "configuração";
            this.configuração.Padding = new System.Windows.Forms.Padding(3);
            this.configuração.Size = new System.Drawing.Size(619, 427);
            this.configuração.TabIndex = 3;
            this.configuração.Text = "Configuração";
            this.configuração.UseVisualStyleBackColor = true;
            this.configuração.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // txtSenhaEmailSMTP
            // 
            this.txtSenhaEmailSMTP.Location = new System.Drawing.Point(135, 257);
            this.txtSenhaEmailSMTP.Name = "txtSenhaEmailSMTP";
            this.txtSenhaEmailSMTP.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaEmailSMTP.TabIndex = 3;
            // 
            // txtEmailUsuarioSMTP
            // 
            this.txtEmailUsuarioSMTP.Location = new System.Drawing.Point(135, 211);
            this.txtEmailUsuarioSMTP.Name = "txtEmailUsuarioSMTP";
            this.txtEmailUsuarioSMTP.Size = new System.Drawing.Size(100, 20);
            this.txtEmailUsuarioSMTP.TabIndex = 2;
            // 
            // nupPortaSMTP
            // 
            this.nupPortaSMTP.Location = new System.Drawing.Point(135, 144);
            this.nupPortaSMTP.Name = "nupPortaSMTP";
            this.nupPortaSMTP.Size = new System.Drawing.Size(120, 20);
            this.nupPortaSMTP.TabIndex = 1;
            // 
            // txtEnderecoSMTP
            // 
            this.txtEnderecoSMTP.Location = new System.Drawing.Point(135, 85);
            this.txtEnderecoSMTP.Name = "txtEnderecoSMTP";
            this.txtEnderecoSMTP.Size = new System.Drawing.Size(100, 20);
            this.txtEnderecoSMTP.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Registro.ResumeLayout(false);
            this.Registro.PerformLayout();
            this.Banco_Dados.ResumeLayout(false);
            this.Banco_Dados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.configuração.ResumeLayout(false);
            this.configuração.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPortaSMTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage Registro;
        private System.Windows.Forms.TabPage Banco_Dados;
        private System.Windows.Forms.TabPage configuração;
        private System.Windows.Forms.Button bntLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.Label lbl_passwordlogin;
        private System.Windows.Forms.Label lbl_nameUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label lblSenhaRegistro;
        private System.Windows.Forms.Label lblUsuarioRegistro;
        private System.Windows.Forms.Button bntRegistar;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenhaEmailSMTP;
        private System.Windows.Forms.TextBox txtEmailUsuarioSMTP;
        private System.Windows.Forms.NumericUpDown nupPortaSMTP;
        private System.Windows.Forms.TextBox txtEnderecoSMTP;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

