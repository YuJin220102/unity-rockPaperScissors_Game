using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_RPS : MonoBehaviour
{
    static public float[,] position = new float[20, 2] {{-1.6f,2.4f}, {-0.8f, 2.4f}, {0f, 2.4f}, {0.8f, 2.4f}, {1.6f, 2.4f},
    {-1.6f, -2.4f}, {-0.8f, -2.4f}, {0f, -2.4f}, {0.8f, -2.4f}, {1.6f, -2.4f},
    {-2.4f, 1.6f}, {-2.4f, 0.8f}, {-2.4f, 0f}, {-2.4f, -0.8f}, {-2.4f, -1.6f},
    {2.4f, 1.6f}, {2.4f, 0.8f}, {2.4f, 0f}, {2.4f, -0.8f}, {2.4f, -1.6f}};
    public GameObject rockObj;
    public GameObject paperObj;
    public GameObject scissorsObj;

    void Update()
    {
        rockObj.transform.position = new Vector3(position[player.rand[0],0], position[player.rand[0],1], 0);
        paperObj.transform.position = new Vector3(position[player.rand[1],0], position[player.rand[1],1], 0);
        scissorsObj.transform.position = new Vector3(position[player.rand[2],0], position[player.rand[2],1], 0);
    }
}

