using G_NET_26_OOP_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_3
{
    public class Cinema
    {
        private Ticket[] _tickets = new Ticket[20];
        private Projector _projector;          

        public string CinemaName { get; }

        public Cinema(string cinemaName, string projectorModel)
        {
            CinemaName = cinemaName;
            _projector = new Projector(projectorModel);
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                    Console.WriteLine($"Ticket #{t.TicketId} added to {CinemaName}.");
                    return true;
                }
            }

            Console.WriteLine("Cinema is full. Cannot add more tickets.");
            return false;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine($"\n===== [{CinemaName}] Tickets =====");



            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] != null)
                {
                    Console.WriteLine(_tickets[i].ToString());
                }
            }



            Console.WriteLine("==================================\n");
        }


        public void OpenCinema()
        {
            Console.WriteLine($"\n>> {CinemaName} is opening...");
            _projector.Start();
            Console.WriteLine($">> {CinemaName} is now OPEN. Enjoy the show!\n");
        }

        public void CloseCinema()
        {
            Console.WriteLine($"\n>> {CinemaName} is closing...");
            _projector.Stop();
            Console.WriteLine($">> {CinemaName} is now CLOSED. Goodbye!\n");
        }

        public override string ToString()
        {
            return $"Cinema: {CinemaName} | {_projector}";
        }
    }
}
