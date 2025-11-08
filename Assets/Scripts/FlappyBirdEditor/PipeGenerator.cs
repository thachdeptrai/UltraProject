using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject PipePrefab;
    private float CountDown;
    public float timeDuration;
    public bool EnableGeneratePipe;
    private void Awake()
    {
        CountDown = timeDuration;
        EnableGeneratePipe = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnableGeneratePipe == true)
        {
            CountDown -= Time.deltaTime;
            if (CountDown <= 0)
            {
                Instantiate(PipePrefab, new Vector3(10, Random.Range(-1.2f, 2.1f), 0), Quaternion.identity);
                CountDown = timeDuration;
                //Debug.Log("Create Pipe Successed");
            }
        }
    }
}
