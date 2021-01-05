using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> scores;
    public HighScores(List<int> list)
    {
        scores = list;
    }

    public List<int> Scores()
    {
        return scores;
    }

    public int Latest()
    {
        return scores.Last();
    }

    public int PersonalBest()
    {
        // 最大の要素を取得
        var max = 0;

        foreach (var e in scores)
        {
            if (max < e)
            {
                max = e;
            }
        }

        return max;
    }

    public List<int> PersonalTopThree()
    {
        // scores から最大値のTOP3を取得
        // copy先の配列を作成
        List<int> topThreeList = new List<int>();
        List<int> _scores = new List<int>(scores);
        _scores.Sort((a, b) => b - a);
        _scores.Sort();
        _scores.Reverse();
        int idx = 0;
        foreach (var e in _scores)
        {
            topThreeList.Add(e);
            if (idx >= 2)
            {
                break;
            }
            idx++;
        }
        //topThreeList.Reverse();
        return topThreeList;
    }
}