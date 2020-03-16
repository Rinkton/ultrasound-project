using System;
using System.Collections.Generic;
using System.Linq;
namespace Ultrasound
{
    /// <summary>
    /// Создаёт первоначальные препятствия и
    /// первоначально управляет ими.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Нужен для того чтобы создать первоначальные объекты и
        /// первоначально управлять ими.
        /// </summary>
        private static void Main()
        {
            //Создаём первоначальные объекты.
            Sender sender = new Sender(5);
            Box box = new Box(12);
            Sender sender2 = new Sender(-3);

            sender.Main(true); //Отправляем с помощью sender лазер вправо? - истина.
        }
    }
}
