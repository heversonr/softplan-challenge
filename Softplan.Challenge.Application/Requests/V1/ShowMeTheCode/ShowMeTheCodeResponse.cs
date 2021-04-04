
namespace Softplan.Challenge.Application.Requests.V1.ShowMeTheCode
{
    public class ShowMeTheCodeResponse
    {
        /// <summary>
        /// The url with the project source.
        /// </summary>
        public string Url { get; set; }

        public ShowMeTheCodeResponse(string url)
        {
            Url = url;
        }

    }
}
