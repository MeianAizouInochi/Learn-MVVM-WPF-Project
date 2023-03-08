using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_MVVM_WPF_App.Models
{
    class Hotel
    {
        private readonly ReservationBook Reservation_Book;
        
        public string Name { get; }

        public Hotel(string Name)
        {
            this.Name = Name;

            this.Reservation_Book = new ReservationBook();
        }
    }
}
