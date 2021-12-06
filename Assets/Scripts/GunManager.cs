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
        launchVelocity = Mathf.Clamp(launchVelocity, 1, 25);

        if (Input.GetButtonDown("Fire1"))
        {
            if (currnetBall == null)
            {
                currnetBall = Instantiate(projectile, gunHead.position, gunHead.rotation);
                currnetBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                                     (0, 0, launchVelocity * 100));
                Mathf.Clamp(0, 100, launchVelocity);
            }
            return;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            launchVelocity -= 1;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            launchVelocity += 1;
        }

        
        textMeshPro.text = launchVelocity.ToString();
        TP(currnetBall);

    }


    private void TP(GameObject inBullet)
    {
        if (!currnetBall)
        {
             return;
        }
        if (Input.GetButtonDown("Fire2"))
        {

            cc.enabled = false;
            player.transform.position = currnetBallPos;
            cc.enabled = true;

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
