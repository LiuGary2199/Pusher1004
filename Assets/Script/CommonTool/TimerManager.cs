using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public static TimerManager Instance { get; private set; }

    // 计时器数据结构
    private class TimerData
    {
        public int Id;                  // 计时器ID
        public float Interval;          // 间隔时间（秒）
        public Action OnTick;           // 每次触发的回调
        public bool IsRepeating;        // 是否重复
        public bool IsPaused;           // 是否暂停
        public float RemainingTime;     // 剩余时间
        public Coroutine Coroutine;     // 协程引用
    }

    private readonly Dictionary<int, TimerData> _timers = new Dictionary<int, TimerData>();
    private int _nextTimerId = 1;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    /// <summary>
    /// 启动计时器（纯主线程）
    /// </summary>
    /// <param name="interval">间隔时间（秒）</param>
    /// <param name="onTick">每次触发的回调</param>
    /// <param name="isRepeating">是否重复触发</param>
    /// <param name="immediateFirstTick">是否立即触发第一次</param>
    /// <returns>计时器ID</returns>
    public int StartTimer(float interval, Action onTick, bool isRepeating = false, bool immediateFirstTick = false)
    {
        int timerId = _nextTimerId++;
        var timerData = new TimerData
        {
            Id = timerId,
            Interval = interval,
            OnTick = onTick,
            IsRepeating = isRepeating,
            IsPaused = false,
            RemainingTime = interval
        };

        // 启动协程（纯主线程执行）
        timerData.Coroutine = StartCoroutine(TimerCoroutine(timerData, immediateFirstTick));
        _timers.Add(timerId, timerData);

        return timerId;
    }

    // 计时器协程（纯主线程）
    private IEnumerator TimerCoroutine(TimerData data, bool immediateFirstTick)
    {
        // 是否立即触发第一次
        if (immediateFirstTick)
        {
            data.OnTick?.Invoke();
            if (!data.IsRepeating) yield break; // 非重复模式下，立即触发后结束
        }

        // 循环计时
        while (true)
        {
            // 等待指定时间（使用 unscaledTime 不受时间缩放影响）
            yield return new WaitForSecondsRealtime(data.Interval);

            // 检查是否已被暂停/停止
            if (data.IsPaused || !_timers.ContainsKey(data.Id)) yield break;

            // 触发回调
            data.OnTick?.Invoke();

            // 非重复模式下，触发后结束
            if (!data.IsRepeating)
            {
                StopTimer(data.Id);
                yield break;
            }
        }
    }

    /// <summary>
    /// 暂停计时器
    /// </summary>
    public void PauseTimer(int timerId)
    {
        if (_timers.TryGetValue(timerId, out var data) && !data.IsPaused)
        {
            data.IsPaused = true;
            StopCoroutine(data.Coroutine); // 停止当前协程
        }
    }

    /// <summary>
    /// 恢复计时器
    /// </summary>
    public void ResumeTimer(int timerId)
    {
        if (_timers.TryGetValue(timerId, out var data) && data.IsPaused)
        {
            data.IsPaused = false;
            // 重新启动协程，继续计时
            data.Coroutine = StartCoroutine(TimerCoroutine(data, false));
        }
    }

    /// <summary>
    /// 停止并移除计时器
    /// </summary>
    public void StopTimer(int timerId)
    {
        if (_timers.TryGetValue(timerId, out var data))
        {
            StopCoroutine(data.Coroutine); // 停止协程
            _timers.Remove(timerId);       // 从字典移除
        }
    }

    /// <summary>
    /// 停止所有计时器
    /// </summary>
    public void StopAllTimers()
    {
        foreach (var data in _timers.Values)
        {
            StopCoroutine(data.Coroutine);
        }
        _timers.Clear();
    }

    /// <summary>
    /// 检查计时器是否在运行
    /// </summary>
    public bool IsRunning(int timerId)
    {
        return _timers.TryGetValue(timerId, out var data) && !data.IsPaused;
    }
}