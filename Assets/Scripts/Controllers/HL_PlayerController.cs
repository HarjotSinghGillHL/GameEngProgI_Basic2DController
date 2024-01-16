using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HL_PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    [SerializeField]
    private int moveSpeed = 2000;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void MovePlayer()
    {
        float flMoveAxisX = Input.GetAxis("Horizontal");
        float flMoveAxisY = Input.GetAxis("Vertical");

        rigidBody.velocity = new Vector2(((flMoveAxisX * Time.deltaTime) * moveSpeed), ((flMoveAxisY * Time.deltaTime) * moveSpeed));
    }

    void Update()
    {
        MovePlayer();
    }
}
