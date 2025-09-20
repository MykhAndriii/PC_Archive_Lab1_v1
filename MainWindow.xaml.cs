using System.Windows;

namespace Lab1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Два інстанса для прикладу
            PersonalComputer pc1 = new PersonalComputer("Dell", 15.6f, 4, 500.0f);
            PersonalComputer pc2 = new PersonalComputer("HP", 17.3f, 8, 1000.0f);

            // Показ значень
            Pc1Info.Text = pc1.GetInfo();
            Pc2Info.Text = pc2.GetInfo();
        }
    }

    public class PersonalComputer
    {
        // Поля
        public string Manufacturer;
        public float Diagonal;
        public int Cores;
        public float Price;

        // Конструктор
        public PersonalComputer(string manufacturer, float diagonal, int cores, float price)
        {
            Manufacturer = manufacturer;
            Diagonal = diagonal;
            Cores = cores;
            Price = price;
        }

        // Метод для отримання інформації у вигляді стрінгового значення
        public string GetInfo()
        {
            return $"Manufacturer: {Manufacturer}\nScreen Diagonal: {Diagonal}\nNumber of Cores: {Cores}\nPrice: {Price}\n";
        }
    }
}