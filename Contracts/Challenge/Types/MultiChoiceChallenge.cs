﻿
namespace Hackathon.Contracts.Challenge.Types
{
    public class MultiChoiceChallenge
    {
        public char ExpectedAnswer { get; set; }

        public char Answer { get; set; }

        public string OptionA { get; set; }

        public string OptionB { get; set; }

        public string OptionC { get; set; }

        public string OptionD { get; set; }
    }
}
