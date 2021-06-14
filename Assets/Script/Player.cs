using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet = null;
    public float attack = 3.5f;
    public int speed = 10;
    public float bullet_range = 0.5f;
    private float range = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        range += Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.UpArrow) && range >= bullet_range)
        {
            GameObject newBullet = GameObject.Instantiate(bullet);
            newBullet.transform.position += transform.position;
            newBullet.transform.eulerAngles = new Vector3(0, 0, 0);
            range = 0;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && range >= bullet_range)
        {
            GameObject newBullet = GameObject.Instantiate(bullet);
            newBullet.transform.position += transform.position;
            newBullet.transform.eulerAngles = new Vector3(0, 180, 0);
            range = 0;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && range >= bullet_range)
        {
            GameObject newBullet = GameObject.Instantiate(bullet);
            newBullet.transform.position += transform.position;
            newBullet.transform.eulerAngles = new Vector3(0, 90, 0);
            range = 0;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && range >= bullet_range)
        {
            GameObject newBullet = GameObject.Instantiate(bullet);
            newBullet.transform.position += transform.position;
            newBullet.transform.eulerAngles = new Vector3(0, 270, 0);
            range = 0;
        }
    }
}
