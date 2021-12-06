using TMPro;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    public Transform gunHead;
    public GameObject player;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private CharacterController cc;

    public GameObject projectile;
    public float launchVelocity;
    GameObject currnetBall;
    GameObject testball;
    Vector3 currnetBallPos;


    private void Awake()
    {

    }
    void Start()
    {

    }
    




    void Update()
    {
        cc = player.GetComponentInChildren<CharacterController>();
        if (currnetBall != null)
        {
            currnetBallPos = currnetBall.transform.position;
        }

        //if (testball)
        //{
        //    cc.enabled = false;
        //    player.transform.position = currnetBallPos;
        //    cc.enabled = true;

        //    Debug.Log(currnetBall.transform.position.ToString());
        //    Debug.Log(player.transform.position.ToString());
        //    Destroy(testball);
        //}
        
        if (Input.GetButtonDown("Fire1"))
        {
            //player.GetComponentInChildren<CharacterController>().enabled = false;
            currnetBall = Instantiate(projectile, gunHead.position, gunHead.rotation);
            currnetBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                                 (0, 0, launchVelocity / 5));
            Mathf.Clamp(0, 100, launchVelocity);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            launchVelocity -= 100;
        }
        if (Input.GetKey(KeyCode.E))
        {
            launchVelocity += 100;
        }

        Mathf.Clamp(10, 1500, launchVelocity);
        textMeshPro.text = launchVelocity.ToString();
        TP(currnetBall);

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (cc.enabled)
            {
                cc.enabled = false;
            }
            
        }
    }


    private void TP(GameObject inBullet)
    {
        if (!currnetBall)
        {
             return;
        }
        if (Input.GetButtonDown("Fire2"))
        {

            //cc.enabled = false;
            player.transform.position = currnetBallPos;
            //cc.enabled = true;

            //player.transform.position = currnetBall.transform.position;
            Debug.Log(currnetBall.transform.position.ToString());
            Debug.Log(player.transform.position.ToString());
            Destroy(currnetBall);
            
        }
    }
    public void Respawn()
    {

    }

    //Item Pooling

}
