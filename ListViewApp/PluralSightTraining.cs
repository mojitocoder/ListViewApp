using System;
using System.Collections.Generic;

namespace ListViewApp
{
	public class PluralSightTraining
	{
		public List<Course> GetAllCourses()
		{
			var list = new List<Course>();

			list.Add(new Course { Name = "Introduction to Autodesk Factory Design Utilities", Author = "Nathan Aliason" });
			list.Add(new Course { Name = "Overcoming Common Android Performance Barriers", Author = "Omri Erez" });
			list.Add(new Course { Name = "Building Your First Android Database Application with SQLite", Author = "Simone Alessandria" });
			list.Add(new Course { Name = "Implementing High Availability in Windows Server 2016", Author = "Greg Shields" });
			list.Add(new Course { Name = "Audition CC Fundamentals", Author = "Thomas Winkley" });
			list.Add(new Course { Name = "JavaScript Asynchronous Module Definition (AMD) Explained", Author = "Kevin Murray" });
			list.Add(new Course { Name = "Product Owner Fundamentals - Foundations of Product Ownership", Author = "Jeremy Jarrell" });
			list.Add(new Course { Name = "Building a Global App with Azure PaaS", Author = "Barry Luijbregts" });
			list.Add(new Course { Name = "Network Vulnerability Scanning with OpenVAS", Author = "David Clinton" });
			list.Add(new Course { Name = "Enhancing Application Communication with gRPC", Author = "Mike Van Sickle" });

			return list;
		}
	}
}
