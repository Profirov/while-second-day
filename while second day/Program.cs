int cakewidth = int.Parse(Console.ReadLine());
int cakeLength = int.Parse(Console.ReadLine());

int pieceTaken = 0;
bool iscAkeOver = false;
int cakeSize = cakewidth * cakeLength;

string input = Console.ReadLine();
while (input != "Stop")
{ 
  int piece = int.Parse(input);
    pieceTaken += piece;

    if (pieceTaken >= cakeSize)
    { 
      int neededPieces = pieceTaken - cakeSize;

        iscAkeOver = true;

        Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
        break;
    }
    input = Console.ReadLine();
}


int piecesLeft = cakeSize - pieceTaken;
if (piecesLeft > 0)
{
    Console.WriteLine($"{piecesLeft} pieces left.");
}