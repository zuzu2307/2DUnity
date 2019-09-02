using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public float boxSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ObstacleMove());
    }

    IEnumerator ObstacleMove()
    {
        yield return new WaitForSeconds(5f);
        transform.Translate(Vector3.left * Time.deltaTime * boxSpeed);
    }
}
