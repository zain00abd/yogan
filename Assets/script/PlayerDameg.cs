using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class PlayerDameg : MonoBehaviour
{

    CircleCollider2D Atac;
    SpriteRenderer sprite;
    Animator anim;
    bool isflop = true;
    // Start is called before the first frame update
    void Start()
    {
        Atac = GetComponent<CircleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        StartCoroutine(isf());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Atac.enabled = true;
            StartCoroutine(Atacnow());
            anim.SetTrigger("Atac1");
            anim.SetBool("ASAD",true);
        }

      
        Debug.Log(ManigarScript.Manigar.playerrd.velocity.x);
        if(ManigarScript.Manigar.playerrd.velocity.x < 0 && isflop)
        {
            sprite.flipX = true;
        }

    }


    IEnumerator Atacnow()
    {
        yield return new WaitForSeconds(0.1f);
        Atac.enabled = false;
    }

    IEnumerator isf()
    {
        yield return new WaitForSeconds(0.05f);
        isflop = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Anim1"))
        {
            Debug.Log(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D that)
    {
        if (that.CompareTag("Anim1"))
        {
            Debug.Log(gameObject);
        }
    }

  


}
