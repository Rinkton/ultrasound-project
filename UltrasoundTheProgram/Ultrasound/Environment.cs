using System;
using System.Collections.Generic;

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
        private List<Obstacle> Obstacles = new List<Obstacle>();

        /// <summary>
        /// Список всех позиций X у препятствий в мире.
        /// </summary>
        private List<int> PositionsX = new List<int>();

        /// <summary>
        /// Тут хранится единый экземпляр класса Environment.
        /// </summary>
        private static Environment Instance;


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
            if (Instance == null)
                Instance = new Environment();

            return Instance;
        }

        /// <summary>
        /// Инициализация нового препятствия.
        /// </summary>
        /// <param name="obstacle">Вид препятствия.</param>
        /// <param name="posX">Позиция по X.</param>
        public void Initialize(Obstacle obstacle, int posX)
        {
            bool isTaken = CheckPlace(posX);

            if (isTaken == false && obstacle != null)
            {
                Obstacles.Add(obstacle);
                PositionsX.Add(posX);
            }
            else
            {
                throw new Exception("Выбранная вами позиция препятствия уже занята или посланное вами препятствие равно null.");
            }
        }

        /// <summary>
        /// Проверяет, нет ли на выданной координате какого - нибудь объекта,
        /// после, отсылает запросчику результат.
        /// </summary>
        /// <param name="posX">Позиция по X для проверки.</param>
        /// <returns>Есть на координате что - то или нет.</returns>
        public bool CheckPlace(int posX)
        {
            foreach (int x in PositionsX)
            {
                if (posX == x)
                    return true;
            }

            return false;
        }
    }
}
