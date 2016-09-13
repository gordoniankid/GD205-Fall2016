using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public int playerX, playerZ;
	public GameObject textObject;
	Vector3 tempPos;
	// Use this for initialization
	void Start () {

		//playerX = 5;
		//playerZ = 10000;
		//Debug.Log (transform.position);
		transform.position = new Vector3(playerX,0,playerZ);
		textObject.GetComponent<TextMesh> ().text = "test";

		tempPos = transform.position;
		tempPos.x = 0;
		tempPos.z = 0;
		transform.position = tempPos;

	}

	// Update is called once per frame
	void Update () {
		playerZ = (int)transform.position.z;
		playerX = (int)transform.position.x;


		transform.position += tempPos;


		if (Input.GetKeyDown ("up")) {
			transform.position += new Vector3 (0, 0, 1);
		}
		if (Input.GetKeyDown ("down")) {
			transform.position += new Vector3 (0, 0, -1);
		}

		if (Input.GetKeyDown ("left")) {
			transform.position += new Vector3 (-1, 0, 0);
		}
		if (Input.GetKeyDown ("right")) {
			transform.position += new Vector3 (1, 0, 0);

		}

		textObject.GetComponent<TextMesh> ().text = "Position: (" + transform.position.x + ", " + transform.position.z + ")"; 

		if (playerX == 0 && playerZ == 2) {//player is at the bad position
			transform.position = tempPos;

		}

		if (playerX == 4 && playerZ == 1)
		{//player is at the bad position
			transform.position = tempPos;
		}

		if (playerX == -3 && playerZ == 1)
		{//player is at the bad position
			transform.position = tempPos;
		}

		if (playerX == 0 && playerZ == -4)
		{//player is at the bad position
			transform.position = tempPos;
		}

		if (playerX == 5 && playerZ == 0)
		{//player is at the bad position
			transform.position = tempPos;
		}

		if (playerX == 4 && playerZ == -3)
		{//player is at the bad position
			textObject.GetComponent<TextMesh>().text = "Winner: (" + 4 + ", " + -3 + ")";
		}



	}

}



