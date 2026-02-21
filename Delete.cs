namespace AppFile;

public class Delete
{
    public static void DeleteMain()
    {
        DirectoryInfo nomePath = DirectoryManager.CheckExistsPath(); // verifica cartella
        
        while (true)
        {
            List<FileInfo> listaFile = DirectoryManager.ListaFile(nomePath);
            DirectoryManager.ShowFile(nomePath); // mostriamo i file contenuti nella cartella
            int nrFileDaEliminare = DirectoryManager.GestoreSelezionaFile(nomePath); 
            Msg.AvvisoCheIlFileVerraEliminato(listaFile[nrFileDaEliminare - 1].Name);

            if (Delete.GestoreDelete(nrFileDaEliminare, nomePath, listaFile))
            {
                break;
            }
            
        }
        
        
    }

    public static void DeleteFile(int nrFileDaEliminare, DirectoryInfo nomePath,List<FileInfo> listaFile)
    {
        
        File.Delete(listaFile[nrFileDaEliminare - 1].FullName); // ELIMINA DEFI , 
        Msg.FileEliminato();
        
    }

    public static bool GestoreDelete(int nrFileDaEliminare, DirectoryInfo nomePath, List<FileInfo> listaFile)
    {
        while (true)
        {
            int selezione = App.GestioneInput.InputTryParse().Item1;

            if (selezione == 1)
            {
                DeleteFile(nrFileDaEliminare, nomePath,listaFile);
                return true;
            }
            else if (selezione == 2)
            {
                Console.WriteLine("Torno alla lista dei file");
                return false;
            }
            else
            {
                Msg.TryParseError();
                
            }
        }
    }
    
}
