using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    float[] rock_position = {-2.31f, -1.54f, -0.77f, 0f, 0.77f, 1.54f, 2.31f};
    static public float rock_position_x;
    static public float rock_position_y;
    float[] rand = {-2.31f, 2.31f};
    public GameObject rockObj;
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if(player.time < timer){
            GameObject makeRock = Instantiate(rockObj);
            if(player.test[0, 0] != 0 || player.test[0, 0] != 6){
                rock_position_x = rand[Random.Range(0,2)];
                rock_position_y = rock_position[player.test[0,0]];
                makeRock.transform.position = new Vector3(rock_position_x, rock_position_y, 0);
                Debug.Log("DD");
            }
            else{
                makeRock.transform.position = new Vector3(rock_position[player.test[0,0]], rock_position[player.test[0,1]], 0);
            }
            timer = 0;
            Destroy(makeRock, 5);
        }
    }
}
