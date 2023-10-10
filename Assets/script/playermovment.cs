using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    float herozintal;
    float vertecal;

    [SerializeField] public Transform player;
    [SerializeField] public Rigidbody2D rd;
    [SerializeField] public KeyCode up;
    [SerializeField] public KeyCode down;
    [SerializeField] public KeyCode left;
    [SerializeField] public KeyCode right;
    [SerializeField] public Animator MovPlayer;

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



    }
    private void FixedUpdate()
    {
        rd.velocity = new Vector2(herozintal * speed, vertecal * speed);


        if (Mathf.Abs(rd.velocity.x) > 0.1f || Mathf.Abs(rd.velocity.y) > 0.1f)
        {
            MovPlayer.SetFloat("ismov", 1f);

        }
        else
        {
            MovPlayer.SetFloat("ismov", 0f);
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
}
