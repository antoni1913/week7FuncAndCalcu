string[] fruitBasket = { "apples", "bananas", "oranges" };
string[] pets = { "dogs", "fish", "hamsters", "cats" };
string[] twoAndHalfMan = { "Alan", "Burta", "Jake" };

PrintArrayElements(pets);
PrintArrayElements(fruitBasket);
PrintArrayElements(twoAndHalfMan);


static void PrintArrayElements(string[] someArray)
{
    for (int i = 0; i < someArray.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {someArray[i]}");
    }
}

/////
