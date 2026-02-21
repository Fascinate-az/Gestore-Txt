namespace AppFile;

public class Read
{
    public static void MainRead()
    {
        DirectoryInfo nomePath = DirectoryManager.CheckExistsPath(); // verifica cartella
        DirectoryManager.ShowFile(nomePath); // mostriamo i file contenuti nella cartella
        int fileDaAprire = DirectoryManager.GestoreSelezionaFile(nomePath); // prendiamo il numero del file da aprire
        AperturaFile(nomePath,fileDaAprire,nomePath);//prepariamo il path completo,e leggiamo il file, prendiamo la lista dei file.
        Msg.PerTornareAlMenuInzialePremere();
    }
    
    

    public static void AperturaFile(DirectoryInfo directoryInfo, int numeroFileDaAprire, DirectoryInfo nomePath)
    {
        List<FileInfo>listFile = DirectoryManager.ListaFile(nomePath);
        string pathDaAprire = listFile[numeroFileDaAprire-1].Name;
        string costruzionePath = DirectoryManager.CreazionePercorsoCompleto(directoryInfo.FullName,pathDaAprire);
        Msg.ContenutoFile(pathDaAprire);
        Read.ReadFile(costruzionePath);
        
        
    }

    public static void ReadFile(string costruzionePath)
    {
        using StreamReader streamReader = new StreamReader(costruzionePath);
        string leggiFile = streamReader.ReadLine();
        while (leggiFile != null)
        {
            Console.WriteLine(leggiFile);
            leggiFile = streamReader.ReadLine();
        }
    }

    
}
