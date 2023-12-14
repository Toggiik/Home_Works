
/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы. */

using System.Diagnostics;

namespace Sem_07 {
	public class Task_03{ 
		public static void Main (string [] args){
			int size = 5;
			int [] array = FillArray (size);
			foreach (int Item in array){
				Console.Write (Item + ", ");
			}
			Console.WriteLine ();
			OutPut (array,  size);
			
		}
		public static int [] FillArray  (int size){
			int [] result = new int [size];
			Random rand = new ();
			for (int i = 0; i < size; i++) {
				result [i] = rand.Next (0, 100);	
			}
			return result;
		}
		public static void OutPut (int [] array, int size){ 
			if (size > 0) { 
				size = size - 1; 
				Console.Write (array [size] + ", ");
				OutPut (array, size);
				
			}
			return;
		}
	}
}