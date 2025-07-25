using UnityEngine;

/// <summary>
/// �̳�MonoBehaviour�ĵ���ģʽ����
/// </summary>
public class SingletonMono<T> : MonoBehaviour where T : SingletonMono<T>
{
    private static T _instance;

    public static T Instance => _instance;

    protected virtual void Awake()
    {
        _instance = this as T;
    }
}
