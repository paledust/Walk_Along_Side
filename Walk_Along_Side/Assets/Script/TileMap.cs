using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {
	[SerializeField] Transform player;
	[SerializeField] List<Transform> tiles = new List<Transform>();
	// Use this for initialization
	void Start () {
		foreach(Transform trans in GetComponentsInChildren<Transform>()){
			if(trans.parent == gameObject.transform){
				tiles.Add(trans);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		foreach(Transform tile in tiles){
			if(tile.position.z - player.position.z <= -12.0f){
				tile.position += Vector3.forward * tiles.Count * 2;
			}
		}
	}
}
