using Array = AbstractClassesAndInterfaces.Array;

Array array = new Array(new int[] {5, 4, 8, 29, 10});
array.Show();
array.Show("Array integers are shown:");
Console.WriteLine($"Мax: {array.Max()}");
Console.WriteLine($"Min: {array.Min()}");
Console.WriteLine($"The arithmetic average: {array.Avg()}");
Console.WriteLine($"Number is in array: {array.Search(5)}");
Console.WriteLine($"Number is in array: {array.Search(11)}");
array.SortAsc();
Console.WriteLine();
array.SortDesc();
Console.WriteLine();
array.SortByParam(true);
Console.WriteLine();
array.SortByParam(false);




