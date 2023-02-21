using System;
using System.Linq;

namespace ting
{
  class Program
  {
    static void Main(string[] args)
    {
    //Le intro text
      Console.WriteLine("This is basiclly me messing around with C# lol"); //Intro Text
      
      //Variable comparing demo
      int x = 20;
      int y = 9;
      if (x > y)
      {
      	Console.WriteLine("Wow so cool woooooooooooooooooo");
      }
      else if (x < y)
      {
      	Console.WriteLine("dum code lol");
      }
      if (x == y)
      {
      	Console.WriteLine("Values are equal");
      }
      
      
      //Stupid thing w3schools cant allow me to do >:((
      int age = Convert.ToInt32(Console.ReadLine());
      
      //Day system to test Switches code
      int DayToday = 4;
      switch(DayToday)
      {
      	case 1:
        	Console.WriteLine("Today is Monday lol");
            break;
        case 2:
        	Console.WriteLine("Today is Tuesday lol");
            break;
        case 3:
        	Console.WriteLine("Today is Wednesday lol");
            break;
        case 4:
        	Console.WriteLine("Today is Thrusday lol");
            break;
        case 5:
        	Console.WriteLine("Today is Friday lol");
            break;
        default:
        	Console.WriteLine("Today is today");
            break;
      }
      
      //Ibcrease number
      int frik = 0;
      while(frik < 5)
      {
      	Console.WriteLine(frik);
        frik += 1;
      }
      
      //Kill man script
      bool dead = false;
      if (dead == true)
      {
      	Console.WriteLine("Man has died");
      }
      else{
      	Console.WriteLine("Man somehow is alive sad");
      }
      
      //Lives system
      int score = 00;
      int lives = 2;
      
      Console.WriteLine("Score: " + score);
      Console.WriteLine("Lives: " + lives);
      
      if (score >= 100 & score <= 600)
      {
      	lives += 1;
        Console.WriteLine("Lives: " + lives);
      }
      //Array Test
      Random rnd = new Random();
      int[] myNum = {10,20,30,40};
      Console.WriteLine(myNum[2]);
      
	  int Min = 0;
	  int Max = 20;
	  Random randNum = new Random();
	  int[] test2 = Enumerable
    	.Repeat(0, 5)
    	.Select(i => randNum.Next(Min, Max))
    	.ToArray();
      // suppose to be random array but failed :(((
 
 	  /*static void Inserttest()
      {
      	Console.WriteLine("Method test");
      }
      
      Inserttest();*/
      
	  double VerID = 4.2; //Lists the version of PE
      Console.WriteLine("Woahhhh cool version thing V: " + VerID);
    }
  }
}
