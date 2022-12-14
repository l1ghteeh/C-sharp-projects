
namespace DZshka
{
    class Encoding
    {
        private string path = "text.txt";

        protected List<string> RecordRead()
        {
            List<string> result = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    result.Add(line);
                }
            }
            return result;
        }

        protected void RecordWrite1(string line)
        {
            StreamWriter SW = new StreamWriter(path, true, System.Text.Encoding.Default);
            SW.WriteLine("Default");
            SW.WriteLine(line);
            SW.Close();
        }



        protected void RecordWrite2(string line)
        {
            StreamWriter SW = new StreamWriter(path, true, System.Text.Encoding.ASCII);
            SW.WriteLine("ASCII");
            SW.WriteLine(line);
            SW.Close();
        }

        protected void RecordWrite3(string line)
        {
            StreamWriter SW = new StreamWriter(path, true, System.Text.Encoding.UTF8);
            SW.WriteLine("UTF-8");
            SW.WriteLine(line);
            SW.Close();
        }

        protected void RecordWrite4(string line)
        {
            StreamWriter SW = new StreamWriter(path, true, System.Text.Encoding.Unicode);
            SW.WriteLine("Unicode");
            SW.WriteLine(line);
            SW.Close();
        }

        private void StartMenu()
        {
            try
            {
                Console.WriteLine("Vvedite 1");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    foreach (string record in RecordRead())
                    {
                        Console.WriteLine(record);
                    }
                    Console.WriteLine();
                }
            }
            catch
            {

            }
        }
        static void Main()
        {
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.Clear();
            Encoding map = new Encoding();
            map.RecordWrite1("Я расскажу вам о том, что случилось со мной прошлым летом. Мы с родителями часто проводим время в деревне. Там у нас большой деревянный дом и участок земли.");
            map.RecordWrite2("Я расскажу вам о том, что случилось со мной прошлым летом. Мы с родителями часто проводим время в деревне. Там у нас большой деревянный дом и участок земли.");
            map.RecordWrite3("Я расскажу вам о том, что случилось со мной прошлым летом. Мы с родителями часто проводим время в деревне. Там у нас большой деревянный дом и участок земли.");
            map.RecordWrite4("A man and woman had been married for more than 60 years. They had shared everything. They had talked about everything.");
            map.StartMenu();
        }
    }
}
