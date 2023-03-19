using System;

namespace EventGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(3);

            //Delegação do evento... Toda vez que o Evento RoomSoudOutEvent ocorres ele chama o 
            //metodo OnRoomSoudOutActivate via DELEGATE que irá disparar a mensagem de sala lotada
            room.RoomSoudOutEvent += OnRoomSoudOutActivate;
            room.ResertSeat();
            room.ResertSeat();
            room.ResertSeat();
            room.ResertSeat();
            room.ResertSeat();
            room.ResertSeat();
            room.ResertSeat();


        }

        static void OnRoomSoudOutActivate(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada!");
        }

        public class Room
        {
            public Room(int seats)
            {
                Seats = seats;
            }
            private int SeatsInUse = 0;
            public int Seats { get; set; }

            public void ResertSeat()
            {
                SeatsInUse++;
                if (SeatsInUse > Seats)
                {
                    OnRoonSoudOut(EventArgs.Empty);
                }
                else
                {
                    Console.WriteLine("Sala Reservada!");
                }
            }

            //Deinição do evento RooSoudOutEvent
            public event EventHandler RoomSoudOutEvent;

            //A implementação Base do evento OnRoomSoudOut
            protected virtual void OnRoonSoudOut(EventArgs eventArgs)
            {
                EventHandler handler = RoomSoudOutEvent;
                handler?.Invoke(this, eventArgs);
            }
        }
    }
}
