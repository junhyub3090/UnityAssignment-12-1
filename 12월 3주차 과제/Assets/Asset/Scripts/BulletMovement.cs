using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
    public GameObject player;
    public GameObject target;
    public GameObject explosion;
    public GameObject bullet;
    public float speed;
    private Transform bulletHead;
    private Transform bulletTail;
    private Transform distance;



	// Use this for initialization
	void Start () {
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();


    }

    // Update is called once per frame
    void Update () {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        Vector3 distance = target.transform.position - player.transform.position;
        Vector3 PlayerTargetDirection = distance.normalized;
        bulletTail.position = player.transform.position;
        bulletHead.position = player.transform.position + 2 * PlayerTargetDirection;
        bulletTail.position += PlayerTargetDirection * speed * Time.deltaTime;
        lineRenderer.SetPosition(0,bulletTail.position);
        lineRenderer.SetPosition(1,bulletHead.position);
        if(Vector3.Dot(PlayerTargetDirection,(target.transform.position-bulletHead.transform.position))<=0)
        {
            Instantiate(explosion, target.transform.position, Quaternion.identity);
            Destroy(explosion, 1);
            Destroy(bullet);


        }

    }
}
