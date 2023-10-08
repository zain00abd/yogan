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

     float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         herozintal = Input.GetAxis("Horizontal");
         vertecal = Input.GetAxis("Vertical");
        /*if (Input.GetKey(up))
        {
            player.transform.Translate(0, -0.01f, 0);
        }
        if (Input.GetKey(down))
        {
            player.transform.Translate(0, 0.01f, 0);
        }
        if (Input.GetKey(left))
        {
            player.transform.Translate(0.01f, 0, 0);
        }
        if (Input.GetKey(right))
        {
            player.transform.Translate(-0.01f, 0, 0);
        }*/

        rd.velocity = new Vector2(herozintal * speed, vertecal * speed);

        Debug.Log(herozintal);

    }
}
