using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using GameOnEntertainment.Shared.Orchestrators;
using GameOnEntertainment.Shared.ViewModels;

namespace GameOnEntertainment.Web.Api
{
    [Route("api/v1/highscores")]
    public class HighScoreApiController: ApiController
    {
        private readonly HighScoreOrchestrator _highScoreOrchestrator;

        public HighScoreApiController()
        {
            _highScoreOrchestrator = new HighScoreOrchestrator();
        }

        [HttpGet]

        public List<HighScoreViewModel> GetAllHighScores()
        {
            var highscores = _highScoreOrchestrator.GetAllHighScores();
            return highscores;
        }
    }
}