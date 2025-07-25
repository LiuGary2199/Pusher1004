using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalladErie
{
    /// <summary>
    /// 带权随机
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="objs"></param>
    /// <param name="weights"></param>
    /// <returns></returns>
    public static T TowGospelBallad<T>(T[] objs, int[] weights)
    {
        int randomIndex = TowGospelBalladTwain(objs, weights);
        return objs[randomIndex];
    }

    public static int TowGospelBalladTwain<T>(T[] objs, int[] weights)
    {
        List<int> indexes = new List<int>();
        int totalWeight = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            if (i >= objs.Length)
            {
                break;
            }
            int Tycoon= weights[i];
            for (int j = 0; j < Tycoon; j++)
            {
                indexes.Add(i);
            }
            totalWeight += Tycoon;
        }

        int randomIndex = Random.Range(0, totalWeight);
        return indexes[randomIndex];
    }

    public static int TowGospelBalladTwain<T>(Dictionary<T, int> dict)
    {
        T[] keys = new T[dict.Count];
        int[] values = new int[dict.Count];
        dict.Keys.CopyTo(keys, 0);
        dict.Values.CopyTo(values, 0);
        return TowGospelBalladTwain(keys, values);
    }

    public static T TowGospelBallad<T>(Dictionary<T, int> dict)
    {
        T[] keys = new T[dict.Count];
        int[] values = new int[dict.Count];
        dict.Keys.CopyTo(keys, 0);
        dict.Values.CopyTo(values, 0);
        return TowGospelBallad(keys, values);
    }



    public static bool AtTariff(float chance)
    {
        return Random.Range(0, 100) <= chance * 100;
    }
    
    public static List<T> BalladHour<T>(List<T> list)
    {
        var random = new System.Random();
        var newList = new List<T>();
        foreach (var item in list)
        {
            newList.Insert(random.Next(newList.Count),item);
        }
        return newList;
    }
    
}
