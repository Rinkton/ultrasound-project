namespace Ultrasound
{
    /// <summary>
    /// Препятствие, которое может быть задетым Laser-ом.
    /// </summary>
    class Box : Obstacle
    {
        /// <summary>
        /// Объявление новой коробки.
        /// </summary>
        /// <param name="x">Позиция по X.</param>
        public Box(int x)
        {
            PosX = x;

            SignUp(this);
        }
    }
}
