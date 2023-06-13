namespace VGS.Models.Response
{
    using VGS.Models.Entities;

    public class VideoGameListResponse : BaseResponse
    {
        public List<VideoGameModel> VideoGameList { get; set; }
    }
}
