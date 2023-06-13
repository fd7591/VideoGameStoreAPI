namespace VGS.Models.Response
{
    using VGS.Models.Entities;

    public class VideoGameResponse : BaseResponse
    {
        public VideoGameModel VideoGame { get; set; }
    }
}
