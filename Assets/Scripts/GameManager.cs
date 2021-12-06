using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject gun;
    public GameObject bullet;
    public Animator ani;
   [SerializeField] private GunManager gunManager;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ani.Play("Reload");
        }

    }
}
