using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// XGL Homework 3. This will help you get used to for loops and using arrays.

public class XGLHW3 : MonoBehaviour {



	// Fix this for-loop so that it adds four to the input!
	// Remember, a for loop has three parts in the "( )":
	// 1. the iterator variable declaration(int i = 0), which keeps track of how many times the loop has run
	// 2. the conditional expression (i < 2), which if true, allows the for loop to run again,
	// 3. and the increment expression (i++), or how much the iterator changes every time the loop runs.

	// Hint: you only need to change one number here.

	// Examples:
	// 2 -> 6
	// 5 -> 9
	// -4 -> 0
	static public int loop_1_add_four(int input) {

		int output = input;
		for (int i = 0; i < 2; i++) {
			output++;
		}
		return output;
	}


	// Return an array of size three, with the three elements a, b, and c.
	// It's array time! arrays are fixed-sized data structures that hold a single type of value. 
	// Creating an array can be done in two ways:
	// TYPE[] ARRAYNAME = new TYPE[]{VALUE1,VALUE2,...}
	//		e.g.: int[] integerArray = new int[]{1,4,5,3};
	// TYPE[] ARRAYNAME = new TYPE[ARRAYSIZE];
	//		e.g.: string[] stringArray = new string[3];

	// Examples
	// 1,4,5 -> [1,4,5]
	// 0,0,1 -> [0,0,1]
	static public int[] array_creation(int a, int b, int c) {
		return new int[1];
	}


	// return the first element of the array!
	// You can access an element of an array using the "[]" syntax:
	// a[3] = return the 4th element from a. a[2] = the 3rd element, etc.
	// Note, arrays index from zero. So the "4th" element actually has an index of 3. The 1st element has an index of 0.
	// Note: a will always have at least one element
	// Examples:
	// [1,2,3] -> 1
	// [3,4,5] -> 3
	// [4,1,4,2,2,2,2,2,2,3,4,1,1,4,1,4,1,1] -> 4
	static public int array_getTheFirstElement(int[] a) {
		return -1;
	}

	// return the i-th element of the array!
	//Note: i will always be > 0 and < a.Length

	// Examples:
	// [1,2,3],2 -> 3
	// [3,4,5],0 -> 3
	// [4,1,4,2,2,2,2,2,2,3,4,1,1,4,1,4,1,1],2 -> 4
	static public int array_getTheIthElement(int[] a, int i) {
		return -1;
	}

	// Return a single string made up of the concatenation of the first "num" strings in input. You'll need to make a loop!
	// Hint: You'll somehow need to incorporate "num" into the three parts of your for loop's initialization.
	// Note: You can assume 'num' will always be > 0 and <=  input.Length , and that input always has at least one element

	// Examples:
	// ["a","b","c"],3 -> "abc"
	// ["a","b","c"],1 -> "a"
	static public string loop_bigString(string[] input, int num) {
		return "";
	}

	// Use .Length to return the length of the input array. 
	// E.g. if "input" = [0,2,3,4], then "input.Length" would give you 4, because there are 4 elements in "input".
	// [0] -> 1
	// [4,3,5,1,2] -> 5
	static public int array_length(int[] input ){ 
		return -1;
	}

	// return the sum of every element in the array.
	// Hint: you'll need to use input.Length somehow.
	// examples
	// [1,1,1] -> 3
	// [3] -> 3
	// [5,4,3,2,1] -> 15
	static public int array_sum(int[] input) {
		return -1;
	}


	// return the sum of every element in the array with an even index (0,2,4, etc.)
	// You will need to use the modulo/remainder (%) operator, which works like the following:
	//  a % b = the remainder of a divided by b.
	//	4 % 2 = 0
	//  1 % 2 = 1
	//	3 % 2 = 1
	//  5 % 3 = 2

	// examples
	// [1,1,1] -> 2
	// [3] -> 3
	// [5,4,3,2,1] -> 9
	static public int array_EvenSum(int[] input) {
		return -1;
	}


	// Change the second element of the array to the first element, and return the array.
	// [1,2] -> [1,1]
	// [2,0,1] -> [2,2,1]
	static public int[] array_3_changer(int[] input) {
		return input;
	}

	// Change the a-th element of the array to the b-th element of the array, only if the a-th element is > than the b-th element.
	// Return the possibly modified array.
	// [1,2],0,1 -> [1,2]
	// [2,0,1],0,2 -> [1,0,1]
	static public int[] array_4_changer2(int[] input, int a, int b) {
		return input;
	}

	// A Vector3 is an object. Objects are just special types of variables that can have many properties associated with them.
	//
	// A Vector 3 contains 3 properties (or values), x, y, and z. In the context of Vector3, these values are also called 'components' to 
	//		refer to the components of a vector in 3D space.
	// Return the x component of the vector if "getX" is true, otherwise return the y component.
	// To access a component of a Vector named 'v':
	//		v.x 
	//		v.y
	// Vector3 w/ components {1,2,3},false -> 2
	// Vector3 w/ components {1,2,3},true -> 1
	static public float vector_getComponent(Vector3 v, bool getX) {
		return -1;
	}

	// Is the position vector of this transform's x property greater than zero?
	// Note: A transform represents the position, rotation and scale of a gameObject in Unity.
	// To access properties of a transform (or any other object), use the dot operator, '.', just like you used to access a component of a vector3.
	// E.g. : transform.position transform.quaternion, transform.eulerAngles
	// transform with position {4,3,-1} -> true
	// transform with position {-2,3,1} -> false
	static public bool vector_isXPositive(Transform transform) {
		return false;	
	}

	// Given an array of game objects, does at least one of them have an x-position that is > 0?
	// You loop through arrays of objects just like you do arrays of ints and strings.
	// A GO/gameobject always has a transform property.
	// [GO w/ pos {1,2,3}, GO w/ pos {0,2,3}] -> true
	// [GO w/ pos {-1,2,3}, GO w/ pos {0,2,3}] -> false
	static public bool vector_isOnePositive(GameObject[] objects) {
		return false;
	}

	// This function does nothing, but acts as a reference for correct syntax.
	void exampleSyntax() {

		int[] initiallyEmptyIntArrayOfSizeFive = new int[5];
		int[] intArrayWithInitialElements = new int[]{ 5, 4, 1 };

		int[] testArray = new int[]{ 1, 2, 3, 4, 5 };
		testArray [1] = 2; // Change an element of an array. In this case, the 2nd element of the array (or element with index 1) will change.


		// Run this code 5 times.
		for (int i = 0; i < 5; i++) {
			// Use a variable as the index into an array.
			initiallyEmptyIntArrayOfSizeFive [i] = 3;
		}

		int someNumber = 6;
		for (int i = 0; i < someNumber; i++) {
			// Do something someNumber times.
		}

		for (int i = 0; i < intArrayWithInitialElements.Length; i++){
			// Do something as many times as there are elements in intArrayWithInitialElements.
		}

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


		string str = "apple";
		str = "apple" + "banana"; // str is now "applebanana"
		int ai = 1;
		string ith_letter = str[ai].ToString ();
		ith_letter = ith_letter + ith_letter;

		// .Substring() gets part of an existing string, or a 'substring'.
		// The first parameter is what character of the string the
		// substring should start from, the second parmater is how long the substring should be
		// In this case, we are getting 5 characters of the string 'str', starting at index 0.
		// So we are getting "apple" out of "applebanana".
		string partOfString = str.Substring (0, 5); // partOfString is now "apple".

		partOfString = partOfString + "1";
	}
}
