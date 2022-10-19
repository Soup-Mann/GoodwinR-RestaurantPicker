//Reed Goodwin
//Challenge Restaurant picker!!
//In this challenge you are going to either get a random
//restaurant or you can choose a category of food
Console.Clear();
string deez = "";
string Choose; 
while(deez != "no"){




Random rndNum = new Random();

Console.WriteLine("Would you like to select a category?");
Console.WriteLine("Type \"1\" For Fast Food");
Console.WriteLine("Type \"2\" For Dine In");
Console.WriteLine("Type \"3\" For an Adventure! (Vague description of restaurant to find)");
Console.WriteLine("Type \"0\" For completely Random");

string userInput = Console.ReadLine();
userInput = userInput.ToLower();


//int numone = Convert.ToInt32(userInput);

//Fast Food!!
if(userInput == "1"){
int num = rndNum.Next(0,9);
Console.Write("Fast Food");
Console.WriteLine("");

Console.WriteLine("-----------");

switch(num){
case 0:
Console.WriteLine("Taco Bell");
break;
case 1:
Console.WriteLine("McDonalds");
break;
case 2:
Console.WriteLine("Jack in the Box");
break;
case 3:
Console.WriteLine("Carls Jr");
break;
case 4:
Console.WriteLine("Popeyes");
break;
case 5:
Console.WriteLine("Kanes");
break;
case 6:
Console.WriteLine("Panda Express");
break;
case 7:
Console.WriteLine("KFC");
break;
case 8:
Console.WriteLine("Papa Johns");
break;
case 9:
Console.WriteLine("Dominoes");
break;

}
Console.WriteLine("-----------");
Console.WriteLine("");
}else if (userInput == "2")
{
int num = rndNum.Next(0,9);
Console.Write("Dine In");
Console.WriteLine("");

Console.WriteLine("-----------");

switch(num){
case 0:
Console.WriteLine("Strings");
break;
case 1:
Console.WriteLine("Mikasa Sushi");
break;
case 2:
Console.WriteLine("Petes Restaurant and BrewHouse");
break;
case 3:
Console.WriteLine("Titos (Place next to petes)");
break;
case 4:
Console.WriteLine("Las Casuelas");
break;
case 5:
Console.WriteLine("Cafe Platano");
break;
case 6:
Console.WriteLine("AppleBees");
break;
case 7:
Console.WriteLine("Chili's");
break;
case 8:
Console.WriteLine("West Coast SOurdough");
break;
case 9:
Console.WriteLine("Indian Cafe");
break;
}
Console.WriteLine("-----------");
Console.WriteLine("");

}else if(userInput == "3")
{

int num = rndNum.Next(0,9);
Console.Write("Adventure!! Here We GO!!");
Console.WriteLine("");

Console.WriteLine("-----------");

switch(num){
case 0:
Console.WriteLine("Go find the nearest taco truck!!");
break;
case 1:
Console.WriteLine("Call Your next of Kin and Ask them to name the first restaurant that comes to mind!");
break;
case 2:
Console.WriteLine("Ask a random person off the street for their input");
break;
case 3:
Console.WriteLine("drive a random direction until you find someplace to eat!");
break;
case 4:
Console.WriteLine("Find the worst rated place on yelp");
break;
case 5:
Console.WriteLine("Find the highest rated place on yelp");
break;
case 6:
Console.WriteLine("Find a place close to you that youve never eaten at");
break;
case 7:
Console.WriteLine("Go to a breakfast place for dinner");
break;
case 8:
Console.WriteLine(" Call ur friend and ask them what you should get");
break;
case 9:
Console.WriteLine("park ur car downtown and walk until you see something good!");
break;
}
Console.WriteLine("-----------");
Console.WriteLine("");



}else if (userInput == "0"){
    int num = rndNum.Next(0,29);
Console.Write("Completely Random");
Console.WriteLine("");

Console.WriteLine("-----------");
switch(num){
case 0:
Console.WriteLine("Taco Bell");
break;
case 1:
Console.WriteLine("McDonalds");
break;
case 2:
Console.WriteLine("Jack in the Box");
break;
case 3:
Console.WriteLine("Carls Jr");
break;
case 4:
Console.WriteLine("Popeyes");
break;
case 5:
Console.WriteLine("Kanes");
break;
case 6:
Console.WriteLine("Panda Express");
break;
case 7:
Console.WriteLine("KFC");
break;
case 8:
Console.WriteLine("Papa Johns");
break;
case 9:
Console.WriteLine("Dominoes");
break;
case 10:
Console.WriteLine("Strings");
break;
case 11:
Console.WriteLine("Mikasa Sushi");
break;
case 12:
Console.WriteLine("Petes Restaurant and BrewHouse");
break;
case 13:
Console.WriteLine("Titos (Place next to petes)");
break;
case 14:
Console.WriteLine("Las Casuelas");
break;
case 15:
Console.WriteLine("Cafe Platano");
break;
case 16:
Console.WriteLine("AppleBees");
break;
case 17:
Console.WriteLine("Chili's");
break;
case 18:
Console.WriteLine("West Coast SOurdough");
break;
case 19:
Console.WriteLine("Indian Cafe");
break;
case 20:
Console.WriteLine("Go find the nearest taco truck!!");
break;
case 21:
Console.WriteLine("Call Your next of Kin and Ask them to name the first restaurant that comes to mind!");
break;
case 22:
Console.WriteLine("Ask a random person off the street for their input");
break;
case 23:
Console.WriteLine("drive a random direction until you find someplace to eat!");
break;
case 24:
Console.WriteLine("Find the worst rated place on yelp");
break;
case 25:
Console.WriteLine("Find the highest rated place on yelp");
break;
case 26:
Console.WriteLine("Find a place close to you that youve never eaten at");
break;
case 27:
Console.WriteLine("Go to a breakfast place for dinner");
break;
case 28:
Console.WriteLine(" Call ur friend and ask them what you should get");
break;
case 29:
Console.WriteLine("park ur car downtown and walk until you see something good!");
break;

}
Console.WriteLine("-----------");
}
Console.WriteLine("Thanks for playing!");
Console.WriteLine("Would you like to try again?");
Console.WriteLine("Press enter to restart, Type \"no\" to Quit");
deez = Console.ReadLine();
}


