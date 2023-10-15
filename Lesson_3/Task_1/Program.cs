System.Console.WriteLine("выберите программу:");
int programmIndex = int.Parse(System.Console.ReadLine());
switch (programmIndex)
{
    case (1):
        // Метод ничего не принимает и ничего не возвращает
        void Method1()
        {
            System.Console.WriteLine("Автор");
        }
        Method1();
        break;
    case (2):
        // Метод может что-то принять, но ничего не возвращает
        void Method2(string msg)
        {
            System.Console.WriteLine(msg);
        }
        Method2("Текст сообщения не тот");

        void Method21(string msg, int count)
        {
            int i = 0;
            while (i < count)
            {
                System.Console.WriteLine(msg);
                i++;
            }
        }
        void Method22(string msg, int count)
        {
            int i = 0;
            while (i < count)
            {
                System.Console.WriteLine(msg);
                i++;
            }
        }
        Method22(count: 3, msg: "Текст сообщения");
        break;
    case (3):
        // Метод мничего не принимает, но Что-то возвращают
        int Method3()
        {
            return DateTime.Now.Year;
        }
        int year = Method3();
        System.Console.WriteLine(year);

        break;
    case (4):
        // Метод  что-то принимает ичто-то возвращает
        string Method4(int count, string text)
        {
            int i = 0;
            string result = String.Empty;
            for (i = 0; i < count; i++)
            {
                result += text;
            }
            return result;
        }
        string res = Method4(10, "z");
        System.Console.Write(res);

        break;
    case (5):
        for (int i = 2; i <= 10; i++)
        {
            for (int j = 2; j <= 10; j++)
            {
                System.Console.WriteLine($"{i} x {j} = {i * j}");
            }
            System.Console.WriteLine();
        }
        break;


    case (6):
        string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
                    + "ежели бы вас послали вместо нашего милого Винценгероде, "
                    + "вы бы взяли приступом согласие прусского короля. "
                    + "Вы так красноречивы. Вы дадите мне чаю?";
        string Replace(string text, char oldValue, char newValue)
        {
            string result = String.Empty;
            int lenght = text.Length;
            for (int i = 0; i < lenght; i++)
            {
                if (text[i] == oldValue) result += $"{newValue}";
                else result += $"{text[i]}";
            }

            return result;
        }
        string newText = Replace(text, ' ', '*');
        System.Console.WriteLine(newText);
        System.Console.WriteLine();

        newText = Replace(newText, '*', ' ');
        System.Console.WriteLine(newText);

        break;

}
