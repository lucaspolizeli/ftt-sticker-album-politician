namespace AlbumFigPoliticos.Generics {

    public sealed class Node<T> {
        internal LinkedList<T> list;
        internal Node<T> next;
        internal Node<T> prev;
        internal T item;

        public Node(T value) {
            this.item = value;
        }

        internal Node(LinkedList<T> list, T value) {
            this.list = list;
            this.item = value;
        }

        public LinkedList<T> List {
            get { return list; }
        }

        public Node<T> Next {
            get { return next == null || next == list.head ? null : next; }
        }

        public Node<T> Previous {
            get { return prev == null || this == list.head ? null : prev; }
        }

        public T Value {
            get { return item; }
            set { item = value; }
        }

        internal void Invalidate() {
            list = null;
            next = null;
            prev = null;
        }
    }
}
