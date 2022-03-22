using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonifyData
{
    internal class Planet
    {
        /// <summary>
        /// Name of the planet.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Distance from the sun in KM.
        /// </summary>
        public long Distance_from_sun { get; set; }
        /// <summary>
        /// Diameter of the planets in KM.
        /// </summary>
        public int Diameter { get; set; }
        /// <summary>
        /// Age of the planets in Years.
        /// </summary>
        public long Age { get; set; }
        /// <summary>
        /// Rotation period is for a planet's time circling around it's own axis. 
        /// </summary>
        public int Rotation_period { get; set; }
        /// <summary>
        /// Rotation speed in km/h. 
        /// </summary>
        public double Rotation_speed { get; set; }
        /// <summary>
        /// Orbital period is for a planet's time circling around another object, for ex.: the Sun.
        /// </summary>
        public double Orbital_period { get; set; }
        /// <summary>
        /// Amount of moons.
        /// </summary>
        public int Moons { get; set; }
        /// <summary>
        /// The planets mass.
        /// </summary>
        public double Mass { get; set; }
        /// <summary>
        /// Highest messured temperature.
        /// </summary>
        public double Highest_temp { get; set; }
        /// <summary>
        /// Lowest messured temperature.
        /// </summary>
        public double Lowest_temp { get; set; }
        /// <summary>
        /// List of statements and facts of the planet.
        /// </summary>
        public List<string> Statements { get; set; }
        /// <summary>
        /// List of object with questions and answers to the planet.
        /// </summary>
        public List<QuestionAndAnswer> Quests { get; set; }

      public Planet()
        {
            this.Statements = new List<string>();
            this.Quests = new List<QuestionAndAnswer>();
        }
    }
}
