using System;

namespace GuTheus Schiarella
{
    class Program
  {
      static void Main(string[] args)
      {
          Console.WriteLine("Digite o nome da agenda: ");
          string nomeAgenda = Console.ReadLine();
          Agenda agenda = new Agenda(nomeAgenda);
        
          for (int i = 0; i < 3; i++)
          {
              Console.WriteLine("Digite o nome do contato: ");
              string nomeContato = Console.ReadLine();
              Console.WriteLine("Digite o telefone do contato: ");
              string telefoneContato = Console.ReadLine();
              Console.WriteLine("Digite o email do contato: ");
              string emailContato = Console.ReadLine();
              agenda.AdicionarContato(nomeContato, telefoneContato, emailContato);
          }

          Console.WriteLine("Informações da agenda:\n");
          Console.WriteLine($"Nome da agenda: {agenda.nome}\n");
          Console.WriteLine("Informações dos contatos:\n");
          Console.WriteLine(agenda.InformacaoTodosContatos());
    }
  }
}