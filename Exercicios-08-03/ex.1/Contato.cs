namespace GuTheus Schiarella
{
    class Contato
    {
        public string nome;
        public string telefone;
        public string email;
    
        public Contato(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
    
        public override string ToString()
        {
            return $"Nome: {nome}\nTelefone: {telefone}\nEmail: {email}\n";
        }
    }
}