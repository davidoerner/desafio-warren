using System;

namespace DesafioWarrenProWay {
    internal class DesafioWarrenProWay {
        public static void Main(string[] args) {
            Menu();
        }

        public static void Menu() {
            Console.WriteLine("1 - Desafio 1");
            Console.WriteLine("2 - Desafio 2");
            Console.WriteLine("3 - Desafio 3");
            Console.WriteLine("0 - Para Sair");
            int op = int.Parse(Console.ReadLine());

            if (op == 0) {
                Environment.Exit(0);
            } else if (op == 1) {
                Console.Clear();
                WarrenDesafio1 desafio1 = new WarrenDesafio1();
                desafio1.Desafio1();
            } else if (op == 2) {
                Console.Clear();
                WarrenDesafio2 desafio2 = new WarrenDesafio2();
                desafio2.Desafio2();
            } else if (op == 3) {
                Console.Clear();
                WarrenDesafio3 desafio3 = new WarrenDesafio3();
                desafio3.Desafio3();
            } else {
                Console.Clear();
                Console.WriteLine("Opção Inválida! Tente Novamente!");
                Menu();
            }
        }
    }
}