using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FloorType { metal, chain, wood };
public class Floor : MonoBehaviour
{

    [SerializeField]
    FloorType floorType;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        //if (Physics.Raycast(transform.position, Vector3.up))
        //{

        //    AudioManager.Instance.Play(FloorNoise[0]);
        //}
        //while (Physics.Raycast(transform.position, Vector3.up))
        //{
        //    AudioManager.Instance.Play(FloorNoise[0]);
        //}
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("test");
        if (collision.gameObject.CompareTag("Player"))
        {
            MovementScript player = collision.gameObject.GetComponent<MovementScript>();
            player.ChanchFloor(floorType);
        }
    }

        //    }
        //void OnTriggerEnter(Collider other)
        //{

        //    if (other.tag == "Player")
        //    {
        //        Debug.Log("test");
        //        AudioManager.Instance.Play(FloorNoise[0]);
        //    }
        //}


    }


    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if (hit.controller.tag =="Player")
    //    {
    //        AudioManager.Instance.Play(FloorNoise[0]);
    //    }
    //}
//}
