using Berger.Extensions.Base;

namespace Berger.Extensions.Logging
{
    public class LogDetail : BaseEntity
    {
        #region Methods
        public void SetInnerException(string inner)
        {
            this.InnerException = inner;
        }
        public void SetMemberMap(string member)
        {
            this.MemberMap = member;
        }
        public void SetMessage(string message)
        {
            this.Message = message;
        }
        public void SetSource(string source)
        {
            this.Source = source;
        }
        public void SetStackTrace(string stack)
        {
            this.StackTrace = stack;
        }
        public void SetTypeMap(string type)
        {
            this.TypeMap = type;
        }
        public void SetPath(string path)
        {
            this.Path = path;
        }
        #endregion

        #region Properties
        public string InnerException { get; set; } = string.Empty;
        public string MemberMap { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string StackTrace { get; set; } = string.Empty;
        public string TypeMap { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        #endregion
    }
}