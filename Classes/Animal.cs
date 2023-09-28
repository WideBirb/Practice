﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	// attributes of an Animal
	// name, sound, 
	class Animal
	{
		public string name;
		public string sound;
		static int numOfAnimals = 0;

		// constructor - same name as name of class
		public Animal()
		{	
			name = "No Name";
			sound = "No Sound";
			numOfAnimals++;
		}

		public Animal(string name = "No Name")
		{
			this.name = name;
			this.sound = "No Sound";
			numOfAnimals++;
		}

		public Animal(string name = "No Name", string sound = "No Sound") 
		{
			this.name = name;
			this.sound = sound;
			numOfAnimals++;
		}

		public void MakeSound()
		{
			Console.WriteLine("{0} says {1}", name, sound);
		}

		public static int GetNumAnimals () 
		{
			return numOfAnimals;
		} 
	}
}
