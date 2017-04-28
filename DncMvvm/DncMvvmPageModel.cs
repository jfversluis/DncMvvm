using Xamarin.Forms;

namespace DncMvvm
{
	public class DncMvvmPageModel
	{
		public string LabelText { get; set; }

		public Command KnockCommand { get; }

		public DncMvvmPageModel()
		{
			KnockCommand = new Command(() => {
				LabelText = "Who's there?";
			});
		}
	}
}