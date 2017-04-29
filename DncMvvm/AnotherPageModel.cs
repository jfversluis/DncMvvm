using FreshMvvm;

namespace DncMvvm
{
	public class AnotherPageModel : FreshBasePageModel
	{
		public string AnotherLabelText { get; set; } = "Hi! I'm another page!";

		public override void Init(object initData)
		{
			var stringValue = initData as string;

			if (string.IsNullOrWhiteSpace(stringValue))
				return;

			AnotherLabelText = stringValue;
		}
	}
}