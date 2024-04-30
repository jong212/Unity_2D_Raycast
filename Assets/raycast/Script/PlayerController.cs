using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before
    // the first frame update

    public float moveSpeed = 1.0f;
    public float rayCastDistance = 5.0f;
    private Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizantalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");



    Vector2 move =new Vector2(horizantalInput, verticalInput);
        move *= moveSpeed;
        rigidbody2D.velocity = move;
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, rayCastDistance);
        RaycastHit2D[] hit = Physics2D.RaycastAll(transform.position, Vector2.right, rayCastDistance, LayerMask.GetMask("Human") | LayerMask.GetMask("Monster"));
        Debug.DrawRay(transform.position, Vector2.right * rayCastDistance, Color.red);

        foreach(var test in hit)
        {
            if (test.collider != null)
            {
                Debug.Log("Hit: " + test.collider.gameObject.name);

            }
        }
    }
}
