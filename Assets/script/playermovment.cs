using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playermovment : MonoBehaviour
{
    float herozintal;
    float vertecal;

    [SerializeField] public Rigidbody2D rd;
    [SerializeField] public KeyCode up;
    [SerializeField] public KeyCode down;
    [SerializeField] public KeyCode left;
    [SerializeField] public KeyCode right;
    [SerializeField] public Animator MovPlayer;
    [SerializeField] public GameObject Wapon1;
    [SerializeField] public Transform Hand1;
    [SerializeField] public Transform  camer;

    Transform tran;

    [SerializeField] public float speed;

    SpriteRenderer play;
    // Start is called before the first frame update
    void Start()
    {
        play = GetComponentInChildren<SpriteRenderer>();
        tran = GetComponentInChildren<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
         herozintal = Input.GetAxis("Horizontal");
         vertecal = Input.GetAxis("Vertical");


    }
    private void FixedUpdate()
    {
        rd.velocity = new Vector2(herozintal * speed, vertecal * speed);


        if (Mathf.Abs(rd.velocity.x) > 0.1f || Mathf.Abs(rd.velocity.y) > 0.1f)
        {
            MovPlayer.SetFloat("movplayer", 1f);

        }
        else
        {
            MovPlayer.SetFloat("movplayer", 0f);
        }

        if (rd.velocity.x < 0)
        {
            transform.Find("body").rotation = Quaternion.Euler(0, 160, 0);
            camer.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (rd.velocity.x > 0)
        {
            transform.Find("body").rotation = Quaternion.Euler(0, 0, 0);
            camer.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wapon1"))
        {
            Debug.Log("zain");
            GameObject par1 = Instantiate(Wapon1);
            par1.transform.SetParent(Hand1);
            par1.transform.position = new Vector3(Hand1.position.x, Hand1.position.y);
            Destroy(collision.gameObject);
        }
    }
}
