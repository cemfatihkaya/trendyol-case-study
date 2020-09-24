namespace TrendyolCaseStudy.Business
{
    public class BaseService
    {
        public string SetMethodNameForMessage(string methodName)
        {
            return $"{GetType().Name}.{methodName}";
        }
    }
}