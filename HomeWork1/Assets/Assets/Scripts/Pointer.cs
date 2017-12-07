using UnityEngine;
using System.Collections;

public class Pointer : MonoBehaviour
{
    public GameObject Sprite;



    void Start()
    {

       
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 touchPos = new Vector2(worldPos.x, worldPos.y);

            transform.position = touchPos;

            GameObject Clone = Instantiate(Sprite, transform.position, Quaternion.identity) as GameObject;

        }
    }


}
