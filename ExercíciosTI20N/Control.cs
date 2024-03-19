using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI20N
{
    class Control
    {
        Model modelo;
        public Control()
        {
            modelo = new Model();
        }//Fim do Construtor

        public void Menu()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: \n" +
                             "0. Sair\n" +
                             "1. Exercício 01\n" +
                             "2. Exercício 02\n" +
                             "3. Exercício 03\n" +
                             "4. Exercício 04\n" +
                             "5. Exercício 05\n" +
                             "6. Exercício 06\n" +
                             "7. Exercício 07\n" +
                             "8. Exercício 08\n" +
                             "9. Exercício 09\n" +
                             "10.Exercício 10\n" +
                             "11.Exercício 11\n" +
                             "13.Exercício 13\n" +
                             "14.Exercício 14\n" +
                             "15.Exercício 15\n" +
                             "16.Exercício 16\n" +
                             "17.Exercicio 17\n" +
                             "18.Exercicio 18\n" +
                             "19.Exercicio 19\n" +
                             "20.Exercicio 20\n" +
                             "21.Exercicio 21\n" +
                             "22.Exercicio 22\n" +
                             "23.Exercicio 23\n" +
                             "24.Exercicio 24\n" +
                             "25.Exercicio 25\n" +
                             "26.Exercicio 26\n" +
                             "27.Exercicio 27\n" +
                             "28.Exercicio 28\n" +
                             "29.Exercicio 29\n" +
                             "30.Exercicio 30\n");
        }//Fim do Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                Menu();//Mostrando as Opções
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(modelo.ExercicioUm());
                        break;
                    case 2:
                        Console.WriteLine(modelo.ExercicioDois());
                        break;
                    case 3:
                        Console.WriteLine("A soma dos números entre 1 e 100 é: " + modelo.ExercicioTres());
                        break;
                    case 4:
                        Console.WriteLine("Os múltiplos de 5 entre 1 e 50 são: " + modelo.ExercicioQuatro());
                        break;
                    case 5:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioCinco(num));
                        break;
                    case 6:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioSeis(num));
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioSete(num));
                        break;
                    case 8:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioOito(num));
                        break;
                    case 9:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioNove(num));
                        break;
                    case 10:
                        Console.WriteLine("Os números primos são: ");
                        Console.WriteLine(modelo.ExercicioDez());
                        break;

                    case 11:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioOnze(num));
                        break;

                    case 13:
                        Console.WriteLine(modelo.ExercicioTreze());
                        break;

                    case 14:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioCatorze(num));
                        break;
                    case 15:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioQuinze(num));
                        break;

                    case 16:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDezesseis(num));
                        break;
                    case 17:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDezessete(num));
                        break;
                    case 18:
                        Console.WriteLine("Informe um número: ");
                        double num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo número: ");
                        double num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDezoito(num1, num2));
                        break;
                     case 19:
                        Console.WriteLine("Informe um número: ");
                        double fahrenheit = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDezenove(fahrenheit));
                        break;
                      case 20:

                        Console.WriteLine("Informe um número: ");
                        double raio = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinte(raio));
                        break;
                    case 21:
                        Console.WriteLine("Informe um número: ");
                        double quadrado = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteUm(quadrado));
                        break;
                    case 22:
                        Console.WriteLine("Informe um número: ");
                        int nun1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int nun2 = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine(modelo.ExercicioVinteDois(nun1, nun2));
                        break;
                    case 23:
                        Console.WriteLine("Informe um número: ");
                        int primeiro = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int segundo = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine(modelo.ExercicioVinteTrez(primeiro, segundo));
                        break;
                    case 24:
                        Console.WriteLine("Informe um número: ");
                        int maior = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteQuatro(maior));
                        break;
                    case 25:
                        Console.WriteLine("Informe um número: ");
                        int camada1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int camada2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteCinco(camada1, camada2));
                        break;
                    case 26:
                        Console.WriteLine("Informe seu peso: ");
                        double peso = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe sua altura: ");
                        double altura = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteSeis( peso, altura));
                        break;
                    case 27:
                        Console.WriteLine("Informe sua idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe seus meses: ");
                        int mes = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe os dias: ");
                        int dias = Convert.ToInt32(Console.ReadLine());

                     

                        Console.WriteLine(modelo.ExercicioVinteSete(idade, mes, dias ));
                        break;

                    case 28:
                        Console.WriteLine("Informe o salário: ");
                        double salario = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a venda: ");
                        double vendas = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine(modelo.ExercicioVinteOito(salario, vendas));
                        break;
                    case 29:
                        Console.WriteLine(modelo.ExercícioVinteNove());
                        break;
                    case 30:
                        Console.WriteLine(modelo.ExercicioTrinta());
                        break;


                    default:
                        Console.WriteLine("Código digitado não é valido!");
                        break;

                }//Fim da Operação
            } while (opcao != 0);
        }//Fim da Operação
    }//Fim da Classe
}//Fim do Projeto
