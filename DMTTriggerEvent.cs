using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/*
* triggers a event
* usage: put on GO with a collider with trigger
* 
* example usage: can be used to play audiosource on trigger
* 
* Author: DMT Team, FH JOANNEUM, IMA,´DMT, NIS, 2025
* www.fh-joanneum.at
*/

namespace DMT
{
    public class DMTTriggerEvent : MonoBehaviour
    {

        [Tooltip("GameObject to activate after Event")]
        public UnityEvent toExecute;

        private void Start()
        {
            Debug.Log("##### DMTTriggerEvent Start: " + this.gameObject.name + " " + this.gameObject.GetType().ToString());
        }

        private void OnTriggerEnter(Collider other)
        {
            if (toExecute != null)
            {
                toExecute.Invoke();
            }

            Debug.Log("##### DMTTriggerEvent: " + this.gameObject.name + " <> " + other.name);
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log("##### DMTTriggerEvent: " + this.gameObject.name + " <> " + other.name);
        }

    }

}
