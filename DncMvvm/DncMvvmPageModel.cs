using System.ComponentModel;
using Xamarin.Forms;

namespace DncMvvm
{
	public class DncMvvmPageModel : INotifyPropertyChanged
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

		public DncMvvmPageModel()
		{
			KnockCommand = new Command(() =>
			{
				LabelText = "Who's there?";
			});
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}