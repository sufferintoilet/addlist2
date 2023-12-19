internal class Program
{
    private static void Main(string[] args)
    {
        int sumList = 0;
        int[] myList = {1,2,3,4,5,6,7,8,9,10};
        Console.WriteLine("summmary");
        for (int i = 0; i <= myList.Length-1; i++) 
        {
            sumList += myList[i]; 
        }
        Console.WriteLine(sumList);
}       


}
