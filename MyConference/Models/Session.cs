using CommunityToolkit.Mvvm.ComponentModel;

namespace MyConference.Models
{
    public partial class Session : ObservableObject
    {
        // Static
        public int Id { get; set; }
        public string Title { get; set; }
        public string Room { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StartTimeDisplay => $"{Start:t}";
        public string DayDisplay => $"{Start:MMM} {Start:d}";
        public Speaker Speaker { get; set; } = new Speaker
        {
            Name = "Mike Ramsey",
            Company = "Ramrod, Inc.",
            Description = "Web Developer, Gamer, Xbox Ambassador, Avid technology geek, Industrial/EBM music lover, Beer fan, and all around good guy. diehard Flyers fan!!",
            Title = "CEO"
        };

        //Dynamic
        [ObservableProperty]
        bool inAgenda;
    }
}
