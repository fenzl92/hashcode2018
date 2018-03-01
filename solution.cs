//Hashcode 2018

using System;
using System.IO;

class program{
	static void Main(){
		
	}
	
	static void readIn(){ //read data in from the .in file
		string[] file = System.IO.ReadAllLines("a_example.in");
		string[] currentLine = file[0].Split(' ');
		simulation Sim = new simulation();
		Sim.availableCars = currentLine[2];
	}
}

class simulation{
	public int currentTime = 0; //current tick, initialised to 0
	public int availableCars; //number of cars not on rides
	public ride[] rides; //array of rides
	public int bonus; //number of bonus points for being early
	public int timeRemaining; //number of ticks left
}

class ride{
	public int startX; //x coord of start pos
	public int startY; //y coord of start pos
	public int endX; //x coord of end pos
	public int endY; //y coord of end pos
	
	public int earliestStart; //earliest start time
	public int latestFinish; //latest finish time
	
	public bool complete;
}

class car{
	public int currentX; //current x coord
	public int currentY; //current y coord
}
