        
namespace AppFile;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            App.Start();
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("NON HAI PERMESSI PER ACCEDERE.\nChiusura in corso");
        }
        
        catch (Exception e)
        {
            Console.WriteLine($"OPS qualcosa è andato storto : {e}");
            
        }
        
        Console.WriteLine("finito");


        


    }
}
