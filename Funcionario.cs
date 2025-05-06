public class Funcionario
{
    public string _Nome;
    private string _Cpf;
    private DateTime _DataNas;
    public string _Email;
    private DateTime _DataAdmissao;
    private double _Salario;


    public void setDataNas(DateTime dataNas)
    {
        DateTime dataAtual = DateTime.Now;
        if (dataNas < dataAtual)
        {
            _DataNas = dataNas;
        }
        else
        {
            Console.WriteLine("Data inválida!");
        }
    }
    public DateTime getDataNas()
    {
        return this._DataNas;
    }
    public void setDataAdmissao(DateTime dataAdmissao)
    {
        DateTime dataAtual = DateTime.Now;
        if (dataAdmissao < dataAtual)
        {
            _DataAdmissao = dataAdmissao;
        }
        else
        {
            Console.WriteLine("Data inválida!");
        }
    }
    public DateTime getDataAdmissao()
    {
        return this._DataAdmissao;
    }

    public void setSalario(double salario)
    {
        if (salario > 0)
        {
            _Salario = salario;
        }
        else
        {
            Console.WriteLine("Entrada inválida!");
        }
    }
    public void setCPF(string cpf)
    {
        bool cpfValido = true;
        cpf = cpf.Replace(".", "").Replace("-", "");
        int somaDig1 = 0;
        int somaDig2 = 0;
        int pesoMult = 10;
        int pesoMult2 = 11;
        int pDigito = 0;
        int sDigito = 0;


        if (cpf.Length != 11)
        {
            Console.WriteLine("CPF Inválido.");
            cpfValido &= false;
            
        }
        // ===============validando o primeiro digito================== 
        if (cpfValido)
        {
            for (int i = 0; i < 9; i++)
            {
                int p = Convert.ToInt32(cpf[i].ToString());
                somaDig1 += p * pesoMult;
                pesoMult--;

            }
        }
        int restoDiv = somaDig1 % 11; // calculando o mod (resto) da soma por 11
        if (cpfValido && restoDiv < 2)
        { // se o resto da divisão for menor que dois, o dígito é igual a zero
            pDigito = 0;

        }else if (cpfValido && restoDiv > 2)
        {// se o resto da divisão for maior ou igual a dois, o dígito é igual a 11 menos o resto da divisão
            pDigito = 11 - restoDiv;
        }
        if (pDigito != Convert.ToInt32(cpf[9].ToString()))
        {// aqui é uma validação, se o segundo digito calculado for difarente do informado, cpfValido = false
            Console.WriteLine("CPF Inválido");
            cpfValido = false;
        }
        
        // ===============validando o segundo digito================== 
        if (cpfValido)
        {   // multiplicando de 11 a 2 
            for (int i = 0; i < 10; i++)
            {
                int p2 = Convert.ToInt32(cpf[i].ToString());
                somaDig2 += p2 * pesoMult2; //  essa soma recebe a multiplicação dos numeros x o peso em ordem decrescente
                pesoMult2--; // começa em 11 e tira 1 a cada iteração
            }
        }
        
        int restoDiv2 = somaDig2 % 11; // calculando o mod (resto) da soma por 11
        if (cpfValido && restoDiv2 < 2)
        {
            sDigito = 0; // se o resto da divisão for menor que dois, o dígito é igual a zero
            
        }else if (cpfValido && restoDiv2 >= 2)
        {
            sDigito = 11 - restoDiv2; // se o resto da divisão for maior ou igual a dois, o dígito é igual a 11 meno o resto
        }

        if (sDigito != Convert.ToInt32(cpf[10].ToString())) 
        {// aqui é uma validação, se o segundo digito calculado for difarente do informado, cpfValido = false
            Console.WriteLine("CPF Inválido");
            cpfValido = false;
        }

        Console.WriteLine($"\nDigito 1: {pDigito}\nDigito 2: {sDigito}");
    }

}