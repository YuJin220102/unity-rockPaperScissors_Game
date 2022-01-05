using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_RPS : MonoBehaviour
{
    public GameObject rock;
    public GameObject paper;
    public GameObject scissors;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.Rptrand == 0){
            rock.SetActive(true);
            paper.SetActive(false);
            scissors.SetActive(false);
        }
        if(player.Rptrand == 1){
            rock.SetActive(false);
            paper.SetActive(true);
            scissors.SetActive(false);
        }
        if(player.Rptrand == 2){
            rock.SetActive(false);
            paper.SetActive(false);
            scissors.SetActive(true);
        }
    }
}
