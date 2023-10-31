using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_Homework12
{


    public class BillTransferEventArgs : EventArgs
    {
        #region  Свойства
        /// <summary>
        /// сумма перевода
        /// </summary>
        public decimal Sum { get; private set; }

        /// <summary>
        /// Дата и время операции
        /// </summary>
        public DateTime Dt { get; private set; }

        ///// <summary>
        ///// Id счета получателя
        ///// </summary>
        //public int BillIdTo { get; private set; }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="BillIdTo">Id счета получателя</param>
        /// <param name="Dt">Дата и время операции</param>
        /// <param name="Sum">сумма перевода</param>
        public BillTransferEventArgs(/*int BillIdTo,*/ DateTime Dt, decimal Sum)
        {
            this.Sum = Sum;
            this.Dt = Dt;
            //this.BillIdTo = BillIdTo;
        }
        #endregion


    }
}
