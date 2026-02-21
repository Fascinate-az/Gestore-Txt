namespace AppFile;

public static class App
{

    public static void Start()
    {
        App.InputMenu();
    }
    public static void InputMenu()
    {
        
        while (true)
        {
            Msg.Menu();
            (int scelta, bool isValid,string _) input = GestioneInput.InputTryParse();
            App.Switch(input.scelta);
            
            
        }
        
    }

    public static void Switch(int input)
    {
        switch (input)
        {
           case 1:
               Read.MainRead();//finito
               break;
           case 2://FINITO
               Write.MainWrite();
               break;
           case 3:
               Console.WriteLine("Qui ti mostro l'elenco dei file"); // CREARE QUALCOSA PER POTER INTERAGIRE CON I FILE
               DirectoryManager.PathMain();
               break;
           case 4:
               Delete.DeleteMain(); //finito
               break;
           case 5: //FINITA
               Exit.CloseApp(); 
               break;
           default:
               Msg.TryParseError();
               break;
        }
    }


    public static class GestioneInput
    {
        public static (int,bool,string) InputTryParse()
        {
            string valoreIngresso;
            bool isValid = int.TryParse(valoreIngresso= Console.ReadLine(), out int input);
            

            return (input, isValid,valoreIngresso);
        }
    }
}


public static class Exit
{
    public static void CloseApp()
    {
        Msg.Exit();
        Environment.Exit(0);
    }
}
