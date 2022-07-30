// Create an array to hold integer values 0 through 9
int[] numArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};

// Create an array of length 10 that alternates between true and false values, starting with true
bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};

// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
List<string> flavors = new List<string>();
flavors.Add("Rocky Road");
flavors.Add("Mint Chocolate Chip");
flavors.Add("Strawberry");
flavors.Add("Vanilla");
flavors.Add("Chocolate");

// Output the length of this list after building it
Console.WriteLine(flavors.Count);

// Output the third flavor in the list, then remove this value
Console.WriteLine(flavors[2]);
flavors.Remove("Strawberry");
// Output the new length of the list (It should just be one fewer!)
Console.WriteLine(flavors.Count);

// Create a dictionary that will store both string keys as well as string values
Dictionary<string,string> userInfo = new Dictionary<string,string>();

// Add key/value pairs to this dictionary where:
// each key is a name from your names array
// each value is a randomly selected flavor from your flavors list.

Random rand = new Random();
int value = rand.Next(flavors.Count);
userInfo.Add(nameArray[0], flavors[value]);
userInfo.Add(nameArray[1], flavors[value]);
userInfo.Add(nameArray[2], flavors[value]);
userInfo.Add(nameArray[3], flavors[value]);

// Loop through the dictionary and print out each user's name and their associated ice cream flavor
foreach (var entry in userInfo)
{
    Console.WriteLine($"Name: {entry.Key}, Favorite Flavor: {entry.Value}");
}