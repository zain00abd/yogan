using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnemyMov1 : MonoBehaviour
{
    private Transform tran;
    private SpriteRenderer Sr;
    public float moveSpeed = 3f; // ���� ������ �����
    [SerializeField] public Transform player; // ���� �����

    private void Start()
    {
        tran = GetComponent<Transform>();
        Sr = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform; // ����� ���� ������ ��� �� ��� �������
        }

        if (player != null)
        {
            Vector2 moveDirection = (player.position - transform.position).normalized; // ����� ������ ��� ������
            Vector2 movement = moveDirection * moveSpeed * Time.deltaTime;

            transform.Translate(movement);
            
        }

        if(player.transform.position.x - tran.transform.position.x < 0)
        {
            Sr.flipX = true;
        }
        else
        {
            Sr.flipX = false;
        }
    }
}
