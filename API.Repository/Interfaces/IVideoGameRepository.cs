namespace API.Repositories.Interfaces
{
    using VGS.Models.Request;
    using VGS.Models.Response;

    public interface IVideoGameRepositories
    {
        /// <summary>
        /// Get all active video games
        /// </summary>
        /// <returns></returns>
        Task<VideoGameListResponse> GetAllVideoGames();

        /// <summary>
        /// Get video game by Id
        /// </summary>
        /// <returns></returns>
        Task<VideoGameResponse> GetVideoGameById(VideoGameByIdRequest request);

        /// <summary>
        /// Insert a new video game in database
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<VideoGameResponse> PostVideoGame(VideoGameRequest request);

        /// <summary>
        /// Save edit of video game
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<VideoGameResponse> EditVideoGame(VideoGameRequest request);

        /// <summary>
        /// Disabled video game
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<VideoGameResponse> DisabledVideoGame(VideoGameByIdRequest request);
    }
}
