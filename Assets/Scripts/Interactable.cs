using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange = false;
    public KeyCode interactKey;
    public UnityEvent interactAction;
   

  


    void Update()
    {
        if (isInRange == true)
        {
            if (Input.GetKeyDown(interactKey))
            {
                
                interactAction.Invoke();
            }
        }
        
    }
    //private void OnCollisionEnter(Collision collision)
    //{
   
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        isInRange = true;
    //        Debug.Log("in range");
    //    }
    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        isInRange = true;
    //        Debug.Log("not in range");
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("in range");
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("not in range");
        }
    }
}
