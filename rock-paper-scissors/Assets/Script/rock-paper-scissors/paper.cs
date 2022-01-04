using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paper : MonoBehaviour
{
    static public float[] paper_position = {-2.31f, -1.54f, -0.77f, 0f, 0.77f, 1.54f, 2.31f};
    float[] rand = {-2.31f, 2.31f};
    public GameObject paperObj;
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if(player.time < timer){
            GameObject makePaper = Instantiate(paperObj);
            if(player.test[2, 0] != 0 || player.test[2, 0] != 6){
                makePaper.transform.position = new Vector3(rand[Random.Range(0,2)], paper_position[player.test[1,0]], 0);
            }
            else{
                makePaper.transform.position = new Vector3(paper_position[player.test[1,0]], paper_position[player.test[1,1]], 0);
            }
            timer = 0;
            Destroy(makePaper, 5);
        }
    }
}
