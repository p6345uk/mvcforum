﻿using MVCForum.Domain.DomainModel;
using MVCForum.Domain.DomainModel.Attributes;
using MVCForum.Domain.Interfaces.API;
using MVCForum.Domain.Interfaces.Badges;

namespace MVCForum.Website.Badges
{
    [Id("d68c289a-e3f7-4f55-ae4f-fc7ac2147781")]
    [Name("AuthorMarkAsSolution")]
    [DisplayName("Badge.AuthorMarkAsSolutionBadge.Name")]
    [Description("Badge.AuthorMarkAsSolutionBadge.Desc")]
    [Image("UserMarkAsSolutionBadge.png")]
    [AwardsPoints(2)]
    public class AuthorMarkAsSolutionBadge : IMarkAsSolutionBadge
    {
        /// <summary>
        /// Post is marked as the answer to a topic - give the topic author a badge
        /// </summary>
        /// <returns></returns>
        public bool Rule(MembershipUser user, IMVCForumAPI api)
        {
            return api.Topic.GetSolvedTopicsByMember(user.Id).Count >= 1;

        }

    }
}
