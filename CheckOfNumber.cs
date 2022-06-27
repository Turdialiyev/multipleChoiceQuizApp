public class CheckOfNumber
{
    private const string error = "Sorry did not find that your sarah.\nPleas  try again. Note order of sarah is from 1 to 114";
    private const string stopOrContounue = "If you are going to exit, you ccould press stop\n If you are going to contounue, you ccould press countounue ";
    public static void Check(int num)
    {            
        if( (num < 1)  || (num > 114) )
        {
            Console.WriteLine("Please enter from 1 to 114");      
        }
        else
        {
            Task.Run(() => 
            {
               MusicDowmloadQuron.Download(num);
            });
        }
    }  
}