namespace Lesson_HelloName.Classes.Lesson_7_classes
{
    internal class Car : Transport
    {
        private string kindOfTransport;

        public Car(string destination, int number, string departureTime, int placeCount, string kindOfTransport) : base(destination, number, departureTime, placeCount)
        {
            this.kindOfTransport = kindOfTransport;
        }

        public void GetKindOfTransport() 
        {
            Console.WriteLine($"Тип транспорта: {kindOfTransport}");
        }
    }
}
