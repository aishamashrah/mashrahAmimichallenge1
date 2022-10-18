//aisha mashrah
//10/18/22
//mini challenge1 say Hello
//the user is going to be asked to enter their name and if they want to play agian.

bool playAgain = true;
Console.WriteLine("Hello , whats your name");
String newName =Console.ReadLine();
Console.WriteLine("Hello,nice to meet you: " + newName);
Console.WriteLine(" ");
    Console.WriteLine("Would you like to play again? Yes or No");
    string rePlay = Console.ReadLine();
    if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
        playAgain = true;
    
        Console.Clear();
        Console.WriteLine( "LETS PLAY AGAIN!!" );
        Console.WriteLine( " " );
    } 
    if(rePlay == "NO" || rePlay == "no"){
        playAgain = false;
        Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
    } 



