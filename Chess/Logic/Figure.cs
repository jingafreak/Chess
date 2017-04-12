﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Logic
{
	class Figure
	{
		#region Attributes

		public Uri Image { get; set; }
		public string Name { get; set; }
		public GameColor Color { get; set; }
		public int? X { get; set; }
		public int? Y { get; set; }

		#endregion

		#region Constructors

		public Figure() : this(null, null, GameColor.None, null, null) { }

		public Figure(string Name) : this(null, Name, GameColor.None, null, null) { }

		public Figure(int X, int Y) : this(null, null, GameColor.None, X, Y) { }

		public Figure(Uri Image, string Name, GameColor Color, int? X, int? Y)
		{
			this.Image = Image;
			this.Name = Name;
			this.Color = Color;
			this.X = X;
			this.Y = Y;
		}

		#endregion
	}
}
