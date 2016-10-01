using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
		cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom,
		corridor_0, stairs_0, closet_door, floor, corridor_1, stairs_1, in_closet,
		corridor_2, stairs_2, corridor_3, courtyard
	};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if 		(myState == States.cell)		{sCell ();} 
		else if (myState == States.sheets_0) 	{sSheets0 ();} 
		else if (myState == States.lock_0) 		{sLock0 ();}
		else if (myState == States.mirror)  	{sMirror ();}
		else if (myState == States.cell_mirror) {sCellMirror ();} 
		else if (myState == States.sheets_1) 	{sSheets1 ();} 
		else if (myState == States.lock_1) 		{sLock1 ();}
		else if (myState == States.corridor_0) 	{sCorridor0 ();}
		else if (myState == States.stairs_0) 	{sStairs0 ();}
		else if (myState == States.closet_door)	{sClosetDoor ();}
		else if (myState == States.floor) 		{sFloor ();}
		else if (myState == States.corridor_1) 	{sCorridor1 ();}
		else if (myState == States.stairs_1) 	{sStairs1 ();}
		else if (myState == States.in_closet) 	{sInCloset ();}
		else if (myState == States.corridor_2) 	{sCorridor2 ();}
		else if (myState == States.stairs_2) 	{sStairs2 ();}
		else if (myState == States.corridor_3) 	{sCorridor3 ();}
		else if (myState == States.courtyard) 	{sCourtyard ();}
	}

	void sCell(){
		text.text = "You wake up in a prison cell, and are unsure how you got there.  However, " +
					"there is one thing you are sure of: You have to escape! There are some dirty " +
					"sheets on the bed, a mirror on the wall, and the door is locked from the outside.\n\n" +
					"Press S to check the Sheets.\nPress M to check the Mirror.\nPress L to check the Lock.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		}
	}

	void sSheets0(){
		text.text = "You think to youself... \"How long have I been sleeping here...?\"\n\n" + 
					"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	void sLock0(){
		text.text = "You try to open the door but notice it's locked from the outside.  You notice a keyhole " + 
					"under the doorknob...\n\nPress R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	void sMirror(){
		text.text = "You look at yourself in the mirror... God you're ugly... but you notice a piece of tape coming " +
					"out of the left side and you pull it... A key comes out!\n\nPress K to pick up the Key.";
		if (Input.GetKeyDown (KeyCode.K)) {
			myState = States.cell_mirror;
		}
	}

	void sCellMirror(){
		text.text = "There are some dirty " +
					"sheets on the bed, a mirror on the wall, and the door is locked from the outside.\n\n" +
					"Press S to check the Sheets.\nPress L to check the Lock.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		}
	}

	void sSheets1(){
		text.text = "You think to youself... \"How long have I been sleeping here...?\"\n\n" + 
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}

	void sLock1(){
		text.text = "You try to open the door but notice it's locked from the outside.  You notice a keyhole " + 
			"under the doorknob...You put the key in the keyhole and hold your breath as you turn it.... *Click* " +
			"It unlocked! You swing the door open to your escape! Congrats! You're out of the cell! Now you're in " +
			"a corridor...?\n\nPress C to Continue.";
		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.corridor_0;
		}
	}

	void sCorridor0() {
		text.text = "You see some stairs to your left going to the next floor along with a closet along the north wall..." +
			"\n\nPress S to go up the Stairs.\nPress C to check the closet.\nPress F to look around the floor.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_0;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.closet_door;
		} else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.floor;
		}
	}

	void sStairs0(){
		text.text = "You start climbing the steps when you hear a few deep voices.  They sound like royal Ogres..." + 
			" They'll kill me for sure if they spot me!\n\nPress R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
	}

	void sClosetDoor(){
		text.text = "You open the closet door... Or at least your tried, but it's locked! Another damn keyhole..? fuhh.." + 
			"\n\nPress R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
	}

	void sFloor(){
		text.text = "You look around the small floor and notice a little sparkle in between two tiles... A Hairpin? What's " + 
			"that doing here..?\n\nPress H to pick up the Hairpin.\nPress R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		} else if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.corridor_1;
		}
	}

	void sCorridor1() {
		text.text = "You see some stairs to your left going to the next floor along with a closet along the north wall..." +
			"\n\nPress S to go up the Stairs.\nPress C to check the closet.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_1;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.in_closet;
		}
	}

	void sStairs1(){
		text.text = "You start climbing the steps when you hear a few deep voices.  They sound like royal Ogres..." + 
			" They'll kill me for sure if they spot me! This hairclip isn't going to do shit for me here!\n\nPress R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_1;
		}
	}

	void sInCloset(){
		text.text = "You open the closet door... using the hairpin you found as a lock pick! Inside you see a bunch of cleaning " + 
			"supplies... More importantly, you find a cleaning uniform that's too small for you!\n\nPress D to Dress up anyways.\n" +
			"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_2;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.corridor_3;
		}
	}

	void sCorridor2() {
		text.text = "You see some stairs to your left going to the next floor along with a closet along the north wall..." +
			"\n\nPress S to go up the Stairs.\nPress C to check the closet.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_2;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.in_closet;
		}
	}

	void sStairs2(){
		text.text = "You start climbing the steps when you hear a few deep voices.  They sound like royal Ogres..." + 
			" They'll kill me for sure if they spot me! Do I really need to put the small uniform on!?!\n\nPress R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_2;
		}
	}

	void sCorridor3() {
		text.text = "This thing makes me look stupid... Is it enough to fool these Ogres? Damn I don't know if I can walk out like " +
			"this... \n\nPress U to Undress.\nPress S to go up the Stairs.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.courtyard;
		} else if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.in_closet;
		}
	}

	void sCourtyard() {
		text.text = "As you go up the stairs contemplating your terrible doom... you notice that they're nowhere to be seen and the " +
			"front door is wide open! You're free and you're wearing the small cleaning dress for nothing! HAHA! Oh well, Congrats! " +
			"At least you didn't die! =]\n\nPress R to Replay.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
}
