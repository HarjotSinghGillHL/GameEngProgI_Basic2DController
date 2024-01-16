using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HL_PlayerController : MonoBehaviour
{
    Rigidbody2D rigidBody;
    [SerializeField]
    private int moveSpeed = 2000;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
 
    void MovePlayer()
    {
        rigidBody.velocity = Vector2.zero;

        float flMoveAxisX = Input.GetAxis("Horizontal");
        float flMoveAxisY = Input.GetAxis("Vertical");

        rigidBody.velocity = new Vector2(((flMoveAxisX * Time.deltaTime) * moveSpeed), ((flMoveAxisY * Time.deltaTime) * moveSpeed));

    }

    void Update()
    {
        MovePlayer();
 
    }
}
