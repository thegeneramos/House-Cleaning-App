namespace HouseCleaningApp
{
    public partial class App : Application
    {
        public static List<Room> Rooms { get; set; } = new List<Room>();
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            Routing.RegisterRoute(nameof(EditRoomPage), typeof(EditRoomPage));
            Routing.RegisterRoute(nameof(AddRoomPage), typeof(AddRoomPage));
            Routing.RegisterRoute(nameof(CurrentHomePage), typeof(CurrentHomePage));
        }
    }
}
