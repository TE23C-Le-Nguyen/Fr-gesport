int score = 0;
Console.WriteLine("WELCOME TO NEV'S POKEMON'S QUIZ!");

//------------------------------------------------------------

Console.WriteLine(" Which Pokémon can use its black ink to draw pictures or issue warnings?");
Console.WriteLine("a) Horsea, b) Starmie, c) Bellsprout");
string answer1 = Console.ReadLine();
if (answer1 == "a")
{
    score++;
    Console.WriteLine("CORRECT ANSWER");
}
else
{
    Console.WriteLine("WRONG ANSWER");
}

//------------------------------------------------------------

Console.WriteLine("Squirtle can eventually become which Pokémon?");
Console.WriteLine("a) Electabuzz, b)  Blastoise, c) Magmar");
string answer2 = Console.ReadLine();
if (answer2 == "b")
{
    score++;
    Console.WriteLine("CORRECT ANSWER");
}
else
{
    Console.WriteLine("WRONG ANSWER");
}

//------------------------------------------------------------

Console.WriteLine(" Which Pokémon seems to always have a headache?");
Console.WriteLine("a) Psyduck, b) Kangaskhan , c) Zapdos ");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
    score++;
    Console.WriteLine("CORRECT ANSWER");
}
else
{
    Console.WriteLine("WRONG ANSWER");
}

//------------------------------------------------------------

Console.WriteLine(" Which Pokémon's English name sounds like a creature from the Indian Ocean?");
Console.WriteLine("a) Gengar, b) Rhydon , c) Dewgong ");
string answer4 = Console.ReadLine();
if (answer4 == "c")
{
    score++;
    Console.WriteLine("CORRECT ANSWER");
}
else
{
    Console.WriteLine("WRONG ANSWER");
}

//------------------------------------------------------------

Console.WriteLine("Which Pokémon can be used to beat Lorelei?");
Console.WriteLine("a) Ice or Water, b) Psychic or Ghost , c) Grass or Electric ");
string answer5 = Console.ReadLine();
if (answer5 == "c")
{
    score++;
    Console.WriteLine("CORRECT ANSWER");
}
else
{
    Console.WriteLine("WRONG ANSWER");
}

//------------------------------------------------------------

Console.WriteLine("Rock tunnel and power plant are closest to which of the following?");
Console.WriteLine("a) Celadon City, b) Cerulean City, c) Cinnabar Island");
string answer6 = Console.ReadLine();
if (answer6 == "b")
{
    score++;
    Console.WriteLine("CORRECT ANSWER");
}
else
{
    Console.WriteLine("WRONG ANSWER");
}

//------------------------------------------------------------

Console.WriteLine("What is Professor Oak's Japanese name?");
Console.WriteLine("a) Okita, b) Okido, c) Arigato ");
string answer7 = Console.ReadLine();
if (answer7 == "b")
{
    score++;
    Console.WriteLine("CORRECT ANSWER");
}
else
{
    Console.WriteLine("WRONG ANSWER");
}

//------------------------------------------------------------

Console.WriteLine("Who stole Misty's bike?");
Console.WriteLine("a) Jessie, b) Gary , c) Ash ");
string answer8 = Console.ReadLine();
if (answer8 == "c")
{
    score++;
    Console.WriteLine("CORRECT ANSWER");
}
else
{
    Console.WriteLine("WRONG ANSWER");
}

//------------------------------------------------------------

Console.WriteLine("Which of the following are Pokemon games?");
Console.WriteLine("a) Gold and Silver, b) Orange and Pewter, c) White and Purple");
string answer9 = Console.ReadLine();
if (answer9 == "a")
{
    score++;
    Console.WriteLine("CORRECT ANSWER");
}
else
{
    Console.WriteLine("WRONG ANSWER");
}

//------------------------------------------------------------

Console.WriteLine("Which of the following Pokémon can be found in Red?");
Console.WriteLine("a) Weepinbell and Magmar, b) Sandslash and Vulpix , c) Arcanine and Scyther");
string answer10 = Console.ReadLine();
if (answer10 == "a")
{
    score++;
    Console.WriteLine("CORRECT ANSWER");
}
else
{
    Console.WriteLine("WRONG ANSWER");
}

//------------------------------------------------------------

Console.WriteLine($"You Got {score}/10 Point.");
if (score == 10)
{
  Console.WriteLine("BRO IS ROTOM POKÉDEX");
}
else if (score > 3)
{
  Console.WriteLine("NOT BAD; KEEP IT UP CHAMP");
}
else 
{
  Console.WriteLine("BRO KNOWS NOTHING ABOUT POKEMON 😭🙏");
}

Console.WriteLine("GAME OVER, THANK YOU FOR PLAYING. CLICK ANYWHERE TO EXIT");
Console.ReadKey();