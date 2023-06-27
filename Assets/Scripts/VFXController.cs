using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXController : MonoBehaviour
{
    public static event System.Action BoomActive;

    [Header("VFX effect")]
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private bool _isCinemachine = false;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }


    private void Update()
    {
        //Start effect
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isCinemachine)
            {
                BoomActive?.Invoke();

                _particleSystem.Play();
            }
            else
            {
                _particleSystem.Play();
                StartCoroutine(_camera.gameObject.GetComponent<BasicCameraShake>().ShakeCamera(0.4f, 0.2f));
            }
        }
    }
}
