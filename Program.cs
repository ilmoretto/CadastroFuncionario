List<Funcionario> funcionarios = new List<Funcionario>();

bool encerrarPrograma = false;
try
{
    while (!encerrarPrograma)
    {
        Console.Clear();
        Console.WriteLine("==============================");
        Console.WriteLine("     CADASTRO DE FUNCIONÁRIOS");
        Console.WriteLine("==============================");
        Console.WriteLine("1 - Novo cadastro");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("==============================");
        Console.Write("Escolha uma opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());


        switch (opcao)
        {
            case 0:
                Console.WriteLine("Encerrando programa...");
                encerrarPrograma = false;
                break;
            case 1:
                CadastrarFuncionario();
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);    
}


void CadastrarFuncionario()
{
    Funcionario fun = new Funcionario();
    string opcContinuar = "s";

    while (opcContinuar != "n")
    {
        Console.Clear();
        Console.WriteLine("=====|CADASTRO DE FUNCIONÁRIOS|=====");
        Console.WriteLine("Informe o nome: ");
        fun._Nome = Console.ReadLine();

        Console.WriteLine("Informe o CPF: ");
        fun.setCpf(Console.ReadLine());
        
        Console.WriteLine("Informe a data de nascimento: ");
        fun.setDataNas(Convert.ToDateTime(Console.ReadLine()));

        Console.WriteLine("Informe o e-mail: ");
        fun._Email = Console.ReadLine();

        Console.WriteLine("Informe a data de admissão: ");
        fun.setDataAdmissao(Convert.ToDateTime(Console.ReadLine()));

        Console.WriteLine("Informe o salário: ");
        fun.setSalario(Convert.ToDouble(Console.ReadLine())); 
        
        funcionarios.Add(fun);

        Console.Write("Deseja cadastrar um novo funcionário? (s/n):");
        opcContinuar = Console.ReadLine().ToLower().Trim();

    }
    
}
