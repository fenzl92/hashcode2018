//Hashcode 2018

using System;
using System.IO;

class program{

    string[] files = new string[] { "a_example.in", "b_should_be_easy.in", "c_no_hurry.in", "d_metropolis.in", "e_high_bonus.in" };
    int cars;

	static void Main(){
		
	}
	
	static void readIn(){ //read data in from the .in file
		string[] file = System.IO.ReadAllLines(files[0]);
		string[] currentLine = file[0].Split(' ');
        cars = currentLine[2];
    }
}

class ride{
	public int startX; //x coord of start pos
	public int startY; //y coord of start pos
	public int endX; //x coord of end pos
	public int endY; //y coord of end pos
	
	public int earliestStart; //earliest start time
	public int latestFinish; //latest finish time
}

class car{
	public int currentX; //current x coord
	public int currentY; //current y coord
}
