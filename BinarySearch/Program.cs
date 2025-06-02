int[] List = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int searchValue = 4;
bool found = false;
int middle = List.Length / 2;
if (List.Length == 0)
{
    Console.WriteLine("List is empty.");
}
else
{
    while (middle >= 0 && middle < List.Length)
    {
        if (List[middle] == searchValue)
        {
            found = true;
            Console.WriteLine($"Value {searchValue} found at index {middle}.");
            break;
        }
        else if (List[middle] < searchValue)
        {
            middle++;
        }
        else
        {
            middle--;
        }
    }
}