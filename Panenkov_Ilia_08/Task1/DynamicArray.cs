using System;
using System.Collections.Generic;

namespace Task1
{
	public class DynamicArray<T> 
	{

		T[] arreay = new T[5];

		int size; //фактическая длинна

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
			size = arreay.Length;
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

		public bool Remove(T item)//6
        {
			var index = Array.IndexOf(arreay, item, 0, size);
            if (index < 0)
			{
				return false;  
            }

            for (var i = index; i < size - 1; i++)
				arreay[i] = arreay[i + 1];         
            size--;
			return true;
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

		public override string ToString()
        {
			string str = null;

			for (int i = 0; i < size; i++)
			{
				str = str + Convert.ToString(arreay[i]);
			}
			return str;

        }

	}
}
