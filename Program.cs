using LoginLinkedinRPA;

   class Program
    {
        static void Main(string[] args)
        {
        string user = " <email> "; // editar com as informações correspondentes
        string password = " <senha> ";
        
            Class1 web = new Class1(user, password);

            web.Executar();
        }
    }

