using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: unset gameobject (player manager) from gameMaster's child and add script to Gamemaster as component 

public class PlayerManager : MonoBehaviour
{
   public Transform car; // player prefab 
   public Transform currentCar;

   public void respawn()
   {
        currentCar = Instantiate(car);
   }

   public Transform GetPlayerTransform()
   {
       return currentCar;
   }
}
