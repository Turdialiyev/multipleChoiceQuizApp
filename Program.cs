var b = true;

while(b) 
{
    int number;
    try
    {
        Console.WriteLine("Please enter number of Surrah");
        number = int.Parse(Console.ReadLine());
        CheckOfNumber.Check(number);

    }
    catch (System.Exception)
    {   
        Console.WriteLine("iltimos son kiriting");
        number = int.Parse(Console.ReadLine());
        CheckOfNumber.Check(number);
    }
    
}
