using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scissors : MonoBehaviour
{
    float[] scissors_position = {-2.31f, -1.54f, -0.77f, 0f, 0.77f, 1.54f, 2.31f};
    static public float scissors_position_x;
    static public float scissors_position_y;
    float[] rand = {-2.31f, 2.31f};
    public GameObject scissorsObj;
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if(player.time < timer){
            GameObject makeScissors = Instantiate(scissorsObj);
            if(player.test[1, 0] != 0 || player.test[1, 0] != 6){
                makeScissors.transform.position = new Vector3(rand[Random.Range(0,2)], scissors_position[player.test[2,0]], 0);
            }
            else{
                makeScissors.transform.position = new Vector3(scissors_position[player.test[2,0]], scissors_position[player.test[2,1]], 0);
            }
            timer = 0;
            Destroy(makeScissors, 5);
        }
    }
}
