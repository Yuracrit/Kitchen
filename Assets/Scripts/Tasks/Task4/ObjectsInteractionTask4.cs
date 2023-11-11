using System;
using UnityEngine;
using UnityEngine.WSA;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 

   [SerializeField] private Toaster _toaster;
   [SerializeField] private GameObject _wafflePrefab;
   [SerializeField] private Transform _waffleRoot;
    

    private void Awake()
    {
        _toaster.TimerIsUp+=OnTimerIsUp;
    }

    private void OnTimerIsUp()
    {
        Instantiate(_wafflePrefab, _waffleRoot);
    }

    private void OnDestroy()
    {
        _toaster.TimerIsUp -= OnTimerIsUp;
    }
}