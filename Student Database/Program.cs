//Student Database

//Create 3 arrays. One with name, one with hometown and one with fav food

string[]names = new string[] {"Chris Cornell", "Curt Cobain", "Chris Robinson", "Robin Zander", "Stephen Tyler"};

string[]hometown = new string[] {"Seattle", "Atlanta","Aberdeen","Beloit", "Yonkers" };

string[]favoriteFood = new string[] {"Oysters","Prawn Salad","Tacos","Eggs","Pancakes"};

Console.WriteLine("Welcome!\n Which student would you like to learn more about? Enter a number 1-5: ");
int indexCounter = 0;
foreach(string name in names)
{
    Console.WriteLine($"name{indexCounter + 1}");
}