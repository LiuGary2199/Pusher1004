using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public static TimerManager Instance { get; private set; }

    // ��ʱ�����ݽṹ
    private class TimerData
    {
        public int Id;                  // ��ʱ��ID
        public float Interval;          // ���ʱ�䣨�룩
        public Action OnTick;           // ÿ�δ����Ļص�
        public bool IsRepeating;        // �Ƿ��ظ�
        public bool IsPaused;           // �Ƿ���ͣ
        public float RemainingTime;     // ʣ��ʱ��
        public Coroutine Coroutine;     // Э������
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
    /// ������ʱ���������̣߳�
    /// </summary>
    /// <param name="interval">���ʱ�䣨�룩</param>
    /// <param name="onTick">ÿ�δ����Ļص�</param>
    /// <param name="isRepeating">�Ƿ��ظ�����</param>
    /// <param name="immediateFirstTick">�Ƿ�����������һ��</param>
    /// <returns>��ʱ��ID</returns>
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

        // ����Э�̣������߳�ִ�У�
        timerData.Coroutine = StartCoroutine(TimerCoroutine(timerData, immediateFirstTick));
        _timers.Add(timerId, timerData);

        return timerId;
    }

    // ��ʱ��Э�̣������̣߳�
    private IEnumerator TimerCoroutine(TimerData data, bool immediateFirstTick)
    {
        // �Ƿ�����������һ��
        if (immediateFirstTick)
        {
            data.OnTick?.Invoke();
            if (!data.IsRepeating) yield break; // ���ظ�ģʽ�£��������������
        }

        // ѭ����ʱ
        while (true)
        {
            // �ȴ�ָ��ʱ�䣨ʹ�� unscaledTime ����ʱ������Ӱ�죩
            yield return new WaitForSecondsRealtime(data.Interval);

            // ����Ƿ��ѱ���ͣ/ֹͣ
            if (data.IsPaused || !_timers.ContainsKey(data.Id)) yield break;

            // �����ص�
            data.OnTick?.Invoke();

            // ���ظ�ģʽ�£����������
            if (!data.IsRepeating)
            {
                StopTimer(data.Id);
                yield break;
            }
        }
    }

    /// <summary>
    /// ��ͣ��ʱ��
    /// </summary>
    public void PauseTimer(int timerId)
    {
        if (_timers.TryGetValue(timerId, out var data) && !data.IsPaused)
        {
            data.IsPaused = true;
            StopCoroutine(data.Coroutine); // ֹͣ��ǰЭ��
        }
    }

    /// <summary>
    /// �ָ���ʱ��
    /// </summary>
    public void ResumeTimer(int timerId)
    {
        if (_timers.TryGetValue(timerId, out var data) && data.IsPaused)
        {
            data.IsPaused = false;
            // ��������Э�̣�������ʱ
            data.Coroutine = StartCoroutine(TimerCoroutine(data, false));
        }
    }

    /// <summary>
    /// ֹͣ���Ƴ���ʱ��
    /// </summary>
    public void StopTimer(int timerId)
    {
        if (_timers.TryGetValue(timerId, out var data))
        {
            StopCoroutine(data.Coroutine); // ֹͣЭ��
            _timers.Remove(timerId);       // ���ֵ��Ƴ�
        }
    }

    /// <summary>
    /// ֹͣ���м�ʱ��
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
    /// ����ʱ���Ƿ�������
    /// </summary>
    public bool IsRunning(int timerId)
    {
        return _timers.TryGetValue(timerId, out var data) && !data.IsPaused;
    }
}