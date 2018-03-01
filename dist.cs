using System;
class Ride{
	static void Main(){
		int[] carPos = new int[] {0,0};
		int[] ridePos = new int[] {2,2};
		int rideDist = Distance(carPos,ridePos);
		Console.WriteLine("{0} = distance",rideDist);
		Console.ReadLine();
	}
	static int Distance(int[]carPos,int[]ridePos){
		int dist = 0;
		
		int xdist = carPos[0] - ridePos[0];
		if(xdist<0){
			xdist *= -1;
		}
		int ydist = carPos[1] - ridePos[1];
		if(ydist<0){
			ydist *= -1;
		}
		dist = xdist + ydist;
		return dist;
		
		
	}
}