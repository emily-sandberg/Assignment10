using Assignment10.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        public TeamViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {

            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
