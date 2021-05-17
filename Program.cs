using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<Pessoa> pessoas = new LinkedList<Pessoa>();

            string opcaoEscolhida = opcoes();

            while (opcaoEscolhida != "X")
            {
                switch (opcaoEscolhida)
                {
                    case "1": //Inserir
                        Console.WriteLine();
                        Console.WriteLine("Digite o nome");
                        var nome = Console.ReadLine().ToUpper();

                        Console.WriteLine();
                        Console.WriteLine("Digite a idade");
                        var idade = Console.ReadLine();

                        pessoas.AddLast(new Pessoa(nome, idade));


                        break;
                    case "2": //Listar
                        foreach (var pessoa in pessoas)
                        {
                            Console.WriteLine($"Nome:{pessoa.Nome}\nIdade: {pessoa.Idade}\n ");
                        }
                        break;
                    case "3": // Pesquisar
                        Console.WriteLine();
                        Console.WriteLine("Digite o Nome");
                        var pesquisaNome = Console.ReadLine().ToUpper();

                        Console.WriteLine();
                        Console.WriteLine("Digite o Nome");
                        var pesquisaIdade = Console.ReadLine().ToUpper();

                        var pessoaPesquisada = new Pessoa (pesquisaNome, pesquisaIdade);

                        if(pessoas.Contains(pessoaPesquisada) == true)
                        {
                            Console.WriteLine($"Nome:{pessoaPesquisada.Nome}, Idade:{pessoaPesquisada.Idade} Anos ");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa nao encontrada");
                        }
                      
                        break;
                    case "4": // Adicionar anterior

                        Console.WriteLine();
                        Console.WriteLine("Digite o Nome que sera subsequente");
                        var pesquisaSubsequente = Console.ReadLine().ToUpper();
                        Console.WriteLine("Digite a idade");
                        var pesquisaidadeSubsequente = Console.ReadLine().ToUpper();
                        var pesquisapessoaSubsequente = new Pessoa(pesquisaSubsequente, pesquisaidadeSubsequente);
                        var pessoaSubsequente = pessoas.Find(pesquisapessoaSubsequente);

                        Console.WriteLine();
                        Console.WriteLine("Digite o Nome que sera anterior");
                        var adcionarNomeAnterior = Console.ReadLine().ToUpper();
                        Console.WriteLine("Digite a idade ");
                        var adcionarIdadeAnterior = Console.ReadLine().ToUpper();
                        var pessoaAnterior = new Pessoa(adcionarNomeAnterior, adcionarIdadeAnterior);
                        pessoas.AddBefore(pessoaSubsequente, pessoaAnterior);

                        break;
                    case "5"://Adicionar subsequente

                        Console.WriteLine();
                        Console.WriteLine("Digite o Nome que sera anterior");
                        var pesquisaAnteriorr = Console.ReadLine().ToUpper();
                        Console.WriteLine("Digite a idade");
                        var pesquisaidadeanterior = Console.ReadLine().ToUpper();
                        var pesquisaPessoaAnterior = new Pessoa(pesquisaAnteriorr, pesquisaidadeanterior);
                        var pessoaAnteriorr = pessoas.Find(pesquisaPessoaAnterior);

                        Console.WriteLine();
                        Console.WriteLine("Digite o Nome que sera Subsequente");
                        var adcionarNomeSubsequente = Console.ReadLine().ToUpper();
                        Console.WriteLine("Digite a idade ");
                        var adcionarIdadeSubsequente = Console.ReadLine().ToUpper();
                        var pessoaSubsequentee = new Pessoa(adcionarNomeSubsequente, adcionarIdadeSubsequente);
                        pessoas.AddAfter(pessoaAnteriorr, pessoaSubsequentee);

                        break;
                    case "6":
                        Console.WriteLine();
                        Console.WriteLine("1- Remover a primeira pessoa");
                        Console.WriteLine("2- Remover a ultima pessoa");
                        Console.WriteLine("3- Pesquisar e remover pessoa");
                        Console.WriteLine("4- Limpar lista de pessoas");
                        var opcaoRemocao = Console.ReadLine();

                        switch (opcaoRemocao)
                        {
                            case "1":
                                pessoas.RemoveFirst();
                                break;
                            case "2":
                                pessoas.RemoveLast();
                                break;
                            case "3":

                                Console.WriteLine();
                                Console.WriteLine("Digite o nome para remover");
                                var nomeParaRemover = Console.ReadLine().ToUpper();

                                Console.WriteLine();
                                Console.WriteLine("Digite a idade");
                                var idadeParaRemover = Console.ReadLine();

                                var pessoaParaRemover = new Pessoa(nomeParaRemover, idadeParaRemover);

                                pessoas.Remove(pessoaParaRemover);
                                break;
                            case "4":
                                pessoas.Clear();
                                break;

                            default:
                                Console.WriteLine("Comando Invalido");
                                break;
                        }



                        break;
                    default:
                        Console.WriteLine("Comando Invalido");
                        break;
                }
                opcaoEscolhida = opcoes();
            }



        }

        private static string opcoes()
        {
            Console.WriteLine();
            Console.WriteLine("1- Inserir pessoa");
            Console.WriteLine("2- Listar pessoas");
            Console.WriteLine("3- Pesquisar pessoa");
            Console.WriteLine("4- Adicionar pessoa anterior");
            Console.WriteLine("5- Adicionar pessoa subsequente");
            Console.WriteLine("6- Remover Pessoa");
            Console.WriteLine("X- Sair");
            var opcaoEscolhida = Console.ReadLine().ToUpper();
            return opcaoEscolhida;
        }
    }
}
