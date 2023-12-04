using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    // <T> это тип хранимых данных
    internal class Item<T>
    {
        public T Data { get; set; } // Хранимые данные
        public Item<T> Next { get; set; } // Следующий элемент связанного списка
        public Item(T data) // Создание нового экземпляра связаного списка
        {
            if (data == null) // Проверка данных, если пустые тогда выдаем ошибку
            {
                throw new ArgumentNullException(nameof(data));
            }
            Data = data; // Если не пустые, то все хорошо
        }
        public override string ToString() //Приведение объекта к строке.
        {
            return Data.ToString();
        }
    }
}
