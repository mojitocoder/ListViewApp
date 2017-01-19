using System;
namespace ListViewApp
{
	public class Course
	{
		public Course()
		{
		}

		public string Name
		{
			get;
			set;
		}

		public string Author
		{
			get;
			set;
		}

		public override String ToString()
		{
			return $"{Author}: {Name}";
		}
	}
}
