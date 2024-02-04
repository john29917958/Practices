namespace Iterator.DesignPatternList
{
    /// <summary>
    /// A linked-list for DEMO iterator pattern.
    /// </summary>
    /// <typeparam name="T">
    /// The type of object.
    /// </typeparam>
    public class DesignPatternList<T> where T : class
    {
        private Node<T> _head;

        /// <summary>
        /// Adds a new object into list.
        /// </summary>
        /// <param name="obj"></param>
        public void Add(T obj)
        {
            Node<T> newNode = new Node<T>();
            newNode.Obj = obj;

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                _head.Next = newNode;
                newNode.Prev = _head;
                _head = newNode;
            }
        }

        /// <summary>
        /// Removes an object from list.
        /// </summary>
        /// <param name="obj">
        /// The object to remove.
        /// </param>
        /// <returns>
        /// Returns true if object is removed;
        /// Returns false if object is not in list.
        /// </returns>
        public bool Remove(T obj)
        {
            if (_head == null) return false;

            Node<T> pointer = _head;

            do
            {
                if (pointer.Obj.Equals(obj))
                {
                    pointer.Prev.Next = pointer.Next;
                    return true;
                }
                else
                {
                    pointer = pointer.Prev;
                }
            } while (pointer.Prev != null);

            return false;
        }

        /// <summary>
        /// Removes all objects from the list.
        /// </summary>
        public void Clear()
        {
            _head = null;
        }

        /// <summary>
        /// Gets the iterator for traversing objects in the list.
        /// </summary>
        /// <returns>
        /// Returns an <see cref="Iterator{T}"/>.
        /// </returns>
        public Iterator<T> GetIterator()
        {
            if (_head == null) return null;

            Node<T> begin = _head;

            while (begin.Prev != null)
            {
                begin = begin.Prev;
            }

            Iterator<T> it = new Iterator<T>(begin);
            return it;
        }
    }
}