using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portifolio
{
    public partial class FrmPortifolio : Form
    {
        public FrmPortifolio()
        {
            InitializeComponent();
            MessageBox.Show("Olá! Bem-vindo ao meu repositório de Mini Projetos e Estudos. Aqui compartilho meus aprendizados," + " códigos e experimentos.", "Bem-vindo", MessageBoxButtons.OK);
            // MessageBox.Show("Este portfólio é uma coleção de projetos que refletem meu crescimento como desenvolvedor e minha paixão por aprender novas tecnologias.", "Sobre o Portfólio", MessageBoxButtons.OK);
        }
    }
}
