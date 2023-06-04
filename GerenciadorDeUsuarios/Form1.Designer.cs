namespace GerenciadorDeUsuarios
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
            btnAdicionar = new Button();
            btnAlterar = new Button();
            btnDeletar = new Button();
            lblId = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblTelephone = new Label();
            lblDateOfBirth = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtTelephone = new TextBox();
            txtDateOfBirth = new TextBox();
            btnLimpar = new Button();
            dgvUser = new DataGridView();
            txtAge = new TextBox();
            lblAge = new Label();
            lblCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(108, 311);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(226, 311);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(112, 34);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(108, 351);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(112, 34);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(148, 63);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 3;
            lblId.Text = "ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(117, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 25);
            lblName.TabIndex = 4;
            lblName.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(124, 137);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(101, 174);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(81, 25);
            lblTelephone.TabIndex = 6;
            lblTelephone.Text = "Telefone:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(3, 247);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(179, 25);
            lblDateOfBirth.TabIndex = 7;
            lblDateOfBirth.Text = "Data De Nascimento:";
            // 
            // txtId
            // 
            txtId.Location = new Point(188, 60);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(188, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(188, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 10;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(188, 171);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(150, 31);
            txtTelephone.TabIndex = 11;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(188, 244);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(150, 31);
            txtDateOfBirth.TabIndex = 12;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(226, 351);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(360, 60);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 62;
            dgvUser.RowTemplate.Height = 33;
            dgvUser.Size = new Size(387, 275);
            dgvUser.TabIndex = 14;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(188, 208);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 31);
            txtAge.TabIndex = 16;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(121, 208);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(61, 25);
            lblAge.TabIndex = 15;
            lblAge.Text = "Idade:";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(360, 360);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(180, 25);
            lblCount.TabIndex = 17;
            lblCount.Text = "Numero de registros:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCount);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(dgvUser);
            Controls.Add(btnLimpar);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtTelephone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblTelephone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(btnDeletar);
            Controls.Add(btnAlterar);
            Controls.Add(btnAdicionar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnAlterar;
        private Button btnDeletar;
        private Label lblId;
        private Label lblName;
        private Label lblEmail;
        private Label lblTelephone;
        private Label lblDateOfBirth;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtTelephone;
        private TextBox txtDateOfBirth;
        private Button btnLimpar;
        private DataGridView dgvUser;
        private TextBox txtAge;
        private Label lblAge;
        private Label lblCount;
    }
}