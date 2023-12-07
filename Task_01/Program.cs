namespace Sem_05 {
	public class Task_01{ 
		public static void Main (string [] args){
			int row = 5;
			int colum = 4;
			int [,] array = FillArray (row,colum);
            Console.Write ("Введите позицию строки =>");
			int itemrow = Convert.ToInt32 (Console.ReadLine());
			Console.Write ("Введите позицию столбца =>");
			int itemcolum = Convert.ToInt32 (Console.ReadLine());
			if ( itemrow < row && itemcolum < colum) Console.WriteLine ($"Элемент на позиции {itemrow};{itemcolum} => {array [itemrow, itemcolum]}");	
			else Console.WriteLine ("такого элемента нет");
			
		}
		public static int [,] FillArray   (int row, int colum){
			int [,] result = new int [row,colum];
			Random rand = new ();
			for (int i = 0; i < row; i++) {
				for (int j = 0; j < colum; j++){
				result [i, j] = rand.Next (0, 100);
				}	
			}
			return result;
		}
	}
}