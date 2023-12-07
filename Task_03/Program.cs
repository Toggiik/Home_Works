/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
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
			int result = MinSumRow (array, row, colum);
			Console.WriteLine(result);	
			
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
		public static int MinSumRow  (int [,] array, int row, int colum){
		 	int result=0;
			int minsum = 0;
            bool flag = true;
			for (int i = 0; i < row; i++){
				for ( int j=0; j < colum; j++) {
					minsum = minsum + array [i,j]; 
				}
                if (flag) {
                    result = minsum;
                    flag = false;
                }
				if ( minsum < result ) result = minsum ;
				minsum = 0;
			}
			return result;
		}

	}
}