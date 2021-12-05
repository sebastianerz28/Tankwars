﻿// Author: Grant Nations
// Author: Sebastian Ramirez
// Powerup class for CS 3500 TankWars Client (PS8)

using Newtonsoft.Json;
using TankWars;

namespace GameModel
{
    /// <summary>
    /// Powerups when collected allow beams to be fired
    /// Consists of an ID, location, and died(has it been collected/should it be drawn)
    /// </summary>
    [JsonObject]
    public class Powerup
    {
        [JsonProperty(PropertyName = "power")]
        public int ID { get; private set; }

        [JsonProperty(PropertyName = "loc")]
        public Vector2D Location { get; private set; }

        [JsonProperty(PropertyName = "died")]
        public bool Died { get; set; }
    
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="id"></param>
        /// <param name="location"></param>
        public Powerup(int id, Vector2D location)
        {
            Died = false;
            ID = id;
            Location = location;
        }

        /// <summary>
        /// Default contructor for Json serialization
        /// </summary>
        public Powerup()
        {

        }
    }

}
