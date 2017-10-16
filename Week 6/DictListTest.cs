using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictListTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<string> stringList= new List<string> ();

		// List is now ["a"]
		stringList.Add ("a");

		// List is now ["a","b","c"]
		stringList.AddRange (new string[]{"b","c"});


		// Removes the first matching item. In this case, the list would now have ["a","c"]
		stringList.Remove ("b");
		printList (stringList);

		// Removes the item with index 0, so now the list is just ["c"];
		stringList.RemoveAt (0);

		// Practical uses for lists:
		// - Managing all instances of a type of script in the game
		// - When you need an array but need to be able to resize it
		// - ... a lot more!

		// A dictionary is useful when you have data consisting of pairs with some kind of relation.
		// Dictionaries store 'key-value' pairs, where a key is used to look up a corresponding value.
		// For an impractical example, you could associate first names with last names.
		Dictionary<string,string> firstToLastNames = new Dictionary<string,string> ();

		// Adds a key-value pair, where "Sean" is the key which can be used to look up "Han Tani".
		firstToLastNames.Add ("Sean","Han Tani");

		firstToLastNames.ContainsKey ("Sean"); // True
		firstToLastNames.ContainsKey ("Han Tani"); // False
		firstToLastNames.ContainsValue ("Sean"); // False
		firstToLastNames.ContainsValue ("Han Tani"); // True

		print (firstToLastNames ["Sean"]);

		// I don't use Dictionaries too often in Unity, but they can be useful for certain engine things.
		// A reason why I don't use them too often is Unity handles a lot of stuff that would normally requires dictionaries.
		// For example, I use them to store dialogue data. I tend to give all my dialogue a title that acts like a key,
		// and then for the value, I store a bunch of dialogue like "Bob: I went to the store..." , etc.
		// This is so that I can type the key into a public script property on an NPC script.
		// So the KV (key-value) pairs in this case are (DIALOGUE_TITLE,DIALOGUE_DATA), both of type string.

		// Generally you use Dictionaries to cache certain data relations that are stored in databases, so you don't have to
		// re-parse that database. For example in Even the Ocean I would store a lot of metadata about NPCs using 
		// (NPC_Name,NPC_Data) pairs, where the K/V is a string.
		// e.g. ("Bob","bobSpritesheet.png frameWidth=16 frameHeight=16")

		// Or, I would store metadata about a particular level's backgrounds as so:
		// (LEVEL_NAME,Level_data) . Again, both K and V are strings.
		// e.g.: ("SHORE_1","shore_background.png 640 480")
		//
		// Note: Dictionaries' values can also be DICTIONARIES! Occasionally this is useful.
	}

	void printList(List<string> l) {
		print ("printing list-----");
		for (int i = 0; i < l.Count; i++ ) {
			print (l[i]); 
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
