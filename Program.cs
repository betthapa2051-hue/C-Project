Console.WriteLine("Enter your name:");

string name = Console.ReadLine();

Console.WriteLine("Enter your age:");

int age = Convert.ToInt32(Console.ReadLine());

if (age>=25){
 Console.WriteLine($"Hello {name}, old ");

}
else{
    Console.WriteLine($"Hello {name}, young ");
}
