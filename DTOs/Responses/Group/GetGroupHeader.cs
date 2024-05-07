using OrientHGAPI.DTOs.Responses.Home;

namespace OrientHGAPI.DTOs.Responses.Group
{
    public class GetGroupHeader
    {
        public string GroupPhone { get; set; }
        public string GroupLogo { get; set; }
        public string GroupLogoColored { get; set; }
        public List<LanguageResponse> Languages { get; set; } = [];
    }
}
