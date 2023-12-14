/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
*/


namespace Sem_07 {
	public class Task_01{ 
		public static void Main (string [] args){
			int m = Convert.ToInt32 (Console.ReadLine()); 
			int n = Convert.ToInt32 (Console.ReadLine()); 
			if (m<n) OutPut (m, n);
			else if (n<m) OutPut (n, m);
		}
		public static void OutPut (int min, int max){ 
			if (min < max) {
				OutPut (min+1, max);
				Console.WriteLine (min);	
			}
			return;	
		}
	}
}