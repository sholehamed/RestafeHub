using System.Text;

namespace RestafeHub.Business.Abstraction.Common
{
    public class GetParameter
    {
        public List<FilterCondition> Filter { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
        public string? Order { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Filter=");
            foreach (FilterCondition filter in Filter)
            {
                sb.Append( filter.ToString() );
                sb.Append( ',' );
            }
            sb.Remove( sb.Length-1, 1 );
            sb.Append("&");
            sb.Append($"Page={Page}&PageSize={PageSize}&Order={Order}");
            return sb.ToString();
        }
    }
    public class FilterCondition
    {
        public string Property { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        public override string ToString() => $"{Property}{Operator}{Value}";

    }

}
