using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chackpoints : MonoBehaviour
{
    public GameObject chackpoint;
    public GameObject player;
    [SerializeField] private CharacterController cc;

    private void Update()
    {



    }
    private void OnTriggerEnter(Collider other)
    {
        cc = player.GetComponentInChildren<CharacterController>();
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER! Trigger");
            cc.enabled = false;
            player.transform.position = chackpoint.transform.position;
            cc.enabled = true;
        }
    }

}
