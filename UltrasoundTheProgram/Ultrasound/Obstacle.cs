using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrasound
{
    /// <summary>
    /// Родительский класс от которого наследуются все предметы в мире.
    /// </summary>
    class Obstacle
    {
        /// <summary>
        /// Позиция в мире по X.
        /// </summary>
        protected int PosX;


        /// <summary>
        /// Отправка информации об самом объекте Environment-у.
        /// </summary>
        /// <param name="obstacle">Вид препятствия.</param>
        /// <param name="x">Позиция по X.</param>
        public void SignUp(Obstacle obstacle, int x) { }
    }
}
