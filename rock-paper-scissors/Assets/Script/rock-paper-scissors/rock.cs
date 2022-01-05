using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    float[,] rock_position = new float[24, 2] {{-2.31f, 2.31f}, {-1.54f,2.31f}, {-0.77f, 2.31f}, {0f, 2.31f}, {0.77f, 2.31f}, {1.54f, 2.31f},
     {2.31f, 2.31f}, {-2.31f, -2.31f}, {-1.54f, -2.31f}, {-0.77f, -2.31f}, {0f, -2.31f}, {0.77f, -2.31f}, {1.54f, -2.31f},
     {2.31f, -2.31f}, {-2.31f, 1.52f}, {-2.31f, 0.77f}, {-2.31f, 0f}, {-2.31f, -0.77f}, {-2.31f, -1.54f},
    {2.31f, 1.52f}, {2.31f, 0.77f}, {2.31f, 0f}, {2.31f, -0.77f}, {2.31f, -1.54f}};
    public GameObject rockObj;
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if(player.time < timer){
            GameObject makeRock = Instantiate(rockObj);
            makeRock.transform.position = new Vector3(rock_position[player.rand[0],0], rock_position[player.rand[0],1], 0);
            timer = 0;
            Destroy(makeRock, 5);
        }
    }
}
