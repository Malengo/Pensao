using Pensao;
// See https://aka.ms/new-console-template for more information
Console.Write("Digite quantos alunos iram alugar um quarto: ");
int studentQuantity = int.Parse(Console.ReadLine());
Room[] room = new Room[10];
Student[] student = new Student[studentQuantity];
string name, email;

for (int numberOfRoom = 0; numberOfRoom < 10; numberOfRoom++)
{
    room[numberOfRoom] = new Room();
    room[numberOfRoom].rent = false;
}

for (int option = 0; option < studentQuantity; option++)
{
    Console.Write("Digite  qual quarto gostaria de ficar: ");
    int choice = int.Parse(Console.ReadLine());
    Boolean teste = true;
    while (teste)
    {

        if (room[choice].rent == false)
        {
            Console.Write("Digite o  nome do Estudante: ");
            name = Console.ReadLine();
            Console.Write("Digite o email  do Estudante: ");
            email = Console.ReadLine();
            student[option] = new Student { Name = name, Email = email, numberRoom = choice };

            room[choice].rent = true;
            teste = false;
        }
        else
        {
            Console.Write("Quarto Ocupado, escolha outro Quarto de 1 á 10: ");
            choice = int.Parse(Console.ReadLine());
        }
    }


}
foreach (Student locator in student)
{
    Console.WriteLine("{0} vai ficar no quarto {1}, e seu email é {2}", locator.Name, locator.numberRoom, locator.Email);
}

