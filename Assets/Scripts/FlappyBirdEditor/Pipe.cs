using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
  private void Start()
    {
    //    StartCoroutine(WaitDestroyScenes(5f));
    //}
    //private IEnumerator WaitDestroyScenes(float duration)
    //{
    //    yield return new WaitForSeconds(duration);
    //    Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
}
