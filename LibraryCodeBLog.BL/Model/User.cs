using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCodeBLog.BL.Model
{
    [Serializable]
    public class User
    {
        #region набор свойств
        /// <summary>
        /// имя пользователя
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        
        public double Height { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get { return DateTime.Now.Year - BirthDay.Year; } }
        #endregion
        /// <summary>
        /// Создание пользователя.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="birthDate">День рождения.</param>
        /// <param name="weight">Вес.</param>
        /// <param name="height">Рост.</param>


        public User(string name,
            Gender gender,
            DateTime birthDate,
            double weight,
            double height)
        {
            #region проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));
            }
            if (gender is null)
            {
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));

            }
            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения.", nameof(birthDate));
            }
            if (weight <= 0)
            {
                throw new ArgumentException("Вес не иожет быть меньше либо равен нуля.", nameof(weight));

            }
            if (height <= 0)
            {
                throw new ArgumentException("Рост не иожет быть меньше либо равен нуля.", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDay = birthDate;
            Weight = weight;
            Height = height;
        }
        public User (string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
