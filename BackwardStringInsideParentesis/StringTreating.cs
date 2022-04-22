namespace BackwardStringInsideParentesis
{
    public class StringTreating
    {
        public static string BackWardsString(string input)
        {
            if (!input.Contains("("))
                return input;

            bool part = false;
            string currentString = string.Empty;
            List<string> stringBackWards = new();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == '(')
                {
                    part = false;
                    stringBackWards.Add(currentString);
                    currentString = string.Empty;
                    continue;
                }

                if (input[i] == ')')
                {
                    part = true;
                    continue;
                }
                
                if (part)
                {
                    currentString += input[i];
                }
            }

            string twistedString = string.Empty;
            bool parentesisOpened = false;
            bool parantesisContentFilled = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    parantesisContentFilled = false;
                    parentesisOpened = true;
                    twistedString += input[i];
                }
                if (input[i] == ')')
                {
                    parentesisOpened = false;
                }

                if (!parentesisOpened)
                    twistedString += input[i];

                if (parentesisOpened && !parantesisContentFilled)
                {
                    twistedString += stringBackWards.Last();
                    stringBackWards.RemoveAt(stringBackWards.Count - 1);
                    parantesisContentFilled = true;
                }
            }

            return twistedString;
        }
    }
}
