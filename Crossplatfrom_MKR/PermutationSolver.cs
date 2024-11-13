namespace Crossplatform_MKR
{
    public static class PermutationSolver
    {
        public static IEnumerable<string> GetPermutations(string str)
        {
            if (str.Length == 1)
                yield return str;
            else
            {
                var usedChars = new HashSet<char>();
                foreach (var c in str)
                {
                    // Skip characters we've already processed at this level to prevent duplicates
                    if (usedChars.Contains(c)) continue;
                    usedChars.Add(c);

                    var remaining = new string(str.Where((x, i) => i != str.IndexOf(c) || x != c).ToArray());
                    foreach (var permutation in GetPermutations(remaining))
                    {
                        yield return c + permutation;
                    }
                }
            }
        }

        public static string Solve(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
                return "Invalid input: a, b, and c must be non-negative integers.";

            if (a == 0 && b == c) return $"YES\n0 {b}";
            if (b == 0 && a == c) return $"YES\n{a} 0";

            var aPerms = GetPermutations(a.ToString())
                .Select(x => int.Parse(x))
                .Distinct()
                .OrderBy(x => x);

            var bPerms = GetPermutations(b.ToString())
                .Select(x => int.Parse(x))
                .Distinct()
                .OrderBy(x => x);

            foreach (var x in aPerms)
            {
                foreach (var y in bPerms)
                {
                    if (x + y == c)
                    {
                        return $"YES\n{x} {y}";
                    }
                }
            }

            return "NO";
        }
    }
}