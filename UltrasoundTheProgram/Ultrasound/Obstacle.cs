namespace Ultrasound
{
    /// <summary>
    /// Родительский класс от которого наследуются все препятствия в мире.
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
        public void SignUp(Obstacle obstacle)
        {
            Environment environment = Environment.GetInstance();
            environment.Initialize(obstacle, obstacle.PosX);
        }
    }
}
