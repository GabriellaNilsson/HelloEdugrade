namespace HelloEdugrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            var CurrentDate = DateTime.Now;
            //DateTime CurrentDate = DateTime.Now;
            Console.WriteLine($"Hej, {name}, på {CurrentDate}");
            //Console.WriteLine($"Hej, {name}, på {CurrentDate:d}");
            // $ = formatera. När det används, som i ovan, kan man kalla på innehållet inom "måsvingar" som variabel. 
        }
        
    }
}