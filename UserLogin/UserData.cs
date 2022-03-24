using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
		private static List<User> _testUsers = new List<User>();

		public static List<User> testUsers
		{
			get
			{
				resetUserData();
				return _testUsers;
			}

			set { }
		}
		public static void resetUserData()
		{
			if (!_testUsers.Any())
			{
				_testUsers.Add(FillUser(UserRoles.ADMIN));

				for (short i = 1; i < 2; i++)
				{
					_testUsers.Add(FillUser(UserRoles.STUDENT));
				}
			}
		}

		public static User IsUserPassCorrect(string Username, string Password)
		{
			User user = (from account in testUsers where account.Username.Equals(Username, StringComparison.Ordinal) && account.Password.Equals(Password, StringComparison.Ordinal) select account).FirstOrDefault();

			return user;
		}

		public static User getUserByUsername(string Username)
		{
			foreach (User user in testUsers)
			{
				if (Username.Equals(user.Username, StringComparison.Ordinal))
				{
					return user;
				}
			}
			return null;
		}
		private static User FillUser(UserRoles role)
		{
			User user = new User();
			Console.WriteLine("Enter you username: ");
			user.Username = Console.ReadLine();
			Console.WriteLine("Enter your password");
			user.Password = Console.ReadLine();
			Console.WriteLine("Enter your faculty number:");
			user.FacNum = Console.ReadLine();
			user.Role = role;
			user.Created = DateTime.MaxValue;
			return user;
		}

		public static void SetUserActiveTo(string Username, DateTime date)
		{
			foreach (User user in testUsers)
			{
				if (Username.Equals(user.Username, StringComparison.Ordinal))
				{
					Logger.LogActivity("Change the activity of " + Username);
					user.Created = date;
					break;
				}
			}
		}

		public static void seeAllUsers()
		{
			foreach (User user in _testUsers)
			{
				Console.WriteLine(user.Username);
			}
		}

		public static void AssignUserRole(string Username, UserRoles role)
		{
			foreach (User user in testUsers)
			{
				if (Username.Equals(user.Username))
				{
					Logger.LogActivity("Changing the role of " + Username);
					user.Role = role;
					break;
				}
			}
		}

		public static void PrepareCertificate()
		{
			StringBuilder certificateBuffer = new StringBuilder();
			certificateBuffer.AppendLine("CERTIFICATE");
			certificateBuffer.AppendLine();
			certificateBuffer.AppendLine("This certificate is evidence for graduating the following course and year for the following student");
			Console.WriteLine("Username of the student:");
			User user = getUserByUsername(Console.ReadLine());
			if (user == null)
			{
				Console.WriteLine("No such user");
				return;
			}
			certificateBuffer.AppendLine("Name: " + user.Username);
			certificateBuffer.AppendLine("Faculty number: " + user.FacNum);
			Console.WriteLine("Speciality for student");
			certificateBuffer.AppendLine("Graduated specialty: " + Console.ReadLine());
			Console.WriteLine("Course of the student");
			certificateBuffer.AppendLine("Course: " + Console.ReadLine());
			certificateBuffer.AppendLine();
			certificateBuffer.AppendLine("CERTIFICATE");
			while (true)
			{
				Console.WriteLine("File name with exstension, e.g file.txt");
				string filename = Console.ReadLine();
				if ((filename == null) || !filename.Contains(".txt"))
				{
					Console.WriteLine("Invalid file");
				}
				else
				{

					SaveCertificate(certificateBuffer.ToString(), filename);
					break;
				}
			}

		}

		private static void SaveCertificate(string Certificate, string FileName)
		{
			if (File.Exists(FileName))
			{
				Thread.Sleep(1000);
				File.AppendAllText(FileName, Certificate);
			}
			else
			{
				FileStream file = File.Create(FileName);
				StreamWriter writer = new StreamWriter(file);
				writer.WriteLine(Certificate);
				writer.Close();
				file.Close();
			}
		}
	}
}
