public abstract class ContaBancaria
{
	public int numeroDaConta = 0;
	public string titularDaConta = "";
	
	public double saldoDaConta;
	
	public void Deposito(double valor)
	{
		saldoDaConta = valor;
		Console.WriteLine($"Foi depositado R$ {valor}.");
		
	}
	
	public virtual void AtualizaSaldo(int saldo)
	{
	
	}
	
}