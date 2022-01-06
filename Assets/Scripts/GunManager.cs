using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GunManager : MonoBehaviour
{
    public Transform gunHead;
    public GameObject player;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private CharacterController cc;

    public GameObject[] projectile;
    public float launchVelocity;
    public GameObject currnetBall;
    public Slider powerSlider;
    Vector3 currnetBallPos;

    public bool redBulletActive = true;
    public bool greenBulletActive = false;
    public bool blackBulletActive = false;

    public Image redFIll;
    public Image greenFIll;
    public Image blackFIll;

    private void Awake()
    {

    }
    void Start()
    {
        powerSlider.value = 1;
    }


    public int i;
    void Update()
    {
        BulletTypeSelector();
        cc = player.GetComponentInChildren<CharacterController>();
        if (currnetBall != null)
        {
            currnetBallPos = currnetBall.transform.position;

        }
        launchVelocity = Mathf.Clamp(launchVelocity, 1, 100);

        if (Input.GetButtonDown("Fire1"))
        {
            if (currnetBall == null)
            {
                currnetBall = Instantiate(projectile[i], gunHead.position, gunHead.rotation);
                currnetBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                                     (0, 0, launchVelocity * 10));
                Mathf.Clamp(0, 100, launchVelocity);
            }
            return;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            launchVelocity -= 0.08f;
            powerSlider.value -= 0.0008f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            launchVelocity += 0.08f;
            powerSlider.value += 0.0008f;
        }
        //powerSlider.value = launchVelocity;


        //textMeshPro.text = launchVelocity.ToString("0");
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(currnetBall);
        }
    }


    private void BulletTypeSelector()
    {
        if (redBulletActive)
        {
            i = 0;
            redFIll.gameObject.SetActive(true); greenFIll.gameObject.SetActive(false); blackFIll.gameObject.SetActive(false);
        }
        else
            redFIll.gameObject.SetActive(false);

        if (greenBulletActive)
        {
            i = 1;
            redFIll.gameObject.SetActive(false); greenFIll.gameObject.SetActive(true); blackFIll.gameObject.SetActive(false);
        }
        else
            greenFIll.gameObject.SetActive(false);

        if (blackBulletActive)
        {
            i = 2;
            redFIll.gameObject.SetActive(false); greenFIll.gameObject.SetActive(false); blackFIll.gameObject.SetActive(true);
        }
        else
            blackFIll.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            redBulletActive = true;
            greenBulletActive = false;
            blackBulletActive = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            redBulletActive = false;
            greenBulletActive = true;
            blackBulletActive = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            redBulletActive = false;
            greenBulletActive = false;
            blackBulletActive = true;
        }
    }

}