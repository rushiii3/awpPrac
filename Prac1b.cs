using System;
class Prac1b
{
	public static void Main()
	{
		string value = "Rushikesh   ";
		string value2 = "Rushi  ";
		Console.WriteLine("length of text is "+value.Length);
		Console.WriteLine("Upper case string "+value.ToUpper());
		Console.WriteLine("Lower case string "+value.ToLower());
		Console.WriteLine("Concation of string using addition operator is "+value+value2);
		Console.WriteLine("Concation of string using concat function is "+string.Concat(value,value2));
		Console.WriteLine("string comparison using equals "+string.Equals(value,value2));
		Console.WriteLine("string comparison using CompareOrdinal "+string.CompareOrdinal(value,value2));

		Console.WriteLine("string comparison using CompareTo "+value.CompareTo(value2));

		Console.WriteLine("String contains function "+value.Contains("i"));

		string value4 = string.Copy(value);
		Console.WriteLine("String copy function "+value4);
		
		//string value3 = $"heloo {value}";
 		//string message = $"Welcome to {name}";
		//Console.WriteLine("string interpolation "+value3);
		Console.WriteLine("String clone "+value.Clone());
		Console.WriteLine("String ends with function "+value.EndsWith("i"));
		Console.WriteLine("String starts with function "+value.StartsWith("R"));

		string datee = string.Format("{0:D}",DateTime.Now);
		Console.WriteLine("String format function "+datee);
		Console.WriteLine("String Index of i "+value.IndexOf("i"));

		Console.WriteLine("String Last Index of i "+value.LastIndexOf("i"));

		Console.WriteLine("String Substring "+value.Substring(1,4));
		
		Console.WriteLine("String remove "+value.Remove(4));
		
		Console.WriteLine("String trim "+value.Trim());
		char[] ch = {"R","i"};
		
		
	}
}
