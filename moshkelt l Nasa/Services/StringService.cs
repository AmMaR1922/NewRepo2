namespace moshkelt_l_Nasa.Services
{
    using System.Collections.Generic;

    namespace StringApi.Services
    {
        public class StringService
        {
            private readonly List<string> _strings = new List<string>();

            public void Add(string value)
            {
                _strings.Add(value);
            }

            public List<string> GetAll()
            {
                return _strings;
            }
        }
    }
}
