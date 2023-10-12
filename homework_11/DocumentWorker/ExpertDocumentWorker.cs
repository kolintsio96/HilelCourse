namespace DocumentWorker
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у новому форматі");
        }
    }
}
