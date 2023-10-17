using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManigarScript : MonoBehaviour
{
    public static ManigarScript Manigar;

    [SerializeField] public Rigidbody2D playerrd;
    [SerializeField] public Transform player;
    void Start()
    {
        Manigar = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
