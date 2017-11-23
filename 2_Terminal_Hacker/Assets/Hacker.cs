using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ShowMainMenu("Welcome David");
	}

    void ShowMainMenu (string greeting) {
		Terminal.ClearScreen();
		Terminal.WriteLine(greeting);	
		Terminal.WriteLine("What would you like to hack into?");	
		Terminal.WriteLine("Press 1 - Neigbhors WIFI");	
		Terminal.WriteLine("Press 2 - Google");	
		Terminal.WriteLine("Press 3 - NSA");	
		Terminal.WriteLine("Enter your selection:");	
	}

	void OnUserInput(string input)
		{
			print(input);
		}
}
