using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hello student, don't edit this!
public class XGLHWTESTER : MonoBehaviour {

	float score = 0;
	float maxScore = 0;

	[Tooltip("Stop the console from printing out when you get an answer correct.")]
	public bool hideCorrect = false;

	[Tooltip("Set to true if the grading script should grade this exercise.")]
	public bool gradeExercise1 = true;
	void Start () {

		VERIFY_INT (1,0,XGLHW1._01_simplest_sum (0,0),"0,0",1);
		VERIFY_INT (1,0,XGLHW1._01_simplest_sum (-1,1),"-1,1",1);
		VERIFY_INT (1,14,XGLHW1._01_simplest_sum (7,7),"7,7",1);
		VERIFY_INT (1,-1,XGLHW1._01_simplest_sum (2,-3),"2,-3",1);


		VERIFY_INT (2,0,XGLHW1._02_simpler_sum (0,0),"0,0",1);
		VERIFY_INT (2,8,XGLHW1._02_simpler_sum (2,3),"2,3",1);
		VERIFY_INT (2,3,XGLHW1._02_simpler_sum (1,1),"1,1",1);

		VERIFY_BOOL (3,false,XGLHW1._03_hotDay (10),"10");
		VERIFY_BOOL (3,false,XGLHW1._03_hotDay (79),"79");
		VERIFY_BOOL (3,false,XGLHW1._03_hotDay (80),"80");
		VERIFY_BOOL (3,true,XGLHW1._03_hotDay (105),"105");

		VERIFY_INT (4,1,XGLHW1._04_simpleSum (0,1),"0,1");
		VERIFY_INT (4,3,XGLHW1._04_simpleSum (1,2),"1,2");
		VERIFY_INT (4,20,XGLHW1._04_simpleSum (5,5),"5,5");
		VERIFY_INT (4,72,XGLHW1._04_simpleSum (34,2),"34,2");

		VERIFY_INT (5,6,XGLHW1._05_kindaSimpleSum (true,1,2),"true,1,2");
		VERIFY_INT (5,3,XGLHW1._05_kindaSimpleSum (false,1,2),"false,1,2");
		VERIFY_INT (5,88,XGLHW1._05_kindaSimpleSum (true,12,32),"true,12,32");

		VERIFY_INT (6,10,XGLHW1._06_absoluteValue (-10),"-10");
		VERIFY_INT (6,1,XGLHW1._06_absoluteValue (1),"1");
		VERIFY_INT (6,1424,XGLHW1._06_absoluteValue (1424),"1424");
		VERIFY_INT (6,64,XGLHW1._06_absoluteValue (-64),"-64");

		VERIFY_BOOL (7,false,XGLHW1._07_goodParty (5,4),"5,4");
		VERIFY_BOOL (7,false,XGLHW1._07_goodParty (5,1),"5,1");
		VERIFY_BOOL (7,false,XGLHW1._07_goodParty (10,1),"10,1");
		VERIFY_BOOL (7,true,XGLHW1._07_goodParty (10,5),"10,5");
		VERIFY_BOOL (7,true,XGLHW1._07_goodParty (10,6),"10,6");

		printGrade (1);
	}
	
	bool VERIFY_INT(int questionID, int answer, int studentAnswer, string testInput,float value=1) {
		maxScore += value;
		string outLine = "";
		outLine = "[" + questionID.ToString () + "]";
		if (studentAnswer != answer) {
			outLine += " [WRONG  ]";
			outLine += " (" + testInput + ") -> " + studentAnswer.ToString () + "[EXPECTED: "+answer.ToString ()+"]";

			outLine += string.Format ("[0/{0} points]", value);
			print (outLine);
			return false;
		} else {
			outLine += " [CORRECT]";
			outLine += " (" + testInput + ") -> " + studentAnswer.ToString ();
			score += value;
			outLine += string.Format ("[{0}/{1} points]", value, value);
			if (!hideCorrect) print (outLine);
		}
		return true;
	}


	bool VERIFY_BOOL(int questionID, bool answer, bool studentAnswer, string testInput,float value=1) {
		maxScore += value;
		string outLine = "";
		outLine = "[" + questionID.ToString () + "]";
		if (studentAnswer != answer) {
			outLine += " [WRONG  ]";
			outLine += " (" + testInput + ") -> " + studentAnswer.ToString () + "[EXPECTED: "+answer.ToString ()+"]";

			outLine += string.Format ("[0/{0} points]", value);
			print (outLine);
			return false;
		} else {
			outLine += " [CORRECT]";
			outLine += " (" + testInput + ") -> " + studentAnswer.ToString ();
			score += value;
			outLine += string.Format ("[{0}/{1} points]", value, value);
			if (!hideCorrect) print (outLine);
		}
		return true;
	}

	void printGrade(int HWID) {
		print (string.Format("[EXERCISE {0} SCORE]: {1:P} ({2}/{3}) points",HWID,score/maxScore,score,maxScore)); 
	}
}
