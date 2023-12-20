using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Sortware
    {
        /// <summary>
        /// Поле, описывающий названия
        /// </summary>
        string name;
        /// <summary>
        /// Поле, описывающий производителя
        /// </summary>
        string manufacturer;
        /// <summary>
        /// Поле, описывающий платное П.О
        /// </summary>
        int paid;
        /// <summary>
        /// Поле, описывающий бесплатное П.О
        /// </summary>
        string free;

        /// <summary>
        /// Свойства поля name
        /// </summary>
        public string Name
         { 
        get {return name;}
        set {name=value;}
         }
        /// <summary>
        /// Свойства поля manufacturer
        /// </summary>
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        /// <summary>
        /// Свойства поля paid
        /// </summary>
        public int Paid
        {
            get { return paid; }
            set { paid= value; }
        }
        /// <summary>
        /// Свойства поля free
        /// </summary>
        public string Free
        {
            get { return free; }
            set { free = value; }
        }
        public Sortware(string name, string manufacturer, string free)

        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Free = free;
        }
        public Sortware(string name, string manufacturer, int paid)

        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Paid = paid;
        }
        public Sortware(string name, string manufacturer, int paid, string free)

        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Paid = paid;
            this.Free = free;
        }
        /// <summary>
        /// Метод вывода информации о Програмнном обеспечении
        /// </summary>
        /// <returns></returns>
        public string ShowInfo()
        {
            return $"Названия - {name}\nпроизводитель - {manufacturer}\n Платное - {paid}\n Бесплатное - {free}";
        }
    }
}
