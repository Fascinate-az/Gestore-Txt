namespace AppFile;

public class Write
{
    public static void MainWrite() // punto di controllo del write
    {
        string percorso = DirectoryManager.CheckExistsPath().FullName; //prendiamo il percorso della cartella
        string percorsoCompleto;
        
        while (true) // chiediamo il nome che si vuole dare al file, se esiste il while continua a chiedere un nuovo nome.
        {
            string nomeFile = Write.NomeFileTxt();
             percorsoCompleto = DirectoryManager.CreazionePercorsoCompleto(percorso, nomeFile);
            
            if (File.Exists(percorsoCompleto))
            {
                Msg.NomeFileGiaInUso();
            }
            else if (string.IsNullOrWhiteSpace(nomeFile))
            {
                Msg.NomeFileEmpty();
            }
            else
            {
                Write.CreaFileTxt(percorsoCompleto);
                
                break;
            }
            
        }
        Write.MenuWrite(percorsoCompleto);
        
        

    }

    

    public static string NomeFileTxt() // CHIEDIAMO IL NOME CHE SI VUOLE DARE AL FILE,E CHIEDIAMO SE VUOLE USCIRE
    {
        
        Msg.NomeFileDaCreare();
        string nomeFile = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nomeFile))
        {
            Console.WriteLine("il nome non può essere vuoto");
            nomeFile = Console.ReadLine();
        }
        
        return $"{nomeFile}.txt";
        
    }
    

    public static void CreaFileTxt(string percorso)
    {
        
        File.Create(percorso).Close();
        Msg.FileCreato();
        Msg.Asterischi();
    }

    public static void ScriviTesto(string percorsocompleto)
    {
        using StreamWriter scrivi = new StreamWriter(percorsocompleto);
        Msg.Scrivi();
        while (true)
        {
            string messaggioDascrivere = Console.ReadLine();
            scrivi.WriteLine(messaggioDascrivere);

            if (string.IsNullOrWhiteSpace(messaggioDascrivere))
            {
                break;
            }
            
        }
        
        Msg.TestoSalvato();
        
    }

    
        
    

    public static void MenuWrite(string percorsoCompleto)
    {
        bool continua = true;
        while (continua)
        {
            Msg.SceltaMenuWrite();
            int scelta = App.GestioneInput.InputTryParse().Item1;
            switch (scelta) {
                case 1:
                    Write.ScriviTesto(percorsoCompleto);
                    continua = false;
                    break;
                case 2:
                    App.InputMenu();
                    continua = false;
                    break;
                case 3:
                    Exit.CloseApp();
                    continua = false;
                    break;
                default:
                    Msg.TryParseError();
                    break;
                
            }
        }
        
    }
    
}


