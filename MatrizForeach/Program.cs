int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");


/*Criar uma variável para manter o número do compartimento atual 
e exibir o total acumulado

crie uma variável que conterá a iteração atual da instrução foreach 
a fim de permitir a exibição do compartimento e da contagem de itens 
prontos nele, além do total acumulado de todos os itens 
de compartimentos contabilizados até agora.

*/