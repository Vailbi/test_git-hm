string [] inputArr = {"one" , "two0" ,  "=_=" , "rus", "test", "00"};
int newSize = 0;
for (int i = 0; i < inputArr.Length; i++)
{
   if (inputArr[i].Length <= 3)
   {
    newSize++;
   } 
}
