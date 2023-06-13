namespace VGS.Models.Entities
{
    /// <summary>
    /// Define VideoGame class
    /// </summary>
    public class VideoGameModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Anho { get; set; }
        public int Ranking { get; set; }
        public int Gender { get; set; }
        public int Console { get; set; }
        public String Base64Image { get; set; }
    }
}
