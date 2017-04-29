using System.ComponentModel;
using FreshMvvm;
using Xamarin.Forms;

namespace DncMvvm
{
	public class DncMvvmPageModel : FreshBasePageModel, INotifyPropertyChanged
	{
		private string _labelText;
		public string LabelText
		{
			get
			{
				return _labelText;
			}
			set
			{
				_labelText = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LabelText)));
			}
		}

		public Command KnockCommand { get; }
		public Command NavigateCommand { get; }

		public DncMvvmPageModel()
		{
			KnockCommand = new Command(() =>
			{
				LabelText = "Who's there?";
			});

			NavigateCommand = new Command(() =>
			{
				CoreMethods.PushPageModel<AnotherPageModel>("Another PageModel by navigation");
			});
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}