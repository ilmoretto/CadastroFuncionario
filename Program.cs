Funcionario fun = new Funcionario();

Console.WriteLine("=====|CADASTRO DE FUNCIONÁRIOS|=====");
Console.WriteLine("Informe o nome: ");
fun._Nome = Console.ReadLine();

Console.WriteLine("Informe o CPF: ");
fun.setCPF(Console.ReadLine());


Console.WriteLine("Informe a data de nascimento: ");
fun.setDataNas(Convert.ToDateTime(Console.ReadLine()));

Console.WriteLine("Informe o e-mail: ");
fun._Email = Console.ReadLine();

Console.WriteLine("Informe a data de admissão: ");
fun.setDataAdmissao(Convert.ToDateTime(Console.ReadLine()));

Console.WriteLine("Informe o saláio: ");
fun.setSalario(Convert.ToDouble(Console.ReadLine()));