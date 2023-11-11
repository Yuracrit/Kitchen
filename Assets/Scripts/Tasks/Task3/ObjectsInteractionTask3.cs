    using System;
    using UnityEngine;

    public class ObjectsInteractionTask3 : MonoBehaviour
    {
        [SerializeField] private GameObject _lampRoot;
        private Lamp[] lamps;

        private void Start()
        {
            lamps = _lampRoot.GetComponentsInChildren<Lamp>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                foreach (var lamp in lamps)
                {
                    lamp.Interact();
                }
                
            }
        }
        
            
    }