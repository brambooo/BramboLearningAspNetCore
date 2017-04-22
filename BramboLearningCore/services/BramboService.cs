using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BramboLearningCore.services
{
    public class BramboService : IBramboService
    {
        private string _intro;

        public BramboService(IConfiguration configuration)
        {
            _intro = configuration["intro"];
        }

        public string GetTitle()
        {
            return _intro;
        }

    }
}
