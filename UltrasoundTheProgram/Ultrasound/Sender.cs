using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Sender(int x) { }

        /// <summary>
        /// Контроллирует всю операцию - от отправки лазера до получения расстояния.
        /// </summary>
        /// <param name="toRight">В какую сторону направить лазер.</param>
        public void Main(bool toRight) { }

        /// <summary>
        /// Отправляет лазер.
        /// </summary>
        /// <param name="toRight">В какую сторону пускать.</param>
        /// <returns>Время до возвращения лазера.</returns>
        private byte Send(bool toRight)
        {
            return 0;
        }

        /// <summary>
        /// Высчитывает, исходя из времени, дистанцию.
        /// </summary>
        /// <param name="time">Время, которое лазер провёл в пространстве.</param>
        /// <returns>Дистанция.</returns>
        private byte CalculateDist(byte time)
        {
            return 0;
        }

        /// <summary>
        /// Выводит результат, то - есть саму дистанцию в консоль.
        /// </summary>
        /// <param name="distance">Дистанция.</param>
        private void DisplayResult(byte distance) { }
    }
}
