using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Animation shootAnim;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            shootAnim.Play("Reload");
        }
    }
}
