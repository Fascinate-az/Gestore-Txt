namespace AppFile;

public class Msg
{
    public static void Menu()
    {
        Console.WriteLine("Seleziona una delle seguenti opzioni:\n1. Apri un file\n2. Scrivi su un file\n3. Visualizza elenco file\n4. Elimina un file\n5. Esci");

    }

    public static void TryParseError()
    {
        Console.WriteLine("Errore! inserire un valore numerico, tra quelli elencati");
        Console.WriteLine("*****************************************************");
    }
    

    public static void Exit()
    {
        Console.WriteLine("Chiusura in corso .....");
    }

    public static void PercorsoCartella()
    {
        Console.WriteLine("Inserire il percorso della cartella");
    }

    public static void PercorsoErrato()
    {
        Console.WriteLine("Il percorso inserito è errato, si prega di ricontrollare.");
    }
    
    public static void InfoFolder(DirectoryInfo directoryInfo)
    {
        if (directoryInfo.GetFiles().Length == 1)
        {
            Console.WriteLine($"La cartella contiene {directoryInfo.GetFiles().Length} elemento ,è stata creata il {directoryInfo.CreationTime} ");
        }
        else
        {
            Console.WriteLine($"La cartella contiene {directoryInfo.GetFiles().Length} elementi ,è stata creata il {directoryInfo.CreationTime} ");
        }
        
    }

    public static void Asterischi()
    {
        Console.WriteLine("*****************************************************");
        Console.WriteLine(" ");
    }

    public static void NomeFileDaCreare()
    {
        Console.WriteLine("Inserire il nome da dare al file txt");
    }

    public static void NomeFileGiaInUso()
    {
        Console.WriteLine("Attenzione esiste gia un file con questo nome, scegliere un altro nome.");
    }
    
    public static void Scrivi()
    {
        Console.WriteLine("Digitare il contenuto da salvare:\nLasciare il campo vuoto per terminare.");
    }

    public static void FileCreato()
    {
        Console.WriteLine("file creato");
        
    }

    public static void SceltaMenuWrite()
    {
        Console.WriteLine("1.Per digitare un testo\n2.Per tornare ad menu principale\n3.Per uscire.");
    }

    public static void TestoSalvato()
    {
        Console.WriteLine("Testo salvato.");
    }

    public static void NomeFileEmpty()
    {
        Console.WriteLine("ERRORE il nome del file non può essere vuoto.");
    }

    public static void ScegliereNumeroFile()
    {
        Console.WriteLine("Scegliere il file,o lasciare il campo vuoto per tornare al menu principale.");
    }

    public static void ContenutoFile(string pathDaAprire)// pathDaAprire è il nome del file scelto da aprire, si ottiene dalla lista dei file -1
    {
        Console.WriteLine($"il file {pathDaAprire} contiene :");
    }

    public static void AvvisoCheIlFileVerraEliminato(string nomeFile)
    {
        Console.WriteLine($"ATTENZIONE IL FILE SELEZIONATO : {nomeFile} VERRà ELIMINATO,PREMERE 1 PER CONFERMARE,2 PER TORNARE ALLA LISTA DEI FILE ");
    }

    public static void FileEliminato()
    {
        Console.WriteLine("File eliminato con successo.");
        Msg.PerTornareAlMenuInzialePremere();
        
    }

    public static void PerTornareAlMenuInzialePremere()
    {
        Console.WriteLine("Per continuare e tornare al menu iniziale premere un tasto qualsiasi");
        Console.ReadKey();
    }
   
}
