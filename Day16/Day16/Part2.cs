﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    internal class Part2
    {
        public static void Run()
        {
            //string puzzle = "###############\r\n#.......#....E#\r\n#.#.###.#.###.#\r\n#.....#.#...#.#\r\n#.###.#####.#.#\r\n#.#.#.......#.#\r\n#.#.#####.###.#\r\n#...........#.#\r\n###.#.#####.#.#\r\n#...#.....#.#.#\r\n#.#.#.###.#.#.#\r\n#.....#...#.#.#\r\n#.###.#.#.#.#.#\r\n#S..#.....#...#\r\n###############";
            //string puzzle = "#################\r\n#...#...#...#..E#\r\n#.#.#.#.#.#.#.#.#\r\n#.#.#.#...#...#.#\r\n#.#.#.#.###.#.#.#\r\n#...#.#.#.....#.#\r\n#.#.#.#.#.#####.#\r\n#.#...#.#.#.....#\r\n#.#.#####.#.###.#\r\n#.#.#.......#...#\r\n#.#.###.#####.###\r\n#.#.#...#.....#.#\r\n#.#.#.#####.###.#\r\n#.#.#.........#.#\r\n#.#.#.#########.#\r\n#S#.............#\r\n#################";
            string puzzle = "#############################################################################################################################################\r\n#...........#.....#...........#.......#...#.......#.#...........#.......#...#.............#.#.....#.........#...#.........#................E#\r\n#.#########.#.#.#.#########.#.###.###.#.###.#.###.#.#.###.#####.#.###.###.#.#.###.#######.#.#.#.#.#.#####.#.#.#.#.#######.#.#.#####.###.#.#.#\r\n#.#.......#...#.#...........#.....#...#.....#.#...#.....#.....#...........................#...#.#.#.....#.#...#...#.....#.#.#.........#...#.#\r\n#.#.#####.#####.###################.#########.#.###.#######.#.#.#.#.#######.###.#.#.#.#########.#####.###.#########.#.#.#.###############.#.#\r\n#.#.#.......#...#...........#.......#.........#...#.#.#...............#...#...#.#.#...........#.....................#.#.........#.......#.#.#\r\n#.#.#.#####.#.###.#####.###.#.#########.#.#######.#.#.#.#.#.#.#######.###.###.#.#.###########.#####.#.#.###.#.#.###.#.#########.#.#####.###.#\r\n#.#.#.#...#.#.#...#...#...#...#.........#.....#...#...#.#.#.#...............#...#...........#.......#.#.#...#.#...#.#.#...#.......#.........#\r\n#.#.###.#.#.#.#.###.#.###.#####.#.###.###.###.#.#######.#.#####.###########.#############.#.#.#######.#.#.#.###.#.#.#.#.#.#.#######.#######.#\r\n#.#.....#.#...#.#...#.#.#.#.......#...#.#...#...#.......#.....#.#.......#.....#.........#.#.#.#.......#.#.#.......................#...#...#.#\r\n#########.###.###.###.#.#.#.#######.###.#.#.#######.#.#######.#.#.#####.#######.#######.###.###.#####.#.#############.#.#.###.###.###.#.#.#.#\r\n#.......#...#.....................#.#.......#.....#.#.#.....#.#.#.#...........#...#...#.#...#...#...#.#.....#.......#.#.#.....#.#...#.#.#.#.#\r\n#.#####.###.###.#####.#.###.#.###.#.#.###.#####.#.#.#.#.###.#.###.###########.###.#.#.#.#.###.###.#.#.#####.#.#####.#.#.#######.###.###.#.###\r\n#.#.#...#...#...#.#...#.#.....#.#...#.#.........#.#.#.....#.#...#.......#...#...#.#.....#.....#...#.#.#.....#.#.....................#...#...#\r\n#.#.#.###.###.###.#.###.#.#.###.#####.###.#.#####.#.#######.###.#.#####.#.#.#.#.#.#.#.#####.###.###.###.#####.#.#.###.#.#.#.#.#.#.###.#####.#\r\n#.#...#.......#...#.#.....#.......#.#...#.#.#.....#...#.....#...#.#.....#.#.#...#.#.......#.#...#...#...#...#.#.#.......#.#...........#.....#\r\n#.#.#########.###.#.#########.###.#.###.###.###.#####.#.#.###.###.#.#.#.#.#.#.###.#######.###.###.###.###.#.#.#.#########.#########.#.#.###.#\r\n#.................#...#.....#.#...#...#...#...#.......#...#...#.....#.#.#.#.#.....#.....#.#...#.#...#.....#...............#.......#...#.#...#\r\n#.#########.#.#.#.###.#.###.#.#.###.#####.###.#########.###.#.#####.#.#.#.#.#########.###.#.###.###.#.###############.###.#.#####.#.#.#.#.#.#\r\n#.........#.#...#.#...#...#...#...#.....#...#...#.....#...#.#.......#...#.#.....#.....#...#.#.#.....#...........#...#...#.#...#.#...#.#...#.#\r\n#.#.#####.#.#####.#.#####.#######.#.###.###.###.#.###.#.#.#.#.#.#########.#####.###.#.#.###.#.#.###############.#.#.###.#.###.#.###.#.#.#.###\r\n#.#.#.....#.#.....#.....#.#...#...#.......#.#...#...#...#.#.#.#.......#...#.........#.#...#.#...#.........#...#...#.....#...#.#...#.#...#...#\r\n#.#.#.#####.###.#######.#.###.#.#####.#.###.#.###.#.###.#.#.#########.#.#.###############.#.###.#####.###.#.#.#########.#####.#.###.#.#.#.#.#\r\n#.#.#.....#...#.......#.#...#...........#...#...#.#...#...#.........#.#.#.........#.......#...#.......#.#.#.#...#.#.....#.....#.#...#.#...#.#\r\n#.#.#.###.###.#######.#.#.#.#############.#####.#.###.###.#########.#.#.#########.#.#########.#########.#.###.#.#.#.#####.#####.#.#####.#.#.#\r\n#.#.#.#.#...#...#.....#.#.#.#.......#...#.#.....#...#...#...#.......#.#.#.....#...#.........#.#.#.........#...#...#.#...#.#.....#.#.....#...#\r\n#.#.#.#.#.#####.#.#####.###.#.#####.#.#.#.#.#####.#.###.###.#.#######.#.#.###.#.#.#########.#.#.#.#########.#######.#.###.#.#.###.#.#.#.#.###\r\n#.#.#...#.....#.#...#...#...#.....#...#.#.#.#.#...#...#.#...#.#.......#...#...#.#.#.#.....#...#.#.#.#.................#...#.#.#...#.#.#.....#\r\n###.###.###.#.#.#.###.###.#.#####.#####.#.#.#.#.#####.#.#.###.#.###########.###.#.#.#.###.#####.#.#.#.#.###############.###.###.###.#.#.#.#.#\r\n#...#.....#...#.#.#...#...#...#...#...#...#.#...#.....#.#.#.#...#...#.......#...#...#.#.....#.....#...........#.........#.....#.....#...#...#\r\n#.#####.#####.#.###.#####.#.###.###.#.#####.#.#####.###.#.#.###.#.###.#######.#######.#.###.#.#####.#.#######.#.#########.###.#####.###.#.#.#\r\n#.......#...#.#.....#...#.#.....#...#...#...#.#.....#...#.#...........#.....#...#.....#.....#.#...#...#...#...#.#.#...#...#.#.........#.#.#.#\r\n#.#####.#.#.#.#######.#.#.#.#####.#####.###.#.#.###.#.#.#.#########.#.#.###.###.#.#########.#.###.#.###.#.#####.#.#.#.#.###.#########.#.#.###\r\n#...#.#...#.#.....#...#...#...#.......#.....#...#...#.#.........#...#...#.....#.....#...#...#...#.#.#.#.#.....#.#...#.#...............#.#...#\r\n###.#.#.###.#.###.#.#.###.###.#.#####.###########.###.#########.#.#.###.#.###.#####.#.#.#.#####.#.#.#.#.#####.#.#####.#######.#.#.#.#####.#.#\r\n#.#.#.#...#.....#.#.#...#...#.#.#.....#.......#...#.#.....#...#...#.......#...#...#...#.#...#...#...#.#.#.....#.....#.........#.#.#.......#.#\r\n#.#.#.#.#.###.#.#.#.###.###.#.###.###.#.###.###.###.#####.#.#############.#.###.#.###.#.###.#.###.###.#.###.#######.#.###.#.###.#.#######.#.#\r\n#...#...#.#.....#.....#...#.#.#...#.....#...#...#.....#...#...............#.#...#...#.#...#...#.#...#.#...#.....#...#.......................#\r\n#.#######.#.#.###########.#.#.#.###.#.#######.###.#####.#####.###.#########.#.#####.#####.#####.###.#.###.#####.#.#####.###.#.#####.#.#.###.#\r\n#...#.....#...#...........#.#.#.#...#.#.....#.#.......#...............#.....#.#...#.#...#.....#...#.#...#.#...#.#...#.#...#.#.#...#...#.#...#\r\n###.#.###.###.#.#.#########.#.#.#.#####.###.#.#####.#.#####.###########.#####.#.#.#.#.#.#.#.#.###.#.#.#.#.#.###.###.#.###.#.#.#.#.###.#.#.###\r\n#...#...#...#.#.#...#.#.....#.#.#...#...#.#.#.....#.#.#...#...#...#...#.#.......#...#.#.#.#.#.....#...#.#.#...#...#.#.......#.#.#...#.#.#.#.#\r\n#.###.#.#####.#.###.#.#.#####.#.#.#.#.###.#.#.#.#.###.#.#.###.#.#.#.#.#.#.###.###.###.#.###.#####.#.#####.###.###.#.###.#####.#.###.###.#.#.#\r\n#.#...#.#.....#...#.#...#.....#.#.#.#.#...#.#...#...#...#...#...#...#...#...#...#...#.#.#...#...#.#.#...#.#...#...#...#...#...#.#.#.....#...#\r\n#.#####.#.#.#.#####.###.#.#####.###.#.#.#.#.#######.#####.#################.###.###.#.#.#.###.###.#.#.#.#.#.#.#.#####.#####.###.#.#########.#\r\n#.#.....#.#.#.....#.......#...#...#.....#.#.......#.#...#...........#.....#.#...#.....#...#.......#.#.#...#.#.............#...#.#...#.......#\r\n#.#.###.#.###.###.#.#######.#.#.#.###.#####.#####.#.#.#.#.#####.#.#.###.#.###.#####.#######.#######.#.#####.#######.#.###.###.#.#.###.#######\r\n#...#...#.......#.#.#.......#.......#.#...#.#.#...#...#...#...#.#.#...#.#.....#.....#...#...#.......#...#.#.......#.#...#.....#.#...#...#...#\r\n###.#########.###.#.###.#.#########.#.#.#.#.#.#.#########.#.#.#.#.###.#.###.#.#.###.#.#.#.#.#.#########.#.#.###.###.###.#######.#.#.###.###.#\r\n#...#...#.....#...#.....#...#...#...#.#.#...#...#.#.....#...#.#.#.#...#.#.#.#.#...#.#.#.....#.#.....#...#.#.#.#.....#.#.#.......#.#...#.#...#\r\n#.###.#.#.###.#.###.#######.#.#.#.###.#.#####.###.#.#.#######.###.#.###.#.#.#.###.#.#.#####.#.#.###.#.###.#.#.#######.#.#.#######.#.###.#.#.#\r\n#...#.#...#.....#...#.........#...#...#.#...#.#...........#.#...#.......#...#...#.#.#.#...#.#.#.#...#.#.....#...#...#...#.#.......#...#...#.#\r\n###.#.#.#########.#.#.#.#########.#.###.###.#.#####.###.#.#.###.#.#######.###.###.#.###.#.###.#.#.###.###.###.#.###.#.#.#.#.#########.#####.#\r\n#...#.#.#...#.....#.#.#.........#.#.#.#...#.#.....#.#...#.....#...#...#...#.#.....#.....#.....#.....#...#.#...#.....#.#...#.....#.....#.....#\r\n#.###.###.#.#.#####.#.#####.###.#.#.#.###.#.#####.###.#.#####.#####.#.#.###.#.#################.###.###.#.#.#.###.###.#.###.#.###.###.#.#####\r\n#.........#.#.#.#...#.#.#...#.#.#.....#.#.#.....#...#.#.#...#.#.....#.#.#...............#.......#.#.....#.#.....#.#...#...#...#...#...#.....#\r\n###.#.#.###.#.#.#.###.#.#.###.#.#####.#.#.#.###.###.#.###.#.###.###.###.#.###############.#######.#######.###.#.###.#####.###.#.###.#.#####.#\r\n#...#...#...#.#.....#...#...#.#.....#...#.#.#...#...#...#.#...#.#.#.#...#.#...#...........#.............#...#.#.....#.#...#...#.....#.....#.#\r\n#########.###.#######.#####.#.#####.#####.#.#.#.#.#####.#.###.#.#.#.#.###.#.#.#.###.#########.#############.#.#######.#.###.#########.###.#.#\r\n#.......#.#.#.......#.#.....#.............#.#.#.#.#...#.#.#.#...#.#...#.#.#.#...#...#...#...#.............#.#.....#...#.#.....#...#.....#...#\r\n#.#####.#.#.#.#####.#.#.#####.#############.#.###.#.#.#.#.#.#####.#####.#.#.#.#######.#.#.#.###.#########.#.#####.###.#.#####.#.#.###.#.###.#\r\n#.....#...#.#.....#.....#.......#.....#.....#.......#...#.#.......#...#...#...........#...#...#...#.....#.#.....#...#.#...#.....#.........#.#\r\n#.###.#####.#####.#####.#####.###.###.#.#.#.###########.#.#.###.#.#.#.#########.#############.###.#.###.#.#####.###.#.###.#######.#######.#.#\r\n#.#...#.....#...#...#...#...#.#...#.#.....#.....#.......#.#.#...#...#...#.....#.....#.....#.#.#...#.#...#.....#.#.....#...........#...#.#.#.#\r\n###.###.#.###.#.#.#.#.#.#.#.###.###.#.#####.###.#.#######.###.###.#.###.#.###.#####.#.###.#.#.#.#.#.#.#####.###.#####.#.###.#.#.###.#.#.#.#.#\r\n#.....#...........#.#.#.#.#.....#...#.......#.#.#.#.#.........#...#.#...#...#...#.....#...#.#.#.#...#.#...#...#...#...#.....#.#.#...#.#...#.#\r\n#.###.#.###########.#.#.#.###.###.#.#######.#.#.#.#.#.#########.###.#.###.#.###.#######.###.#.#.###.#.#.#.###.###.#.#########.#.#.###.#.###.#\r\n#...#.....#.........#.#.#.......#.#...#.....#.#.#...#.........#.....#...#.#.#.#...#...#...#.#...#...#...#...#...#.#.#.#...#...#.#.#.#.#.....#\r\n#.#.#####.#######.###.#.#######.#.#####.#.#.#.#.#######.#.#.#.#########.###.#.###.#.#.###.#.#####.#.#######.###.#.#.#.#.#.#.###.#.#.#.#####.#\r\n#.#.....#.#...#.......#...#...#.#.#.....#.#.#.#.........#...#.........#...#.#...#.#.#.............#.....#...#...#.#...#.#.#...#.#...#...#.#.#\r\n#######.#.#.#.#.###.#.#####.#.#.#.#.#####.#.#.#############.#########.###.#.#.#.#.###########.#######.#.#.#.#.#.#.###.#.#.#.#.#.###.###.#.#.#\r\n#.......#...#.#.#...#.....#.#...#...#...#.#...#.....#.....#.........#...#...#.#.#.......#...#...#.....#...#.#.#.#...#.#.#.#.#...#.#...#.#.#.#\r\n#.###########.#.#.###.###.#.#######.#.#.#.###.#.#.#.#.###.#########.#########.#.#######.#.#####.#.#########.#.#####.###.#.#.#.#.#.###.#.#.#.#\r\n#.#.........#...#.....#.#.#.#.....#...#.#...#...#.#.#.#.#.......#...#.......#.#...#...#.#.....#.#...#.....#.#...#...#...#.#.#.#.....#.#.#...#\r\n#.#.#######.###.#######.#.#.#.###.#####.###.###.#.#.#.#.#######.#.###.###.#.#.###.#.#.#.#####.#.###.#.###.#.#.#.#.###.###.#.#.#######.#.###.#\r\n#.#.#.....#...#.........#.#...#.#.#.....#...#...#.#.#...#...#...#.#...#.#...#...#...#.#.....#.....#.#.#.....#.#.#.#.......#.#.....#...#.....#\r\n#.#.#.###.#.#####.#######.#####.#.#.#####.###.###.###.###.#.#.#.#.#.###.#.#####.#####.#.#.#.#####.#.#.#######.#.#.#.###.#########.#.#######.#\r\n#.#.#.#.#.#.....#.#.......#...#...#.#...#.#...#.#.....#...#...#.#...#.....#.....#.#...#.#.#...#.#...#...#.....#...#.#...........#...#.......#\r\n#.#.#.#.#.#####.#.#.#####.#.#.#.###.#.#.#.#.###.#.#####.#######.#####.#####.#.###.#.###.#.###.#.#.#####.###.#######.###########.#####.#####.#\r\n#.#.#.#.#...#...#.#...#...#.#...#.#.#.#...#.#.........#.#...#...#...#...#.#.#...#...#...#.#...#...#...#...#.#...#.....#.#.....#...#...#...#.#\r\n#.###.#.###.#.###.###.###.#.#####.#.#.#####.###########.###.#.###.#.###.#.#.###.#####.#.#.###.#####.#.###.#.#.#.#.###.#.#.###.###.#.###.###.#\r\n#.......#...#...#...#...#.#...#.....#.#.#...#.....#...#...#.#...#.#.....#.....#.......#.....#.#...#.#.#...#.#.#...#...#.#.....#...#.#.....#.#\r\n#.#######.###.#.###.#.#.#.###.###.###.#.#.###.###.#.#.#.#.#.###.#.#############.###########.#.#.#.#.#.#.###.#.#####.###.#.#.#.#.###.#####.#.#\r\n#...#...#...#.#.....#.#.#...#.......#.#...#.....#...#.#.#.#...#.#.............#.#.........#.#...#.#.#...#...#.....#.#.....#.#.#.#.......#...#\r\n#####.#.###.#.#######.#.###.###.#####.#.###.###.#####.#.#.###.#.#############.#.#####.###.#.#####.#.#####.###.#.#.#.###.###.###.#######.#.###\r\n#.....#...#.#.#.......#.#.#.#.#.......#...#.#...#...#.#.....#.......#...#...#.#.......#.....#.....#.#.....#.#...#.#...#.................#...#\r\n#.#.#####.#.#.#.#####.#.#.#.#.#########.#.#.#.###.#.#.#####.#####.#.#.###.#.#.#####.#####.#.#.#####.#.#####.#.#####.#.#####################.#\r\n#.#.....#...#.#.#.....#.#.........#.......#.#...#.#.#.....#.......#...#...#...#...#.#...#...#.#.....#.#.......#...#.#.#...........#...#.....#\r\n#.#.###.#####.#.###.###.#.#########.###########.#.#.#####.#.#####.#.###.#######.###.#.#.#####.#.#.###.#.#######.#.###.#.#########.#.#.#.#####\r\n#.#.........#.#...#.#...#.#...#.....#.............#...#...#.#...#.#.#...#...........#.#...#...#.#.#.#.#...#...#.#...#...#.........#.#.#...#.#\r\n#.#.#.#######.#.#.###.#.###.#.#.#####.###.###.#####.#.#.###.#.#.#.#.#.###.###########.###.#.#####.#.#.###.#.#.#.###.#####.#########.#####.#.#\r\n#.#.#.#.........#.....#.#...#...#.#...#...#.......#.#.#.#...#.#.#.#.#.#.#.#...#.......#...#.......#.#...#...#.#.#.#.......#.........#.....#.#\r\n#.#.###.#########.#.#####.#######.#.#.#.#########.###.#.#####.#.#.#.#.#.#.#.#.#.#######.###########.###.#####.#.#.#########.#.#######.###.#.#\r\n#.#...#...........#.......#...#...#.#.#.....#...#.....#.......#.#...#.......#.#...#...#.#.........#.....#.....#.#...#.....#.#...#...#.#.....#\r\n#.#.#.#######.#.###.#######.###.#.#.#.#####.#.#.###############.###.#.#.###.###.#.#.#.#.###.#####.#.#.###.#####.###.#.###.#.###.#.#.#.###.#.#\r\n#.#.#.....#...#...#...#.....#...#.........#...#.#.....#.....#.#.....#...#...#.....#.#.#...#.#...#.#...#.#.#...#...#...#...#...#.......#...#.#\r\n#.###.###.#.###.#.###.###.###.#####.###########.#.###.#.###.#.#####.###.#.###.#.###.#.###.#.#.#.#.###.#.#.#.#####.#.###.#.###.#########.#.###\r\n#.....#...#.#...#...#...#.....#...#.#...#.......#.#.....#.#...#...#.#.#.#...#...#...#...#.#.#.#...#...#.....#.....#...#.#.#...#.........#...#\r\n###.#.###.#.#.###.#.###.#####.#.#.###.#.#.#######.#######.###.###.#.#.#.#####.#.#.###.#.#.#.#.#.###.#########.#######.#.#.#.#########.#.#.#.#\r\n#...#.#.....#...#.#...#.....#.#.#...#.#.#.#.....#...#...#.........#.#.#.#...#.#.#.......#.#...#.#...#.........#.#.....#.#...#.......#.#...#.#\r\n#.###.#.#.###.#.#.#.#######.###.#.#.#.#.#.#.###.#.#.#.#.###########.#.#.#.#.###.#.#.#####.#.###.#.###.#########.#.#####.#####.#####.#.#####.#\r\n#.#...#.#.#...#.#.#.......#.....#...#.#.#.#...#.....#.#.....#...........#.#.....#.#.....#.#.#...#.....#.........#.......#.....#...#.#.#.....#\r\n#.#.#.#.#.#.###.#.#####.#.#######.###.#.#.#.#####.#.#.#####.#.#.#######.#.#########.###.#.#.#.#########.###############.#.###.#.###.#.#.###.#\r\n#.#.......#.#...#.....#.#.#.......#...#.#.#.#...#.#...#...#...#...................#.#.#...#.#.....#.....#.............#.#.#.#.#.....#.#.#...#\r\n#.#.#.###.#.#.#####.#.###.#.#######.###.#.#.#.#.#.#####.#######.#.#.#####.#####.#.#.#.#####.###.###.###.#.#######.#####.#.#.#.#.#####.#.#.###\r\n#.....#.....#.#...#.#.#...#.....#...#.....#.#.#.#.#...#.........#.#...#.....#.....#.#.....#.#.#.......#.#.............#.#...#.#.#.......#.#.#\r\n#.###.#.#.###.#.#.#.#.#.#######.#.#.#.#######.#.#.#.###.#######.#.###.#####.#.#####.#.###.#.#.#########.#.#.#########.#.###.#.#.#.###.###.#.#\r\n#.....#...#...#.#.#.#.#.#.....#.#.#.#.#...#...#.#.#.#...#.....#.#...#.....#.#.#.#...#.#...#.......#.....#.#.........#...#...#...............#\r\n#.###.###.###.#.#.###.#.#.#.#.#.#.#.###.#.#.###.#.#.#.###.#####.#########.###.#.#.###.#.#####.#####.###.#.###.###.#.#########.#####.#.#.###.#\r\n#...............#.....#...#.#.#.#.#.#...#...#...#.#.#.....#.....#.......#.....#...#...#.......#...#.#.#.#...#.#...#...#.....#.#.....#.....#.#\r\n#.#.#.###.#####.#######.###.###.#.#.#.#######.###.#.###.#.#.#.###.###.#####.###.###.#######.###.#.#.#.#.###.###.#####.###.#.#.#.#####.#####.#\r\n#.#.#.....#.....#...#...#.#.....#.#.#.....#...#.#.#.......#.#.#...#.#.........#.#...#.#...#...#.#...#...#.#...#.#.........#...#...#.........#\r\n#.#.#######.#####.#.#.###.#######.#.#####.#.###.#.#.#######.###.###.#########.#.#.###.#.#.#.###.#####.###.###.#.#.###############.#.#.#######\r\n#...#.....#...#...#...#...........#.....#.#.......#.......#...#.#.........#.#...#.#.....#.#.#...#.....#.....#...#.......#.........#.#.......#\r\n###.#.###.###.#.###.#.#.#######.#.###.#.#.###.#.#####.#######.#.#.#####.#.#.#####.#.###.#.###.#####.###.#.#######.#.#####.#####.#.#.#.#####.#\r\n#...#.#.#.....#.#.#...#...#.....#...#.#...#...#.....#.#...#...#.#.#.....#...#...#...#...#...#.....#.#.............#.#.....#.#...#.#.#.....#.#\r\n#####.#.###.###.#.#####.#.#.#######.#######.#######.###.#.#.#.#.#.#.###.#####.#.#.###.#####.#.###.#.#.###.#####.#.#.#.#####.#.#####.#####.#.#\r\n#.....#.......#.#.....#...#.#...#.#.......#...#.....#...#...#.#.#.#.#...#.....#...#...#.....#...#...#...#.......#.#.#...#...#.....#.#.#...#.#\r\n#.#####.###.#.#.#.#.#.#####.#.#.#.#.#.###.#.#.#.#####.###.#####.#.#.###.#.#########.###.#########.#.#.#.#.#.###.#.#.###.#.#.#####.#.#.#.###.#\r\n#...#...#...#.#.#.#.#.....#...#.#.#.#.#.#...#.#.#.....#.......#.#.#...#.#.....#.#...#.....#.......#.......#.#...#.#...#...#.#...#...#...#...#\r\n###.#.#.#.#.###.#.#.#####.###.#.#.#.#.#.#####.#.#.###.#.#####.#.#.###.#######.#.#.#######.#.###.#####.#####.#.###.#.#######.#.#.###.#####.#.#\r\n#...............#.#.#...#...#.#.#.....#.........#.#...#.#.....#.#.#.#.......#...#.#...#.....#.#...........#.....#.#.....#...#...............#\r\n#.#########.#.#.###.#.#####.###.#########.#######.#.#.#.#.#####.#.#.#######.###.#.#.#.#######.#.#######.#.#######.#####.#.#########.#.#####.#\r\n#.#...........#.....#.....#.....#.......#.#...#...#.#.#.#.......#.#.......#...#...#.#.............#.....#.........#.....#.#.........#.....#.#\r\n#.#.#######.#.###########.###.###.#####.#.#.#.#####.#.#.#######.#.#.#######.###.#.#.#####.#########.###############.#.#.#.###.#####.#.#.#.#.#\r\n#.#.......#.....#.........#...#...#...#.#...#...#...#.#.#...#.......#...........#...#.....#.........#.......#.......#...#...#.#.....#...#.#.#\r\n#.###.###.#.#####.###.#####.###.#.#.###.#######.#.#####.#.#.#.#.#####.#####.#.#######.#.#.#.###########.###.#.#############.#.#.###.#.###.#.#\r\n#...#...#...........#.......#...#.....#...#...#...#...#...#.#.#.#.....#...#.#.#...#...#.................#...#...#.........#...#.....#.#...#.#\r\n#.#.#######.#######.#####.###.###.###.###.#.#.#.###.#.#####.#.#.#.#####.#.#.#.#.#.#.#####.###.###.###.#####.###.#.#####.###.###.###.#.#.###.#\r\n#.#...#.......#...#.#...#.#...#.......#.#...#.#.#...#...........................#.#...#...#...#...#...#...#.#...#.#.................#.#.#...#\r\n#.###.#.#####.#.#.###.#.#.#.###.#.###.#.#####.#.#.#######.#.#.#.###.#.#.#####.#.#.###.#.#.###.#.#######.#.###.#.#.#.#.###.###.#.#.#.#.#.###.#\r\n#...#...#...#...#.#...#.#.#.#...#...............#...#...#...#.#.....#...#...#.#.#...#.#.....#.#.....#...#.....#.#.#.#...#.....#.#...#.#...#.#\r\n###.#####.#.#####.#.###.#.#.#.#.#####.#####.#.#.###.#.#.#####.#.#####.###.#.#.#.#####.###.#.#.#####.#.#####.#####.#.#####.#####.#.#.#####.###\r\n#...#.....................#.#.#.#...#.#...#.#.#.#...#.#.......................#.#...#.....#.............#...#.....#...#.......#.#.#.....#...#\r\n#.#####.###.#.#.#.###.#.#.#.#.#.#.#.###.#.###.###.###.#.#####.#.#.###.#######.#.#.#.###.#.#.#####.#.###.#.###.#######.#.#.#.###.#.#.#.#.#.#.#\r\n#...................#.#.#.#.#.#...#.....#.#...#.....................#.#.......#.#.#.....#.#.#...#.#...#.#.#...#.....#...#.#.#...#.....#.#.#.#\r\n#########.###.#.#.###.#.###.#############.#.###.###.#######.#.#.#.#.#.#.#######.#.###.###.#.#.#.###.###.#.#.###.###.#####.#.#.#.#######.###.#\r\n#.....#...#...#.#.#...#...#.#...#...#.....#.#...#...#.....#.#.....#.#.#.#.....#.#.#...#.....#.#.....#...#.#.#...#.#...#...#.#...#.....#.....#\r\n#.###.#.#####.#.#.#.#####.#.#.#.#.#.#.###.#.#.###.###.###.#.#.#.#.#.###.###.#.#.#.#####.#.###.#####.#.#####.###.#.###.#.#.#.###.#.#.###.###.#\r\n#S..#.........#.........#.....#...#...#...#...#.......#...#.......#.........#...#.............#...............................#...#.........#\r\n#############################################################################################################################################";


            static int Heuristica(Nodo currentNodo, Nodo nextNodo)
            {
                int xResult = Math.Abs(currentNodo.X - nextNodo.X);
                int yResult = Math.Abs(currentNodo.Y - nextNodo.Y);

                bool corner = currentNodo.directionX != nextNodo.directionX || currentNodo.directionY != nextNodo.directionY;
                int maximum = Math.Max(xResult, yResult);

                if (corner)
                {
                    return xResult + yResult + 1000;
                }
                else
                {
                    return xResult + yResult;
                }

            }

            static List<Nodo> ReconstructPath(Dictionary<Nodo, HashSet<Nodo>> cameFrom, Nodo current)
            {
                List<Nodo> totalPath = new List<Nodo>();
                Queue<Nodo> queue = new Queue<Nodo>();

                queue.Enqueue(current);

                while (queue.Count > 0)
                {
                    current = queue.Dequeue();

                    if (cameFrom.ContainsKey(current))
                    {
                        foreach (var item in cameFrom[current])
                        {
                            if (!totalPath.Contains(item))
                            {
                                queue.Enqueue(item);
                            }

                        }
                    }
                    if (totalPath.FindIndex(x => x.X == current.X && x.Y == current.Y) == -1)
                    {
                        totalPath.Add(current);
                    }
                }

                totalPath.Reverse();
                return totalPath;
            }

            // Asumiendo definiciones de clases y métodos auxiliares
            static List<Nodo> AStar(List<List<string>> map, Nodo start, Nodo goal)
            {
                //Inicia valores
                PriorityQueue<Nodo, int> openSet = new PriorityQueue<Nodo, int>();
                HashSet<Nodo> openSetTracker = new HashSet<Nodo>();

                int bestScore = int.MaxValue;
                List<Nodo> best = new List<Nodo>();

                var cameFrom = new Dictionary<Nodo, HashSet<Nodo>>();

                var gScore = new Dictionary<Nodo, int>
                {
                    [start] = 0
                };

                var fScore = new Dictionary<Nodo, int>
                {
                    [start] = Heuristica(start, goal)
                };

                openSet.Enqueue(start, fScore[start]);

                while (openSet.Count > 0)
                {
                    Nodo current = openSet.Dequeue();

                    //Final del camino
                    if (goal.X == current.X && goal.Y == current.Y)
                    {
                        int realCost = gScore[current];//calculeRealCost(reconstructPath);
                        if (realCost <= bestScore)
                        {
                            Console.WriteLine("Goal reached: " + realCost);
                            List<Nodo> reconstructPath = ReconstructPath(cameFrom, current);
                            bestScore = realCost;
                            best = reconstructPath;
                        }
                    }


                    int[][] directions = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };

                    // Procesa cada nodo adyacente
                    foreach (var direction in directions)
                    {
                        Nodo neighbor = new Nodo(current.X + direction[0], current.Y + direction[1], direction);

                        //Comprobar si el vecino está fuera del mapa o es un obstáculo
                        if (neighbor.X < 0 || neighbor.X >= map.Count || neighbor.Y < 0 || neighbor.Y >= map[0].Count || map[neighbor.X][neighbor.Y] == "#")
                        {
                            continue;
                        }

                        var tentativeGScore = gScore[current] + Heuristica(current, neighbor);
                        if (neighbor.X == 7 && neighbor.Y == 5 && neighbor.directionY == 1)
                        {
                            Console.WriteLine("Debug");
                        }
                        if (tentativeGScore <= gScore.GetValueOrDefault(neighbor, int.MaxValue))
                        {
                            //If the neighbor is not in the cameFrom dictionary, add it. Or if the current gScore is less than the previous one, update it.
                            if (!cameFrom.ContainsKey(neighbor) || tentativeGScore < gScore.GetValueOrDefault(neighbor, int.MaxValue))
                            {
                                cameFrom[neighbor] = new HashSet<Nodo>();
                            }

                            cameFrom[neighbor].Add(current);
                            gScore[neighbor] = tentativeGScore;
                            fScore[neighbor] = gScore[neighbor] + Heuristica(neighbor, goal);
                            if (!openSetTracker.Contains(neighbor))
                            {
                                openSet.Enqueue(neighbor, fScore[neighbor]);
                                openSetTracker.Add(neighbor);
                            }

                        }

                    }
                    openSetTracker.Remove(current);


                }

                return best; // Fallo al encontrar un camino
            }




            List<List<string>> map = puzzle.Split("\n").Select(x => x.Select(y => y.ToString()).ToList()).ToList();
            Dictionary<Nodo, int[]> predecessor = new Dictionary<Nodo, int[]>();

            int[] start = [1, 1];
            int[] end = [map.Count - 2, map[0].Count - 2];
            for (int y = 0; y < map.Count; y++)
            {
                for (global::System.Int32 x = 0; x < map[y].Count; x++)
                {
                    if (map[y][x] == "E")
                    {
                        end = [y, x];
                    }
                    else if (map[y][x] == "S")
                    {
                        start = [y, x];
                    }
                }
            }

            Nodo startNode = new Nodo(start[0], start[1], new int[] { 0, 1 });
            Nodo endNode = new Nodo(end[0], end[1]);
            //Nodo endNode = new Nodo(7, 7);

            List<Nodo> result = AStar(map, startNode, endNode);
            //Calcula el coste del camino y resto la posición original
            int tiles = result.Count;
            Console.WriteLine("Tiles: " + tiles);
            int count = 0;
            //Renderiza el mapa con los nodos visitados
            for (int y = 0; y < map.Count; y++)
            {
                for (int x = 0; x < map[y].Count; x++)
                {
                    if (result.FindIndex(z => z.X == y && z.Y == x) != -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("O");
                        Console.ResetColor();
                        count++;
                    }
                    else
                    {
                        Console.Write(map[y][x]);
                    }
                }
                Console.WriteLine();
            }
            

        }
    }
}
