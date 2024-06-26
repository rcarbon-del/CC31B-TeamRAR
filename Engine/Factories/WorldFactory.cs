﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public class WorldFactory
    {
        public static World CreateWorld()
        {
            World newWorld = new World();



            newWorld.AddLocation(0, 0,
            "Matcha Green Office",
            "Home",
            "MatchaGreenOffice.png");
            newWorld.LocationAt(0, 0).TraderHere =
                TraderFactory.GetTraderByName("Green Tea Butter");
            newWorld.LocationAt(0, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));

            newWorld.AddLocation(-1, 0,
            "Fondue Lake",
            "You see a lake!",
            "FondueLake.png");
            newWorld.LocationAt(-1, 0).AddMonster(1, 100); 
            newWorld.LocationAt(-1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));

            newWorld.AddLocation(-2, 0,
            "Bamboo Cookie Forest",
            "You see a forest!",
            "BambooCookieForest.png");
            newWorld.LocationAt(-2, 0).AddMonster(2, 100); 
            newWorld.LocationAt(-2, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(4));

            newWorld.AddLocation(-2, 1,
            "White Chocolate Heaven",
            "You see heaven!",
            "WhiteChocolateHeaven.png");
            newWorld.LocationAt(-2, 1).TraderHere =
                TraderFactory.GetTraderByName("Golden Propet Cookie");


            newWorld.AddLocation(-1, -1,
            "White Chocolate Mocha Falls",
            "You see a chocolate waterfall!",
            "WhiteChocolateMochaFalls.png");
            
            newWorld.LocationAt(-1, -1).TraderHere =
                TraderFactory.GetTraderByName("White Lily Cookie");
            newWorld.LocationAt(-1, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(6));

            newWorld.AddLocation(1, 0,
            "Vanilla Ice City",
            "You see neighboring city!",
            "VanillaIceCity.png");
            newWorld.LocationAt(1, 0).TraderHere =
                TraderFactory.GetTraderByName("Macaroon Cookie");

            newWorld.AddLocation(2, 0,
            "Crinkle Dessert",
            "You see a dessert",
            "CrinkleDessert.png");
            newWorld.LocationAt(2, 0).AddMonster(4, 100);
            newWorld.LocationAt(2, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(5));

            newWorld.AddLocation(1, -1,
            "Tropical Cheese Beach",
            "You see a beach!",
            "TropicalCheeseBeach.png");
            newWorld.LocationAt(1, -1).AddMonster(5, 100);
            newWorld.LocationAt(1, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(7));

            newWorld.AddLocation(1, -2,
            "Cinnamon Coral Ocean",
            "You're in the ocean",
            "CinnamonCoralOcean.png");
            newWorld.LocationAt(1, -2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(2, -2,
            "Choco Lava Island",
            "You see an island",
            "ChocoLavaIsland.png");
            newWorld.LocationAt(2, -2).TraderHere =
                TraderFactory.GetTraderByName("Chocolate Pirate Cookie");
            newWorld.LocationAt(2, -2).AddMonster(6, 100);
            newWorld.LocationAt(2, -2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(8));



            return newWorld;


        }
    }
}
