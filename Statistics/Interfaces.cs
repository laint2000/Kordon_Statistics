namespace Statistics
{
    public interface IHTTPConnector
    {
        event System.Action<string> OnLoadStringComplete;

        string LoadString(string url);
    }
}