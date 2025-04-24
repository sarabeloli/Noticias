using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1___Beatriz_e_Sara
{
    public partial class Form1 : Form
    {
        private string paisSelecionado = "EUA"; // Valor padrão

        public Form1()
        {
            InitializeComponent();
            timer1.Start(); // Inicia o relógio
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarHora(); // Atualiza a hora ao abrir
            cmbPaises.Items.AddRange(new string[] { "EUA", "Ucrânia", "Rússia" });
            cmbPaises.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarHora();
        }

        private void AtualizarHora()
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void menuPolitica_Click(object sender, EventArgs e)
        {
            string texto = "";

            switch (paisSelecionado)
            {
                case "EUA":
                    texto = "Política dos EUA:\n\n\nEm abril de 2025, os Estados Unidos enfrentam um cenário político complexo.\n\n\nA administração do presidente Donald Trump tem adotado uma postura mais isolacionista, especialmente em relação ao conflito na Ucrânia.\n\n\nRecentemente, Trump suspendeu a assistência militar e o compartilhamento de inteligência com Kiev,\n\n\n após uma reunião tensa com o presidente ucraniano Volodymyr Zelensky na Casa Branca.\n\n\nEssa decisão gerou críticas de aliados europeus e levantou preocupações sobre o compromisso dos EUA com a segurança internacional.";
                    break;
                case "Ucrânia":
                    texto = "Política da Ucrânia:\n\n\nA Ucrânia enfrenta desafios políticos significativos em 2025.\n\n\nO presidente Volodymyr Zelensky busca manter a unidade nacional e o apoio internacional, apesar das pressões internas e externas.\n\n\nA suspensão do apoio militar dos EUA complicou ainda mais a situação,\n\n\n levando o governo ucraniano a intensificar esforços diplomáticos com outros parceiros internacionais.";
                    break;
                case "Rússia":
                    texto = "Política da Rússia:\n\n\nSob a liderança de Vladimir Putin, a Rússia mantém uma postura autoritária e centralizada.\n\n\nO governo tem promovido políticas que reforçam o controle estatal e limitam a oposição interna.\n\n\nRecentemente, Putin desafiou os EUA para um \"duelo de alta tecnologia\", destacando os avanços militares russos e a disposição para confrontos estratégicos.";
                    break;
            }

            lblConteudo.Text = texto;
            string nomeArquivo = $"{paisSelecionado}_politica.jpg";
            CarregarImagemRedimensionada(nomeArquivo);
        }

        private void menuEconomia_Click(object sender, EventArgs e)
        {
            string texto = "";

            switch (paisSelecionado)
            {
                case "EUA":
                    texto = "Economia dos EUA:\n\n\nA economia americana continua robusta, com crescimento impulsionado por investimentos em tecnologia e energia.\n\n\nNo entanto, a reestruturação do capitalismo interno tem causado debates sobre desigualdade e políticas fiscais.\n\n\nO governo Trump tem promovido reformas que visam reduzir a intervenção estatal, que tem gerado tanto apoio quanto críticas de diferentes setores da sociedade.";
                    break;
                case "Ucrânia":
                    texto = "Economia da Ucrânia:\n\n\nA economia ucraniana está sob forte pressão devido à guerra prolongada.\n\n\nA infraestrutura do país sofreu danos significativos, e a dependência de ajuda externa aumentou.\n\n\nRecentemente, a Ucrânia iniciou negociações com os EUA para um novo acordo de minerais,\n\n\n visando impulsionar a recuperação econômica e atrair investimentos estrangeiros.";
                    break;
                case "Rússia":
                    texto = "Economia da Rússia:\n\n\nA economia russa enfrenta sanções internacionais, mas tem mostrado resiliência.\n\n\nO país tem buscado fortalecer laços econômicos com nações como China e Irã, além de investir em setores estratégicos para reduzir a dependência de mercados ocidentais.\n\n\nEssas medidas visam mitigar os impactos das sanções e manter a estabilidade econômica interna.";
                    break;
            }

            lblConteudo.Text = texto;
            string nomeArquivo = $"{paisSelecionado}_economia.jpg";
            CarregarImagemRedimensionada(nomeArquivo);
        }


        private void menuGuerra_Click(object sender, EventArgs e)
        {
            string texto = "";

            switch (paisSelecionado)
            {
                case "EUA":
                    texto = "Conflito EUA-Ucrânia:\n\n\nOs Estados Unidos têm adotado uma abordagem mais cautelosa em relação ao conflito na Ucrânia.\n\n\nEmbora tenham suspendido parte do apoio militar, continuam envolvidos em negociações diplomáticas com a Rússia.\n\n\nRecentemente, representantes dos EUA e da Rússia se reuniram em Istambul para discutir a reabertura de embaixadas e missões diplomáticas,\n\n\n sinalizando uma tentativa de melhorar as relações bilaterais.";
                    break;
                case "Ucrânia":
                    texto = "Guerra na Ucrânia:\n\n\nA guerra na Ucrânia continua intensa, com a Rússia controlando cerca de 19% do território ucraniano.\n\n\nAs forças ucranianas enfrentam desafios como escassez de recursos e moral abalada.\n\n\nApesar disso, o país mantém sua resistência e busca apoio internacional para fortalecer sua defesa e recuperar os territórios ocupados.";
                    break;
                case "Rússia":
                    texto = "Conflito Rússia-Ucrânia:\n\n\nA Rússia continua sua ofensiva na Ucrânia, controlando uma parte significativa do território ucraniano.\n\n\nAs forças russas têm realizado ataques constantes, visando enfraquecer a resistência ucraniana.\n\n\nApesar das críticas internacionais, o governo russo mantém sua justificativa de que as ações são necessárias para proteger seus interesses e segurança nacional.";
                    break;
            }

            lblConteudo.Text = texto;
            string nomeArquivo = $"{paisSelecionado}_guerra.jpg";
            CarregarImagemRedimensionada(nomeArquivo);
        }


        private void menuParcerias_Click(object sender, EventArgs e)
        {
            string texto = "";

            switch (paisSelecionado)
            {
                case "EUA":
                    texto = "Parcerias dos EUA:\n\n\nApesar das tensões, os EUA mantêm parcerias estratégicas com diversos países.\n\n\nA relação com a Ucrânia, embora abalada, ainda inclui acordos em áreas como minerais e tecnologia.\n\n\nAlém disso, os EUA continuam a colaborar com aliados europeus e asiáticos em questões de segurança e comércio, buscando equilibrar seus interesses globais.";
                    break;
                case "Ucrânia":
                    texto = "Parcerias da Ucrânia:\n\n\nA Ucrânia tem fortalecido suas parcerias com países europeus e outras nações aliadas.\n\n\nApesar das recentes tensões com os EUA, o país continua a buscar acordos estratégicos que possam contribuir para sua segurança e reconstrução.\n\n\nA cooperação com a União Europeia e outras organizações internacionais permanece vital para o futuro da Ucrânia.";
                    break;
                case "Rússia":
                    texto = "Parcerias da Rússia:\n\n\nA Rússia tem fortalecido suas parcerias com países que compartilham interesses estratégicos semelhantes.\n\n\nA colaboração com nações como China e Irã tem se intensificado, abrangendo áreas como comércio, energia e defesa.\n\n\nEssas alianças visam contrabalançar o isolamento imposto pelas sanções ocidentais e expandir a influência russa em outras regiões.";
                    break;
            }

            lblConteudo.Text = texto;
            string nomeArquivo = $"{paisSelecionado}_parcerias.jpg";
            CarregarImagemRedimensionada(nomeArquivo);
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNoticias_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bbc.com/portuguese");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Data selecionada: " + dateTimePicker1.Value.ToShortDateString());
        }

        private void cmbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            paisSelecionado = cmbPaises.SelectedItem.ToString();
            lblConteudo.Text = $"Selecione um tema para ver informações sobre {paisSelecionado}.";
            picImagem.Image = null;
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return bmp;
        }

        private void CarregarImagemRedimensionada(string nomeArquivo)
        {
            string caminho = System.IO.Path.Combine(Application.StartupPath, nomeArquivo);

            if (System.IO.File.Exists(caminho))
            {
                Image original = Image.FromFile(caminho);
                Image redimensionada = ResizeImage(original, picImagem.Width, picImagem.Height);
                picImagem.Image = redimensionada;
            }
            else
            {
                picImagem.Image = null;
                MessageBox.Show("Imagem não encontrada: " + nomeArquivo);
            }
        }
    }
}
