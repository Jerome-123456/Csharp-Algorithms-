int[] List = { 5, 3, 8, 4, 2 };
int searchValue = 4;
bool found = false;
for (int i = 0; i < List.Length; i++)
{
    if (List[i] == searchValue)
    {
        found = true;
        Console.WriteLine($"Value {searchValue} found at index {i}.");
        break;
    }
}