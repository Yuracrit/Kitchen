using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)    
    [SerializeField] private GameObject _lampRoot;
    [SerializeField] private GameObject _prefab;

    private void Awake()
    {
        Instantiate(_prefab, _lampRoot.transform);
    }
}