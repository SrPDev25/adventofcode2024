using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal class Part2
    { 
        public static void Run()
        {
            //string puzzle = "p=0,4 v=3,-3\r\np=6,3 v=-1,-3\r\np=10,3 v=-1,2\r\np=2,0 v=2,-1\r\np=0,0 v=1,3\r\np=3,0 v=-2,-2\r\np=7,6 v=-1,-3\r\np=3,0 v=-1,-2\r\np=9,3 v=2,3\r\np=7,3 v=-1,2\r\np=2,4 v=2,-3\r\np=9,5 v=-3,-3";
//int[] mapSize = { 11, 7 };
string puzzle = "p=73,39 v=-17,38\r\np=30,80 v=27,22\r\np=36,10 v=-86,-24\r\np=56,22 v=6,-46\r\np=75,64 v=98,-83\r\np=78,34 v=33,-38\r\np=83,88 v=-83,55\r\np=4,0 v=-48,44\r\np=45,75 v=42,2\r\np=27,47 v=75,90\r\np=75,100 v=-90,-61\r\np=45,29 v=-36,-76\r\np=73,64 v=48,-7\r\np=40,7 v=-87,-62\r\np=43,35 v=-57,11\r\np=74,77 v=77,70\r\np=11,42 v=9,4\r\np=98,28 v=75,34\r\np=34,42 v=66,-55\r\np=15,97 v=2,6\r\np=26,43 v=57,-72\r\np=84,24 v=-34,36\r\np=56,79 v=64,67\r\np=59,30 v=61,-81\r\np=94,19 v=68,-20\r\np=55,9 v=-37,83\r\np=11,69 v=18,75\r\np=3,45 v=24,76\r\np=48,88 v=20,-75\r\np=10,88 v=-13,59\r\np=77,66 v=47,36\r\np=28,46 v=73,88\r\np=2,6 v=-96,18\r\np=98,80 v=89,-75\r\np=1,71 v=-77,62\r\np=68,99 v=89,-42\r\np=84,35 v=-10,-8\r\np=26,102 v=-94,-93\r\np=44,72 v=-84,-51\r\np=11,39 v=-56,65\r\np=78,5 v=-38,-63\r\np=99,101 v=59,-21\r\np=87,90 v=-77,27\r\np=58,38 v=-29,75\r\np=45,69 v=86,-3\r\np=74,4 v=44,55\r\np=23,92 v=-71,44\r\np=97,70 v=-41,-83\r\np=55,89 v=-9,70\r\np=55,99 v=-14,58\r\np=82,72 v=-75,-60\r\np=10,90 v=58,-38\r\np=29,49 v=76,-24\r\np=25,83 v=-88,40\r\np=19,3 v=1,52\r\np=5,40 v=-84,19\r\np=40,28 v=70,27\r\np=85,0 v=69,-58\r\np=72,65 v=39,24\r\np=52,92 v=-73,90\r\np=75,6 v=41,94\r\np=93,79 v=75,51\r\np=15,35 v=-85,46\r\np=2,8 v=-49,-32\r\np=57,20 v=-87,-47\r\np=67,32 v=78,50\r\np=15,53 v=-55,92\r\np=12,64 v=59,-48\r\np=7,50 v=60,-99\r\np=27,13 v=-92,-44\r\np=25,27 v=72,41\r\np=29,31 v=-50,-50\r\np=64,39 v=49,-46\r\np=8,95 v=-99,33\r\np=0,49 v=-3,35\r\np=19,99 v=89,14\r\np=35,68 v=-14,66\r\np=36,55 v=94,81\r\np=40,32 v=22,45\r\np=100,64 v=68,-47\r\np=38,30 v=87,89\r\np=69,8 v=-30,72\r\np=54,71 v=-37,62\r\np=37,68 v=-65,85\r\np=81,56 v=62,54\r\np=41,1 v=42,10\r\np=7,94 v=31,59\r\np=7,17 v=18,16\r\np=41,42 v=-29,38\r\np=17,25 v=-63,60\r\np=72,22 v=87,5\r\np=6,42 v=-70,42\r\np=100,87 v=-98,-59\r\np=35,88 v=15,-86\r\np=50,68 v=-1,-79\r\np=30,29 v=-86,30\r\np=40,90 v=-29,-78\r\np=51,80 v=-88,-52\r\np=10,15 v=-45,-25\r\np=50,88 v=29,-75\r\np=4,16 v=17,-31\r\np=73,34 v=62,-46\r\np=81,90 v=-2,9\r\np=25,101 v=87,29\r\np=68,9 v=-2,-5\r\np=80,61 v=98,-4\r\np=35,17 v=-78,78\r\np=4,41 v=89,-61\r\np=76,22 v=-81,60\r\np=54,9 v=57,75\r\np=69,18 v=41,-1\r\np=77,46 v=25,38\r\np=69,58 v=67,7\r\np=4,97 v=90,-1\r\np=90,65 v=-12,66\r\np=63,82 v=96,-95\r\np=15,84 v=-55,-29\r\np=81,13 v=33,7\r\np=82,33 v=91,53\r\np=3,51 v=-69,-15\r\np=68,102 v=12,3\r\np=2,52 v=-52,79\r\np=79,56 v=-74,-76\r\np=69,29 v=-73,9\r\np=34,35 v=72,73\r\np=93,83 v=97,-42\r\np=95,63 v=17,77\r\np=80,101 v=32,44\r\np=51,57 v=-22,3\r\np=95,79 v=-40,-25\r\np=65,101 v=-2,-40\r\np=91,74 v=-46,-63\r\np=69,74 v=56,63\r\np=12,86 v=31,55\r\np=13,32 v=-57,8\r\np=21,29 v=30,38\r\np=67,28 v=-32,-96\r\np=41,86 v=-15,-48\r\np=7,82 v=-40,-90\r\np=64,60 v=63,5\r\np=29,48 v=-43,1\r\np=1,28 v=46,-46\r\np=48,63 v=-51,-26\r\np=67,54 v=40,-75\r\np=91,63 v=-32,13\r\np=51,94 v=43,-29\r\np=28,12 v=-71,34\r\np=98,99 v=17,-59\r\np=53,0 v=90,-80\r\np=86,76 v=47,39\r\np=59,69 v=56,-60\r\np=80,55 v=50,50\r\np=89,23 v=25,91\r\np=79,97 v=-10,-74\r\np=13,69 v=-92,89\r\np=22,102 v=-36,83\r\np=7,82 v=-67,93\r\np=85,85 v=69,-2\r\np=37,40 v=-58,-31\r\np=70,31 v=42,-45\r\np=57,95 v=12,33\r\np=21,93 v=-64,-40\r\np=47,29 v=14,57\r\np=5,101 v=-42,-56\r\np=78,53 v=-39,73\r\np=92,34 v=5,-16\r\np=77,98 v=17,57\r\np=69,11 v=-72,-14\r\np=65,41 v=99,-15\r\np=66,90 v=-9,9\r\np=76,62 v=98,-22\r\np=22,35 v=-78,84\r\np=72,95 v=-38,-17\r\np=59,35 v=12,-30\r\np=52,94 v=-59,67\r\np=52,100 v=77,-25\r\np=16,62 v=-50,-91\r\np=57,23 v=-59,-77\r\np=90,38 v=-33,-46\r\np=55,39 v=85,-99\r\np=13,84 v=-92,-59\r\np=62,48 v=42,2\r\np=4,13 v=62,86\r\np=74,0 v=-24,-55\r\np=22,87 v=95,48\r\np=20,73 v=-32,-34\r\np=19,81 v=-6,-33\r\np=42,82 v=65,32\r\np=52,45 v=-80,-27\r\np=3,35 v=18,30\r\np=70,77 v=41,-18\r\np=9,48 v=-39,-30\r\np=39,7 v=43,-28\r\np=98,102 v=-47,29\r\np=37,39 v=-8,-66\r\np=75,47 v=-17,-41\r\np=70,102 v=-15,-84\r\np=24,39 v=-64,-15\r\np=70,91 v=76,56\r\np=25,98 v=65,41\r\np=88,60 v=-4,88\r\np=82,79 v=-97,18\r\np=7,11 v=-78,90\r\np=41,35 v=65,38\r\np=92,23 v=65,-65\r\np=82,40 v=26,-31\r\np=42,27 v=26,-40\r\np=92,102 v=32,67\r\np=64,88 v=-74,-17\r\np=30,41 v=81,-15\r\np=26,8 v=73,-70\r\np=44,10 v=-51,-50\r\np=15,10 v=15,-58\r\np=34,102 v=72,-32\r\np=40,73 v=-43,-52\r\np=47,63 v=87,-22\r\np=90,43 v=-83,-76\r\np=24,93 v=-58,90\r\np=37,15 v=-15,52\r\np=71,45 v=-59,42\r\np=6,14 v=-92,10\r\np=34,20 v=-14,7\r\np=22,4 v=-93,-51\r\np=60,91 v=-23,-13\r\np=35,54 v=-42,69\r\np=34,9 v=51,79\r\np=29,65 v=58,16\r\np=96,5 v=-67,31\r\np=22,19 v=-6,7\r\np=63,62 v=27,41\r\np=94,0 v=32,71\r\np=31,24 v=-64,-73\r\np=51,39 v=94,82\r\np=37,44 v=-79,-34\r\np=77,33 v=37,-8\r\np=67,78 v=34,-78\r\np=25,57 v=23,-17\r\np=23,57 v=-70,-91\r\np=12,28 v=-93,-61\r\np=37,44 v=58,-57\r\np=27,81 v=28,63\r\np=68,50 v=-44,42\r\np=89,10 v=11,22\r\np=40,51 v=-38,55\r\np=91,64 v=55,5\r\np=11,94 v=96,79\r\np=3,90 v=3,78\r\np=51,58 v=-51,77\r\np=87,42 v=60,-91\r\np=35,87 v=73,91\r\np=38,27 v=-66,57\r\np=71,71 v=84,-10\r\np=39,65 v=79,-64\r\np=22,37 v=69,-72\r\np=65,21 v=53,-31\r\np=35,3 v=27,-42\r\np=80,33 v=67,17\r\np=8,87 v=-20,-9\r\np=59,63 v=73,50\r\np=58,34 v=48,-88\r\np=93,102 v=11,29\r\np=53,81 v=-1,59\r\np=4,20 v=-47,62\r\np=23,29 v=-20,-81\r\np=61,89 v=78,59\r\np=34,72 v=85,19\r\np=52,41 v=-36,31\r\np=50,48 v=57,-4\r\np=95,64 v=97,58\r\np=17,36 v=-78,-80\r\np=60,85 v=50,-44\r\np=31,22 v=46,-15\r\np=78,78 v=-22,-56\r\np=80,44 v=14,-2\r\np=57,45 v=-52,73\r\np=81,42 v=-41,-36\r\np=67,102 v=9,20\r\np=0,20 v=-26,30\r\np=80,64 v=4,55\r\np=93,67 v=-20,83\r\np=48,57 v=-94,68\r\np=28,14 v=-57,-93\r\np=2,22 v=-12,-61\r\np=78,62 v=-68,-54\r\np=0,22 v=68,91\r\np=14,22 v=-49,91\r\np=85,48 v=-90,-15\r\np=89,6 v=-11,79\r\np=81,89 v=98,82\r\np=1,14 v=89,87\r\np=11,48 v=12,-11\r\np=57,21 v=-63,73\r\np=42,5 v=-77,-46\r\np=40,6 v=6,7\r\np=83,56 v=-68,-75\r\np=17,5 v=88,-9\r\np=38,16 v=-29,-81\r\np=85,45 v=-68,-91\r\np=75,0 v=-24,-9\r\np=77,98 v=-82,86\r\np=57,25 v=95,-65\r\np=72,13 v=-4,-31\r\np=51,7 v=-52,52\r\np=62,39 v=-10,88\r\np=23,54 v=99,-57\r\np=43,29 v=86,-88\r\np=86,39 v=69,23\r\np=64,91 v=-32,-21\r\np=61,36 v=78,-69\r\np=71,8 v=84,36\r\np=20,46 v=22,47\r\np=54,64 v=85,62\r\np=62,27 v=63,-54\r\np=81,67 v=42,70\r\np=44,26 v=43,68\r\np=2,45 v=89,31\r\np=0,59 v=-91,-13\r\np=35,92 v=72,-78\r\np=48,38 v=86,-95\r\np=66,15 v=-37,-58\r\np=57,94 v=-66,91\r\np=100,12 v=45,72\r\np=93,5 v=-32,-59\r\np=8,24 v=-63,-85\r\np=69,6 v=5,75\r\np=59,84 v=49,-52\r\np=0,66 v=74,-13\r\np=69,43 v=71,-23\r\np=11,95 v=-9,-60\r\np=65,30 v=84,-73\r\np=91,65 v=-76,-14\r\np=80,44 v=55,50\r\np=13,26 v=44,-23\r\np=11,93 v=25,57\r\np=30,62 v=-9,-3\r\np=43,69 v=-57,-52\r\np=98,19 v=-90,14\r\np=44,83 v=-30,24\r\np=7,36 v=-71,15\r\np=50,67 v=-37,-71\r\np=54,92 v=-68,37\r\np=58,47 v=78,46\r\np=95,10 v=48,-67\r\np=36,79 v=94,40\r\np=37,35 v=58,-57\r\np=16,40 v=-93,-25\r\np=82,22 v=-67,-54\r\np=66,15 v=41,41\r\np=29,37 v=44,49\r\np=82,10 v=79,63\r\np=37,95 v=43,-36\r\np=13,14 v=-5,-66\r\np=60,93 v=85,29\r\np=46,83 v=21,-67\r\np=75,74 v=-68,93\r\np=88,53 v=43,-8\r\np=47,67 v=-22,-83\r\np=8,93 v=31,2\r\np=88,38 v=-29,51\r\np=65,6 v=53,74\r\np=20,28 v=94,-54\r\np=63,64 v=-14,77\r\np=56,93 v=-64,-63\r\np=25,0 v=-99,-62\r\np=40,90 v=37,-59\r\np=72,29 v=-60,-88\r\np=42,6 v=65,-43\r\np=51,37 v=-66,-46\r\np=32,1 v=-14,-28\r\np=10,42 v=23,58\r\np=7,31 v=89,34\r\np=71,102 v=-89,37\r\np=49,10 v=58,-31\r\np=1,83 v=-85,25\r\np=59,80 v=-8,-75\r\np=50,13 v=27,-82\r\np=28,79 v=8,28\r\np=4,7 v=38,56\r\np=76,99 v=26,-51\r\np=4,76 v=77,-27\r\np=18,9 v=44,-4\r\np=7,29 v=60,-26\r\np=96,7 v=33,41\r\np=27,79 v=15,-25\r\np=92,36 v=-19,47\r\np=45,102 v=-22,-93\r\np=31,32 v=-72,-27\r\np=8,73 v=-73,8\r\np=29,39 v=-6,-64\r\np=68,46 v=-97,8\r\np=31,99 v=46,-80\r\np=90,50 v=19,61\r\np=79,100 v=98,52\r\np=63,57 v=34,-3\r\np=39,83 v=-30,-29\r\np=2,4 v=32,10\r\np=49,95 v=-26,15\r\np=60,65 v=-74,43\r\np=74,73 v=-89,-79\r\np=42,66 v=-85,10\r\np=94,0 v=-6,5\r\np=92,89 v=25,-32\r\np=67,26 v=-56,-21\r\np=79,53 v=13,47\r\np=65,78 v=-3,1\r\np=49,74 v=36,-45\r\np=76,39 v=-99,23\r\np=87,62 v=47,-7\r\np=16,82 v=-85,44\r\np=38,64 v=49,39\r\np=46,22 v=-44,-21\r\np=93,55 v=96,-68\r\np=12,17 v=-87,-34\r\np=90,2 v=-98,29\r\np=47,64 v=50,5\r\np=82,21 v=48,-81\r\np=4,87 v=53,32\r\np=23,43 v=8,-42\r\np=7,72 v=-61,46\r\np=58,53 v=-37,8\r\np=89,9 v=33,75\r\np=14,30 v=20,8\r\np=26,35 v=-3,60\r\np=1,44 v=-98,-34\r\np=7,61 v=-91,-84\r\np=40,96 v=-80,-19\r\np=71,28 v=11,-88\r\np=61,78 v=55,93\r\np=51,36 v=-59,19\r\np=19,88 v=-20,-44\r\np=42,4 v=-22,98\r\np=81,35 v=-69,73\r\np=96,95 v=97,52\r\np=43,49 v=19,-80\r\np=97,70 v=-98,-56\r\np=53,38 v=56,15\r\np=18,33 v=-11,34\r\np=64,63 v=-39,-56\r\np=94,83 v=-39,90\r\np=4,36 v=60,-57\r\np=34,5 v=-86,-47\r\np=31,80 v=-77,-52\r\np=81,73 v=5,-82\r\np=54,56 v=57,73\r\np=42,91 v=-20,-27\r\np=0,6 v=-48,-93\r\np=48,26 v=92,-39\r\np=62,86 v=-80,-14\r\np=5,24 v=2,43\r\np=99,69 v=-91,-83\r\np=26,85 v=73,25\r\np=54,56 v=-8,-7\r\np=2,1 v=60,90\r\np=43,26 v=44,-23\r\np=2,0 v=-74,24\r\np=63,35 v=92,80\r\np=95,50 v=39,-45\r\np=20,62 v=-35,39\r\np=85,92 v=-59,11\r\np=39,76 v=1,-21\r\np=25,23 v=63,74\r\np=92,35 v=24,68\r\np=59,51 v=13,92\r\np=55,99 v=-23,56\r\np=50,59 v=22,37\r\np=55,7 v=77,-72\r\np=8,52 v=-84,-34\r\np=21,73 v=2,21\r\np=17,40 v=-63,61\r\np=86,76 v=46,-22\r\np=18,12 v=-72,-60\r\np=3,49 v=-44,-69\r\np=89,92 v=-98,-2\r\np=47,79 v=-73,-10\r\np=53,84 v=57,-6\r\np=62,31 v=-96,72\r\np=86,47 v=3,57\r\np=46,85 v=73,-42\r\np=35,84 v=-19,64\r\np=12,10 v=14,47\r\np=96,87 v=-83,-67\r\np=50,71 v=93,93\r\np=17,4 v=-6,79\r\np=94,51 v=10,69\r\np=5,66 v=-12,-41\r\np=82,16 v=-90,-73\r\np=39,63 v=-36,-68\r\np=15,79 v=-6,-33\r\np=27,58 v=-78,-72\r\np=68,42 v=59,-84\r\np=19,30 v=30,-33\r\np=0,77 v=89,-22\r\np=93,94 v=-3,-24\r\np=22,64 v=-13,-25\r\np=2,47 v=89,-11\r\np=11,49 v=-20,-95\r\np=35,42 v=-42,-91\r\np=22,93 v=-6,-32\r\np=100,75 v=10,-56\r\np=41,94 v=-94,-55";
int[] mapSize = { 101, 103 };



string[] robotsLines = puzzle.Split("\r\n");

List<int[][]> robots = new List<int[][]>();

for (int i = 0; i < robotsLines.Length; i++)
{
    int[] originalPos = new int[2];
    int[] velocity = new int[2];

    //Extract data
    string[] robot = robotsLines[i].Split(" ");
    //p=0,4
    originalPos[0] = int.Parse(robot[0].Substring(robot[0].IndexOf('=') + 1, robot[0].IndexOf(',') - robot[0].IndexOf('=') - 1));
    originalPos[1] = int.Parse(robot[0].Substring(robot[0].IndexOf(',') + 1, robot[0].Length - robot[0].IndexOf(',') - 1));

    velocity[0] = int.Parse(robot[1].Substring(robot[1].IndexOf('=') + 1, robot[1].IndexOf(',') - robot[1].IndexOf('=') - 1));
    velocity[1] = int.Parse(robot[1].Substring(robot[1].IndexOf(',') + 1, robot[1].Length - robot[1].IndexOf(',') - 1));

    robots.Add(new int[][] { originalPos, velocity });
}
int cicle = 1;
while (true)
{

    int[] securityLevel = new int[] {0,0,0,0 };

    //Update robots
    for (int i = 0; i < robots.Count; i++)
    {
       int[] currentPos = robots[i][0];
       int[] velocity = robots[i][1];

        for (global::System.Int32 j = 0; j < mapSize.Length; j++)
        {
            currentPos[j] = (currentPos[j] + velocity[j]) % mapSize[j];
            if(currentPos[j] < 0)
            {
                currentPos[j] = mapSize[j] + currentPos[j];
            }
        }

        robots[i][0] = currentPos;

        //Check securityLevel
        if (currentPos[0] < mapSize[0] / 2)
        {
            if (currentPos[1] < mapSize[1] / 2)
            {
                securityLevel[0]++;
            }
            else if (currentPos[1] > mapSize[1] / 2)
            {
                securityLevel[1]++;
            }
        }
        else if (currentPos[0] > mapSize[0] / 2)
        {
            if (currentPos[1] < mapSize[1] / 2)
            {
                securityLevel[2]++;
            }
            else if (currentPos[1] > mapSize[1] / 2)
            {
                securityLevel[3]++;
            }
        }
    }

    //Search for some loop where a quarter have a to dense amount of robots
    bool isSomeLevelTooHigh = false;
    foreach (var item in securityLevel)
    {
        if (item > robots.Count / 2)
        {
            isSomeLevelTooHigh = true;
        }
    }


    if(isSomeLevelTooHigh)
    {
        Console.WriteLine("Cicle: " + cicle);
        //Print the map
        for (int x = 0; x < mapSize[0]; x++)
        {

            for (global::System.Int32 y = 0; y < mapSize[1]; y++)
            {
                int numberOfRobots = 0;

                for (int i = 0; i < robots.Count; i++)
                {
                    if (robots[i][0][0] == y && robots[i][0][1] == x)
                    {
                        numberOfRobots++;
                    }
                }
                if (numberOfRobots == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(numberOfRobots);
                }

            }
            Console.WriteLine();
        }
        Console.ReadKey();
        Console.Clear();
    }
    cicle++;
}


        }
    }
}
