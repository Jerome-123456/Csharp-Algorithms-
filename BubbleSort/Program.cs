int[] List = { 5, 3, 8, 4, 2 };
for (int i = 1; i < List.Length; i++)
{
    for (int j = 0; j < List.Length - i; j++)
    {
        if (List[j] > List[j + 1])
        {
            int temp = List[j];
            List[j] = List[j + 1];
            List[j + 1] = temp;
        }
    }
}
foreach (int i in List)
{
    Console.Write(i + " ");
}