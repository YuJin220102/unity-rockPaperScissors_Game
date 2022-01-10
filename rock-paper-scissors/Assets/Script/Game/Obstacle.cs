using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Obstacle : MonoBehaviour
{
    int[] rsZone = new int[5];
    int[] sfZone = new int[5];
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(player.count == 1){
            rsZone[player.count - 1] = player.risk;
            GameObject.Find("Image"+rsZone[0]).GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("Image"+rsZone[0]).GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);

            sfZone[player.count - 1] = player.Safety;
            GameObject.Find("Image"+sfZone[0]).GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("Image"+sfZone[0]).GetComponent<Image>().color = new Color(85/255f, 255/255f, 50/255f, 255/255f);
        }
        
        if(player.count == 2){
            rsZone[player.count - 1] = player.risk; 
            GameObject.Find("Image"+rsZone[1]).GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("Image"+rsZone[1]).GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);

            sfZone[player.count - 1] = player.Safety;
            GameObject.Find("Image"+sfZone[1]).GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("Image"+sfZone[1]).GetComponent<Image>().color = new Color(85/255f, 255/255f, 50/255f, 255/255f);
        }

        if(player.count == 3){
            rsZone[player.count - 1] = player.risk; 
            GameObject.Find("Image"+rsZone[2]).GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("Image"+rsZone[2]).GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);

            sfZone[player.count - 1] = player.Safety;
            GameObject.Find("Image"+sfZone[2]).GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("Image"+sfZone[2]).GetComponent<Image>().color = new Color(85/255f, 255/255f, 50/255f, 255/255f);
        }

        if(player.count == 4){
            rsZone[player.count - 1] = player.risk; 
            GameObject.Find("Image"+rsZone[3]).GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("Image"+rsZone[3]).GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);

            sfZone[player.count - 1] = player.Safety;
            GameObject.Find("Image"+sfZone[3]).GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("Image"+sfZone[3]).GetComponent<Image>().color = new Color(85/255f, 255/255f, 50/255f, 255/255f);
        }

        if(player.count == 5){
            rsZone[player.count - 1] = player.risk; 
            GameObject.Find("Image"+rsZone[4]).GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("Image"+rsZone[4]).GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);

            sfZone[player.count - 1] = player.Safety;
            GameObject.Find("Image"+sfZone[4]).GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("Image"+sfZone[4]).GetComponent<Image>().color = new Color(85/255f, 255/255f, 50/255f, 255/255f);
        }
    }
}
