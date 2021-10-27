using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
  public GameObject objectToSpawn;
  private PlacementIndicator placementIndicator;
  private GameObject spawnedObject;
  void Start()
  {
      placementIndicator = FindObjectOfType<PlacementIndicator>();

  }
  void Update()
  {
      if(spawnedObject==null && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began )
      {
           ARPlaceObject();    
      }
  }
  void ARPlaceObject()
    {
        spawnedObject = Instantiate(objectToSpawn,placementIndicator.transform.position,placementIndicator.transform.rotation);
    }
}
