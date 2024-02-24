class Options 
{
    
    public int Menu()
    {
        Console.WriteLine("\n\nO que deseja fazer?");
        Console.WriteLine("1. Somar");
        Console.WriteLine("2. Subtrair");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("0. Sair");
        int opcao = Convert.ToInt32(Console.ReadLine());

        return opcao;
    }


    public double PedirNumero()
    {
        Console.Write("\n>> ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        return n1;
    }
}