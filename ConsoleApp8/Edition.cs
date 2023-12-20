using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /// <summary>
    /// Класс, описывающий Издание
    /// </summary>

    class Edition
    {
        /// <summary>
        /// Поле, описывающий названия
        /// </summary>
        string name;
        /// <summary>
        /// Поле, описывающий Фамилия автора
        /// </summary>
        string surname;
        /// <summary>
        /// Поле, описывающий 
        /// </summary>
        int yearpublising;

        /// <summary>
        /// Свойства поля name
        /// </summary>
        public string Name
        { 
        get {return name;}
        set {name=value;}
         }
          /// <summary>
         /// Свойства поля surname
        /// </summary>
        public string Surname
        { 
        get {return surname;}
        set {surname=value;}
        }
        /// <summary>
        /// Свойства поля yearpublising;
        /// </summary>
        public int Yearpublising
        {
            get { return yearpublising; }
            set { yearpublising = value; }
        }
        public Edition()
        {

        }
        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="yearpublising"></param>

        public Edition(string name, string surname)

        {
            this.Name = name;
            this.Surname = surname;
        }
        public Edition(string name, string surname, int yearpublising)
 
        {
        this.Name = name;
        this.Surname = surname;
        this.Yearpublising = yearpublising;
        }
        /// <summary>
        /// Метод вывода информации о Издании
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return $"Названия издавния - {name}\nФамилия издателя - {surname}\nГод издания - {yearpublising}";
        }

    }
}
