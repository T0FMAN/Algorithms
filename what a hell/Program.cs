int[] array = Sort(new int[] { 9, 2, 3, 4, 7, 5, 10, 3, 6 });

foreach (int x in array)
    Console.WriteLine(x);

int[] Sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        var x = Sort(array);
    }
}

int[] Merge(int[] array)
{

}


var list = array.ToList(); 
list.Sort();

var ahuet = array.OrderByDescending(x => x);

var debil = from i in array
            orderby i
            select i;

foreach (var item in list)
    Console.WriteLine(item);

foreach (var x in ahuet)
    Console.WriteLine(x);

foreach (var i in debil)
    Console.Write(i);
