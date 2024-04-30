using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before
    // the first frame update

    public float moveSpeed = 1.0f;
    public float rayCastDistance = 5.0f;
    private Rigidbody2D rigidbody2D;

    private void wake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizantalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 move =new Vector2(horizantalInput, verticalInput);
        move *= moveSpeed;
        rigidbody2D.velocity = move;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, rayCastDistance);
        Debug.DrawRay(transform.position, Vector2.right * rayCastDistance, Color.red);

        if(hit.collider != null)
        {

        }

    }
}
