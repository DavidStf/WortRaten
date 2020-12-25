using System;

 namespace MyApp
 {
   class Program
   {
     static void Main(string[]args)
     {
       string geheimW= "samurai";
       string guess = "";
       int guessCount= 0;
       int limit= 3;
       bool keineVersuche = false;

       while(guess!= geheimW && !keineVersuche)
       {
        if(guessCount< limit)
        {
          Console.WriteLine("Versuchen Sie das Wort zu erraten: ");
          guess=Console.ReadLine();
          guessCount++;
        }
        else
        {
          keineVersuche = true;
          
        }
        
       }
       if(keineVersuche)
       {
        Console.WriteLine("Falsch!");
      
       }
       else
       {
         Console.WriteLine("Richtig!");
       }
          Console.ReadLine();
     }
   }
 }
 