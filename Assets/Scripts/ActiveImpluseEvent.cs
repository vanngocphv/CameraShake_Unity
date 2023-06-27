using Cinemachine;
using UnityEngine;
using UnityEngine.Events;

public class ActiveImpluseEvent : MonoBehaviour
{
    private CinemachineImpulseSource _impulseSource;


    private void Awake()
    {
        _impulseSource = GetComponent<CinemachineImpulseSource>();
    }
    private void Start()
    {
        VFXController.BoomActive += OnActiveShake;
    }




    private void OnActiveShake()
    {

        ActiveShake();
    }
    public void ActiveShake()
    {
        _impulseSource.GenerateImpulse();
    }


    private void OnDestroy()
    {
        VFXController.BoomActive -= OnActiveShake;
    }

}
