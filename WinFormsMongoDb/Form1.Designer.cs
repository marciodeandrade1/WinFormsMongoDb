namespace WinFormsMongoDb
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            btnSalvar = new Button();
            btnListar = new Button();
            lstUsuarios = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 60);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 101);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(97, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(167, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(97, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(167, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(97, 98);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(167, 23);
            txtTelefone.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(97, 143);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(189, 143);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(307, 28);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.ScrollAlwaysVisible = true;
            lstUsuarios.Size = new Size(325, 139);
            lstUsuarios.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 208);
            Controls.Add(lstUsuarios);
            Controls.Add(btnListar);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cadastro de Usuários - MongoDB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Button btnSalvar;
        private Button btnListar;
        private ListBox lstUsuarios;
    }
}
