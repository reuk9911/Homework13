using Newtonsoft.Json;
using Skillbox_Homework12;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework12_new
{
    public class ActionLog
    {
        #region Поля и свойства
        /// <summary>
        /// Лист с логами транзакций
        /// </summary>
        public List<string> Logs { get; private set; }
        #endregion

        #region Конструкторы
        public ActionLog()
        {
            this.Logs = new List<string>();
        }

        #endregion

        #region Методы
        public void OnOpenCloseBill(Object Sender, BillOpenCloseEventArgs Args)
        {
            if (Args.Type == OperationTypeEnum.Open)
                Logs.Add(Args.Dt.ToShortTimeString() + " " + ((Client)Sender).Name + " открыл счет " + Args.BillId);
            else
                Logs.Add(Args.Dt.ToShortTimeString() + " " +  ((Client)Sender).Name + " открыл счет " + Args.BillId);

        }

        public void OnBillDeposit(Object Sender, BillDepositEventArgs Args)
        {
            Logs.Add("Клиент " + ((Client)Sender).Name + " пополнил счет id = " + Args.BillId + "на " + Args.Sum);
        }

        public void OnTransfer(Object Sender, BillTransferEventArgs Args)
        {
            Logs.Add("Клиент " + ((Client)Sender).Name + " перевел " + Args.Sum);
        }

        public bool DeserializeJson(string LogPath)
        {
            if  (!File.Exists(LogPath))
            {
                return false;
            }
            string json = File.ReadAllText(LogPath);

            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            Logs = JsonConvert.DeserializeObject<List<string>>(json, serializerSettings);
            return true;
        }

        public void SerializeJson(string LogPath)
        {

            JsonSerializerSettings serializeSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string json = JsonConvert.SerializeObject(Logs, Formatting.Indented, serializeSettings);
            File.WriteAllText(LogPath, json);

        }

        #endregion

        #region Обработчики событий
        #endregion
    }
}
