namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var count = 0;
            var temp = string.Empty;
            var mostCount = 0;
            var mostWord = string.Empty;
            var stringArr = paragraph.ToLower().Replace('!', ' ').Replace('?', ' ').Replace('\'', ' ').Replace(',', ' ').Replace(';', ' ').Replace('.', ' ').Split(' ');
            for (int i = 0; i < stringArr.Length; i++)
            {
                if (string.IsNullOrEmpty(stringArr[i]))
                {
                    continue;
                }
                if (IsExistInBanned(banned, stringArr[i]))
                {
                    count = 0;
                    continue;
                }
                if (count == 0)
                {
                    temp = stringArr[i];
                    count++;
                    for (int j = i + 1; j < stringArr.Length; j++)
                    {
                        if (IsExistInBanned(banned, stringArr[j]) || stringArr[j] == mostWord)
                        {
                            continue;
                        }
                        if (temp == stringArr[j])
                        {
                            count++;
                        }
                    }
                }
                if (count > mostCount)
                {
                    mostCount = count;
                    mostWord = temp;
                }
                count = 0;
            }
            return mostWord;
        }

        private bool IsExistInBanned(string[] banned, string word)
        {
            for (int i = 0; i < banned.Length; i++)
            {
                if (banned[i] == word)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
