﻿// See https://aka.ms/new-console-template for more information
using Strategy_instructed;

// Use of wanted strategy

var strategy = new BikeStrategy();
var map = new Map(strategy);

var start = new Coordinate();
var stop = new Coordinate();

map.CreateRoute(start, stop);
