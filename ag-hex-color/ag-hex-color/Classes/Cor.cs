using System;
using System.Collections.Generic;
namespace Genetic.Classes {
    public class Cor {
        public List<string> DNA = new List<string>();
        public int Fitness = 255;
        private Random rand = new Random();
        /// <summary>
        /// Transforma o inteiro para um Byte, o Cromossomo
        /// </summary>
        /// <param name="i">Valor de representação entre 0 e 255</param>
        /// <returns>Cromossomo</returns>
        public string TransformToBinary(int i) {
            string binary = Convert.ToString(i,2);
            binary = binary.PadLeft(8, '0');
            Console.WriteLine(binary);
            return binary;
        }
        /// <summary>
        /// Faz o crossover do DNA da Cor atual e outra.
        /// </summary>
        /// <param name="MAE">Cor com que a cor atual será combinada</param>
        /// <returns>Cor filha</returns>
        public Cor crossover(Cor MAE) {
            //chance de mutação fixa
            int mutationChance = 1;
            List<string> DNAPAI = DNA;
            List<string> DNAMAE = MAE.DNA;
            Cor FILHO = new Cor();
            string cromossomo = "";
            for(int I = 0; I < 3; I++) {//para cada cromossomo no DNA
                cromossomo = "";
                //contador para posição adicionada do cromossomo
                int count = 0;
                //identificado a partição real do cromossomo
                int crossOver = DNAPAI[I].Length / 2;
                //carregando primeira parte do cromossomo do produto usando cromossomo de PAI com chance de mutação
                for(int i = 0; i < crossOver && i <= 8; i++) {
                    int mutation = rand.Next(0,100);
                    if(mutation <= mutationChance) {
                        //mutação sobre parte PAI do cromossomo produto
                        if(DNAPAI[I][i].Equals('0')) {
                            cromossomo += '1';
                        } else {
                            cromossomo += '0';
                        }
                    } else {
                        if(i < DNAPAI[I].Length) {
                            cromossomo += DNAPAI[I][i];
                        }
                    }
                    count = i;
                }
                //carregando segunda parte do cromossomo do produto usando cromossomo de MAE com chance de mutação
                for(int i = count; i < DNAMAE[I].Length - 1 && i <= 8; i++) {
                    int mutation = rand.Next(0,100);
                    if(mutation <= mutationChance) {
                        //mutação sobre parte MAE do cromossomo produto
                        if(DNAMAE[I][i].Equals('0')) {
                            cromossomo += '1';
                        } else {
                            cromossomo += '0';
                        }
                    } else {
                        if(i < DNAMAE[I].Length) {
                            cromossomo += DNAMAE[I][i];
                        }
                    }
                }
                FILHO.DNA.Add(cromossomo);
            }
            return FILHO;
        }
        /// <summary>
        /// Gera os cromossomos apartir dos valores passados
        /// </summary>
        /// <param name="R">Cromossomo referente a parte vermelha do RGB e do DNA</param>
        /// <param name="G">Cromossomo referente a parte verde do RGB e do DNA</param>
        /// <param name="B">Cromossomo referente a parte azul do RGB e do DNA</param>
        public void CarregaDNA(int R,int G,int B) {
            DNA = new List<string>();
            DNA.Add(TransformToBinary(R));
            DNA.Add(TransformToBinary(G));
            DNA.Add(TransformToBinary(B));
        }
    }
}
