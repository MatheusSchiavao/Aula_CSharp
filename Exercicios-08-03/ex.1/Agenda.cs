using System.Collections.Generic;

namespace GuTheus Schiarella
{
  class Agenda
  {
      public string nome;
      public List<Contato> contatos;
      
      public Agenda(string nome)
      {
          this.nome = nome;
          this.contatos = new List<Contato>();
      }
      
      public void AdicionarContato(string nome, string telefone, string email)
      {
          contatos.Add(new Contato(nome, telefone, email));
      }
      
      public string InformacaoContato(int indice)
      {
          return contatos[indice].ToString();
      }
      
      public string InformacaoTodosContatos()
      {
          string info = "";
          foreach (Contato c in contatos)
          {
              info += c.ToString() + "\n";
          }
          return info;
      }
  }
}
