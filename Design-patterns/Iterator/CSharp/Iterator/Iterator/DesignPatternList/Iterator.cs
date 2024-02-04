using System;

namespace Iterator.DesignPatternList
{
    /// <summary>
    /// For traversing a list of objects.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the objects.
    /// </typeparam>
    public class Iterator<T>
    {
        /// <summary>
        /// Handles the traversed object.
        /// </summary>
        /// <param name="obj">
        /// The traversed object.
        /// </param>
        public delegate void OnEachHandler(T obj);

        /// <summary>
        /// Checks if any object to be traversed next.
        /// </summary>
        public bool HasNext
        {
            get
            {
                return _head.Next != null;
            }
        }

        private readonly Node<T> _begin;
        private Node<T> _head;

        /// <summary>
        /// Creates a iterator instance.
        /// </summary>
        /// <param name="begin">
        /// The beginning of a list of objects.
        /// </param>
        public Iterator(Node<T> begin)
        {
            _begin = begin;
            _head = begin;
        }

        /// <summary>
        /// Traverses to first object in the list.
        /// </summary>
        /// <returns>
        /// Returns the first object in the list.
        /// </returns>
        public T First()
        {
            _head = _begin;
            return _begin.Obj;
        }

        /// <summary>
        /// Gets the current object which iterator points to.
        /// </summary>
        /// <returns>
        /// Returns the current object which iterator points to.
        /// </returns>
        public T Get()
        {
            return _head.Obj;
        }

        /// <summary>
        /// Traverses to next object in the list.
        /// </summary>
        /// <returns>
        /// Returns the next object in the list.
        /// </returns>
        public T Next()
        {
            if (HasNext)
            {
                _head = _head.Next;
                return _head.Obj;
            }
            else
            {
                throw new IndexOutOfRangeException("No more object in list.");
            }
        }

        /// <summary>
        /// Traverses through all objects in the list.
        /// </summary>
        /// <param name="handler">
        /// The call back to handle each traversed object.
        /// </param>
        public void OnEach(OnEachHandler handler)
        {
            Node<T> it = _begin;

            do
            {
                handler.Invoke(it.Obj);
                it = it.Next;
            } while (it != null);
        }
    }
}