string[] arrayOne = new string[9] { "SBS", "SAS", "Special", "Boat", "Service", "Strength", "1941", "1940", "22" };
string[] arrayTwo = new string[arrayOne.Length];

void Enumeration(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if(arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}