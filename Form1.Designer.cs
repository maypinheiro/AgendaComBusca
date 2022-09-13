
namespace WF1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.celular = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.Novo = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Deletar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pesquisarId = new System.Windows.Forms.TextBox();
            this.buscarId = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGENDA- CONTATOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(51, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(51, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(51, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(51, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(51, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(159, 169);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(383, 20);
            this.nome.TabIndex = 6;
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(159, 210);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(383, 20);
            this.endereco.TabIndex = 7;
            // 
            // celular
            // 
            this.celular.Location = new System.Drawing.Point(159, 251);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(383, 20);
            this.celular.TabIndex = 8;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(159, 292);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(383, 20);
            this.telefone.TabIndex = 9;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(159, 327);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(383, 20);
            this.email.TabIndex = 10;
            // 
            // Novo
            // 
            this.Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Novo.ForeColor = System.Drawing.Color.Black;
            this.Novo.Location = new System.Drawing.Point(593, 297);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(123, 46);
            this.Novo.TabIndex = 11;
            this.Novo.Text = "Limpar";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Salvar
            // 
            this.Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Salvar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Salvar.Location = new System.Drawing.Point(430, 367);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(112, 31);
            this.Salvar.TabIndex = 12;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Atualizar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Atualizar.Location = new System.Drawing.Point(593, 174);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(123, 46);
            this.Atualizar.TabIndex = 13;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Deletar
            // 
            this.Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Deletar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Deletar.Location = new System.Drawing.Point(593, 236);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(123, 46);
            this.Deletar.TabIndex = 14;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // Sair
            // 
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Sair.Location = new System.Drawing.Point(658, 636);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(69, 31);
            this.Sair.TabIndex = 15;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 417);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 200);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(50, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pesquisar por ID";
            // 
            // pesquisarId
            // 
            this.pesquisarId.Location = new System.Drawing.Point(229, 110);
            this.pesquisarId.Name = "pesquisarId";
            this.pesquisarId.Size = new System.Drawing.Size(80, 20);
            this.pesquisarId.TabIndex = 19;
            // 
            // buscarId
            // 
            this.buscarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscarId.Location = new System.Drawing.Point(352, 106);
            this.buscarId.Name = "buscarId";
            this.buscarId.Size = new System.Drawing.Size(88, 26);
            this.buscarId.TabIndex = 20;
            this.buscarId.Text = "Pesquisar";
            this.buscarId.UseVisualStyleBackColor = true;
            this.buscarId.Click += new System.EventHandler(this.buscarId_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WF1.Properties.Resources.kisspng_bee_logo_ibm_graphic_designer_ibm_5ab6f25e9dca09_7415427815219390386463;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Image = global::WF1.Properties.Resources.kisspng_bee_logo_ibm_graphic_designer_ibm_5ab6f25e9dca09_7415427815219390386463;
            this.button1.Location = new System.Drawing.Point(446, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WF1.Properties.Resources.copiaAbelha;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 60);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(758, 679);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscarId);
            this.Controls.Add(this.pesquisarId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Deletar);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.celular);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pesquisarId;
        private System.Windows.Forms.Button buscarId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

