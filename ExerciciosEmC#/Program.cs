using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace ExerciciosEmC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            //Problema "retangulo"
            //fazer um programa para le as medidas da base e altura de um retangulo.
            //Em seguida mostrar o valora da área,perimetro e diagonal deste retangulo com quatro casas decimais.

            //Console.WriteLine("Digite a medida da base do retângulo:");
            //double baseRetangulo = Convert.ToDouble(Console.ReadLine(), ci);

            //Console.WriteLine("Digite a medida da altura do retângulo:");
            //double alturaRetangulo = Convert.ToDouble(Console.ReadLine(), ci);

            //double area = baseRetangulo * alturaRetangulo;
            //double perimetro = 2 * (baseRetangulo + alturaRetangulo);
            //double diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(alturaRetangulo, 2));

            //Console.WriteLine("Área: " + area.ToString("f4", ci));
            //Console.WriteLine("Perímetro: " + perimetro.ToString("f4", ci));
            //Console.WriteLine("Diagonal: " + diagonal.ToString("f4", ci));

            //Console.ReadLine();


            //Problema "idades" 
            //fazer um programa para ler o nome e a idade de duas pessoas.
            //ao final mostrar uma mensagem com os nomes e a idade media entre essas pessoas com uma casa decimal

            //string nome1, nome2;
            //int idade1, idade2;
            //double media;

            //Console.WriteLine("Digite os dados da primeira pessoa ");
            //Console.Write("NOME: ");
            //nome1 = Console.ReadLine();
            //Console.Write("IDADE: ");
            //idade1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite os dados da segunda pessoa ");
            //Console.Write("Nome: ");
            //nome2 = Console.ReadLine();
            //Console.Write("Idade: ");
            //idade2 = int.Parse(Console.ReadLine());


            //media = (idade1 + idade2) / 2.0;
            //Console.WriteLine("a idade media de " + nome1 +  " e " + nome2 + " é " + media.ToString("f1",ci)+ " anos");

            //Problema "soma" 
            //Fazer um programa para ler dois valores inteiros X e Y, e depois mostrar na tela o valor da soma destes números.

            //int x;
            //int y;
            //int soma;
            //Console.WriteLine("Digite o valor de (x): ");
            //x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor de (y): ");
            //y = int.Parse(Console.ReadLine());

            //soma = x + y;

            //Console.WriteLine("A soma dos números são: " + soma );

            //Problema "terreno" 
            //Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma 
            //casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. Em seguida,
            // o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com
            //duas casas decimais, conforme exemplo. 

            //double largura;
            //double comprimento;
            //double MetroQuadrado;
            //double area;
            //double PrecoTerreno;

            //Console.WriteLine("Digite a largura do terreno: ");
            //largura = double.Parse(Console.ReadLine(),ci);

            //Console.WriteLine("Digite o comprimento do terreno: ");
            //comprimento = double.Parse(Console.ReadLine(),ci);

            //Console.WriteLine("Digite o valor do metro quadrado: ");
            //MetroQuadrado = double.Parse(Console.ReadLine(),ci);

            // area = largura * comprimento;
            // PrecoTerreno = area * MetroQuadrado;

            //Console.WriteLine("A area do terreno é: "+area.ToString("f2",ci));
            //Console.WriteLine("O preço do terreno é: "+PrecoTerreno.ToString("f2",ci));


            //Problema "troco" 
            //Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia.
            //O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto, 
            //e o valor em dinheiro dado pelo cliente(suponha que haja dinheiro suficiente). Seu programa deve
            //mostrar o valor do troco a ser devolvido ao cliente.

            //double preco;
            //int QuantidadeProduto;
            //double DinheiroRecebido;

            //Console.WriteLine("Dgite o preço do produto: ");
            //preco = double.Parse(Console.ReadLine(),ci);

            //Console.WriteLine("Quantidade comprada: ");
            //QuantidadeProduto = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dinheiro recebido: ");
            //DinheiroRecebido = double.Parse(Console.ReadLine(),ci); 

            //preco *= QuantidadeProduto;
            //DinheiroRecebido -= preco;

            //Console.WriteLine("o total da sua compra é: " +preco.ToString("f2",ci) +"R$"+ " seu troco é: "+ DinheiroRecebido.ToString("f2",ci)+"R$");

            //Problema "circulo" 
            // Fazer um programa para ler o valor "r" do raio de um círculo, e depois mostrar o valor da área do
            //círculo com três casas decimais. A fórmula da área do círculo é a seguinte: 𝑎𝑟 = �. � . Você pode
            //usar o valor de � fornecido pela biblioteca da sua linguagem de programação, ou então, se preferir, use
            //diretamente o valor 3.14159.

            //double area;
            //double raio = 3.14159;

            //Console.WriteLine("Digite o valor do raio do circulo: ");
            //raio = double.Parse(Console.ReadLine(),ci);

            //area = Math.PI * raio * raio;

            //Console.WriteLine("o valor da area é: "+ area.ToString("f3",ci));


            //Problema "pagamento" 
            //Fazer um programa para ler o nome de um(a) funcionário(a), o valor que ele(a) recebe por hora, e a
            //quantidade de horas trabalhadas por ele(a). Ao final, mostrar o valor do pagamento do funcionário com
            //uma mensagem explicativa, conforme exemplo.

            string funcionario;
            double ValorHora;
            int horaTrabalhada;
            double soma;

            Console.WriteLine("NOme do funcionario: ");
            funcionario = Console.ReadLine();

            Console.WriteLine("Valor por Hora: ");
            ValorHora = double.Parse(Console.ReadLine(),ci);

            Console.WriteLine("Horas trabalhadas: ");
            horaTrabalhada = int.Parse(Console.ReadLine());

            soma = ValorHora * horaTrabalhada;

            Console.WriteLine("O funcionario " +funcionario + "deve receber "+ soma.ToString("f2",ci)+"R$");
        }
    }
}