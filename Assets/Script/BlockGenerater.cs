using UnityEngine;
using System.Collections;

public class BlockGenerater : MonoBehaviour
{

    public GameObject block;
    float rotspeed = 10;

    // Use this for initialization
    void Start()
    {
        for (int i = -5; i < 5; i++)
        {
            for (int j = -5; j < 5; j++)
            {
                var newblock = (GameObject)Instantiate(block);
                newblock.transform.parent = this.transform;
                newblock.transform.localPosition = new Vector3(i * 3, j * 3 , 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1.0f; //1秒間に3D空間を1移動する
        Vector3 pos = this.transform.localEulerAngles;
        pos.z += speed * Time.deltaTime;
        this.transform.localEulerAngles = pos;
    }
}