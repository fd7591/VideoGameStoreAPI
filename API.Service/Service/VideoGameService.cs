namespace API.Service.Service
{
    using API.Repositories.Interfaces;
    using API.Service.Interfaces;
    using VGS.Models.Request;
    using VGS.Models.Response;

    public class VideoGameService : IVideoGameService
    {
        private readonly IVideoGameRepositories _videoGameRepositories;
        public VideoGameService(IVideoGameRepositories videoGameRepositories)
        {
            _videoGameRepositories = videoGameRepositories;
        }

        /// <summary>
        /// Get all active video games
        /// </summary>
        /// <returns></returns>
        public async Task<VideoGameListResponse> GetAllVideoGames()
        {
            return await _videoGameRepositories.GetAllVideoGames();
        }

        /// <summary>
        /// Get video game by Id
        /// </summary>
        /// <returns></returns>
        public async Task<VideoGameResponse> GetVideoGameById(VideoGameByIdRequest request)
        {
            return await _videoGameRepositories.GetVideoGameById(request);
        }

        /// <summary>
        /// Insert or edit a video game in database
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<VideoGameResponse> PostVideoGame(VideoGameRequest request)
        {
            if (request.VideoGame.Id > 0)
            {
                return await _videoGameRepositories.EditVideoGame(request);
            }
            else 
            {
                return await _videoGameRepositories.PostVideoGame(request);
            }
        }

        /// <summary>
        /// Disabled video game
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<VideoGameResponse> DisabledVideoGame(VideoGameByIdRequest request)
        {
            return await _videoGameRepositories.DisabledVideoGame(request);
        }
    }
}
