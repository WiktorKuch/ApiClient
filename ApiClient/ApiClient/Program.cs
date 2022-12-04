namespace ApiClient
{
    class ApiClient
    {
        private readonly string baseUrl = "https://our-api-dev.com";
        private const string getUserEndpoint = "/api/users";
        private readonly HttpClient httpClient = new HttpClient();
        private int defaultPort = 80;


        public ApiClient(string _baseUrl)
        {
            baseUrl = _baseUrl;
        }
        public void Getusers()
        { 
            var getUsersUri = $"{baseUrl}{getUserEndpoint}";
            //HTTP GET Request @ getUsersUri 
            httpClient.GetAsync(getUsersUri);
            // return users 

        }

        public void PostUser()
        {

        }
        public void GetResources()
        {

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}