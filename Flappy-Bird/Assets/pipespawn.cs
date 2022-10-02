using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;
    public float timespawn = 1f;
    void Start()
    {
        StartCoroutine(pipewave());
    }
    private void SpawnObstacle()
    {
        GameObject cloneobstacle = Instantiate(obstacle) as GameObject;
        cloneobstacle.transform.position = new Vector2(12.4f, Random.Range(-3.51f, 4.51f));
    }
    IEnumerator pipewave()
    {
        while(true)
        {
            yield return new WaitForSeconds(timespawn);
            SpawnObstacle();
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
