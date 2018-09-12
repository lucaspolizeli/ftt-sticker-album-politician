using System;
using System.Collections;
using System.Collections.Generic;

namespace AlbumFigPoliticos.Generics {

    public class LinkedList<T> : ICollection<T>, IList<T>, IEnumerable<T> {

        internal Node<T> head;
        internal int count;

        public int Count 
            => count;

        protected Node<T> First 
            => head;

        protected Node<T> Last 
            => head?.prev;

        bool ICollection<T>.IsReadOnly 
            => false;

        public T this[int index] {
            get => FindNodeAt(index).Value;
            set => FindNodeAt(index).Value = value;
        }

        public LinkedList() { }

        public LinkedList(IEnumerable<T> collection) {
            if (collection == null)
                throw new ArgumentNullException("collection");
            foreach (T item in collection) AddLast(item);
        }

        public LinkedList<T> ForEach(Action<T> action) {
            if (action == null)
                throw new ArgumentNullException("action");
            foreach (var item in this) action(item);
            return this;
        }

        void ICollection<T>.Add(T value) => AddLast(value);

        public T AddAfter(Node<T> node, T value) {
            ValidateNode(node);
            var result = new Node<T>(node.list, value);
            InternalInsertNodeBefore(node.next, result);

            return result.Value;
        }

        public void AddAfter(Node<T> node, Node<T> newNode) {
            ValidateNode(node);
            ValidateNode(newNode);
            InternalInsertNodeBefore(node.next, newNode);
            newNode.list = this;
        }

        public T AddBefore(Node<T> node, T value) {
            ValidateNode(node);
            var result = new Node<T>(node.list, value);
            InternalInsertNodeBefore(node, result);
            if (node == head) head = result;

            return result.Value;
        }

        public void AddBefore(Node<T> node, Node<T> newNode) {
            ValidateNode(node);
            ValidateNode(newNode);
            InternalInsertNodeBefore(node, newNode);
            newNode.list = this;
            if (node == head) head = newNode;
        }

        public T AddFirst(T value) {
            var result = new Node<T>(this, value);

            if (head == null) InternalInsertNodeToEmptyList(result);
            else {
                InternalInsertNodeBefore(head, result);
                head = result;
            }

            return result.Value;
        }

        public void AddFirst(Node<T> node) {
            ValidateNode(node);
            if (head == null) InternalInsertNodeToEmptyList(node);
            else {
                InternalInsertNodeBefore(head, node);
                head = node;
            }
            node.list = this;
        }

        public T Add(T value) => AddLast(value);

        public T AddLast(T value) {
            var result = new Node<T>(this, value);

            if (head == null) InternalInsertNodeToEmptyList(result);
            else InternalInsertNodeBefore(head, result);

            return result.Value;
        }

        public void AddLast(Node<T> node) {
            ValidateNode(node);
            if (head == null) InternalInsertNodeToEmptyList(node);
            else InternalInsertNodeBefore(head, node);
            node.list = this;
        }

        public void Clear() {
            var current = head;

            while (current != null) {
                var temp = current;
                current = current.Next;
                temp.Invalidate();
            }

            head = null;
            count = 0;
        }

        public bool Contains(T value) => Find(value) != null;

        public void CopyTo(T[] array, int index) {
            if (array == null)
                throw new ArgumentNullException("array");
            if (index < 0 || index > array.Length)
                throw new ArgumentOutOfRangeException($"Index {index} out of range");
            if (array.Length - index < Count)
                throw new ArgumentException("Insufficient disk space");

            var node = head;

            if (node != null) {
                do {
                    array[index++] = node.item;
                    node = node.next;
                } while (node != head);
            }
        }

        public T Find(T value) {
            var node = FindNode(value);
            return (node == null) ? default(T) : node.Value;
        }

        public Node<T> FindNode(T value) {
            var node = head;
            var c = EqualityComparer<T>.Default;

            if (node != null) {
                if (value != null) {
                    do {
                        if (c.Equals(node.item, value)) {
                            return node;
                        }
                        node = node.next;
                    } while (node != head);
                } else {
                    do {
                        if (node.item == null) {
                            return node;
                        }
                        node = node.next;
                    } while (node != head);
                }
            }
            return null;
        }

        private Node<T> FindNodeAt(int index) {
            if (index < 0 || index > count - 1)
                throw new IndexOutOfRangeException();

            var i = 0;
            var node = head;

            while (i < index) {
                i++;
                node = node.next;
            }
            return node;
        }

        public T FindLast(T value) {
            if (head == null) return default(T);

            var last = head.prev;
            var node = last;
            var c = EqualityComparer<T>.Default;

            if (node != null) {
                if (value != null) {
                    do {
                        if (c.Equals(node.item, value)) return node.Value;
                        node = node.prev;
                    } while (node != last);
                } else {
                    do {
                        if (node.item == null) return node.Value;
                        node = node.prev;
                    } while (node != last);
                }
            }

            return default(T);
        }

        public Enumerator GetEnumerator() 
            => new Enumerator(this);

        IEnumerator<T> IEnumerable<T>.GetEnumerator() 
            => GetEnumerator();

        public bool Remove(T value) {
            var node = FindNode(value);

            if (node != null) {
                InternalRemoveNode(node);
                return true;
            }

            return false;
        }

        public void Remove(Node<T> node) {
            ValidateNode(node);
            InternalRemoveNode(node);
        }

        public void RemoveFirst() {
            if (head == null)
                throw new InvalidOperationException();
            InternalRemoveNode(head);
        }

        public void RemoveLast() {
            if (head == null)
                throw new InvalidOperationException();
            InternalRemoveNode(head.prev);
        }

        private void InternalInsertNodeBefore(Node<T> node, Node<T> newNode) {
            newNode.next = node;
            newNode.prev = node.prev;
            node.prev.next = newNode;
            node.prev = newNode;
            count++;
        }

        private void InternalInsertNodeToEmptyList(Node<T> newNode) {
            newNode.next = newNode;
            newNode.prev = newNode;
            head = newNode;
            count++;
        }

        internal void InternalRemoveNode(Node<T> node) {
            if (node.next == node) head = null;
            else {
                node.next.prev = node.prev;
                node.prev.next = node.next;
                if (head == node) head = node.next;
            }
            node.Invalidate();
            count--;
        }

        internal void ValidateNode(Node<T> node) {
            if (node == null)
                throw new ArgumentNullException("node");
            if (node.List != this)
                throw new InvalidOperationException();
        }

        IEnumerator IEnumerable.GetEnumerator() 
            => GetEnumerator();

        public int IndexOf(T item) {
            for (int i = 0; i < this.Count; i++) {
                if (this[i].Equals(item)) return i;
            }
            return -1;
        }

        public void Insert(int index, T item) {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index) {
            throw new NotImplementedException();
        }

        public struct Enumerator : IEnumerator<T>, IEnumerator {
            private LinkedList<T> list;
            private Node<T> node;
            private int index;

            internal Enumerator(LinkedList<T> list) {
                this.list = list;
                node = list.head;
                Current = default(T);
                index = 0;
            }

            public T Current { get; private set; }

            object IEnumerator.Current {
                get {
                    if (index == 0 || (index == list.Count + 1)) throw new InvalidOperationException();
                    return Current;
                }
            }

            public bool MoveNext() {
                if (node == null) {
                    index = list.Count + 1;
                    return false;
                }

                ++index;
                Current = node.item;
                node = node.next;
                if (node == list.head) node = null;
                return true;
            }

            void IEnumerator.Reset() {
                Current = default(T);
                node = list.head;
                index = 0;
            }

            public void Dispose() { }
        }
    }
}
