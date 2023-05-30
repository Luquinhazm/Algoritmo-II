class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Carro c1 = new Carro();

        Carro[] carros = new Carro[100];

        int posicao = 0;
        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("Bem Vindo. Escolha a opção desejada: ");
            Console.WriteLine("1. Novo");
            Console.WriteLine("2. Listar Carros");
            Console.WriteLine("3. Remover Carro");
            Console.WriteLine("4. Entrada de Carro");
            Console.WriteLine("5. Saída de Carro");
            Console.WriteLine("0. Sair");

            opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sua opção foi {opcao} ");

            switch (opcao)
            {
                case 1:
                    Carro carro = new Carro();
                    Console.WriteLine("Digite a marca do carro");
                    carro.Marca = Console.ReadLine();

                    Console.WriteLine("Digite o modelo do carro");
                    carro.Modelo = Console.ReadLine();

                    Console.WriteLine("Digite o ano do carro");
                    carro.Ano = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a quantidade de carro");
                    carro.Quantidade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o preço do carro");
                    carro.Preco = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite o codigo do carro");
                    carro.Codigo = Convert.ToInt32(Console.ReadLine());

                    carros[posicao] = carro;
                    Console.WriteLine("Carro cadastrado com sucesso!!!");

                    posicao++;
                    break;

                case 2:
                    for (int cont = 0; cont < posicao; cont++)
                    {
                        Console.WriteLine($"Existe {carros[cont].Quantidade} {carros[cont].Marca} {carros[cont].Modelo} do Ano {carros[cont].Ano} com o preço de {carros[cont].Preco} no estoque. ");
                    }
                    break;
                case 3:
                    Console.WriteLine("Informe o codigo do carro");
                    int cod3 = Convert.ToInt32(Console.ReadLine());

                    int posicaoremover = -1;
                    for (int cont = 0; cont < posicao; cont++)
                    {
                        if (carros[cont].Codigo == cod3)
                        {
                            posicaoremover = cont;
                            break;
                        }
                    }

                    if (posicaoremover == (posicao - 1))
                    {
                        carros[posicao - 1] = null;
                        posicao--;
                        Console.WriteLine("Carro removido com sucesso");
                    }
                    else
                    {
                        for (int pos = posicaoremover + 1; pos < posicao; pos++)
                        {
                            carros[pos - 1] = carros[pos];
                        }
                        carros[posicao - 1] = null;
                        posicao--;
                    }

                    break;

                case 4:
                    Console.WriteLine("Informe o codigo do carro");
                    int cod = Convert.ToInt32(Console.ReadLine());

                    for (int cont = 0; cont < posicao; cont++)
                    {
                        if (carros[cont].Codigo == cod)
                        {
                            Console.WriteLine("informe a quantidade que deseja adicionar");
                            int novaQuantidade = Convert.ToInt32(Console.ReadLine());
                            carros[cont].Quantidade = carros[cont].Quantidade + novaQuantidade;
                        }
                    }

                    break;
                case 5:
                    Console.WriteLine("Informe o codigo do carro");
                    int cod2 = Convert.ToInt32(Console.ReadLine());

                    for (int cont = 0; cont < posicao; cont++)
                    {
                        if (carros[cont].Codigo == cod2)
                        {
                            Console.WriteLine("informe a quantidade que deseja remover");
                            int novaQuantidade = Convert.ToInt32(Console.ReadLine());
                            carros[cont].Quantidade = carros[cont].Quantidade - novaQuantidade;
                        }
                    }
                    break;
            }
        }

    }
}