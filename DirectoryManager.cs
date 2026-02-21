
namespace AppFile;

public class DirectoryManager
{
    public static string PathFolder() // CHIEDIAMO IL PERCORSO , VIENE CHIAMATO  DAL CHECK EXISTS PATH
    {
        Msg.PercorsoCartella();

        string percorsoCartella = Console.ReadLine();

        
        return percorsoCartella;
    }

    public static DirectoryInfo CheckExistsPath()
    {
        
        
        do
        {
            DirectoryInfo directoryInfo;
           string path = DirectoryManager.PathFolder();
            directoryInfo = new DirectoryInfo(path);
            
            if (directoryInfo.Exists) // SE TROVA LA CARTELLA ESCE DAL CICLO E VA AVANTI
            {
                return directoryInfo;
                break;
            }
           
            Msg.PercorsoErrato();
          
        } while (true);
        
        
        

    }

    public static void PathMain()
    {
        DirectoryManager.ShowFile(DirectoryManager.CheckExistsPath());//CENTRO PRINCIPALE PER GESTIRE LA RICERCA DELLE CARTELLE.
        
    }

    public static void ShowFile(DirectoryInfo directoryInfo)
    {
        directoryInfo.GetFiles().ToList();
        int counterFile = 1;

        Msg.InfoFolder(directoryInfo);//mostra numero dei file e data creazione
        Msg.Asterischi();
        foreach (FileInfo fileInfo in directoryInfo.GetFiles())
        {
            
            Console.WriteLine($"{counterFile}. {fileInfo.Name}");
            counterFile++;
        }
    }

    public static int ContaNumeroFile(DirectoryInfo directoryInfo)
    {
        return directoryInfo.GetFiles().Length;
        
    }
    
    public static string CreazionePercorsoCompleto(string percorso,string nomeFile)
    {
        
        string percorsoCompleto = @$"{percorso}\{nomeFile}";
        return percorsoCompleto;
        
    }

   

    public static List<FileInfo> ListaFile(DirectoryInfo directoryInfo)
    {
        
        List<FileInfo>listaFile = directoryInfo.GetFiles().ToList();
        return listaFile;
    }

    

    public static int GestoreSelezionaFile(DirectoryInfo directoryInfo)
    {
        int numeroFileNellaCartella = DirectoryManager.ContaNumeroFile(directoryInfo);
        
        Msg.InfoFolder(directoryInfo);
        Msg.ScegliereNumeroFile();
        
        while (true)
        {
            
            (int nrFile, bool _, string valoreIngresso) numeroFileScelto = App.GestioneInput.InputTryParse();
            if (string.IsNullOrWhiteSpace(numeroFileScelto.valoreIngresso))
            {
                App.InputMenu();
                return 0;

            }
            if (numeroFileScelto.nrFile >= 1 && numeroFileScelto.nrFile <= numeroFileNellaCartella)
            {
                
                return numeroFileScelto.nrFile;
                
            }

            Msg.TryParseError();
            
        }
    }

   
    
    
}
