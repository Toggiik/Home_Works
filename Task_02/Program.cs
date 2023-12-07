/*Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.*/
namespace Sem_05 {
	public class Task_01{ 
		public static void Main (string [] args){
			int row = 5;
			int colum = 4;
			int [,] array = FillArray (row,colum);
            for ( int i = 0; i < row; i++){
				for (int j = 0; j < colum; j++){
					Console.Write (array [i,j] + "    ");
				}
				Console.WriteLine();
            }
            Console.WriteLine("Новый массив");
			int [] result = new int[colum];
			for (int i = 0; i < colum; i++){
				result [i] = array [0,i];
			}
			array = ChangeFirstAndLast (array, result, row);
			for ( int i = 0; i < row; i++){
				for (int j = 0; j < colum; j++){
					Console.Write (array [i,j] + "    ");
				}
				Console.WriteLine();	
			}
		}
		public static int [,] FillArray  (int row, int colum){
			int [,] result = new int [row,colum];
			Random rand = new ();
			for (int i = 0; i < row; i++) {
				for (int j = 0; j < colum; j++){
				result [i, j] = rand.Next (0, 100);
				}	
			}
			return result;
		}
		public static int [,] ChangeFirstAndLast  (int [,] array, int [] result , int row){
			int sizecolum = result.Length;
			for (int i = 0; i < sizecolum; i++){
				array [0,i] = array [row-1, i];
				array [row-1, i] = result[i];  
			}
			return array;
		}
	}
}
