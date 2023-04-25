using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public int objNum;
    public GameObject objCollect;

    public Transform leftTop;
    public Transform rightBottom;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < objNum; i++)
        {
            float newX = Random.Range(leftTop.position.x, rightBottom.position.x);
            float newY = Random.Range(rightBottom.position.y, leftTop.position.y);
            Vector3 newPos = new Vector3(newX, transform.position.z, newY);
            GameObject newObj = Instantiate(objCollect, newPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
