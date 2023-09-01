namespace Investimentos
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.lbName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblProfisao = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 7);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nome Completo";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(3, 23);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txbName, "Digite o seu nome");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.txbJob);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.lblProfisao);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.mtbCPF);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 374);
            this.panel1.TabIndex = 2;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(553, 63);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(553, 20);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(3, 63);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(100, 20);
            this.txbJob.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txbJob, "Digite sua profissão");
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(12, 173);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 9;
            this.lblGenero.Text = "Gênero";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outro",
            "Prefiro não informar"});
            this.cmbGenero.Location = new System.Drawing.Point(3, 189);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 8;
            // 
            // lblProfisao
            // 
            this.lblProfisao.AutoSize = true;
            this.lblProfisao.Location = new System.Drawing.Point(12, 46);
            this.lblProfisao.Name = "lblProfisao";
            this.lblProfisao.Size = new System.Drawing.Size(45, 13);
            this.lblProfisao.TabIndex = 7;
            this.lblProfisao.Text = "Profisão";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(3, 111);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txbEmail, "Digite o seu Email");
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(3, 150);
            this.mtbCPF.Mask = "000,000,000,00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(100, 20);
            this.mtbCPF.TabIndex = 5;
            this.toolTip1.SetToolTip(this.mtbCPF, "Digite o seu CPF");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(15, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 131);
            this.panel2.TabIndex = 13;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(607, 113);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Profissao";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPF";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Genero";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUser";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProfisao;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}