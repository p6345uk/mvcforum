﻿using System.Linq;
using MVCForum.Domain.DomainModel;
using MVCForum.Domain.DomainModel.Attributes;
using MVCForum.Domain.Interfaces.API;
using MVCForum.Domain.Interfaces.Badges;

namespace MVCForum.Website.Badges
{
    [Id("a54ec5d1-111d-4698-b2d0-78fbdaa52d1b")]
    [Name("OneThousandPoints")]
    [DisplayName("Badge.OneThousandPoints.Name")]
    [Description("Badge.OneThousandPoints.Desc")]
    [Image("OneThousandPoints.png")]
    [AwardsPoints(10)]
    public class OneThousandPoints : IPostBadge
    {
        public bool Rule(MembershipUser user, IMVCForumAPI api)
        {
            var points = user.Points.Sum(x => x.Points);
            return points >= 1000;
        }
    }
}
