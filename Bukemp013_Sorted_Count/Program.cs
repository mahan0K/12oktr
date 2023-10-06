// Сортировка подсчётом 


Console.Clear();
int[] array = {1,2,2,1,2,3,4,5,6,7,8,9,0,0,9,6,5,4,1,8,};

CoutingSort(array);
Console.WriteLine(string.Join(", ", array));


void CoutingSort(int[] inputArray)
{
int [] counters = new int [10];

for (int i =0; i< inputArray.Length; i++)
{
    counters[inputArray[i]]++;
//     int ourNumber = inputarray[i];
// counters[ourNumber]++;
 }
int index = 0;
for (int i = 0; i < counters.Length; i++)
{
    for (int j = 0; j < counters[i]; j++)
    {
        inputArray[index] =i;
        index++;
      
    }
}

}


void 
