  

using System;

public class Task

{

    public static void Main(string[] args)

    {

       string Word= "Code Academy";

       Console.WriteLine(Gaps(ref Word));

    }

    static string Gaps (ref string Word){

        string gaps ="";

         for(int i=0;i<Word.Length;i++){

             if(Word[i]==" ")

             

             {

                 continue;

             }

             else{

                 gaps+=Word;

                 Console.WriteLine(Word);

             }

             

         }return Word;

        

        

    }

}
