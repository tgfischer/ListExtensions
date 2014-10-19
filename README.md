ListExtensions
==============

This is a class that contains some List extension classes that I made

GetPermutations
--------------

This method is used for finding all permutations of the `List`. You can get a `List` of permutations by simply calling the method like so

```cs
List<int> list = new List<int>(); // You can use any type of object in the list

// ...

list.GetPermutations();
```

`.GetPermutations()` returns a `List<List<T>>` type object. For example, the following code...

```cs
List<int> list = new List<int>();

for (int i = 0; i < 3; i++) list.Add(i); // Add 3 integers to the List

// Get the permutations
List<List<int>> permutations = list.GetPermutations();

// Iterate through all permutations of the list
foreach (List<int> permutation in permutations)
{
    // Iterate through all items in this permutations
    for (int i = 0; i < permutation.Count; i++)
    {
        Console.Write(permutation[i]);

        // Don't add a comma after the last item
        if (i < permutation.Count - 1) Console.Write(", ");
    }

    Console.WriteLine();
}
```

... has the following output

```
0, 1, 2
0, 2, 1
1, 0, 2
1, 2, 0
2, 1, 0
2, 0, 1
```

Swap
--------------

This method is used for finding swapping 2 items in a `List`. You can swap two items in a `List` by calling the method like so

```cs
List<int> list = new List<int>(); // You can use any type of object in the list

// ...

list.Swap(0, 1);
```

The first parameter is the index of the first item you would like to swap, and the second parameter is the index of the second item you would like to swap. Both parameters are of type `int`. The return type of `.Swap(int, int)` is `void`

Here is an example

```cs
List<int> list = new List<int>();

for (int i = 0; i < 3; i++) list.Add(i); // Add 3 integers to the List

list.Swap(0, 2); // Swap item 0 and item 2

// Iterate through all the items in the List
for (int i = 0; i < list.Count; i++)
{
    Console.Write(list[i]);

    // Don't add a comma after the last item
    if (i < list.Count - 1) Console.Write(", ");
}
```

The above example has the following output

```
2, 1, 0
```
