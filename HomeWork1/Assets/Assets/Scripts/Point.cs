using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour
{
    public float timeGap;
    private float time=0;

    float xMove, yMove;

    private void Update()
    {
        float width = gameObject.GetComponent<Renderer>().bounds.size.x;
        time += Time.deltaTime;


        if (Input.GetKey(KeyCode.RightArrow))
        {
            xMove = width;
            yMove = 0;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            xMove = -width;
            yMove = 0;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            yMove = width;
            xMove = 0;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            yMove = -width;
            xMove = 0;
        }
        
            if (time >= timeGap)
            {
                this.transform.Translate(new Vector2(xMove, yMove));
                time = time - timeGap;
            }
        


    }
}


     