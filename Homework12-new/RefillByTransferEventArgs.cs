using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_Homework12
{


    public class RefillByTransferEventArgs : EventArgs
    {
        #region  Свойства
        /// <summary>
        /// сумма перевода
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        /// Дата и время операции
        /// </summary>
        public DateTime Dt { get; set; }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Dt">Дата и время операции</param>
        /// <param name="Sum">сумма перевода</param>
        public RefillByTransferEventArgs(DateTime Dt, decimal Sum)
        {
            this.Sum = Sum;
            this.Dt = Dt;
        }
        #endregion


    }
}
