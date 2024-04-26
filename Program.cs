namespace Abstrata;

class Program
{
	static void Main(string[] args)
	{
		ContaPoupanca poupanca = new ContaPoupanca();
		
		poupanca.numeroDaConta = 1000;
		poupanca.titularDaConta = "zeh da manga";
		poupanca.Deposito(20000.00);
	}
}
