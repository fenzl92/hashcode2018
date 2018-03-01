//Hashcode 2018

using System;
using System.IO;

class program{
	public int currentTime = 0; //current tick, initialised to 0
	public int availableCars; //number of cars not on rides
	public ride[] rides; //array of rides
	public car[] cars; //array of cars
	public int bonus; //number of bonus points for being early
	public int timeRemaining; //number of ticks left
	
	static void Main(){
		
	}
	
	static void readIn(){ //read data in from the .in file
		string[] file = System.IO.File.ReadAllLines("a_example.in");
		string[] currentLine = file[0].Split(' ');
		for(int i = 0; i < 6; i++){
			currentLine[i] = Convert.ToInt32(currentLine[i]);
		}
		availableCars = currentLine[2];
		cars = new car[currentLine[2]];
		rides = new ride[currentLine[3]];
		bonus = currentLine[4];
		timeRemaining = currentLine[5];
		
	}
	
	public void advance(){
		//advance 1 tick
	}
}

class ride{
	public int[] start = new int[2]{0, 0}; //start pos
	public int[] endX = new int[2]{0, 0}; //end pos
	
	public int earliestStart; //earliest start time
	public int latestFinish; //latest finish time
	
	public bool complete = false;
}

class car{
    public int[] currentPos = new int[2] {0,0};
    public int[] destination = new int[2];
    public bool busy = false;
}
