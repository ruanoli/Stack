
Stack<int> pilhas = new Stack<int>();

//Adicionando itens na stack
pilhas.Push(2);
pilhas.Push(4);
pilhas.Push(6);
pilhas.Push(8);

foreach(int item in pilhas)
{
    Console.WriteLine(item);
}

var remove = pilhas.Pop(); //remove o último elemento que entrou na pilha
Console.WriteLine($"Removendo o item {remove}");

foreach(int item in pilhas)
{
    Console.WriteLine(item);
}