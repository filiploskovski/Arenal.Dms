using Newtonsoft.Json;

namespace Arenal.Dms.Domain
{
    public class DatabaseExceptionModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
