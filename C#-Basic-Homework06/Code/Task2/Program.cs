//Create a list of ten numbers.
//Use LINQ to select in a list of the squares of all the numbers in the list from above.

List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> squareNumberList = numberList.Select(x => x*x).ToList();
foreach (int num in squareNumberList)
{
    Console.WriteLine(num);
}