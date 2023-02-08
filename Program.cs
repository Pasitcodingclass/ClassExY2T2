using System;
class Program{
    public static void Main(string[]args){
        int Inputn, Inputr;
        Inputn = int.Parse(Console.ReadLine());
        Inputr = int.Parse(Console.ReadLine());
        int sum = Cal(Inputn)/Cal(Inputn-Inputr);
        Console.WriteLine(sum);
    }
    public static int Cal(int Inputn){
        
        if(Inputn > 1){
            return Inputn * Cal(Inputn-1);
        }
        else{
            return 1;
        }
    }
    
}
