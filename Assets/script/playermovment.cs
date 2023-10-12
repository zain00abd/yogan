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

    Transform head;

    [SerializeField] public float speed;

    SpriteRenderer play;
    // Start is called before the first frame update
    void Start()
    {
        play = GetComponentInChildren<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
         herozintal = Input.GetAxis("Horizontal");
         vertecal = Input.GetAxis("Vertical");

        head = GetComponentInParent<Transform>();

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
            play.flipX = true;
        }
        else if (rd.velocity.x > 0)
        {
            play.flipX = false;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wapon1"))
        {
            Debug.Log("zain");
            GameObject par1 = Instantiate(Wapon1);
            par1.transform.SetParent(head);
            Destroy(collision.gameObject);
        }
    }
}
