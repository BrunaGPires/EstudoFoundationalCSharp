int saleAmount = 1001;
//se saleAmount for maior que 1000 então discount recebera o valor 100
//caso saleAmount for menor que 1000 então discount recebera o valor 50
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");