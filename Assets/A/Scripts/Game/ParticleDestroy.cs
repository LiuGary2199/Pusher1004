using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

/// <summary>
/// �����Զ����ٵĽű�
/// </summary>
public class ParticleDestroy : MonoBehaviour
{
    public ParticleSystem ps;
    private ParticleSystem.MainModule mainModule;
    private void Start()
    {
        ps = GetComponent<ParticleSystem>();
        mainModule = ps.main;   //��ȡMainModule
        mainModule.stopAction = ParticleSystemStopAction.Callback;  //���ý���ʱ���ûص�
    }

    private void OnParticleSystemStopped()
    {
        GameObjectPool.Instance.PushObj(gameObject.name, gameObject);
    }
}
