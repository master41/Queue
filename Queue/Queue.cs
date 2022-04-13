using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Queue<T>:IEnumerable<T>
    {
        // Посидання на найстаріший вузол.
        private Node<T> first;
        // Посидання на найсвіжіший вузол.
        private Node<T> last;
        // Кількість елементів у черзі.
        private int count;

        public bool IsEmpty { get => first == null; }
        public int Count { get => count; }

        // Додавання нового елемента у кінець зв'язного списку.
        public void Enqueue(T component)
        {
            // Збереження посилання на кінцевий вузол.
            Node<T> oldlast = last;
            // Створення нового кінцевого вузла.
            last = new Node<T>();
            last.item = component;
            last.next = null;
            // Початок і кінець списку вказують на єдиний елемент.
            if (IsEmpty)
            { first = last; }
            else
            // Прив'язка нового вузла до кінця списку.
            { oldlast.next = last; }
            count++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
            { throw new InvalidOperationException("Черга порожня."); }
            // Видалення елементу із початку списку.
            T component = first.item;
            first = first.next;
            count--;
            if (IsEmpty)
            { last = null; }
            return component;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = first;
            while (current != null)
            {
                yield return current.item;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
