﻿using Семестр_2_Лаба_4;
Circle circle2 = new Circle(9, "Brown");
Segment segment1 = new Segment(12,"Orange");
Square square1 = new Square(12, "Blue");
Circle circle1 = new Circle(12, "Red");
//circle1.GetPerimeter();
//circle1.GetColour();
//circle1.GetArea();
//circle1.GetSegment();
//Console.WriteLine(circle1.ToString());
//square1.GetPerimeter();
//square1.GetColour();
//square1.GetArea();
//square1.GetSegment();
//Console.WriteLine(square1.ToString());
//segment1.GetPerimeter();
//segment1.GetColour();
//segment1.GetArea();
//segment1.GetSegment();
//Console.WriteLine(segment1.ToString());
MyFigures myFigures1 = new MyFigures();
myFigures1.Add(square1);
myFigures1.Add(circle2);
myFigures1.Add(segment1);
myFigures1.Add(circle1);
myFigures1.GetMyFigures();
