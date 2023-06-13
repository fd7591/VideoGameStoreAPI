namespace VGS.Models.Request
{
    using VGS.Models.Entities;

    public class VideoGameRequest : BaseRequest
    {
        public VideoGameModel VideoGame { get; set; }
    }
}
