using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
	public class DynamicArray<T> : IEnumerable<T> 
	{
		

		T[] arreay = new T[5];

		int size;


        public T[] Length { get => Length; set => Length = value; }//8

        public T[] Capacity { get => Capacity; }//9     

		public DynamicArray()//1
		{
			arreay = new T[8];
			size = 8;
		}

		public DynamicArray(int capacity)//2
		{
			arreay = new T[capacity];
			size = capacity;
		}
        
		public DynamicArray(T[] newArrey)//3
		{
			arreay = newArrey;
		}


		public void Add(T item) //4
        {
            EnsureCapacity(size + 1);

			arreay[size] = item;
            size++;
        }

		public void AddRange(T[] arr)//5
		{
			
				T[] newArrey = new T[arreay.Length + arr.Length];
				for (int i = 0; i < arreay.Length; i++)
				{
					newArrey[i] = arreay[i];
				}
				for (int i = arreay.Length; i < arr.Length; i++)
				{
					newArrey[i] = arr[i];
				}

		}

		public void Remove(T item)//6
        {
			var index = Array.IndexOf(arreay, item, 0, size);
            if (index < 0)
			{
				return;  
            }

            for (var i = index; i < size - 1; i++)
				arreay[i] = arreay[i + 1];         
            size--;
        }

		public void Insert(int index, T item)//7
        {
            if (index < 0 || index >= size)
			{
				throw new IndexOutOfRangeException($"Index: {index}, Size: {size}");
			}
                     
            EnsureCapacity(size + 1);

            for (var i = size; i > index; i--)
			{
				arreay[i] = arreay[i - 1];            
			}

			arreay[index] = item;
            size++;
        }
         
        
		public T this[int index] //10
		{
			get
			{
				if (index  < 0 || index >= size)
				{
					throw new IndexOutOfRangeException();
                }
				return arreay[index];
			}

			set
			{
				if (index < 0 || index >= size)
				{
					throw new IndexOutOfRangeException();
				}
				arreay[index] = value;
			}
		}


		void EnsureCapacity(int capacity)
        {
			if (arreay.Length < capacity)
            {
                var arr = new T[capacity];
				Array.Copy(arreay, arr, size);
				arreay = arr;
            }
        }

		public void ExtandArray()
        {
			T[] newArray = new T[size * 2];
            CopyArray(newArray);
        }

        public void ExtandArray(int lengthSecondArray)
        {
            T[] newArray = new T[size + lengthSecondArray];
            CopyArray(newArray);
        }

        public void CopyArray(T[] extArr)
        {
			for (int i = 0; i < arreay.Length; i++)
            {
				extArr[i] = arreay[i];
            }
			arreay = extArr;
        }

        public IEnumerator<T> GetEnumerator()
        {
			for (int i = 0; i < size; i++)
            {
				yield return arreay[i];
            }
        }

       
		IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return arreay.GetEnumerator();
		}

		public DynamicArray(IEnumerable<T> collection)
        {
			arreay = collection.ToArray();
			size = collection.Count();
        }
	}
}
