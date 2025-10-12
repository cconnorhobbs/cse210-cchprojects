using System;
using System.Collections.Generic;

namespace JournalApp
{
    public class PromptGenerator
    {
        private List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Did I act in a Christlike way today?",
            "What can I do to better follow God's will tomorrow?",
            "Is there anyone I mistreated today? If so, how can I forgive them?",
            "What will I study in the scriptures tomorrow?",
            "What responsibilities and goals do I have for tomorrow?"
        };

        private Random _random = new Random();

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}
