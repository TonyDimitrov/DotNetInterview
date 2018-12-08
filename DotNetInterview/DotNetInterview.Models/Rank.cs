
namespace DotNetInterview.Models
{
    public class Rank : BaseEntity<string>
    {
        public int Ranking { get; set; }

        public string UserId { get; set; }

        public DNIUser User { get; set; }

        public string QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
