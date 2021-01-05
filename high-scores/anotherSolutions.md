```cs
using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> HS = new List<int>();

    public HighScores(List<int> list) => HS = list;

    public List<int> Scores() => HS;

    public int Latest() => HS.Last();

    public int PersonalBest() => HS.Max();

    public List<int> PersonalTopThree() => HS.OrderByDescending(a => a).ToList().GetRange(0, HS.Count > 2 ? 3 : HS.Count);
}
```

```cs
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> _scores;

    public HighScores(List<int> scores) => this._scores = scores;

    public List<int> Scores() => _scores;

    public int Latest() => _scores.Last();

    public int PersonalBest() => _scores.Max();

    public List<int> PersonalTopThree() => _scores
        .OrderByDescending(i => i)
        .Take(3)
        .ToList();
}
```

