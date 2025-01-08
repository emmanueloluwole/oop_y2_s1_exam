using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Event> eventS;
        private List<Ticket> tickets;
        private List<VIPTicket> VIPtickets;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            eventS = GetEvents();

        }
        private List<Event> GetEvents()
        {
            List<Event> events = new List<Event>();
            Event e1 = new Event("Music Event", new DateTime(2021, 12, 12), EventType.Music);
            Event e2 = new Event("Comedy Event", new DateTime(2021, 12, 13), EventType.Comedy);
            Event e3 = new Event("Theatre Event", new DateTime(2021, 12, 14), EventType.Theatre);
            //events.Add(e1);
            //events.Add(e2);
            //events.Add(e3);

            return new List<Event>() { e1, e2, e3 };
        }
        private List<Ticket> GetTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            Ticket t1 = new Ticket("Early Bird", 100m, 100);
            Ticket t2 = new Ticket("Platinum", 250m, 100);
            //tickets.Add(t1);
            //tickets.Add(t2);
            //tickets.Add(t3);
            return new List<Ticket>() { t1, t2 };
        }
        private List<VIPTicket> GetVIPTickets()
        {
            List<VIPTicket> VIPtickets = new List<VIPTicket>();
            VIPTicket vt1 = new VIPTicket("Ticket and hotel package", 150m, 100, "Free Drinks", 50m);
            VIPTicket vt2 = new VIPTicket("Weekend ticket", 2000m, 100, "with camping", 100m);
            //VIPtickets.Add(vt1);
            //VIPtickets.Add(vt2);
            return new List<VIPTicket>() { vt1, vt2 };
        }



    }
}
