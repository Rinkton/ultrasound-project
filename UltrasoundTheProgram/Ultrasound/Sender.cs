using System;

namespace Ultrasound
{
    /// <summary>
    /// Может отправить лазер, получить его, обработать информацию, вывести её.
    /// Также является препятствием.
    /// </summary>
    class Sender : Obstacle
    {
        /// <summary>
        /// Объявление нового Sender-а.
        /// </summary>
        /// <param name="x">Позиция появления в мире по X.</param>
        public Sender(int x)
        {
            PosX = x;

            SignUp(this); //Активируем метод родительского класса (Obstacle).
        }

        /// <summary>
        /// Контроллирует всю операцию - от отправки лазера до вывода расстояния.
        /// </summary>
        /// <param name="toRight">В какую сторону направить лазер.</param>
        public void Main(bool toRight)
        {
            byte time = Send(toRight);

            byte distance = CalculateDist(time);

            DisplayResult(distance);
        }

        /// <summary>
        /// Отправляет лазер и получает его.
        /// </summary>
        /// <param name="toRight">В какую сторону пускать.</param>
        /// <returns>Время до возвращения лазера.</returns>
        private byte Send(bool toRight)
        {
            Laser laser = new Laser(toRight, PosX);
            byte time = laser.Main();

            return time;
        }

        /// <summary>
        /// Высчитывает, исходя из времени, дистанцию.
        /// </summary>
        /// <param name="time">Время, которое лазер провёл в пространстве.</param>
        /// <returns>Дистанция.</returns>
        private byte CalculateDist(byte time)
        {
            byte distance;

            if (time != 0) //Ибо если time = 0, то если поделить его на 2, то возникнет математическая ошибка.
                distance = Convert.ToByte(time / 2);
            else
                distance = 0;

            return distance;
        }

        /// <summary>
        /// Выводит результат: саму дистанцию в консоль или сообщение о потери лазера.
        /// </summary>
        /// <param name="distance">Дистанция.</param>
        private void DisplayResult(byte distance)
        {
            if (distance != 0)
            {
                Console.WriteLine($"Дистанция равна {distance}.");
            }
            else
            {
                Console.WriteLine("Лазер был потерян...");
            }

            Console.ReadKey(true); //true - не отображать нажатую клавишу в консоли.
        }
    }
}
