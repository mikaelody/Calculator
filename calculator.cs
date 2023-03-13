class Calculator{
	static void Main(String[] args){
		int a = 16;
		int b = 10;
		
		Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, penambahan(a,b));
		Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, penngurangan(a,b));
		Console.WriteLine("\n Tekan sembarang key untuk keluar");
		Console.ReadKey();
		}
	
	static int penambahan (int a, int b){
		return a + b;
	}
	static int penngurangan (int a, int b){
		return a - b;
	}
}