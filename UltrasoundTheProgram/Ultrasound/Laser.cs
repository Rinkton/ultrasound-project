using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private byte Time;


        /// <summary>
        /// Объявление нового лазера.
        /// </summary>
        /// <param name="toRight">В какую сторону.</param>
        /// <param name="senderPosX">Позиция отправившего отправителя по X.</param>
        public Laser(bool toRight, int senderPosX) { }

        /// <summary>
        /// Контроллирует все действия, которые должны быть выполнены на каждой новой координате X.
        /// </summary>
        /// <returns>Время, проведённое в пространстве.</returns>
        private byte Main()
        {
            return 0;
        }

        /// <summary>
        /// Делает шаг в указанную сторону по X.
        /// </summary>
        private void Step() { }

        /// <summary>
        /// Проверяет, обращаясь к Environment-у, не соприкоснулся ли лазер с чем - нибудь.
        /// </summary>
        /// <returns>Соприкоснулся с чем - нибудь или нет.</returns>
        private bool Check()
        {
            return false;
        }
    }
}
