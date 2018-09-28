using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour {

    public static GameObject [][] Border;
    public int BorderH, BorderW;
    private Vector2 StartVector;
    public GameObject FloorTiles;
    private GameObject Room;

	// Use this for initialization
	void Start () {
        Border = new GameObject[BorderW][];
        for (int i = 0; i < BorderW; i++)
        {
            Border[i] = new GameObject[BorderH];

        }
        StartVector.x = BorderW / 2; StartVector.y = BorderH / 2;

        Generate();
	}
	
    
	// Update is called once per frame
	void Update () {
		
	}

     void Generate()
    {
        Room = Instantiate<GameObject>(FloorTiles,new Vector3(StartVector.x,StartVector.y),Quaternion.identity);
      //  Room.transform.localScale = new Vector2(Random.Range(Room.transform.position.x = 3, 8))
    }
}
