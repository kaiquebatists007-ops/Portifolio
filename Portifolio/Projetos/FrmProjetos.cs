using System.Diagnostics; // Para abrir o navegador
using System.IO; // Para manipular arquivos
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portifolio
{
    public partial class FrmProjetos : Form
    {
        // Lista para saber quais PictureBox estão na tela e poder apagá-los depois
        private List<PictureBox> telasAtivas = new List<PictureBox>(); // Lista para armazenar os PictureBox ativos na tela
        public FrmProjetos()
        {
            InitializeComponent();

            btnExecutar.Visible = false;
            btnExecutar.Enabled = false;
        }

        // Metodo para limpar a tela e apagar os PictureBox que estão na tela
        private void LimparTela()
        {
            foreach (var tela in telasAtivas) // Percorre cada PictureBox na lista de telasAtivas
            {
                this.Controls.Remove(tela); // Remove o PictureBox da tela
                tela.Dispose(); // Libera os recursos do PictureBox
            }
            telasAtivas.Clear();
        }

        // Posição da PictureBox (X, Y) 
        private void AdicionarTela(Image imagem, int x, int y, int largura = 220, int altura = 160)
        {
            PictureBox tela = new PictureBox();
            tela.Image = imagem;  // Define a imagem da PictureBox
            tela.Location = new Point(x, y);   // Define a posição da PictureBox na tela
            tela.Size = new Size(largura, altura);  // Define o tamanho da PictureBox
            tela.SizeMode = PictureBoxSizeMode.StretchImage;  // Ajusta a imagem para caber na PictureBox mantendo a proporção
            tela.BorderStyle = BorderStyle.FixedSingle; // Adiciona uma borda ao redor da PictureBox

            this.Controls.Add(tela);
            telasAtivas.Add(tela);
        }
        // Metodo para selecionar o projeto e mostrar a descrição
        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cbProjetos.Text))
            {
                MessageBox.Show("Selecione um projeto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listDescricao.Items.Clear(); // Limpa a lista de descrição antes de adicionar novas descrições

            LimparTela(); // Limpa a tela antes de adicionar novas imagens

            lblNomeProjeto.Text = cbProjetos.Text.ToUpper();

            btnAchou(); // Mostra o botão de executar

            switch (cbProjetos.Text)
            {
                
                case "Numero Primo":
                    listDescricao.Items.Add("A aplicação Número Primo tem como");
                    listDescricao.Items.Add("objetivo identificar se um número é primo");
                    listDescricao.Items.Add("ou não.");

                    AdicionarTela(Properties.Resources.PrimeiraTela, 405, 150, 230, 100);
                    AdicionarTela(Properties.Resources.SegundaTela, 290, 260, 230, 100);
                    AdicionarTela(Properties.Resources.TerceiraTela, 525, 260, 230, 100);
                    break;

                case "Tabuada":
                    listDescricao.Items.Add("teste");
                    break;
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            
            switch (cbProjetos.Text)
            {
                case "Numero Primo":
                    ExecutarNumerPrimo();
                    break;

                case "Tabuada":
                    MessageBox.Show("Projeto Tabuada ainda não implementado.");
                    btnExecutar.Enabled = true;
                    break;
            }
            
        }

        private void btnSumiu()
        {
            btnExecutar.Visible = false;
            btnExecutar.Enabled = false;
        }

        private void btnAchou()
        {
            btnExecutar.Visible = true;
            btnExecutar.Enabled = true;
        }
        

        private void ExecutarNumerPrimo()
        {
            // Monta o caminho saindo da pasta bin\Debug do projeto atual até o NumeroPrimo.exe
            string caminhoExe = Path.Combine(       // Caminho relativo para o executável do projeto NumeroPrimo
                Application.StartupPath,            // Caminho do diretório de inicialização do aplicativo
                @"..\..\Projetos\Numero_Primo\NumeroPrimo\bin\Debug\NumeroPrimo.exe"
            );

            // Converte para o caminho completo limpo
            caminhoExe = Path.GetFullPath(caminhoExe);
            Process.Start(caminhoExe);
            
        }
    }
    
}


       

        
    

