using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {

	bool playerWon = false; //used to end the game

	public Text text; //UI text; used to display messages to the player
	public Transform player; //the player's location
	public Transform treasure; //the goal's location

	//landmarks
	public Transform palm;
	public Transform bottle;
	public Transform shadow;
	public Transform oasis;

	void Start(){
		treasure = this.transform;
	}
	
	// Update is called once per frame
	void Update () {

		if (playerWon) {
			//victory messages
			text.text = "You found the treasure! Congratulations!";
		
		//Allows the player to pickup the treasure if they are close enough
		} else if ((player.position - treasure.position).magnitude < 5f) {
			text.text = "Here it is! Press [SPACE] to collect the treasure!";

			if (Input.GetKeyUp (KeyCode.Space)) {
				playerWon = true;
			}
		} // End player win condition

		//Hints are listed here
		if ((player.position - palm.position).magnitude < 5f) {
			text.text = "Is that? A message in a bottle south east of here?";
		}
		if ((player.position - bottle.position).magnitude < 5f) {
			text.text = "It says to head to the shadow of the great stone, north.";
		}
		if ((player.position - shadow.position).magnitude < 10f) {
			text.text = "Follow the shadow North-West until you reach an oasis";
		}
		if ((player.position - oasis.position).magnitude < 15f) {
			text.text = "Almost there! Just North and to the East to the trasure!";
		}
	
	} //End void Update()
} 
