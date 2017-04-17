using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class QMap : MonoBehaviour {

	private Dictionary<QState, int[]> qMap;

	// Use this for initialization
	void Start () {
		qMap = new Dictionary<QState, int[]> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// read the stored q map.
	void readDataFromFile(string fileName) {
		int counter = 0;
		string line;

		// Read the file and display it line by line.
		StreamReader file = 
			new StreamReader(fileName);
		while((line = file.ReadLine()) != null)
		{
			print (line);
			counter++;
		}

		file.Close();

	}

	// Update the stored q map.
	void writeDataToFile(string fileName) {
		StreamWriter file = new StreamWriter (fileName, false);
		{
			string titleLine = "Data collection Date: " + System.DateTime.Now.ToString ();
			file.WriteLine ("");file.WriteLine ("");
			file.WriteLine (titleLine);
			for(int i = 0; i < qMap.Keys.Count; i++) 
			{
				string line = "fake lin;";

				file.WriteLine(line);
			}
		}
	}
}
