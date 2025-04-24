namespace P1___Beatriz_e_Sara
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPolitica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEconomia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGuerra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuParcerias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNoticias = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbPaises = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPolitica,
            this.menuEconomia,
            this.menuGuerra,
            this.menuParcerias,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPolitica
            // 
            this.menuPolitica.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuPolitica.Name = "menuPolitica";
            this.menuPolitica.Size = new System.Drawing.Size(71, 24);
            this.menuPolitica.Text = "Politica";
            this.menuPolitica.Click += new System.EventHandler(this.menuPolitica_Click);
            // 
            // menuEconomia
            // 
            this.menuEconomia.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuEconomia.Name = "menuEconomia";
            this.menuEconomia.Size = new System.Drawing.Size(89, 24);
            this.menuEconomia.Text = "Economia";
            this.menuEconomia.Click += new System.EventHandler(this.menuEconomia_Click);
            // 
            // menuGuerra
            // 
            this.menuGuerra.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuGuerra.Name = "menuGuerra";
            this.menuGuerra.Size = new System.Drawing.Size(67, 24);
            this.menuGuerra.Text = "Guerra";
            this.menuGuerra.Click += new System.EventHandler(this.menuGuerra_Click);
            // 
            // menuParcerias
            // 
            this.menuParcerias.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuParcerias.Name = "menuParcerias";
            this.menuParcerias.Size = new System.Drawing.Size(81, 24);
            this.menuParcerias.Text = "Parcerias";
            this.menuParcerias.Click += new System.EventHandler(this.menuParcerias_Click);
            // 
            // menuSair
            // 
            this.menuSair.BackColor = System.Drawing.Color.IndianRed;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(48, 24);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblConteudo);
            this.grpInfo.Location = new System.Drawing.Point(16, 44);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfo.Size = new System.Drawing.Size(1035, 288);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informações";
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Location = new System.Drawing.Point(8, 33);
            this.lblConteudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(165, 16);
            this.lblConteudo.TabIndex = 0;
            this.lblConteudo.Text = "Selecione um tema acima.";
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(384, 340);
            this.picImagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(349, 170);
            this.picImagem.TabIndex = 2;
            this.picImagem.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(130, 20);
            this.lblHora.Text = "Carregando hora...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnNoticias
            // 
            this.btnNoticias.Location = new System.Drawing.Point(937, 497);
            this.btnNoticias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoticias.Name = "btnNoticias";
            this.btnNoticias.Size = new System.Drawing.Size(113, 26);
            this.btnNoticias.TabIndex = 4;
            this.btnNoticias.Text = "Abrir Notícias";
            this.btnNoticias.UseVisualStyleBackColor = true;
            this.btnNoticias.Click += new System.EventHandler(this.btnNoticias_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 495);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(283, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbPaises
            // 
            this.cmbPaises.FormattingEnabled = true;
            this.cmbPaises.Items.AddRange(new object[] {
            "EUA",
            "Ucrânia",
            "Rússia"});
            this.cmbPaises.Location = new System.Drawing.Point(889, 4);
            this.cmbPaises.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaises.Name = "cmbPaises";
            this.cmbPaises.Size = new System.Drawing.Size(160, 24);
            this.cmbPaises.TabIndex = 6;
            this.cmbPaises.SelectedIndexChanged += new System.EventHandler(this.cmbPaises_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbPaises);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnNoticias);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "NoticiasBiaSa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPolitica;
        private System.Windows.Forms.ToolStripMenuItem menuEconomia;
        private System.Windows.Forms.ToolStripMenuItem menuGuerra;
        private System.Windows.Forms.ToolStripMenuItem menuParcerias;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNoticias;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbPaises;
    }
}

