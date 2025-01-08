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
        //link tio repo
        //https://github.com/emmanueloluwole/oop_y2_s1_exam.git
        private List<Event> events;
        private List<Ticket> tickets;
        private List<VIPTicket> vIPtickets;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            events = GetEvents();
            //displaying the events in the listbox
            lbxEvents.ItemsSource = events;



            if (events.Count > 0)
            {
                tickets = GetTickets();
                //displaying the tickets in the listbox
                lbxTickets.ItemsSource = tickets;
                vIPtickets = GetVIPTickets();
             
            }
          



        }
        private List<Event> GetEvents()
        {
            //create a list of events
            List<Event> events = new List<Event>();
            Event e1 = new Event("Oasis croke park", new DateTime(2025, 06, 20), EventType.Music);
            Event e2 = new Event("Electric Picnic", new DateTime(2025, 08, 20), EventType.Music);
            //events.Add(e1);
            //events.Add(e2);
            //events.Add(e3);


            //add event to the list
            return new List<Event>() { e1, e2 };
        }
        private List<Ticket> GetTickets()
        {
            //create a list of tickets
            List<Ticket> tickets = new List<Ticket>();
            Ticket t1 = new Ticket("Early Bird", 100m, 100);
            Ticket t2 = new Ticket("Platinum", 250m, 100);
            //tickets.Add(t1);
            //tickets.Add(t2);
            //tickets.Add(t3);
            //create a list of VIP tickets
            List<VIPTicket> VIPtickets = new List<VIPTicket>();
            VIPTicket vt1 = new VIPTicket("Ticket and hotel package", 150m, 100, "Free Drinks", 50m);
            VIPTicket vt2 = new VIPTicket("Weekend ticket", 2000m, 100, "with camping", 100m);
            //VIPtickets.Add(vt1);
            //VIPtickets.Add(vt2);

            //add tickets to the list
            return new List<Ticket>() { t1, t2,vt1,vt2 };
        }
        private List<VIPTicket> GetVIPTickets()
        {
            //create a list of VIP tickets
            List<VIPTicket> VIPtickets = new List<VIPTicket>();
            VIPTicket vt1 = new VIPTicket("Ticket and hotel package", 150m, 100, "Free Drinks", 50m);
            VIPTicket vt2 = new VIPTicket("Weekend ticket", 2000m, 100, "with camping", 100m);
            //VIPtickets.Add(vt1);
            //VIPtickets.Add(vt2);

            //add VIP tickets to the list
            return new List<VIPTicket>() { vt1, vt2 };
        }

   
    }
}
