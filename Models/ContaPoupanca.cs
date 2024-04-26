public class ContaPoupanca : ContaBancaria
{
	public override void AtualizaSaldo(int dias )
	{
		if (dias == 30)
		{
			Console.WriteLine("O saldo foi incrementado em 0.5%");
		}
	}
}