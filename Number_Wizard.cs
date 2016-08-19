using UnityEngine;
using System.Collections;

public class Number_Wizard : MonoBehaviour {
	int Min = 1;
	int Max = 1000;
	int guess = 500;

	// Use this for initialization
	void Start () {
		print ("Guess a number between "	+Min		+" and "	+Max);
		print ("If your number is higher than 500 press up or if it is lower than 500 press down");
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up arrow was pressed");
			Min = guess;
			guess = (Min + Max) / 2;
			print ("is your number lower or higher than" +guess);
		}

			if  (Input.GetKeyDown(KeyCode.DownArrow)) {
			print ("Down arrow was pressed");
			Max = guess;
			guess = (Min + Max) /2;
			print ("is your number lower or higher than" +guess);

				
		}
	
	}

}