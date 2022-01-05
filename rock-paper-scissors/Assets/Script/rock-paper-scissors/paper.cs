using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paper : MonoBehaviour
{
    float[,] paper_position = new float[24, 2] {{-2.31f, 2.31f}, {-1.54f,2.31f}, {-0.77f, 2.31f}, {0f, 2.31f}, {0.77f, 2.31f}, {1.54f, 2.31f},
     {2.31f, 2.31f}, {-2.31f, -2.31f}, {-1.54f, -2.31f}, {-0.77f, -2.31f}, {0f, -2.31f}, {0.77f, -2.31f}, {1.54f, -2.31f},
     {2.31f, -2.31f}, {-2.31f, 1.52f}, {-2.31f, 0.77f}, {-2.31f, 0f}, {-2.31f, -0.77f}, {-2.31f, -1.54f},
    {2.31f, 1.52f}, {2.31f, 0.77f}, {2.31f, 0f}, {2.31f, -0.77f}, {2.31f, -1.54f}};
    public GameObject paperObj;
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if(player.time < timer){
            GameObject makePaper = Instantiate(paperObj);
            makePaper.transform.position = new Vector3(paper_position[player.rand[1],0], paper_position[player.rand[1],1], 0);
            timer = 0;
            Destroy(makePaper, 5);
        }
    }
}
