using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
		private static string _Username, _Password, _email;
		private static UserRoles _currentUserRole;
		public static string Username
		{
			get
            {
				return _Username;
            }
		}

		public delegate void ActionOnError(string error);

		private ActionOnError _onError;

		public LoginValidation(string Username, string Password, ActionOnError error)
		{
			_Username = Username;
			_Password = Password;
			_onError = error;
		}

		public static UserRoles currentUserRole
		{
			get;
			private set;
		}

		public static UserRoles getRole()
		{
			return _currentUserRole;
		}


		public bool validateUserInput(ref User user)
		{
			string errorMessage;

			if (_Username.Equals(null) || _Password.Equals(null))
			{
				user.Role = UserRoles.ANONYMOUS;
				_onError("Null username or password");
				return false;
			}
			else if (IsStringEmpty(_Username) || IsStringEmpty(_Username))
			{
				user.Role = UserRoles.ANONYMOUS;
				_onError("Empty username or password");
				return false;
			}
			else if (IsStringLessThan5(_Username) || IsStringLessThan5(_Username))
			{
				user.Role = UserRoles.ANONYMOUS;
				_onError("Short username or password");
				return false;
			}

			user = UserData.IsUserPassCorrect(_Username, _Password);

			if (user == null)
			{
				errorMessage = "No user";
				_onError(errorMessage);
				return false;
			}
			_currentUserRole = user.Role;
			Logger.LogActivity("Succesfull Login");
			return true;
		}



		private static bool IsStringEmpty(string word)
		{
			return word.Equals(String.Empty);
		}

		private static bool IsStringLessThan5(string word)
		{
			return word.Length < 5;
		}

		public LoginValidation()
		{
		}
	}
}
