namespace _List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите:Добавить/Список/Сохранить/Открыть/Удалить");


            while (true)
            {
                var command = Console.ReadLine().Split(' ');
                Controller f = new Controller();
                switch (command[0])
                {
                    case "Добавить":
                        f.AddGood(command[1], float.Parse(command[2]), float.Parse(command[3]));
                        break;
                    case "Список":
                        Console.WriteLine(f.GetGoods());
                        break;
                    case "Сохранить":
                        f.SaveList();
                        break;
                    case "Открыть":
                        f.OpenList();
                        break;
                    case "Удалить":
                        f.Delete();
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }

            }
        }   
    }
}