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

           Instantiate(Sprite, transform.position, Quaternion.identity);

        }
    }


}
