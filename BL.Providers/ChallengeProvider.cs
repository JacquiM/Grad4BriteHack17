﻿
namespace BL.Providers
{
    using System;
    using Hackathon.Contracts.Challenge;
    using Utilities;

    public class ChallengeProvider
    {
        private readonly IChallengeAdapter _challengeAdapter;

        public ChallengeProvider() { }

        public ChallengeProvider(IChallengeAdapter adapter)
        {
            _challengeAdapter = adapter ?? DependencyFactory.Resolve<IChallengeAdapter>();
        }

        public Challenge Create(ChallengeRequest request)
        {
            var challenge = new Challenge
            {
                Id = Guid.NewGuid(),
                MultiChoiceChallenge = request.MultiChoiceChallenge,
                YesNoChallenge = request.YesNoChallenge,
                Question = request.Question,
                Success = request.Success,
                Type = request.Type
            };

            return _challengeAdapter.Create(challenge);
        }

        public Challenge Update(Guid challengeId, IChallengeUpdatable request)
        {
            return _challengeAdapter.Update(challengeId, request);
        }

        public Challenge Get(Guid id)
        {
            return _challengeAdapter.Get(id);
        }
    }
}
