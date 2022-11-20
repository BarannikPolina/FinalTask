string[] arr1 = {"hello", "world", "-329", "1", "-87", "7", "cat", ":-)", "57"};
string[] arr2 = new string [arr1.Length];

int count = 0;
int arrFinishLength = 0;
for (int i = 0; i < arr1.Length; i++) 
{
    if (arr1[i].Length <= 3) 
    {
        arr2[count] = arr1[i];
        count++;
        arrFinishLength = arrFinishLength + 1;
    }
}
        
string[] arr3 = new string [arrFinishLength];
for (int i = 0; i < arr2.Length; i++) {
    if (arr2[i] != null) 
    {
    arr3[i] = arr2[i];
    }
}
Console.WriteLine(string.Join(" ", arr3));


    