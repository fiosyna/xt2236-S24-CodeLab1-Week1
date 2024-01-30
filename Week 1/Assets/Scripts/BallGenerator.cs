using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ball;

    public int ballCount = 10;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateBall(ballCount);
        }
    }

    void GenerateBall(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Vector3 pos = new Vector3(4.4f, 2.4f, Random.Range(-4.3f, 4.3f));
            Instantiate(ball,pos,transform.rotation);
        }

    }
}
