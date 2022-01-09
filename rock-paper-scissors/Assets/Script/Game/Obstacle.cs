using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Obstacle : MonoBehaviour
{
    // float[,] Obstacle_position = new float[25,2] {{-1.6f, 1.6f},{-1.6f, 0.8f},{-1.6f, 0f},{-1.6f, -0.8f},
    // {-1.6f, -1.6f},{0.8f, 1.6f},{0.8f, 0.8f},{0.8f, 0f},{0.8f, -0.8f},{0.8f, -1.6f},{0f, 1.6f},{0f, 0.8f}
    // ,{0f, 0f},{0f, -0.8f},{0f, -1.6f},{-0.8f, 1.6f},{-0.8f, 0.8f},{-0.8f, 0f},{-0.8f, -0.8f},{-0.8f, -1.6f}
    // ,{-1.6f, 1.6f},{-1.6f, 0.8f},{-1.6f, 0f},{-1.6f, -0.8f},{-1.6f, -1.6f}};
    float time = 5f;
    float timer = 0f;
    // int rand_x, rand_y, rand;
    int rand;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Image0").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("Image0").GetComponent<Image>().color = new Color(82/255f, 82/255f, 82/255f, 255/255f); 
    }

    // Update is called once per frame
    void Update()
    {
            GameObject.Find("Image"+player.Obs).GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("Image"+player.Obs).GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);

           // GameObject.Find("Image"+rand).GetComponent<BoxCollider2D>().enabled = false;
            //GameObject.Find("Image"+rand).GetComponent<Image>().color = new Color(149/255f, 149/255f, 149/255f, 255/255f); 
    }
}
