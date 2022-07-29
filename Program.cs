string [] inputArray = {"one" , "two0" ,  "=_=" , "rus", "test", "00"};
int newSize = 0;
for (int i = 0; i < inputArray.Length; i++)
{
   if (inputArray[i].Length <= 3)
   {
    newSize++;
   } 
}
string [] newArray = new string[newSize];

int index= 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        newArray[index] = inputArray[i];
        index++;
    }
}
string Print(string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (i == length-1)
        {
            output+= ($"\"{array[i]}\"");
        }
        else
        output+= ($"\"{array[i]}\", ");
    }
    return output;
}

Console.WriteLine($"[{Print(newArray)}]");
File.WriteAllText("output.txt" , Print(newArray));