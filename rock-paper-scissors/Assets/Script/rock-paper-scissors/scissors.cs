using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scissors : MonoBehaviour
{
    float[,] scissors_position = new float[24, 2] {{-2.31f, 2.31f}, {-1.54f,2.31f}, {-0.77f, 2.31f}, {0f, 2.31f}, {0.77f, 2.31f}, {1.54f, 2.31f},
     {2.31f, 2.31f}, {-2.31f, -2.31f}, {-1.54f, -2.31f}, {-0.77f, -2.31f}, {0f, -2.31f}, {0.77f, -2.31f}, {1.54f, -2.31f},
     {2.31f, -2.31f}, {-2.31f, 1.52f}, {-2.31f, 0.77f}, {-2.31f, 0f}, {-2.31f, -0.77f}, {-2.31f, -1.54f},
    {2.31f, 1.52f}, {2.31f, 0.77f}, {2.31f, 0f}, {2.31f, -0.77f}, {2.31f, -1.54f}};
    public GameObject scissorsObj;
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if(player.time < timer){
            GameObject makeScissors = Instantiate(scissorsObj);
            makeScissors.transform.position = new Vector3(scissors_position[player.rand[2],0], scissors_position[player.rand[2],1], 0);
            timer = 0;
            Destroy(makeScissors, 5);
        }
    }
}
