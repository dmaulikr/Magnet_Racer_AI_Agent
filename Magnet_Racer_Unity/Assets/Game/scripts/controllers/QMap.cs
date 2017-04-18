using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class QMap {

	// Public Data
	public string qMapTextLocation;

	// Private Data
	private int learningLaps;
	private Dictionary<QState, int[]> qMap;

	// Number of values in a line
	private static int VALUES_PER_LINE = 7;

	// Use this for initialization
	public QMap(string fileName) {
		learningLaps = 0;
		qMap = new Dictionary<QState, int[]> ();
		//readDataFromFile (fileName);
	}

	// read the stored q map.
	void readDataFromFile(string fileName) {
		qMap.Clear ();
		string line;
		string[] values = new string[VALUES_PER_LINE];
		int[] intValues = new int[VALUES_PER_LINE];
		QState state;
	
		// Read the file and display it line by line.
		StreamReader file = new StreamReader(fileName);

		// Get first line to see number of laps trained for in file
		line = file.ReadLine();
		learningLaps = int.Parse (line);

		while((line = file.ReadLine()) != null)
		{
			Debug.Log("Read line: " + line);
			values = line.Split (";");
			for (int i = 0; i < values.Length; i++) {
				intValues[i] = int.Parse (values[i]);
			}
			state = new QState (intValues [0], intValues [1], intValues [2], intValues [3], intValues [4]);
			int[] qValues = new int[2];
			qValues [0] = intValues [5];
			qValues [1] = intValues [6];

			qMap.Add (state, qValues);
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
		file.Close ();
	}
}
