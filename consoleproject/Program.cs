using System;
using Microsoft;

namespace hello{

	class test{
		
		static void Main(string[] args){
			Console.WriteLine("This is weird");
			Console.WriteLine(System.PlatformID.MacOSX.ToString());
			Console.WriteLine(System.PlatformID.Xbox.GetType());
			if (1 == 1){
				Console.WriteLine(Microsoft.Win32.RegistryView.Registry64.GetHashCode());
			}
		}
	}
}
	