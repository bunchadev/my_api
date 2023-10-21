namespace API_PTTTHDT_.Model.Dto
{
    public class TokenDto
    {
        public string access_token { get; set; }
        public string message { get; set; }
        public int statusCode { get; set; }
        public string username { get; set; }
        public string role { get; set; }
    }
}
