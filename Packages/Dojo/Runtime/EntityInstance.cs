using System.Collections;
using System.Collections.Generic;
using dojo_bindings;
using UnityEngine;

namespace Dojo
{
    public class EntityInstance : MonoBehaviour
    {
        public string key;
        public string[] models;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void OnEntityStateUpdate() {
            Debug.Log("jme suis fait pigner sur discord");
        }
    }
}
