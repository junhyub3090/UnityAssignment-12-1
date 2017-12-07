using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour
{
    public float speed;
    public GameObject Cube;

    private Rigidbody rb;
    

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 touchPos = new Vector2(wp.x, wp.y);

            transform.position = touchPos;
 
            GameObject instObj = Instantiate(Cube, transform.position, Quaternion.identity) as GameObject;

           
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    
        rb.AddForce(movement*speed);
    }
}