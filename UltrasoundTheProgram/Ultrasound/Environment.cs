using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrasound
{
    /// <summary>
    /// Содержит информацию о всех препятствиях.
    /// </summary>
    class Environment
    {
        /// <summary>
        /// Список всех препятствий в мире.
        /// </summary>
        private List<Obstacle> Obstacles;

        /// <summary>
        /// Список всех позиций X у препятствий в мире.
        /// </summary>
        private List<int> PositionsX;


        /// <summary>
        /// Делаем конструктор частным, чтобы использовать для класса Environment паттерн Singleton.
        /// </summary>
        private Environment() { }

        /// <summary>
        /// Метод, который является основным для исполнения паттерна Singleton у класса Environment.
        /// </summary>
        /// <returns>Уже имеющийся экземпляр или новый.</returns>
        public static Environment GetInstance()
        {
            return null;
        }

        /// <summary>
        /// Инициализация нового препятствия.
        /// </summary>
        /// <param name="obstacle">Вид препятствия.</param>
        /// <param name="posX">Позиция по X.</param>
        public void Initialize(Obstacle obstacle, int posX) { }

        /// <summary>
        /// Проверяет, нет ли на выданной координате какого - нибудь объекта,
        /// после, отсылает запросчику результат.
        /// </summary>
        /// <param name="posX">Позиция по X для проверки.</param>
        /// <returns>Есть на координате что - то или нет.</returns>
        public bool CheckPlace(int posX)
        {
            return false;
        }
    }
}
