using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// XGL Homework 1. This will test your skills with basic math and conditional statements.
// READ THE CODING BASICS HANDOUT to familiarize yourself with the basics of integers, floats, and booleans.

// ***INSTRUCTIONS***
// 1. Fill in the functions with the correct code! All of these functions are 'wrong'.
// 2. To check your work, save this script, attach it to an empty game object and hit play (command+P)
// 3. Look in the console (command+shift+C) to see your score and errors.

// ***SUBMISSION***
// Submit a screenshot of your grade to canvas (command+shift+4, click+drag around the box, submit that .png) ! 
// I will grade based on it. Don't lie.

// **INFORMATION**
// When you see "(x,y) -> z", this means the when the input parameters have the values
// x and y, the function should return z.
//

public class XGLHW1 : MonoBehaviour {


	// Return the sum of two numbers, a and b.
	static public int _01_simplest_sum(int a, int b) {
		return -1;
	}

	// Return the sum of b, and twice c.
	// (2,3) -> 8
	// (1,1) -> 3
	static public int _02_simpler_sum(int b, int c) {
		return -1;
	}

	// If it's a hot day, return 'true'. Otherwise, return 'false'.
	// A hot day is when temperature > 80.
	static public bool _03_hotDay(int temperature) {
		return false;	
	}

	// If d is greater than or equal to e, return twice the sum of d and e.
	// Otherwise, return the sum of d and e.
	// (0,1) -> 1
	// (2,2) -> 8
	// (3,1) -> 8
	// (1,5) -> 6
	static public int _04_simpleSum(int d, int e) {
		return -1;
	}

	// If doubleIt is true, return twice the sum of f and g.
	// Otherwise, return the sum of f and g.
	// (true,1,2) -> 6
	// (false,1,2) -> 3
	static public int _05_kindaSimpleSum(bool doubleIt, int f, int g) {
		return -1;
	}

	// Return the absolute value of a.
	// Hint: Use the Mathf.abs() function.
	// (-10) -> 10
	// (0) -> 0
	// (10) -> 10
	static public int _06_absoluteValue(int a) {
		return -1;
	}

	// Return true if the party was good.
	// A party is good if there are at least 10 guests and at least half of them are cool.
	// numGuests = the number of guests
	// coolGuests = the number of guests that are cool.
	// (5, 3) -> false
	// (10, 4) -> false
	// (15, 5) -> false
	// (19, 10) -> true
	static public bool _07_goodParty(float numGuests, int coolGuests) {
		return false;
	}


	// This function does nothing, but acts as a reference for correct syntax.
	void exampleSyntax() {
		// Basic math operators. You can also group things by parentheses.
		int a = 0;
		int b = 0;
		a = a + b;
		a = a - b;
		a = a * b;
		a = a / b;
		a = (a + 1) * b;
		a = (a + (b - 4)) * (b - (a / 2));

		// Increment/decrement operators. Increases or decreases a variable by 1.
		a ++;
		a--;
		a += 1;
		a -= 1;

		// Shorthand multiplication (equivalent to a = a * 2, and a = a / 2);
		a *= 2;
		a /= 2;

		// if-else statements. 
		bool c = false;
		bool d = false;

		if (c) {
			// Do something because c was true.
		}

		if (c) {
			// Do s.t. b/c c was true.
		} else {
			// Otherwise, do some default action.
		}

		if (c) {
			// Do s.t. b/c c was true.
		} else if (d) {
			// otherwise, do s.t. b/c d was true.
		} else {
			// Otherwise, do some default action.
		}
	}
}
