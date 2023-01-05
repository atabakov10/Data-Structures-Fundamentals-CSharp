namespace Problem04.SinglyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SinglyLinkedList<T> : IAbstractLinkedList<T>
    {
        private class Node
        {
            public T Element { get; set; }
            public Node Next { get; set; }

            public Node(T element, Node next)
            {
                this.Element = element;
                this.Next = next;
            }

            public Node(T element)
            {
                this.Element = element;
            }
        }

        private Node head;
        
        public int Count { get; set; }

        public void AddFirst(T item)
        {
            var node = new Node(item, head);
            this.head = node;
            this.Count++;
        }

        public void AddLast(T item)
        {
            var newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var node = head;
                while (node.Next != null)
                {
                    node = node.Next;
                }

                node.Next = newNode;
            }

            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = head;

            while (node != null)
            {
                yield return node.Element;
                node = node.Next;
            }
        }

        public T GetFirst()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }

            return this.head.Element;
        }

        public T GetLast()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }
            
            var node = this.head;
            
            while (node.Next != null)
            {
                node = node.Next;
            }

            return node.Element;
        }

        public T RemoveFirst()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }

            var oldHead = head;
            this.head = oldHead.Next;
            
            this.Count--;
            return oldHead.Element;
        }

        public T RemoveLast()
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            if (Count == 1)
            {
                head = null;
            }
            var node = head;
            while (node.Next.Next != null)
            {
                node = node.Next;
            }


            Count--;
            return node.Next.Element;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}