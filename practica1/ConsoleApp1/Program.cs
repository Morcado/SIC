using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4;
using Antlr4.Runtime;

namespace ConsoleApp1 {
	class Program {
		static void Main(string[] args) {
			string line = ""; //input
			while (true) {
				line = Console.ReadLine();
				if (line.Contains("EXIT") || line.Contains("exit")) {
					break;
				}
				Combined1Lexer lex = new Combined1Lexer(new AntlrInputStream(line + Environment.NewLine)); //lexer con la cadena
				CommonTokenStream tokens = new CommonTokenStream(lex); //Se crean los tokens con el lexer
				Combined1Parser parser = new Combined1Parser(tokens); //Se crea el parser con los tokens

				try {
					parser.exp(); //Ejecutar analizador
				}
				catch (RecognitionException e) {
					Console.Error.WriteLine(e.StackTrace);
				}
			}
		}
	}
}
