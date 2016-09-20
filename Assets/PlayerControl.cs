using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public Camera mainCam;
	public GameObject player;
	private float movementSpeed = 5;

	// Update is called once per frame
	void Update () {
		//movement script
		if (Input.GetKey (KeyCode.A) && player.transform.position.x > -33) {
			player.transform.position += new Vector3 (-movementSpeed, 0, 0) * Time.deltaTime; //Movement; time independant
			player.transform.eulerAngles = new Vector3 (0, 270, 0); //rotate to face movement direction
		}//end leftward movement

		if (Input.GetKey (KeyCode.D) && player.transform.position.x < 62 ) {
			player.transform.position += new Vector3 (movementSpeed, 0, 0) * Time.deltaTime; //Movement; time independant
			player.transform.eulerAngles = new Vector3 (0, 90, 0); //rotate to face movement direction
		}//end rightward movement

		if (Input.GetKey (KeyCode.W) && player.transform.position.z < 158 ) {
			player.transform.position += new Vector3 (0, 0, movementSpeed) * Time.deltaTime; //Movement; time independant
			player.transform.eulerAngles = new Vector3 (0, 0, 0); //rotate to face movement direction
		}//end forward movement

		if (Input.GetKey (KeyCode.S) && player.transform.position.z > -36) {
			player.transform.position += new Vector3 (0, 0, -movementSpeed) * Time.deltaTime; //Movement; time independant
			player.transform.eulerAngles = new Vector3 (0, 180, 0); //rotate to face movement direction
		}//end backward movement

		//this script moves the camera along with the player
		Camera.main.transform.position = transform.position + new Vector3(0f,5f,-9f);
	}
}
