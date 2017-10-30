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
	public bool gradeExercise2 = true;

	void Start () {


		if (gradeExercise1) {
			VERIFY_INT (1, 0, XGLHW1._01_simplest_sum (0, 0), "0,0", 1);
			VERIFY_INT (1, 0, XGLHW1._01_simplest_sum (-1, 1), "-1,1", 1);
			VERIFY_INT (1, 14, XGLHW1._01_simplest_sum (7, 7), "7,7", 1);
			VERIFY_INT (1, -1, XGLHW1._01_simplest_sum (2, -3), "2,-3", 1);


			VERIFY_INT (2, 0, XGLHW1._02_simpler_sum (0, 0), "0,0", 1);
			VERIFY_INT (2, 8, XGLHW1._02_simpler_sum (2, 3), "2,3", 1);
			VERIFY_INT (2, 3, XGLHW1._02_simpler_sum (1, 1), "1,1", 1);

			VERIFY_BOOL (3, false, XGLHW1._03_hotDay (10), "10");
			VERIFY_BOOL (3, false, XGLHW1._03_hotDay (79), "79");
			VERIFY_BOOL (3, false, XGLHW1._03_hotDay (80), "80");
			VERIFY_BOOL (3, true, XGLHW1._03_hotDay (105), "105");

			VERIFY_INT (4, 1, XGLHW1._04_simpleSum (0, 1), "0,1");
			VERIFY_INT (4, 3, XGLHW1._04_simpleSum (1, 2), "1,2");
			VERIFY_INT (4, 20, XGLHW1._04_simpleSum (5, 5), "5,5");
			VERIFY_INT (4, 72, XGLHW1._04_simpleSum (34, 2), "34,2");

			VERIFY_INT (5, 6, XGLHW1._05_kindaSimpleSum (true, 1, 2), "true,1,2");
			VERIFY_INT (5, 3, XGLHW1._05_kindaSimpleSum (false, 1, 2), "false,1,2");
			VERIFY_INT (5, 88, XGLHW1._05_kindaSimpleSum (true, 12, 32), "true,12,32");

			VERIFY_INT (6, 10, XGLHW1._06_absoluteValue (-10), "-10");
			VERIFY_INT (6, 1, XGLHW1._06_absoluteValue (1), "1");
			VERIFY_INT (6, 1424, XGLHW1._06_absoluteValue (1424), "1424");
			VERIFY_INT (6, 64, XGLHW1._06_absoluteValue (-64), "-64");

			VERIFY_BOOL (7, false, XGLHW1._07_goodParty (5, 4), "5,4");
			VERIFY_BOOL (7, false, XGLHW1._07_goodParty (5, 1), "5,1");
			VERIFY_BOOL (7, false, XGLHW1._07_goodParty (10, 1), "10,1");
			VERIFY_BOOL (7, true, XGLHW1._07_goodParty (10, 5), "10,5");
			VERIFY_BOOL (7, true, XGLHW1._07_goodParty (10, 6), "10,6");

			printGrade (1);
		}
		score = maxScore = 0;

		if (gradeExercise2) {


			VERIFY_BOOL (1,true,XGLHW2._01_isItCool ("cool"),"cool");
			VERIFY_BOOL (1,false,XGLHW2._01_isItCool ("horse"),"horse");

			VERIFY_STRING (2,"ab",XGLHW2._02_stitcher ("a","b",1),"a,b,1");
			VERIFY_STRING (2, "ba", XGLHW2._02_stitcher ("a", "b", 2), "a,b,2");
			VERIFY_STRING (2, "eeebafea", XGLHW2._02_stitcher ("afea", "eeeb", 2), "afea,eeeb,2");
			VERIFY_STRING (2, "invalid pattern", XGLHW2._02_stitcher ("a", "b", 3), "a,b,3");

			VERIFY_STRING (3, "aaa", XGLHW2._03_front1 ("a"), "a");
			VERIFY_STRING (3, "bbobb", XGLHW2._03_front1 ("bob"), "bob");
			VERIFY_STRING (3, "ccurryc", XGLHW2._03_front1 ("curry"), "curry");

			VERIFY_BOOL(4,false,XGLHW2._04_startsWithA ("banana"),"banana");
			VERIFY_BOOL(4,true,XGLHW2._04_startsWithA ("apple"),"apple");
			VERIFY_BOOL(4,true,XGLHW2._04_startsWithA ("Arby's"),"Arby's");

			VERIFY_STRING (5,"notapple",XGLHW2._05_notString ("apple"),"apple");
			VERIFY_STRING (5,"not horse",XGLHW2._05_notString ("not horse"),"not horse");
			VERIFY_STRING (5,"notNOT apple",XGLHW2._05_notString ("NOT apple"),"NOT apple");

			VERIFY_STRING (6,"",XGLHW2._06_redundantSubstring ("horse",6,1),"horse,6,1");
			VERIFY_STRING (6,"ors",XGLHW2._06_redundantSubstring ("horse",3,1),"horse,3,1");
			VERIFY_STRING (6,"mcdon",XGLHW2._06_redundantSubstring ("mcdonald",5,0),"mcdonalds,5,0");

			VERIFY_STRING (7,"oyb",XGLHW2._07_trickyString ("boy",0),"boy,0");
			VERIFY_STRING (7,"yob",XGLHW2._07_trickyString ("boy",1),"boy,1");
			VERIFY_STRING (7,"ybo",XGLHW2._07_trickyString ("boy",2),"boy,2");
			VERIFY_STRING (7,"abanan",XGLHW2._07_trickyString ("banana",5),"banana,5");
			VERIFY_STRING (7,"ananab",XGLHW2._07_trickyString ("banana",0),"banana,0");
			VERIFY_STRING (7,"herwWERWrraaaeru",XGLHW2._07_trickyString ("aaeruaherwWERWrr",5),"aaeruaherwWERWrr,5");

			printGrade (2);
		}

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

	bool VERIFY_STRING(int questionID, string answer, string studentAnswer, string testInput,float value=1) {
		maxScore += value;
		string outLine = "";
		outLine = "[" + questionID.ToString () + "]";
		if (studentAnswer != answer) {
			outLine += " [WRONG  ]";
			outLine += " (" + testInput + ") -> " + studentAnswer + "[EXPECTED: "+answer +"]";

			outLine += string.Format ("[0/{0} points]", value);
			print (outLine);
			return false;
		} else {
			outLine += " [CORRECT]";
			outLine += " (" + testInput + ") -> " + studentAnswer;
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
