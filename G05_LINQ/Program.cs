int[] x = { 1, 2, 3, 4, 5 };
int[] y = { 4, 5, 7, 9, 10, 11, 12 };

Console.WriteLine("Union");
var result1 = x.MyUnion(y);
result1.ToList().ForEach(Console.WriteLine);

Console.WriteLine("Concat");
var result2 = x.MyConcat(y);
result2.ToList().ForEach(Console.WriteLine);

Console.WriteLine("Except");
var result3 = x.MyExcept(y);
result3.ToList().ForEach(Console.WriteLine);

Console.WriteLine("Intersect");
var result4 = x.MyIntersect(y);
result4.ToList().ForEach(Console.WriteLine);

//Console.WriteLine("MyWhere");
//var result5 = x.MyWhere(y);
//result4.ToList().ForEach(Console.WriteLine);

//TODO: create own implementation in MyEnumerable for the following methods: 
//Union, Concat, Except, Intersect.
//As example use MyWhere method.

//-----------------------------------------------------------
var products = DataProvider.GetTestData();
//products.ToList().ForEach(Console.WriteLine);

//var result = products
//    .Where(p => p.Price < 2)
//    .OrderBy(p => p.Price);

//var result = from p in products
//             where p.Price < 2
//             orderby p.Price
//             select p;

//var result = products
//    .MyWhere(p => p.Price < 2);

//result.ToList().ForEach(Console.WriteLine);