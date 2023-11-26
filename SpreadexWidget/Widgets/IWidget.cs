namespace SpreadexWidget.Widgets
{
	public interface IWidget
    {
        int X { get; }
        int Y { get; }

        string Draw();
    }
}