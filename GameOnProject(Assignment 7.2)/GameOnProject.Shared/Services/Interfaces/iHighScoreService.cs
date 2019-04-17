using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOnProject.Shared.ViewModels;

namespace GameOnProject.Shared.Services.Interfaces
{
    public interface IHighScoreService
    {
        bool IsThisYourHighScore(HighScoreViewModel highscore);
    }
}
