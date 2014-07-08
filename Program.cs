using System;

namespace StringResxDesignerGenerator
{
	class MainClass
	{
		public static int Main(string[] args)
		{
			if (args == null || args.Length < 4)
			{
				Console.WriteLine("Usage: ");
				Console.WriteLine(" StringResxDesignerGenerator <resxfile> <namespace> <classname> <outputfile>");
				return 1;
			}
			
			StringResXFileCodeGenerator.GenerateDesignerFile(args[0], args[1], args[2], args[3]);
			return 0;
		}
	}
}
