namespace Ultrasound
{
    /// <summary>
    /// Идёт в указанном направлении, каждый раз проверяет контакт с внеш. миром,
    /// при контакте, если это не отправивший его Sender - 
    /// летит в другую сторону, в противном случае - возвращает время.
    /// </summary>
    class Laser
    {
        /// <summary>
        /// В какую сторону идёт.
        /// </summary>
        private bool ToRight;

        /// <summary>
        /// Позиция в мире по X.
        /// </summary>
        private int PosX;

        /// <summary>
        /// Позиция отправившего отправителя по X.
        /// </summary>
        private readonly int SenderPosX;

        /// <summary>
        /// Время, проведённое в пространстве.
        /// </summary>
        private byte Time = 0;


        /// <summary>
        /// Объявление нового лазера.
        /// </summary>
        /// <param name="toRight">В какую сторону.</param>
        /// <param name="senderPosX">Позиция отправившего отправителя по X.</param>
        public Laser(bool toRight, int senderPosX)
        {
            ToRight = toRight;
            SenderPosX = senderPosX;
            PosX = senderPosX;
        }

        /// <summary>
        /// Контроллирует все действия, которые должны быть выполнены на каждой новой координате X.
        /// </summary>
        /// <returns>Время, проведённое в пространстве.</returns>
        public byte Main()
        {
            while (true)
            {
                //Лазер не может находится в пространстве больше 255 единиц времени, в противном случае он теряется
                if (Time != 255)
                    Step();
                else
                    return 0;

                bool isContact = Check();

                if (isContact)
                {
                    if (PosX == SenderPosX)
                        return Time;
                    else
                        ToRight = !ToRight; //Поворачиваем лазер в другую сторону.
                }
            }
        }

        /// <summary>
        /// Делает шаг в указанную сторону по X.
        /// </summary>
        private void Step()
        {
            switch (ToRight)
            {
                case true:
                    PosX++;
                    break;

                default:
                    PosX--;
                    break;
            }

            Time++;
        }

        /// <summary>
        /// Проверяет, обращаясь к Environment-у, не соприкоснулся ли лазер с чем - нибудь.
        /// </summary>
        /// <returns>Соприкоснулся с чем - нибудь или нет.</returns>
        private bool Check()
        {
            Environment environment = Environment.GetInstance();
            bool isContact = environment.CheckPlace(PosX);

            return isContact;
        }
    }
}
