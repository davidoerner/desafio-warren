using System.Text;

namespace DesafioWarrenProWay {
    public class WarrenDesafio1 {
            static int Reverso(int numero) {
                string sNumero = numero.ToString();
                if (sNumero[sNumero.Length - 1] == '0')
                    return -1;
                var numeroReverso = new StringBuilder();
                for (int idx = sNumero.Length - 1; idx >= 0; idx--)
                    numeroReverso.Append(sNumero[idx]);
                return Int32.Parse(numeroReverso.ToString());
            }
            public void Desafio1() {
                {
                for (int idx = 11; idx < 1000000; idx++) {
                    int soma = idx + Reverso(idx);
                    if (soma > 1000000 || soma % 2 != 0)
                        continue;
                    Console.WriteLine(idx);
                   
                }
            }
        }
    }
}