using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

/// <summary>
/// 粒子自动销毁的脚本
/// </summary>
public class ParticleDestroy : MonoBehaviour
{
    public ParticleSystem ps;
    private ParticleSystem.MainModule mainModule;
    private void Start()
    {
        ps = GetComponent<ParticleSystem>();
        mainModule = ps.main;   //获取MainModule
        mainModule.stopAction = ParticleSystemStopAction.Callback;  //设置结束时调用回调
    }

    private void OnParticleSystemStopped()
    {
        GameObjectPool.Instance.PushObj(gameObject.name, gameObject);
    }
}
