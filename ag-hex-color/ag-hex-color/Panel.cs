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
        List<Cor> cores = new List<Cor>();
        List<Cor> Saude = new List<Cor>();
        int populacaoini = 0;
        int geracao;
        bool auto = false;
        Random rand = new Random();

        public Panel() {
            InitializeComponent();
        }

        private void SelecaoDeCor(object sender,EventArgs e) {
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            CMR.Text = "R: "+c.R.ToString();
            CMG.Text = "G: "+c.G.ToString();
            CMB.Text = "B: "+c.B.ToString();
            CorModelo.BackColor = c;
        }

        private void selecaoNatural() {
            int cutOff = Int32.Parse(CutOff.Text);
            if(cutOff == 0) {
                cutOff = 5;
                CutOff.Text = "5";
            }
            Saude = new List<Cor>();

            for(int i = 0; i < cores.Count; i++) {
                
                int r = Convert.ToInt32(cores[i].DNA[0],2);
                int g = Convert.ToInt32(cores[i].DNA[1],2);
                int b = Convert.ToInt32(cores[i].DNA[2],2);
                //definindo a saude da população em comparação com a cor modelo
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

                cores[i].Saude = r + g + b;

                Saude.Add(cores[i]);
            }
            //ordenado a população de mais adequados a menos adequados
            Saude.Sort(delegate (Cor a1,Cor a2) {
                return a1.Saude.CompareTo(a2.Saude);
            });

            //removendo parte da população, permanecendo somente os melhores na população
            for(int i = Saude.Count / cutOff; i < Saude.Count; i++) {
                cores.Remove(Saude[i]);
            }
        }

        private void getbest() {
            int r = Convert.ToInt32(Saude[0].DNA[0],2);
            int g = Convert.ToInt32(Saude[0].DNA[1],2);
            int b = Convert.ToInt32(Saude[0].DNA[2],2);
            BFR.Text = "R: " + r.ToString();
            BFG.Text = "G: " + g.ToString();
            BFB.Text = "B: " + b.ToString();
            BF1.BackColor = Color.FromArgb(r,g,b);


            r = Convert.ToInt32(Saude[1].DNA[0],2);
            g = Convert.ToInt32(Saude[1].DNA[1],2);
            b = Convert.ToInt32(Saude[1].DNA[2],2);

            BF2.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Saude[2].DNA[0],2);
            g = Convert.ToInt32(Saude[2].DNA[1],2);
            b = Convert.ToInt32(Saude[2].DNA[2],2);

            BF3.BackColor = Color.FromArgb(r,g,b);


            r = Convert.ToInt32(Saude[3].DNA[0],2);
            g = Convert.ToInt32(Saude[3].DNA[1],2);
            b = Convert.ToInt32(Saude[3].DNA[2],2);

            BF4.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Saude[4].DNA[0],2);
            g = Convert.ToInt32(Saude[4].DNA[1],2);
            b = Convert.ToInt32(Saude[4].DNA[2],2);

            BF5.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Saude[Saude.Count - 1].DNA[0],2);
            g = Convert.ToInt32(Saude[Saude.Count - 1].DNA[1],2);
            b = Convert.ToInt32(Saude[Saude.Count - 1].DNA[2],2);

            WF1.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Saude[Saude.Count - 2].DNA[0],2);
            g = Convert.ToInt32(Saude[Saude.Count - 2].DNA[1],2);
            b = Convert.ToInt32(Saude[Saude.Count - 2].DNA[2],2);

            WF2.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Saude[Saude.Count - 3].DNA[0],2);
            g = Convert.ToInt32(Saude[Saude.Count - 3].DNA[1],2);
            b = Convert.ToInt32(Saude[Saude.Count - 3].DNA[2],2);

            WF3.BackColor = Color.FromArgb(r,g,b);

            r = Convert.ToInt32(Saude[Saude.Count - 4].DNA[0],2);
            g = Convert.ToInt32(Saude[Saude.Count - 4].DNA[1],2);
            b = Convert.ToInt32(Saude[Saude.Count - 4].DNA[2],2);

            WF4.BackColor = Color.FromArgb(r,g,b);

            if(!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void cruzamento() {
            //com somente uma parte da população inicial, selecionando os melhores, agora vamos gerar o resto da população a partir desses melhores
            while(cores.Count != populacaoini) {
                
                int index1 = rand.Next(0,cores.Count - 1);
                int index2 = rand.Next(0,cores.Count - 1);

                Cor animal = cores[index1].cruzar(cores[index2]);
                cores.Add(animal);
            }
        }

        private void timerSelecao_Tick(object sender,EventArgs e) {
            geracao++;

            this.BackColor = Color.Gray;
            selecaoNatural();
            cruzamento();
            getbest();
            this.BackColor = Color.White;

            labelGeracao.Text = "Geração: " + geracao;

            if(!auto) {
                timerSelecao.Enabled = false;
            }

        }

        private void ButtonStart_Click(object sender,EventArgs e) {
            populacaoini = Int32.Parse(textBox2.Text);

            if(cores.Count == 0) {
                while(cores.Count != populacaoini) {
                    Cor cor = new Cor();

                    int R = rand.Next(0,255);
                    int G = rand.Next(0,255);
                    int B = rand.Next(0,255);

                    cor.Randomizar(R,G,B);

                    cores.Add(cor);
                }
            } else {
                timerSelecao.Enabled = !timerSelecao.Enabled;
            }

            timerSelecao.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender,DoWorkEventArgs e) {
            Bitmap image = new Bitmap(pictureBox1.Height,pictureBox1.Width);
            Graphics gra = Graphics.FromImage(image);
            int a = 0;

            for(int y = 0; y <= pictureBox1.Height; y += 10) {
                for(int x = 0; x <= pictureBox1.Width; x += 10) {
                    try {
                        Brush brus = new SolidBrush(Color.FromArgb(Convert.ToInt32(Saude[a].DNA[0],2),Convert.ToInt32(Saude[a].DNA[1],2),Convert.ToInt32(Saude[a].DNA[2],2)));
                        gra.FillRectangle(brus,x,y,10,10);
                    } catch {
                        break;
                    }

                    a++;

                    if(a >= Saude.Count)
                        break;
                }
            }
            pictureBox1.Image = image;
        }

        private void Panel_Load(object sender,EventArgs e) {

        }
    }
}
