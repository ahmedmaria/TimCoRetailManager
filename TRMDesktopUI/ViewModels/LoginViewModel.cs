using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDesktopUI.Helpers;

namespace TRMDesktopUI.ViewModels
{
   public class LoginViewModel : Screen
    {
		private string _userName;
		private string _password;
		private IAPIHelper _apiHelper;
		public LoginViewModel(IAPIHelper apiHelper)
		{
			_apiHelper = apiHelper;

		}
		public string UserName
		{
			get { return _userName; }
			set
			{ 
				_userName = value;
				NotifyOfPropertyChange(() => UserName);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}

		

		public string Password // caliburn micro support for passwordbox https://stackoverflow.com/questions/30631522/caliburn-micro-support-for-passwordbox
		{
			get { return _password; }
			set
			{ 
				_password = value;
				NotifyOfPropertyChange(() => Password);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}
		

		public bool IsErrorVisible
		{

			get {
				bool output = false;
				if (ErrorMessage?.Length > 0) 
				{ output = true; }
				return output;
					}
			
		}
		private string _errorMessageVar;

		public string ErrorMessage
		{
			get { return _errorMessageVar; }
			set {
				_errorMessageVar = value;
				NotifyOfPropertyChange(() => ErrorMessage);
				NotifyOfPropertyChange(() => IsErrorVisible);

			}
		}

		public bool CanLogIn
		{
			get
			{

				bool output = false;
				if (UserName?.Length > 0 && Password?.Length > 0)
				{
					output = true;
				}

				return output;

			}
			
		
		} 

		public async Task LogIn()
		{
			try
			{
				ErrorMessage = "";
				var result = await _apiHelper.Authenticate(UserName, Password);
			}
			catch (Exception ex)
			{

				ErrorMessage = ex.Message;
			}
		}

	}
}
