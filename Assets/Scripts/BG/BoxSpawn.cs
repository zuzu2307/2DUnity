using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{

    public GameObject box;

    [HideInInspector]
    public bool canSpawn;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn)
        {
            if (timer <= 0) Spawner();
            timer -= Time.deltaTime;
        }
    }

    void Spawner()
    {
        Instantiate(box, new Vector3(15, 0, 0), Quaternion.Euler(0, 0, 0));
        timer = 2f;
    }
}
