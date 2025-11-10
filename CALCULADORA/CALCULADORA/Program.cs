

namespace Calculadora
{
    internal class Programa calculadora 
    {
        static void Main(string[] args)
    {
        Console.WriteLine("ESCOLHA SUA MATEMÁTICA!");
        Console.WriteLine(" 1 - Adição");
        Console.WriteLine(" 2 - Subtração");
        Console.WriteLine(" 3 - Multiplicação");
        Console.WriteLine(" 4 - Divisão");

        { 
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            double nume1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double nume2 = double.Parse(Console.ReadLine());

            double resul = 0; 

            switch (operacao)
            {
                case 1:
                    resul = adicao(nume1, nume2);
                    break;

                case 2:
                    resul = subtracao(nume1, nume2);
                    break;

                case 3:
                    resul = multipli(nume1, nume2);
                    break;

                case 4:
                    if (nume2 == 0)
                        Console.WriteLine("Erro: divisão por zero!");
                    else
                        resul = div(nume1, nume2);
                    break;

                case 5:
                    if (nume2 == 0)
                        Console.WriteLine("Erro: não existe resto da divisão por zero!");
                    else
                        resul = modulo(nume1, nume2);
                    break;

                default:
                    Console.WriteLine("Número não reconhecido");
                    break;
            }

            Console.WriteLine("Resultado: " + resul.ToString("F1")); 
            Console.ReadLine();
        }

        // Métodos agora usam double para permitir resultados decimais
        public static double adicao(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double subtracao(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double multipli(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double div(double num1, double num2)
        {
            return num1 / num2; // divisão normal
        }

        public static double modulo(double num1, double num2)
        {
            return num1 % num2; // resto da divisão
        }
    }
}