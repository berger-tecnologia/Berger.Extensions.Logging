namespace Berger.Extensions.Logging
{
    public class Fault
    {
        public string RequestId { get; init; }
        public string Message { get; init; }
        public List<string> Path { get; init; }
        public Dictionary<string, int> Locations { get; init; }
        public Dictionary<string, string> Extensions { get; init; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}