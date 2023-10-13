using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class PlayerDameg : MonoBehaviour
{

    CircleCollider2D Atac;
    // Start is called before the first frame update
    void Start()
    {
        Atac = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Atac.enabled = true;
            StartCoroutine(Atacnow());
        }
    }

    IEnumerator Atacnow()
    {
        yield return new WaitForSeconds(0.2f);
        Atac.enabled = false;
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
