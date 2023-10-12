namespace DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = ReadInput("Enter access key(pro, exp, ''): ");
            DocumentWorker documentWorker = new DocumentWorker();

            switch (key)
            {
                case "pro":
                    documentWorker = new ProDocumentWorker();
                    break;
                case "exp":
                    documentWorker = new ExpertDocumentWorker();
                    break;
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
        private static string ReadInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}