using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Genetic.Classes;
using System.Collections;

namespace Genetic {
    public partial class Panel:Form {
        List<Cor> Populacao = new List<Cor>();
        List<Cor> Fitness = new List<Cor>();
        int populacaoini = 0;
        int geracao;
        bool auto = false;
        bool paint = true;
        Random rand = new Random();

        public Panel() {
            InitializeComponent();
        }
        /// <summary>
        /// Ação do recurso visual de seleção de cor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelecaoDeCor(object sender,EventArgs e) {
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            CMR.Text = "R: " + c.R.ToString();
            CMG.Text = "G: " + c.G.ToString();
            CMB.Text = "B: " + c.B.ToString();
            CorModelo.BackColor = c;
        }
        /// <summary>
        /// Faz a avaliação de fitness dos individuos e 
        /// </summary>
        private void SelecaoAvaliacaoFitness() {
            int cutOff = 0;
            try {
                cutOff = Int32.Parse(CutOff.Text);
            } catch {
                cutOff = 0;
            }

            if(cutOff == 0) {
                cutOff = 5;
                CutOff.Text = "5";
            }
            Fitness = new List<Cor>();

            for(int i = 0; i < Populacao.Count; i++) {
                //traduzindo de binario para int
                int r = Convert.ToInt32(Populacao[i].DNA[0],2);
                int g = Convert.ToInt32(Populacao[i].DNA[1],2);
                int b = Convert.ToInt32(Populacao[i].DNA[2],2);

                //definindo a avaliação do individuo em comparação com a cor modelo
                r = CorModelo.BackColor.R - r;
                g = CorModelo.BackColor.G - g;
                b = CorModelo.BackColor.B - b;

                if(r < 0) {
                    r *= -1;
                }
                if(g < 0) {
                    g *= -1;
                }
                if(b < 0) {
                    b *= -1;
                }
                Populacao[i].Fitness = r + g + b;

                Fitness.Add(Populacao[i]);
            }
            //ordenado a população de mais adequados a menos adequados
            Fitness.Sort(delegate (Cor a1,Cor a2) {
                return a1.Fitness.CompareTo(a2.Fitness);
            });
            //removendo parte da população, permanecendo somente os melhores na população
            for(int i = Fitness.Count / cutOff; i < Fitness.Count; i++) {
                Populacao.Remove(Fitness[i]);
            }
        }
        /// <summary>
        /// carrega na tela os melhores e piores individuos
        /// </summary>
        private void CarregaMelhoresPioresIndividuosPopulacao() {
            //BEST FITED
            int r = Convert.ToInt32(Fitness[0].DNA[0],2);
            int g = Convert.ToInt32(Fitness[0].DNA[1],2);
            int b = Convert.ToInt32(Fitness[0].DNA[2],2);
            BFR.Text = "R: " + r.ToString();
            BFG.Text = "G: " + g.ToString();
            BFB.Text = "B: " + b.ToString();
            BF1.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Fitness[1].DNA[0],2);
            g = Convert.ToInt32(Fitness[1].DNA[1],2);
            b = Convert.ToInt32(Fitness[1].DNA[2],2);
            BF2.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Fitness[2].DNA[0],2);
            g = Convert.ToInt32(Fitness[2].DNA[1],2);
            b = Convert.ToInt32(Fitness[2].DNA[2],2);
            BF3.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Fitness[3].DNA[0],2);
            g = Convert.ToInt32(Fitness[3].DNA[1],2);
            b = Convert.ToInt32(Fitness[3].DNA[2],2);
            BF4.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Fitness[4].DNA[0],2);
            g = Convert.ToInt32(Fitness[4].DNA[1],2);
            b = Convert.ToInt32(Fitness[4].DNA[2],2);
            BF5.BackColor = Color.FromArgb(r,g,b);

            //WORST FITED
            r = Convert.ToInt32(Fitness[Fitness.Count - 1].DNA[0],2);
            g = Convert.ToInt32(Fitness[Fitness.Count - 1].DNA[1],2);
            b = Convert.ToInt32(Fitness[Fitness.Count - 1].DNA[2],2);
            WF1.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Fitness[Fitness.Count - 2].DNA[0],2);
            g = Convert.ToInt32(Fitness[Fitness.Count - 2].DNA[1],2);
            b = Convert.ToInt32(Fitness[Fitness.Count - 2].DNA[2],2);
            WF2.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Fitness[Fitness.Count - 3].DNA[0],2);
            g = Convert.ToInt32(Fitness[Fitness.Count - 3].DNA[1],2);
            b = Convert.ToInt32(Fitness[Fitness.Count - 3].DNA[2],2);
            WF3.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Fitness[Fitness.Count - 4].DNA[0],2);
            g = Convert.ToInt32(Fitness[Fitness.Count - 4].DNA[1],2);
            b = Convert.ToInt32(Fitness[Fitness.Count - 4].DNA[2],2);
            WF4.BackColor = Color.FromArgb(r,g,b);

            if(!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void cruzamento() {
            if(Populacao.Count != populacaoini) {
                //com somente uma parte da população, selecionamos os melhores
                //List<Cor> Pais = Populacao.ToList();
                while(Populacao.Count != populacaoini) {
                    //Agora vamos gerar o resto da população definida a partir desses melhores
                    int PaiAleatorio = rand.Next(0,Populacao.Count - 1);
                    int MaeAleatoria = rand.Next(0,Populacao.Count - 1);
                    Cor Filho = Populacao[PaiAleatorio].crossover(Populacao[MaeAleatoria]);
                    Populacao.Add(Filho);
                }
            }
        }
        private void timerSelecao_Tick(object sender,EventArgs e) {
            geracao++;
            this.BackColor = Color.Gray;
            SelecaoAvaliacaoFitness();
            cruzamento();
            if(paint) {
                CarregaMelhoresPioresIndividuosPopulacao();
                this.BackColor = Color.White;
                labelGeracao.Text = "Geração: " + geracao;
            }
            if(!auto) {
                timerSelecao.Enabled = false;
            }
            int r = Convert.ToInt32(Fitness.First().DNA[0],2);
            int g = Convert.ToInt32(Fitness.First().DNA[1],2);
            int b = Convert.ToInt32(Fitness.First().DNA[2],2);
            if((CorModelo.BackColor.R == r && CorModelo.BackColor.G == g && CorModelo.BackColor.B == b) || geracao >= int.Parse(MaxGeracoes.Text)) {
                timerSelecao.Enabled = false;
                auto = false;
                CarregaMelhoresPioresIndividuosPopulacao();
                this.BackColor = Color.White;
                labelGeracao.Text = "Geração: " + geracao;
            }
        }
        private void Acao_GeraNovaGeracao(object sender,EventArgs e) {
            if(Populacao.Count == 0 || Populacao.Count != populacaoini) {
                GeraPopulacaoAleatoria();
            } else {
                timerSelecao.Enabled = !timerSelecao.Enabled;
            }
            timerSelecao.Enabled = true;
        }
        private void backgroundWorker1_DoWork(object sender,DoWorkEventArgs e) {
            //carregamento da representação grafica
            Bitmap image = new Bitmap(pictureBox1.Height,pictureBox1.Width);
            Graphics gra = Graphics.FromImage(image);
            int a = 0;
            for(int y = 0; y <= pictureBox1.Height; y += 10) {
                for(int x = 0; x <= pictureBox1.Width; x += 10) {
                    try {
                        Brush brus = new SolidBrush(Color.FromArgb(Convert.ToInt32(Fitness[a].DNA[0],2),Convert.ToInt32(Fitness[a].DNA[1],2),Convert.ToInt32(Fitness[a].DNA[2],2)));
                        gra.FillRectangle(brus,x,y,10,10);
                    } catch {
                        break;
                    }

                    a++;
                    if(a >= Fitness.Count)
                        break;
                }
            }
            pictureBox1.Image = image;
        }
        private void CarregaPopulacaoTela() {
            //carregamento da representação grafica
            Bitmap image = new Bitmap(pictureBox1.Height,pictureBox1.Width);
            Graphics gra = Graphics.FromImage(image);
            int a = 0;
            for(int y = 0; y <= pictureBox1.Height; y += 10) {
                for(int x = 0; x <= pictureBox1.Width; x += 10) {
                    try {
                        Brush brus = new SolidBrush(Color.FromArgb(Convert.ToInt32(Populacao[a].DNA[0],2),Convert.ToInt32(Populacao[a].DNA[1],2),Convert.ToInt32(Populacao[a].DNA[2],2)));
                        gra.FillRectangle(brus,x,y,10,10);
                    } catch {
                        break;
                    }

                    a++;

                    if(a >= Populacao.Count)
                        break;
                }
            }
            pictureBox1.Image = image;
        }
        private void Panel_Load(object sender,EventArgs e) {
            populacaoini = 1024;
            GeraPopulacaoAleatoria();
            CarregaPopulacaoTela();
        }
        private void InputQuantidadePopulacao_TextChanged(object sender,EventArgs e) {
            if(InputQuantidadePopulacao.Text != null) {
                try {
                    //pega tamanho da população definida
                    populacaoini = Int32.Parse(InputQuantidadePopulacao.Text);
                    GeraPopulacaoAleatoria();
                    CarregaPopulacaoTela();
                } catch {

                }
            }
        }
        private void GeraPopulacaoAleatoria() {
            if(Populacao.Count > populacaoini) {
                Populacao = new List<Cor>();
            }
            //gera população inicial se não gerada
            while(Populacao.Count != populacaoini) {
                Cor cor = new Cor();

                int R = rand.Next(0,255);
                int G = rand.Next(0,255);
                int B = rand.Next(0,255);

                cor.CarregaDNA(R,G,B);

                Populacao.Add(cor);
            }
        }

        private void btnAteMatchMax_Click(object sender,EventArgs e) {
            auto = true;
            paint = CB_Paint.Checked;
            Acao_GeraNovaGeracao(sender,e);
        }
    }
}
