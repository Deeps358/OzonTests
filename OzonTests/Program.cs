using OzonTests;

Console.WriteLine("Выберите тест от 1 до 5");
string choose = Console.ReadLine();
try
{
    switch(Convert.ToInt32(choose))
    {
        case 1:
            Test1 test1 = new Test1();
            test1.Solution();
            break;
        case 2:
            Test2 test2 = new Test2();
            test2.Solution();
            break;
        case 3:
            Test3 test3 = new Test3();
            test3.Solution();
            break;
        case 4:
            Test4 test4 = new Test4();
            test4.Solution();
            break;
        case 5:
            Test5 test5 = new Test5();
            test5.Solution();
            break;
        default:
            Console.WriteLine("Некорректный ввод");
            break;
    }
}
catch
{
    Console.WriteLine("Некорректный ввод");
}