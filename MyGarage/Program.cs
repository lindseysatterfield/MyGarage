using MyGarage.Aircrafts;
using MyGarage.Cars;
using MyGarage.Watercrafts;
using System;
using System.Collections.Generic;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var airForceOne = new AirForceOne();
            airForceOne.FuelCapacity = 500;
            airForceOne.Color = "Blue/White";
            airForceOne.PassengerCount = 125;
            airForceOne.HasPresident = true;

            var boeing = new Boeing();
            boeing.FuelCapacity = 400;
            boeing.Color = "Red";
            boeing.PassengerCount = 145;

            var planes = new List<AircraftBase>() { airForceOne, boeing };
            foreach (var plane in planes)
            {
                plane.Flying();
            }
            Console.WriteLine();

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var outback = new SubaruOutback();
            outback.FuelCapacity = 20;
            outback.Color = "Blue";
            outback.PassengerCount = 5;

            var ascent = new SubaruAscent();
            ascent.FuelCapacity = 25;
            ascent.Color = "Red";
            ascent.PassengerCount = 8;

            var cars = new List<CarBase>() { outback, ascent };
            foreach (var car in cars)
            {
                car.Driving();
            }
            Console.WriteLine();

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var mayflower = new Mayflower();
            mayflower.FuelCapacity = 0;
            mayflower.Color = "Brown";
            mayflower.PassengerCount = 104;

            var titanic = new Titanic();
            titanic.FuelCapacity = 0;
            titanic.Color = "Black/White";
            titanic.PassengerCount = 2435;

            var boats = new List<WatercraftBase>() { mayflower, titanic };
            foreach (var boat in boats)
            {
                boat.Driving();
            }
            Console.WriteLine();
        }
    }
}
