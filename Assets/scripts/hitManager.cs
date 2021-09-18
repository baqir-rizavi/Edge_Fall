using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("obstacle")) // game over
        {

            //DisplayGameOverUI();
            
            GameMaster.instance.playerManager.respawn();
            Destroy(gameObject);

            Debug.Log("respawn");
        }
    }

    void DisplayGameOverUI()
    {
        throw new System.NotImplementedException();


        //TODO: create mainmenu and game over canvas UI

        //TODO: implement function
    }

}
