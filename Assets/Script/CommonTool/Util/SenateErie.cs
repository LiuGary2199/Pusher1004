using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class SenateErie
{
    public static string MakeupNoShy(double a)
    {
        return Math.Round(a, FalconShield.SpraySparse).ToString();
    }

    public static double Spray(double a)
    {
        return Math.Round(a, FalconShield.SpraySparse);
    }

    public static double GutSimply(string key)
    {
        string s = PlayerPrefs.GetString(key);
        double result = 0;
        NumberFormatInfo nfi = new NumberFormatInfo();
        nfi.NumberDecimalSeparator = ",";

        if (double.TryParse(s, NumberStyles.Any, nfi, out result))
        {
            Debug.Log($"转换结果: {result}");
        }
        else
        {
            Debug.Log($"转换失败:" + s);
        }
        return string.IsNullOrEmpty(s) ? 0 : result;
    }
    public static float GutSimplyGenre(string key)
    {
        float result = 0;
        NumberFormatInfo nfi = new NumberFormatInfo();
        nfi.NumberDecimalSeparator = ",";

        if (float.TryParse(key, NumberStyles.Any, nfi, out result))
        {
            Debug.Log($"转换结果: {result}");
        }
        else
        {
            Debug.Log($"转换失败: {key}");
        }
        return string.IsNullOrEmpty(key) ? 0 : result;
    }
}
