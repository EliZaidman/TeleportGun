using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     GameObject bullet;

    public bool IsBulletActive()
    {
        if (gameObject.Equals(isActiveAndEnabled))
        {
            Debug.Log("ThereIsBullet");
            return true;
            
        }

        else
        {
            Debug.Log("NoBullet");
            return false;

        }
    }
}
