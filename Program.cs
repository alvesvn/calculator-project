namespace calculator_project;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("## PROGRAMA DA CALCULADORA ##");

        Calcular calc = new Calcular();
        Options opt = new Options();


        int opcao = 0;
        do
        {
            opcao = opt.Menu();
            if (opcao == 0){
            Console.WriteLine("Até a próxima!");
            break;
            }

            double n1 = opt.PedirNumero();
            double n2 = opt.PedirNumero();


            double res = 0;

            switch (opcao)
            {
                case 1:
                    res = calc.Somar(n1, n2);
                    break;

                case 2:
                    res = calc.Subtrair(n1, n2);
                    break;

                case 3:
                    res = calc.Multiplicar(n1, n2);
                    break;

                case 4:
                    res = calc.Dividir(n1, n2);
                    break;
            }

            Console.Write("== " + res);


        } while (opcao != 0);

    }


}
