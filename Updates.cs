using System.Diagnostics;

namespace Assembilies
{

    [DebuggerDisplay("Number: {Number} --- Title: {Title}")]
    public class Updates
    {
        private int Number;
        private string Title;

        public Updates(int number, string title)
        {
            Number = number;
            Title = title;
        }
        public override string ToString()
        {
            return $"No. {Number} - {Title}";
        }
    }
}

