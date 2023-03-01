namespace Matheus
{
  public class Gerente : Empregado{
    public Gerente(string Nome, double Salario, int Ano, int Mes, int Dia) : base(Nome, Salario, Ano, Mes, Dia) {
      this.Nome = nome;
      this.Salario = Salario;
      this.Contrato - new DateTime(Ano, Mes, Dia);
      Bonus = 0;
    }

    public double Bonus { get; set; }

    public override double Salario {
      get {
        double SalarioBase = base.Salario;
        return SalarioBase + Bonus;
      }
    }
  }
}