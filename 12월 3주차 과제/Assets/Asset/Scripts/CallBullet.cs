using UnityEngine;
using System.Collections;

public class CallBullet : MonoBehaviour
{
    public GameObject LineRenderer;



    void Start()
    {


    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPos.z = 0;
            Instantiate(LineRenderer, worldPos, Quaternion.identity);
            

        }
    }


}