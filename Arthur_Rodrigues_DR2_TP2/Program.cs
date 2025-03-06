using System.Data;

namespace Arthur_Rodrigues_DR2_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Questão 01 ------------------------------------------------
            /*
            Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");
            string sDataDeNascimento = Console.ReadLine();

            DateTime dtNascimento = DateTime.Parse(sDataDeNascimento);

            var date = DateTime.Now;

           int idade = date.Year - dtNascimento.Year;
            if(date < dtNascimento.AddYears(idade))
            {
                idade--;
            }
            Console.WriteLine($"Você tem {idade} anos");
            */

            // Questão 02 ------------------------------------------------
            /*
            DateTime hoje = DateTime.Today;
            DateTime proximoAniversario = new DateTime(hoje.Year, dtNascimento.Month, dtNascimento.Day);

            if(proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            int diasParaAniversario = (proximoAniversario - hoje).Days;
            Console.WriteLine(diasParaAniversario);
            */

            // Questão 03 ------------------------------------------------
            /*
            Console.Write("Digite a primeira data (dd/mm/yyyy): ");
            DateTime dt1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite a outra data (dd/mm/yyyy): ");
            DateTime dt2 = DateTime.Parse(Console.ReadLine());

            DateTime proximoData = new DateTime(dt1.Year, dt2.Month, dt2.Day);

            if (proximoData < dt1)
            {
                proximoData = proximoData.AddYears(1);
            }

            TimeSpan diferenca = proximoData - dt1;
            int diasParaData = diferenca.Days;
            int mesesParaData = (proximoData.Month - dt1.Month);
            int anosParaData = (proximoData.Year - dt1.Year);

            if (mesesParaData < 0)
            {
                mesesParaData += 12;
                anosParaData--;
            }

            // Exibindo a resposta formatada
            Console.WriteLine($"Faltam {diasParaData} dias.");

            if (anosParaData > 0 || mesesParaData > 0)
            {
                Console.WriteLine($"Isso equivale a aproximadamente {anosParaData} anos e {mesesParaData} meses.");
            }
            */

            // Questão 04 ------------------------------------------------
            /*
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Nome: {nome} - Idade: {idade} - Telefone: {telefone} - E-mail: {email}");
            */

            // Questão 05 ------------------------------------------------
            /*
            Console.Write("Digite a temperatura em Celcius: ");
            double tempCelcius = double.Parse(Console.ReadLine());

            double tempFah = (tempCelcius * 9 / 5) + 32;
            double tempKelvin = tempCelcius + 273.15;

            Console.WriteLine($"Temperatura em Fahrenheit: {tempFah}°F");
            Console.WriteLine($"Temperatura em Kelvin: {tempKelvin}K");
            */

            // Questão 06 ------------------------------------------------
            /*
            Console.Write("Digite seu peso (Kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (M): ");
            double altura = double.Parse(Console.ReadLine()); //Lembrar de digitar o número double com ","

            double imc = peso / (altura * altura);
            Console.WriteLine($"IMC = {imc:F2}");

            if(imc < 18.5)
            {
                Console.WriteLine("Seu IMC indica: Magreza");
            } 
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Seu IMC indica: Peso normal");
            }
            else if(imc >= 25 && imc <= 34.9)
            {
                Console.WriteLine("Seu IMC indica: Sobrepeso");
            } else if(imc >= 35)
            {
                Console.WriteLine("Seu IMC indica: Obesidade");
            }
            else
            {
                Console.WriteLine("ERRO - Entrada Inválida");
            }
            */

            // Questão 07 ------------------------------------------------
            /*
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if(num == 0)
            {
                Console.WriteLine("O número é zero");
            }
            else if(num % 2 == 0)
            {
                Console.WriteLine("O número é par");

            }
            else
            {
                Console.WriteLine("O número é impar");
            }
            */

            // Questão 08 ------------------------------------------------
            /*
            Console.Write("Digite a sua nota: ");
            double nota = double.Parse(Console.ReadLine()); //Lembrar de digitar o número double com ","

            if (nota >= 9)
            {
                Console.WriteLine("Excelente");
            }
            else if(nota >= 8 && nota < 9)
            {
                Console.WriteLine("Bom");
            }
            else if(nota >= 6 && nota < 8)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Insuficiente");
            }
            */

            // Questão 09 ------------------------------------------------
            /*
            Console.Write("Digite o seu salário bruto: R$ ");
            double salarioBruto = double.Parse(Console.ReadLine());

            double imposto = 0;

            if (salarioBruto <= 2000)
            {
                imposto = 0;
            }
            else if (salarioBruto <= 4000)
            {
                imposto = salarioBruto * 0.075;
            }
            else if (salarioBruto <= 6000)
            {
                imposto = salarioBruto * 0.15;
            }
            else
            {
                imposto = salarioBruto * 0.225;
            }

            double salarioLiquido = salarioBruto - imposto;

            Console.WriteLine($"Salário Bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Imposto Descontado: R$ {imposto:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
            */

            // Questão 10 ------------------------------------------------
            /*
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            for(; num >= 0; num--)
            {
                Console.WriteLine(num);
            }
            */

            // Questão 11 ------------------------------------------------
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tabuada do {i}");
                for (int j = 1; j <= 10; j++)
                {
                    int resultado = i * j;
                    Console.WriteLine($"{i} * {j} = {resultado}");
                }
            }
            */

            // Questão 12 ------------------------------------------------
            /*
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);

            int chute;
            int tentativas = 0;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 99.\n");
            do
            {
                Console.Write("Digite o seu chute: ");
                chute = int.Parse(Console.ReadLine());

                if(chute > numeroAleatorio)
                {
                    Console.WriteLine(" O número secreto é MENOR! Tente novamente");
                } else if (chute < numeroAleatorio)
                {
                    Console.WriteLine("O número secreto é MAIOR! Tente novamente");
                }
                tentativas++;
            } while (chute != numeroAleatorio);

            Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio} em {tentativas} tentativa(s).");
            */
        }
    }
}
