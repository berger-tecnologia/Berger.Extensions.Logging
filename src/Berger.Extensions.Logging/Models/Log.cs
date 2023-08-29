using Berger.Extensions.Base;

namespace Berger.Extensions.Logging
{
    public class Log : BaseInput
    {
        #region Methods
        public void SetDetail()
        {
            LogDetail = new LogDetail();
        }
        public void SetType(LogType logType)
        {
            this.LogType = logType;
        }
        public void SetCode(string code)
        {
            this.Code = code;
        }
        public void SetQuery(string query)
        {
            this.Query = query;
        }
        public void SetExtensions(Dictionary<string, string> extensions)
        {
            Extensions = extensions;
        }
        public void SetLocations(Dictionary<string, int> locations)
        {
            Locations = locations;
        }
        public void SetMessage(string message)
        {
            Message = message;
        }
        #endregion

        #region Properties
        public Guid? BatchID { get; set; }
        public string Code { get; set; }
        public string Query { get; set; }
        public string Message { get; set; }
        public Dictionary<string, int> Locations { get; set; }
        public Dictionary<string, string> Extensions { get; set; }
        public LogType LogType { get; set; }
        public LogDetail LogDetail { get; set; } = null!;
        #endregion
    }
}