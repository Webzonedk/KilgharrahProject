using System.Text.Json;
using JsonifyData;






#region English

List<Planet> planets_en = new List<Planet>()
        {
         /// <summary>
         /// Mercury.
         /// </summary>
            new Planet
            {
                Name="Mercury",
                Distance_from_sun = 47000000,
                Diameter= 4878 ,
                Age=4600000000,
                Rotation_period=84450,
                Rotation_speed=10892 ,
                Orbital_period=88,
                Moons=0,
                Mass=3.301*Math.Pow(10,23),
                Highest_temp=430,
                Lowest_temp=-180,
                Statements={
                    "Mercury is one of the smallest planets in the Solar System, and it is the closest to the Sun",
                    "Mercury orbits around the Sun in 88 Days, the shortest of all the Sun's planets.",
                    "It is named after the Roman god of commerce, and the messenger of the gods, Mercurius.",
                    "It's surface appears heavily cratered and similar in appearance to the Moon's.",
                    "Despite the small size, Mercury has a significant, and apparently global magnetic field.",
                    "It has almost no atmosphere to retain heat, the temperature ranges from -173 °C to 427 °C.",
                    "The planet experienced a spacecraft crash, back in the 30 of April, 2015; when NASA intentionally let a spacecraft, named &#34;MESSENGER&#34; crash into it."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="How long does it take Mercury to orbitate one round of the Sun?",
                        Answers={ "10 days", "88 days", "200 days", "365 days" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Who was the planet Mercury named after?",
                        Answers={ "It isn’t named after anybody", "The Greek god, Hermes", "The Roman god, Mercurius"},
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="What is the maximum temperature on Mercury?",
                        Answers={ "166 °C", "512 °C", "427 °C", "400 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the minimum temperature on Mercury?",
                        Answers={ "-173 °C", "0 °C", "-100 °C", "-386 °C" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the space probe that NASA crashed on Mercury?",
                        Answers={ "MESSAGE", "MESSENGER", "MESSAGES", "MESS" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What does the surface of the planet Mercury look like?",
                        Answers={ "Smooth", "Small Hills", "Heavily Cratered", "Covered by water" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Mercury is the closest planet to the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },

                }
            },

         /// <summary>
         /// Venus.
         /// </summary>
            new Planet
            {
                Name="Venus",
                Distance_from_sun = 108208930 ,
                Diameter= 12104 ,
                Age=4600000000,
                Rotation_period=348480,
                Rotation_speed=6.52,
                Orbital_period=225 ,
                Moons=0,
                Mass=4867*Math.Pow(10,24),
                Highest_temp=475,
                Lowest_temp=-173,
                Statements={
                    "Venus is the second closest planet from the Sun.",
                    "It's named after the Roman goddess of love and beauty, Venus.",
                    "Venus orbits around the Sun in 225 days.",
                    "Venus is the brightest natural object in the sky, after the Moon, it can cast shadows and can be visible to the naked eye in broad daylight.",
                    "Like Mercury, Venus does not have any moons also.",
                    "Though Mercury is closer to the Sun, Venus has the hottest surface of any planet in the Solar System, with the max temperature around 474 °C.",
                    "It's size and mass are similar to the Earth, often described as &#34;Earth's sister&#34;.",
                    "It has an theory, which says out, that if Venus had any ocean or even water on it's land, it was evaporated by the heat, and because the lack of the magnetic field, the remaining free hydrogen was swept into interplanetary space by the solar wind."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="What position does Venus have in the order of the planets when counting from the sun?",
                        Answers={ "First", "Fourth", "Second", "Tenth" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Which god or goddess was the planet named after?",
                        Answers={ "The roman goddess, Venus", "The roman goddess, Diana", "The greek goddess, Aphrodite", "The greek goddess, Artemis" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Venus to orbitate one round of the Sun?",
                        Answers={ "112 days", "225 days", "256 days", "720 days" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Venus have?",
                        Answers={ "2", "7", "0", "6" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the maximum temperature on Venus?",
                        Answers={ "1000 °C", "600 °C", "474 °C", "200 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Venus is one of the brightest natural objects in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Why can we call Venus, as &#34;Earth's sister&#34;?",
                        Answers={ "Because of Size and Mass are similar to Earth", "There aren't such a thing like &#34;Earth's sister&#34;"},
                        CorrectAnswerIndex=0
                    }
                 }
            },

         /// <summary>
         /// Earth.
         /// </summary>
            new Planet
            {
                Name="Earth",
                Distance_from_sun = 150000000,
                Diameter= 12756,
                Age=4500000000,
                Rotation_period=1440,
                Rotation_speed=1670,
                Orbital_period=365,
                Moons=1,
                Mass=5972*Math.Pow(10,24),
                Highest_temp=56.7,
                Lowest_temp=-89.2,
                Statements={
                    "Earth only has one moon.",
                    "Earth is more than 4.5 billion years old.",
                    "Earth takes a year to orbitate one round of the Sun.",
                    "Earth rotates around its own axis in 24 hours.",
                    "Earth is filled by: 71% of water, the rest are land.",
                    "Humans are only on Earth (yet), and they emerged ca. 300 000 years ago. Nowadays, the human population is around 8 billion already.",
                    "Every fourth year, we have to add an extra day, now containing 366 days, it's called &#34;Leap year&#34;."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="How many moons does Earth have?",
                        Answers={ "3", "7", "1", "4" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How old is Earth?",
                        Answers={ "100 thousand years", "6 million years", "4.5 billion years", "10 billion years" },
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="What does the earth consist of?",
                        Answers={ "71% water and 29% land", "29% water and 71% water", "50% water and 50% land", "85% water and 15% land" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="How long does the Earth need to rotate around its own axis?",
                        Answers={ "12 hours", "6 hours", "24 hours", "48 hours" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take the Earth to orbitate one round of the Sun?",
                        Answers={ "Half a year", "1 year", "5 years", "6 Months" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How many days are there in a year on earth?",
                        Answers={ "365 days", "366 days", "256 days", "460 days" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="For how many years, have there been humans on earth?",
                        Answers={ "100.000", "10.000", "600.000", "300.000" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="What does the &#34;Leap Year&#34; mean?",
                        Answers={ "When we have one less day", "When we have one extra day", "When we have one extra month", "When we have two less months" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How big is the human population on Earth?",
                        Answers={ "4 million", "100.000", "8 billion", "16.000" },
                        CorrectAnswerIndex=2
                    },

                }
            },
         
         /// <summary>
         /// Mars.
         /// </summary>
            new Planet
            {
                Name = "Mars",
                Distance_from_sun = 228000000,
                Diameter = 6792,
                Age = 3000000000,
                Rotation_period = 1476,
                Rotation_speed = 868.22,
                Orbital_period = 687,
                Moons = 2,
                Mass = 6417 * Math.Pow(10, 23),
                Highest_temp = 21,
                Lowest_temp = -128,
                Statements ={
                    "Mars is the second-smallest planet in the Solar System and the fourth planet of the Sun.",
                    "It's named after the Roman god of war, Mars.",
                    "The planet has two moons, Phobos and Demios.",
                    "It has a thin atmosphere, with the surface featuring impact craters, valleys, dunes, and polar ice caps.",
                    "Mars has the largest volcano and the highest known mountain in the Solar System, named Olympus Mons.",
                    "The planet was visited by several uncrewed spacecraft, for ex.: &#34;Mariner 4, in 1965&#34;",
                    "It can easily be seen from Earth with naked eye."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Mars have in the order of the planets when counting from the sun?",
                        Answers={ "Fourth", "Second", "Sixth", "Ninth" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Mars is the second smallest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="What was Mars the god of?",
                        Answers={ "Flowers", "Life", "War", "Death" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="We know Mars has two moons. What are they called?",
                        Answers={ "Triton and Titan", "Callisto and Europa", "Phobos and Deimos"},
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the name of the highest known mountain on Mars?",
                        Answers={ "It hasn’t got any name", "Olympia Moon", "Olympus Mons", "Olympian Field" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that the planet was visited by several CREWED spacecrafts?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that you can see the planet with naked eye from the Earth?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Does Mars have any kind of atmosphere?",
                        Answers={ "Thin", "Strong", "Weak", "Tall" },
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Jupiter.
         /// </summary>
            new Planet
            {
                Name = "Jupiter",
                Distance_from_sun = 778000000,
                Diameter = 143000,
                Age = 4600000000,
                Rotation_period = 595,
                Rotation_speed = 45000,
                Orbital_period = 4333,
                Moons = 81,
                Mass = 1898 * Math.Pow(10, 27),
                Highest_temp = 145,
                Lowest_temp = -195,
                Statements ={
                    "Jupiter is the fifth planet from the Sun, and the largest in the Solar System.",
                    "It's named after the roman god Jupiter, the king of the gods.",
                    "The planet completes an orbit around the Sun every 11.86 years.",
                    "Jupiter is the third brightest natural object in the Earth's night sky, after the Moon and Venus.",
                    "The planet is primarily composed of hydrogen and helium, it lacks a well-defined solid surface.",
                    "Jupiter has at least 80 known moons and possibly many more, the four biggest are: Io, Europa, Ganymede and Callisto.",
                    "People have been observing Jupiter since prehistoric times."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Jupitor have in the order of the planets when counting from the sun?",
                        Answers={ "Fifth", "First", "Sixth", "Seventh" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What was Jupiter the god of?",
                        Answers={ "The god of the underworld, Hades", "The roman king of the gods, Jupiter", "The goddess of magic, Hecate"},
                        CorrectAnswerIndex =1
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Jupiter to orbitate one round of the Sun?",
                        Answers={ "22 Years", "600 days", "12 year", "15 years" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Jupiter have?",
                        Answers={ "20", "45", "70", "80" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Since when did humans start to observe the planet?",
                        Answers={ "Since yesterday", "Since last year", "Since prehistoric times", "Since last week" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the planet composed of?",
                        Answers={ "Solid surface", "Hydrogen and Helium", "Water"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What are the four biggest Moon called?",
                        Answers={ "Io, Callisto, Europa, and Ganymede", "Jupiter, Fo, Callisteo, and Phobos", "Miraculus, Saturn, Ganymede, and Quasimodo"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Jupiter is the biggest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Saturn.
         /// </summary>
            new Planet
            {
                Name = "Saturn",
                Distance_from_sun = 1433449370,
                Diameter = 120500,
                Age = 4600000000,
                Rotation_period = 642,
                Rotation_speed = 35500,
                Orbital_period = 10756,
                Moons = 82,
                Mass = 5683 * Math.Pow(10, 26),
                Highest_temp = 57,
                Lowest_temp = -173,
                Statements ={
                    "Saturn is the sixth planet from the Sun and the second-largest in the Solar System.",
                    "It takes Saturn 10 759 days to finish one revolution around the Sun.",
                    "The outer atmosphere is generally bland and lacking in contrast, although long-lived features can appear.",
                    "Wind speeds on the planet can reach 1800 km/h.",
                    "Saturn's most notable feature is it's prominent ring system, which is composed mainly of ice particles, with a smaller amount of rocky debris and dust.",
                    "Saturn has at least 83 moons of which 53 are officially named, the largest one called &#34;Titan&#34;.",
                    "It's named after the roman god of wealth and agriculture and the father of Jupiter, Saturn."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Saturn have in the order of the planets when counting from the sun?",
                        Answers={ "First", "Fifth", "Tenth", "Sixth" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that it takes 10759 days for Saturn to orbitate one round of the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Saturn have?",
                        Answers={ "53", "36", "83", "92" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What are the highest measured wind speeds on the planet?",
                        Answers={ "100km/h", "1800km/h", "320km/h", "960km/h"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Saturn is the third largest planet in the Solar System?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of titans, Cronus", "The roman god of wealth and agriculture, Saturn", "The greek goddess of snow, Khione", "The norse god of lightnings, Thor" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What does Saturn have that no other planet has?",
                        Answers={ "A system of rings in orbit", "A special brand of candy", "A high-speed train"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What is the largest moon of Saturn, called?",
                        Answers={ "Ghost", "Titan", "Zeus", "Giant" },
                        CorrectAnswerIndex=1
                    }
                }
            },
         
         /// <summary>
         /// Uranus.
         /// </summary>
            new Planet
            {
                Name = "Uranus",
                Distance_from_sun = 2870972200,
                Diameter = 51100,
                Age = 4600000000,
                Rotation_period = 1020,
                Rotation_speed = 9320,
                Orbital_period = 30687,
                Moons = 27,
                Mass = 8682 * Math.Pow(10, 25),
                Highest_temp = 4982,
                Lowest_temp = -224,
                Statements ={
                    "Uranus is the seventh planet of the Solarsystem.",
                    "It's named after the Greek god of the Sky, Uranus.",
                    "the planet orbits the Sun every 84 years.",
                    "Like Jupiter, it lacks a well-defined solid surface.",
                    "The planet's atmosphere is similar to Jupiter's and Saturn's in its primary composition of hydrogen and helium, but it contains more &#34;ices&#34;, such as water, or ex: ammonia.",
                    " Uranus has the coldest planetary atmosphere in the Solar System, with the minimum temperature of -224 °C",
                    "Wind speeds can reach 900 km/h.",
                    "The planet has 27 known moons.",
                    "Only one spacecraft visited the planet, in 1986, the &#34;Voyeur 2&#34;."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="What position does Uranus have in the order of the planets when counting from the sun?",
                        Answers={ "Third", "Seventh", "Fourth", "Eleventh" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Uranus to orbitate one round of the Sun?",
                        Answers={ "84 years", "105 years", "140 years", "56 years" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Uranus doesn't have any solid material on the surface?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Which planets can Uranus be compared to?",
                        Answers={ "Neptune and Mercury", "Mars and Venus", "Earth and Moon", "Jupiter and Saturn" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Uranus has the coldest planetary atmosphere in the Solar System?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of the sky, Uranus", "The irish goddess of fate, Morrigan", "It wasn’t named after anybody" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="How many spacecraft has visited the planet?",
                        Answers={ "2", "5", "1", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What are the highest measured wind speeds on the planet Uranus?",
                        Answers={ "450 km/h", "900 km/h", "500 km/h", "700 km/h" },
                        CorrectAnswerIndex=1
                    }
                }
            },

         /// <summary>
         /// Neptune.
         /// </summary>
            new Planet
            {
                Name = "Neptune",
                Distance_from_sun = 4503443661,
                Diameter = 49500,
                Age = 4600000000,
                Rotation_period = 960,
                Rotation_speed = 9650,
                Orbital_period = 60190,
                Moons = 14,
                Mass = 1024 * Math.Pow(10, 26),
                Highest_temp = 7000,
                Lowest_temp = -218,
                Statements ={
                    "Neptune is the eighth and the planet furthest from the Sun.",
                    "It has no well-defined solid surface, as being composed primarily of gasses and liquids.",
                    "The planet orbits the Sun every 165 years.",
                    "It's named after the roman god of the seas, Neptune.",
                    "Neptune has 14 known moons, the largest called Triton.",
                    "The planet's atmosphere is composed primarily of hydrogen and helium, along with traces of hydrocarbons and possibly nitrogen, though it contains more &#34;ices&#34;, than Jupiter or Saturn.",
                    "Like Uranus, only one spacecraft visited the planet, in 1989, &#34;The Voyeur 2&#34;.",
                    "Neptune's outer atmosphere is one of the coldest places in the Solar System, with the temperature around -218 °C, but at the planet's center is much hotter, notedly 5100 °C."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Is it true that Neptune is the planet furthest from the Sun?",
                        Answers={ "Yes", "No"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Neptune to orbitate one round of the Sun?",
                        Answers={ "200 years", "172 years", "165 years", "147 years" },
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The greek god of the seas, Poseidon", "The roman god of the seas, Neptune", "The egyptian god of the seas, Nu)" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Neptune have?",
                        Answers={ "10", "16", "14", "17" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the biggest moon in orbit of Neptune called?",
                        Answers={ "Triton", "Oceanus", "Styx", "Nereus" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that the planet has been visited by a lot of spacecrafts?",
                        Answers={ "Yes", "No" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="What is the temperature of Neptune's outer atmosphere?",
                        Answers={ "-162 °C", "-346 °C", "-218 °C", "-252 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What is the temperature in the center Neptune's inner core?",
                        Answers={ "3700 °C", "4600 °C", "6600 °C", "5100 °C" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the spacecraft that visited Neptune?",
                        Answers={ "Voyeur 2", "MESSENGER", "Apollo 7", "It wasn’t named" },
                        CorrectAnswerIndex=0
                    },
                }
            },

         /// <summary>
         /// Pluto.
         /// </summary>
            new Planet
            {
                Name = "Pluto",
                Distance_from_sun = 5906376272,
                Diameter = 2274,
                Age = 4600000000,
                Rotation_period = 9180,
                Rotation_speed = 47.18,
                Orbital_period = 90520,
                Moons = 5,
                Mass = 1309 * Math.Pow(10, 22),
                Highest_temp = -223,
                Lowest_temp = -233,
                Statements ={
                    "Pluto is a dwarf planet in the Kuiper belt.",
                    "It's named after the Roman god of the underworld, Pluto.",
                    "After the planet was discovered in 1930, it was declared to be the ninth planet from the Sun. Later this was questioned because of the distance and size, and this led to 2006, when it was reclassified as a dwarf planet.",
                    "It has 5 known moons: Charon, Styx, Nix, Kerberos and Hydra.",
                    "Back in 2015, a spacecraft, named &#34;New Horizons&#34; performed a flyby on Pluto, and it was the only visit to the planet.",
                    "Pluto orbits the Sun every 248 years.",
                    "The surface of Pluto is composed of more than 98% nitrogen ice, with traces of methane and carbon monoxide."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Who is the planet named after?",
                        Answers={ "The norse goddess of death, Hela", "The greek god of the underworld, Hades", "The greek god of death, Thanatos", "The roman god of the underworld, Pluto" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question=" Is Pluto a normal planet?",
                        Answers={ "Yes", "no, It doesn’t exist", "It is unknown", "It is a dwarf planet" },
                        CorrectAnswerIndex =3
                    },
                    new QuestionAndAnswer{
                        Question="When was Pluto discovered by humans?",
                        Answers={ "1890", "1910", "1930", "1950" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How long does it take Pluto to orbitate one round of the Sun?",
                        Answers={ "248 days", "248 months", "248 years" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How many moons does Pluto have?",
                        Answers={ "15", "22", "5", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="What year was Pluto visited by a spacecraft?",
                        Answers={ "2006", "2012", "2009", "2015" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="What was the name of the spacecraft that visited the planet?",
                        Answers={ "New Horizons", "Voyeur 5", "Titanic 22", "Crazy Horse" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="What is Pluto composed of?",
                        Answers={ "Dirt", "Sugar", "Nitrogen Ice", "Salt", "Grass" },
                        CorrectAnswerIndex=2
                    }
                }
            },
        };

#endregion




#region Danish

List<Planet> planets_da = new List<Planet>()
        {
         /// <summary>
         /// Mercury.
         /// </summary>
            new Planet
            {
                Name="Merkur",
                Distance_from_sun = 47000000,
                Diameter= 4878 ,
                Age=4600000000,
                Rotation_period=84450,
                Rotation_speed=10892 ,
                Orbital_period=88,
                Moons=0,
                Mass=3.301*Math.Pow(10,23),
                Highest_temp=430,
                Lowest_temp=-180,
                Statements={
                    "Merkur er en af de mindste planeter i solsystemet, og den er tættest på Solen.",
                    "Merkur kredser om Solen i løbet af 88 dage, hvilket er den korteste kredsløbsperiode af alle Solens planeter.",
                    "Merkur er opkaldt efter den romerske handelsgud, og gudernes budbringer, Mercurius.",
                    "Merkur overflade fremstår stærkt krateret og ligner Månens udseende.",
                    "På trods af den lille størrelse har Merkur et betydeligt, og tilsyneladende globalt magnetfelt.",
                    "Merkur har næsten ingen atmosfære til at holde på varmen, temperaturen varierer fra -173 °C til 427 °C.",
                    "Merkur oplevede et rumfartøjsstyrt tilbage den 30. april 2015; da NASA med vilje lod et rumfartøj ved navn &#34;MESSENGER&#34; styrte ind i det."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="Hvor lang tid tager det Merkur at kredse en omgang om Solen?",
                        Answers={ "10 dage", "88 dage", "200 dage", "365 dage" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hvem er planeten Mercur opkaldt efter?",
                        Answers={ "Den er ikke opkaldt efter nogen", "Den græske gud, Hermes", "Den romerske gud Merkurius"},
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="Hvad er den højst målte temperatur på Merkur?",
                        Answers={ "166 °C", "512 °C", "427 °C", "400 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvad er den laveste målte temperatur på Merkur?",
                        Answers={ "-173 °C", "0 °C", "-100 °C", "-386 °C" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvad var navnet på den rumsonde, som NASA lod styrte ned på Merkur?",
                        Answers={ "MESSAGE", "MESSENGER", "MESSAGES", "MESS" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hvordan ser overfladen ud på planeten Merkur?",
                        Answers={ "Glat", "Små bakker", "kraterfyldt", "Dækket af vand" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Er det sandt at Merkur er den planet som er tættest på solen?",
                        Answers={ "Ja", "Nej"},
                        CorrectAnswerIndex=0
                    },

                }
            },

         /// <summary>
         /// Venus.
         /// </summary>
            new Planet
            {
                Name="Venus",
                Distance_from_sun = 108208930 ,
                Diameter= 12104 ,
                Age=4600000000,
                Rotation_period=348480,
                Rotation_speed=6.52,
                Orbital_period=225 ,
                Moons=0,
                Mass=4867*Math.Pow(10,24),
                Highest_temp=475,
                Lowest_temp=-173,
                Statements={
                    "Venus er den næst nærmeste planet fra Solen.",
                    "Den er opkaldt efter den romerske gudinden for kærlighed og skønhed, Venus.",
                    "Venus kredser om Solen på 225 dage.",
                    "Venus er det lyseste naturlige objekt på himlen, kun overgået af solen og månen. Den kan det kaste skygger og kan være synligt med det blotte øje ved højlys dag.",
                    "Ligesom Merkur har Venus heller ingen måner.",
                    "Selvom Mercur er tættere på Solen, Så er det Venus som har den varmeste overflade af enhver planet i solsystemet, med en top temperatur omkring 474 °C.",
                    "Dens størrelse og masse ligner Jordens, Derfor bliver Venus ofte betegnet som &#34;Jordens søster&#34;.",
                    "Der er en teori, som siger, at hvis Venus engang havde et hav eller andet vand, så blev det fordampet af varmen, og på grund af manglen på magnetfeltet, blev den tilbageværende brint fejet ud i rummet af solvinden."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="Hvilken position har Venus i planeternes rækkefølge, når man tæller fra solen?",
                        Answers={ "Første", "Fjerde", "Anden", "Tiende" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvilken gud, eller gudinde er planeten opkaldt efter?",
                        Answers={ "Den romerske gudinde, Venus", "Den romerske gudinde, Diana", "Den græske gudinde, Afrodite", "Den græske gudinde, Artemis" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Hvor lang tid tager det Merkur at kredse en omgang om Solen?",
                        Answers={ "112 dage", "225 dage", "256 dage", "720 dage" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hvor mange måner har Venus?",
                        Answers={ "2", "7", "0", "6" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvad er den højst målte temperatur på Venus?",
                        Answers={ "1000 °C", "600 °C", "474 °C", "200 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Er det rigtigt, at Venus er et af de lyseste naturlige objekter i solsystemet?",
                        Answers={ "Ja", "Nej"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvorfor kan vi kalde Venus for en &#34;Jordens søster&#34;?",
                        Answers={ "På grund af at størrelse og masse er tæt på Jordens", "Jorden har da ingen søskende"},
                        CorrectAnswerIndex=0
                    }
                 }
            },

         /// <summary>
         /// Earth.
         /// </summary>
            new Planet
            {
                Name="Jorden",
                Distance_from_sun = 150000000,
                Diameter= 12756,
                Age=4500000000,
                Rotation_period=1440,
                Rotation_speed=1670,
                Orbital_period=365,
                Moons=1,
                Mass=5972*Math.Pow(10,24),
                Highest_temp=56.7,
                Lowest_temp=-89.2,
                Statements={
                    "Jorden har kun én måne.",
                    "Jorden er mere end 4,5 milliarder år gammel.",
                    "Det tager et år for Jorden at kredse en omgang om Solen.",
                    "Jorden roterer om sin egen akse på 24 timer.",
                    "Jorden består af: 71% vand, og resten er land.",
                    "Mennesker lever kun på Jorden (endnu), og de opstod for ca. 300.000 år siden. I dag er den menneskelige befolkningstal allerede på ca. 8 milliarder.",
                    "Hvert fjerde år skal vi tilføje en ekstra dag, der så indeholder 366 dage, det hedder &#34;Skudår&#34;."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="Hvor mange måner har Jorden?",
                        Answers={ "3", "7", "1", "4" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvor gammel er jorden?",
                        Answers={ "100 tusind år", "6 millioner år", "4.5 milliarder år", "10 milliarder år" },
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="Hvad består jorden af?",
                        Answers={ "71% vand og 29% land", "29% vand og 71% vand", "50% vand og 50% land", "85% vand og 15% land" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvor lang tid bruger Jorden på at roterer en omgang om sin egen akse?",
                        Answers={ "12 timer", "6 timer", "24 timer", "48 timer" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvor lang tid tager det Jorden at kredse en omgang om Solen?",
                        Answers={ "Et halvt år", "1 år", "5 år", "6 måneder" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="hvor mange dage er der på et år på jorden?",
                        Answers={ "365 dage", "366 dage", "256 dage", "460 dage" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvor mange år, har der været mennesker på jorden?",
                        Answers={ "100.000", "10.000", "600.000", "300.000" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Hvad betyder &#34;skudår&#34;?",
                        Answers={ "At der er en dag mindre på et år", "At der er en dag ekstra på et år", "At der er en ekstra måned på et år", "At der er to færre måneder på et år" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hvor mange mennesker lever på Jorden?",
                        Answers={ "4 millioner", "100.000", "8 milliarder", "16.000" },
                        CorrectAnswerIndex=2
                    },

                }
            },

         /// <summary>
         /// Mars.
         /// </summary>
            new Planet
            {
                Name = "Mars",
                Distance_from_sun = 228000000,
                Diameter = 6792,
                Age = 3000000000,
                Rotation_period = 1476,
                Rotation_speed = 868.22,
                Orbital_period = 687,
                Moons = 2,
                Mass = 6417 * Math.Pow(10, 23),
                Highest_temp = 21,
                Lowest_temp = -128,
                Statements ={
                    "Mars er den næstmindste planet i solsystemet og den fjerde planet, talt fra solen Solen.",
                    "Mars er opkaldt efter den romerske krigsgud, Mars.",
                    "Planeten har to måner, Phobos og Demios.",
                    "Mars har en tynd atmosfære, med en overflade med mange  nedslag kratere, dale, klitter og polare iskapper.",
                    "Mars har den største vulkan og det højeste kendte bjerg i solsystemet, ved navn Olympus Mons.",
                    "Planeten blev besøgt af flere ubemandede rumfartøjer, f.eks.: &#34;Mariner 4, i 1965&#34;",
                    "Mars kan ses fra Jorden med det blotte øje."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Hvilken position har Mars i planeternes rækkefølge, når man tæller fra solen?",
                        Answers={ "Fjerde", "Anden", "Sjette", "Niende" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Er det rigtigt, at Mars er den næstmindste planet i solsystemet?",
                        Answers={ "Ja", "Nej"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Hvad repræsenterede guden Mars?",
                        Answers={ "Blomster", "Livet", "Krig", "Døden" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Vi ved, at Mars har to måner. Hvad hedder de?",
                        Answers={ "Triton og Titan", "Callisto og Europa", "Phobos og Deimos"},
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvad hedder det højeste bjerg på Mars?",
                        Answers={ "Det har ikke noget navn", "Olympia Moon", "Olympus Mons", "Olympian Field" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Er det sandt, at planeten blev besøgt af flere BEMANDEDE rumfartøjer?",
                        Answers={ "Ja", "Nej"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Er det sandt at du kan se Planeten Mars med det blotte øje her på Jorden?",
                        Answers={ "Ja", "Nej"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Har Mars nogen form for atmosfære?",
                        Answers={ "Tynd", "Stærk", "Svag", "Høj" },
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Jupiter.
         /// </summary>
            new Planet
            {
                Name = "Jupiter",
                Distance_from_sun = 778000000,
                Diameter = 143000,
                Age = 4600000000,
                Rotation_period = 595,
                Rotation_speed = 45000,
                Orbital_period = 4333,
                Moons = 81,
                Mass = 1898 * Math.Pow(10, 27),
                Highest_temp = 145,
                Lowest_temp = -195,
                Statements ={
                    "Jupiter er den femte planet fra Solen, og den største planet i solsystemet.",
                    "Den er opkaldt efter den romerske gud Jupiter, gudernes konge.",
                    "Planeten fuldfører et kredsløb om Solen i løbet af 11,86 år.",
                    "Jupiter er det tredje lyseste naturlige objekt på jordens nattehimmel, efter Månen og Venus.",
                    "Planeten er primært sammensat af brint og helium, den mangler en veldefineret fast overflade.",
                    "Jupiter har mindst 80 kendte måner og muligvis mange flere som endnu ikke er opdaget, de fire største er: Io, Europa, Ganymedes og Callisto.",
                    "Menneskeheden har observeret Jupiter siden forhistorisk tid."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Hvilken position har Jupiter i planeternes rækkefølge, når man tæller fra solen?",
                        Answers={ "Femte", "Første", "Sjette", "Syvende" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvad repræsenterede guden Jupiter?",
                        Answers={ "Underverdenens gud, Hades", "Gudernes romerske konge, Jupiter", "Magiens gudinde, Hecate"},
                        CorrectAnswerIndex =1
                    },
                    new QuestionAndAnswer{
                        Question="Hvor lang tid tager det Jupiter at kredse en omgang om Solen?",
                        Answers={ "22 år", "600 dage", "12 år", "15 år" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvor mange måner har Jupiter?",
                        Answers={ "20", "45", "70", "80" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Siden hvornår begyndte mennesker at observere planeten Jupiter?",
                        Answers={ "Siden i går", "Siden sidste år", "Siden forhistorisk tid", "Siden sidste uge" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvad består planeten af?",
                        Answers={ "Fast overflade", "Hydrogen og helium", "Vand"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hvad hedder de fire største måner?",
                        Answers={ "Io, Callisto, Europa, og Ganymede", "Jupiter, Fo, Callisteo, og Phobos", "Miraculus, Saturn, Ganymede, og Quasimodo"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Er det rigtigt, at Jupiter er den største planet i solsystemet?",
                        Answers={ "Ja", "Nej"},
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Saturn.
         /// </summary>
            new Planet
            {
                Name = "Saturn",
                Distance_from_sun = 1433449370,
                Diameter = 120500,
                Age = 4600000000,
                Rotation_period = 642,
                Rotation_speed = 35500,
                Orbital_period = 10756,
                Moons = 82,
                Mass = 5683 * Math.Pow(10, 26),
                Highest_temp = 57,
                Lowest_temp = -173,
                Statements ={
                    "Saturn er den sjette planet fra Solen og den næststørste i solsystemet.",
                    "Det tager Saturn 10.759 dage at afslutte en omdrejning omkring Solen.",
                    "Den ydre atmosfære er generelt intetsigende og kontrastløs, selvom længerevarende variationer kan forekomme.",
                    "Vindhastigheder på planeten kan nå op på 1800 km/t.",
                    "Saturns mest bemærkelsesværdige træk, er dets fremtrædende ringsystem, som hovedsageligt består af ispartikler med en mindre mængde isdækkede stenstykker og støv.",
                    "Saturn har mindst 83 måner, hvoraf 53 er officielt navngivet, den største kaldes &#34;Titan&#34;.",
                    "Saturner opkaldt efter den romerske gud for rigdom og landbrug og Jupiters far, Saturn."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Hvilken position har Saturni planeternes rækkefølge, når man tæller fra solen?",
                        Answers={ "Første", "Femte", "Tiende", "Sjette" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Er det rigtigt, at det tager 10759 dage for Saturn at kredse en runde om Solen?",
                        Answers={ "Ja", "Nej"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Hvor mange måner har Saturn?",
                        Answers={ "53", "36", "83", "92" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvad er de højest målte vindhastigheder på planeten?",
                        Answers={ "100km/t", "1800km/t", "320km/t", "960km/t"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Er det rigtigt, at Saturn er den tredjestørste planet i solsystemet?",
                        Answers={ "Ja", "Nej"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hvem er planeten opkaldt efter?",
                        Answers={ "Den græske gud for titaner, Cronus", "Den romerske gud for rigdom og landbrug, Saturn", "Den græske gudinde for sne, Khione", "Den nordiske Tordengud, Thor" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hvad har Saturn, som ingen anden planet har?",
                        Answers={ "Tydelige ringe i kredsløb om sig", "Et specielt slik mærke", "Et højhastighedstog"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvad hedder Saturns største måne?",
                        Answers={ "Ghost", "Titan", "Zeus", "Giant" },
                        CorrectAnswerIndex=1
                    }
                }
            },
         
         /// <summary>
         /// Uranus.
         /// </summary>
            new Planet
            {
                Name = "Uranus",
                Distance_from_sun = 2870972200,
                Diameter = 51100,
                Age = 4600000000,
                Rotation_period = 1020,
                Rotation_speed = 9320,
                Orbital_period = 30687,
                Moons = 27,
                Mass = 8682 * Math.Pow(10, 25),
                Highest_temp = 4982,
                Lowest_temp = -224,
                Statements ={
                    "Uranus er solsystemets syvende planet.",
                    "Planeten er opkaldt efter den græske himmelgud, Uranus.",
                    "Planeten kredser om Solen i løbet af 84. år.",
                    "Ligesom Jupiter mangler den en veldefineret fast overflade.",
                    "Planetens atmosfære ligner Jupiters og Saturns i sin primære sammensætning af brint og helium, men den indeholder mere &#34;is&#34;, såsom vand, samt ammoniak.",
                    "Uranus er den planet med den koldeste atmosfære i solsystemet, med minimum temperature på ned til -224 °C.",
                    "Vindhastigheden kan nå op på 900 km/t.",
                    "Planeten har 27 kendte måner.",
                    "Kun ét rumfartøj har besøgt planeten, i 1986, &#34;Voyeur 2&#34;."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Hvilken position har Uranus i planeternes rækkefølge, når man tæller fra solen?",
                        Answers={ "Tredje", "Syvende", "Fjerde", "Ellevte" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hvor lang tid tager det Jupiter at kredse en omgang om Solen?",
                        Answers={ "84 år", "105 år", "140 år", "56 år" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Er det rigtigt, at Uranus ikke har noget fast materiale på overfladen?",
                        Answers={ "Ja", "Nej" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvilke planeter kan Uranus sammenlignes med?",
                        Answers={ "Neptun og Merkur", "Mars og Venus", "Jorden og Månen", "Jupiter og Saturn" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Er det rigtigt, at Uranus er den planet i solsystemet med den koldeste atmosfære?",
                        Answers={ "Ja", "Nej" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvem er planeten opkaldt efter?",
                        Answers={ "Himlens græske gud, Uranus", "Den irske skæbnegudinde, Morrigan", "Den er ikke opkaldt efter nogen" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvor mange rumfartøjer har besøgt planeten?",
                        Answers={ "2", "5", "1", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvad er de højeste målte vindhastigheder på planeten Uranus?",
                        Answers={ "450 km/t", "900 km/t", "500 km/t", "700 km/t" },
                        CorrectAnswerIndex=1
                    }
                }
            },

         /// <summary>
         /// Neptune.
         /// </summary>
            new Planet
            {
                Name = "Neptun",
                Distance_from_sun = 4503443661,
                Diameter = 49500,
                Age = 4600000000,
                Rotation_period = 960,
                Rotation_speed = 9650,
                Orbital_period = 60190,
                Moons = 14,
                Mass = 1024 * Math.Pow(10, 26),
                Highest_temp = 7000,
                Lowest_temp = -218,
                Statements ={
                    "Neptun er den ottende og er den planet, der er længst væk fra Solen.",
                    "Den har ingen veldefineret fast overflade, da den primært består af gasser og væsker.",
                    "Planeten kredser om Solen i løbet af 165. år.",
                    "Den er opkaldt efter den romerske havgud, Neptun.",
                    "Neptun har 14 kendte måner. Den største kaldes Triton.",
                    "Planetens atmosfære består primært af brint og helium sammen med spor af kulbrinter og muligvis nitrogen, selvom den indeholder mere &#34;is&#34;, end Jupiter eller Saturn.",
                    "Ligesom Uranus besøgte kun ét rumfartøj planeten, i 1989, &#34;The Voyeur 2&#34;.",
                    "Neptuns ydre atmosfære er et af de koldeste steder i solsystemet, med temperaturen omkring -218 °C, men i planetens centrum er det meget varmere, angiveligt 5100 °C."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Er det rigtigt, at Neptun er den planet, der er længst væk fra Solen?",
                        Answers={ "Ja", "Nej"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvor lang tid tager det Neptun at kredse en omgang om Solen?",
                        Answers={ "200 år", "172 år", "165 år", "147 år" },
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="Hvem er planeten opkaldt efter?",
                        Answers={ "Den græske havgud, Poseidon", "Den romerske havgud, Neptun", "Den egyptiske havgud, Nu)" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hvor mange måner har Neptun?",
                        Answers={ "10", "16", "14", "17" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvad hedder den største måne i kredsløb om Neptun?",
                        Answers={ "Triton", "Oceanus", "Styx", "Nereus" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Er det rigtigt, at planeten er blevet besøgt af en masse rumfartøjer?",
                        Answers={ "Ja", "Nej" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hvordan er temperaturen ved Neptuns ydre atmosfære?",
                        Answers={ "-162 °C", "-346 °C", "-218 °C", "-252 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="How is the temperature in the center Neptune's inner core?",
                        Answers={ "3700 °C", "4600 °C", "6600 °C", "5100 °C" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Hvad hed det rumfartøj, der besøgte Neptun?",
                        Answers={ "Voyeur 2", "MESSENGER", "Apollo 7", "Den Havde ikke noget navn" },
                        CorrectAnswerIndex=0
                    },
                }
            },

         /// <summary>
         /// Pluto.
         /// </summary>
            new Planet
            {
                Name = "Pluto",
                Distance_from_sun = 5906376272,
                Diameter = 2274,
                Age = 4600000000,
                Rotation_period = 9180,
                Rotation_speed = 47.18,
                Orbital_period = 90520,
                Moons = 5,
                Mass = 1309 * Math.Pow(10, 22),
                Highest_temp = -223,
                Lowest_temp = -233,
                Statements ={
                    "Pluto er en dværgplanet i Kuiper bæltet.",
                    "Den er opkaldt efter den romerske gud for underverdenen, Pluto.",
                    "Efter at planeten blev opdaget i 1930, blev den erklæret for at være den niende planet fra Solen. Senere blev der sat spørgsmålstegn ved dette på grund af afstanden og størrelsen. Dette førte til 2006, til at den blev omklassificeret til at være en dværgplanet.",
                    "Pluto har 5 kendte måner: Charon, Styx, Nix, Kerberos og Hydra.",
                    "I 2015 gennemførte et rumfartøj ved navn &#34;New Horizons&#34; en forbiflyvning på Pluto, og det var det eneste besøg på planeten.",
                    "Pluto kredser om Solen i løbet af 248 år.",
                    "Overfladen på Pluto er sammensat af mere end 98 % nitrogen is, med spor af metan og kulilte."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Hvem er planeten opkaldt efter?",
                        Answers={ "Den nordiske dødsgudinde, Hela", "Den græske gud for underverdenen, Hades", "Den græske dødsgud, Thanatos", "Den romerske gud for underverdenen, Pluto" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question=" Er Pluto en normal planet?",
                        Answers={ "Ja", "Nej, Den eksisterer ikke", "Det vides ikke", "Det er en dværgplanet" },
                        CorrectAnswerIndex =3
                    },
                    new QuestionAndAnswer{
                        Question="Hvornår blev Pluto opdaget af mennesker?",
                        Answers={ "1890", "1910", "1930", "1950" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvor lang tid tager det Pluto at kredse en omgang om Solen?",
                        Answers={ "248 dage", "248 måneder", "248 år" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvor mange måner kredser omkring Pluto?",
                        Answers={ "15", "22", "5", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hvilket år blev Pluto besøgt af et rumfartøj?",
                        Answers={ "2006", "2012", "2009", "2015" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Hvad hed det rumfartøj, der besøgte planeten?",
                        Answers={ "New Horizons", "Voyeur 5", "Titanic 22", "Crazy Horse" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hvad består Pluto af?",
                        Answers={ "Jord", "Sukker", "Nitrogen is", "Salt", "Græssletter" },
                        CorrectAnswerIndex=2
                    }
                }
            },
        };

#endregion




#region Hungarian

List<Planet> planets_hu = new List<Planet>()
        {
         /// <summary>
         /// Mercury.
         /// </summary>
            new Planet
            {
                Name="Merkúr",
                Distance_from_sun = 47000000,
                Diameter= 4878 ,
                Age=4600000000,
                Rotation_period=84450,
                Rotation_speed=10892 ,
                Orbital_period=88,
                Moons=0,
                Mass=3.301*Math.Pow(10,23),
                Highest_temp=430,
                Lowest_temp=-180,
                Statements={
                    "Merkúr az egyik legkisebb bolygó a naprendszerben és ez van legközelebb a Naphoz.",
                    "Merkúr 88 nap alatt tesz meg egy kört a Nap körül, a többi bolygó közül a legrövidebb idő alatt.",
                    "A római kereskedelem istenéről és az istenek hírnökéről, Merkúriuszról lett elnevezve.",
                    "A felszíne kráteres és hasonló a megjelenése a Hold felszínéhez.",
                    "A kis mérete ellenére Merkúrnak jelentős mágneses mezője van.",
                    "Szinte nincs légköre ami megtartaná a hőt, így a hőmérséklet -173 °C és 427 °C között változik.",
                    "A NASA 2015. április 30-án hagyta, hogy a MESSENGER nevű űrhajóra lezuhanjon a bolygóra."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="Mennyi időbe telik amíg a Merkúr megtesz egy teljes kört a Nap körül?",
                        Answers={ "10 nap", "88 nap", "200 nap", "365 nap" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Kiről nevezték el a Merkúrt?",
                        Answers={ "Senkiről sem lett elnevezve", "A görög Istenről, Hermészről", "Egy római Istenről, Merkuriusról"},
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="Mi a legmagasabb hőmérséklet a Merkúron?",
                        Answers={ "166 °C", "512 °C", "427 °C", "400 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Mi a legalacsonyabb hőmérséklet a Merkúron?",
                        Answers={ "-173 °C", "0 °C", "-100 °C", "-386 °C" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Mi volt a neve annak az űrszondának amivel a NASA landolt a Merkúron?",
                        Answers={ "MESSAGE", "MESSENGER", "MESSAGES", "MESS" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hogyan néz ki a talaj a Merkúron?",
                        Answers={ "Sima", "Hegyes", "Kráteres", "Vizes" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Igaz, hogy a Merkúr a legközelebbi bolygó a Naphoz?",
                        Answers={ "Igaz", "Hamis"},
                        CorrectAnswerIndex=0
                    },

                }
            },

         /// <summary>
         /// Venus.
         /// </summary>
            new Planet
            {
                Name="Vénusz",
                Distance_from_sun = 108208930 ,
                Diameter= 12104 ,
                Age=4600000000,
                Rotation_period=348480,
                Rotation_speed=6.52,
                Orbital_period=225 ,
                Moons=0,
                Mass=4867*Math.Pow(10,24),
                Highest_temp=475,
                Lowest_temp=-173,
                Statements={
                    "A Vénusz a második legközelebbi bolygó a Naphoz.",
                    "A római szerelem és szépség istennőjéről, Vénuszról nevezték el.",
                    "Vénusz 225 nap alatt tesz meg egy kört a Nap körül.",
                    "A Vénusz a legvilágosabb természetes bolygó az égen, a Hold után. Árnyékot vethet és látható lehet szabad szemmel is a fényes égbolton.",
                    "Merkúrhoz hasonlóan a Vénusznak sincsenek holdjai.",
                    "Annak ellenére, hogy Merkúr van a legközelebb a Naphoz, a Vénusznak van a legforróbb felszíne a többi bolygó közül a naprendszerben. A maximum hőmérséklet 474 °C.",
                    "A mérete és a tömege hasonlít a Földhöz, ezért néha a Föld testvérének nevezik.",
                    "Van egy teória, miszerint ha a Vénuszon lenne víz vagy óceán akkor az elpárolgott volna a hő miatt és az erős mágneses mező miatt. A megmaradt hidrogént a bolygóközi térbe söpörte volna  a napszél."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="A Naptól számítva hányadik bolygó a Vénusz?",
                        Answers={ "Első", "Negyedik", "Második", "Tizedik" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Melyik Istenről vagy Istennőről nevezték el a bolygót?",
                        Answers={ "Római istennőről, Vénuszról", "A római Istennőről, Diana-ról", "A görög Istennőről, Afroditéről", "A görög Istennőről, Artemiszről" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Hány nap szükséges a Vénusznak, hogy megtegyen egy kört a Nap körül?",
                        Answers={ "112 nap", "225 nap", "256 nap", "720 nap" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hány holdja van a Vénusznak?",
                        Answers={ "2", "7", "0", "6" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Mi a legmagasabb hőmérséklet a Vénuszon?",
                        Answers={ "1000 °C", "600 °C", "474 °C", "200 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Is it true that Venus is one of the brightest natural objects in the Solar System?",
                        Answers={ "Igaz", "Hamis"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Miért hívhatjuk a Vénusz a Föld testvérének?",
                        Answers={ "Mert a mérete és a tömege hasonlít a Föld méretéhez és tömegéhez", "Nem hívjuk így"},
                        CorrectAnswerIndex=0
                    }
                 }
            },

         /// <summary>
         /// Earth.
         /// </summary>
            new Planet
            {
                Name="Föld",
                Distance_from_sun = 150000000,
                Diameter= 12756,
                Age=4500000000,
                Rotation_period=1440,
                Rotation_speed=1670,
                Orbital_period=365,
                Moons=1,
                Mass=5972*Math.Pow(10,24),
                Highest_temp=56.7,
                Lowest_temp=-89.2,
                Statements={
                    "A Földnek csak egy holdja van.",
                    "A Föld több mint 4.5 billió éves.",
                    "A Földnek egy évbe telik amíg megtesz egy kört a Nap körül.",
                    "A Föld 24 óra alatt tesz meg egy kört a saját tengelye körül.",
                    "A Föld 71%-a víz, a maradék talaj.",
                    "A Földön 300 000 éve élnek emberek. A népesség 8 billió körül van.",
                    "Minden negyedik évben van egy extra napunk, a 366 napos évet szökőévnek hívjuk."
                },
                 Quests={
                    new QuestionAndAnswer{
                        Question="Hány holdja van a Földnek?",
                        Answers={ "3", "7", "1", "4" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hány éves a Föld?",
                        Answers={ "100 ezer éves", "6 millió éves", "4.5 billió éves", "10 billió éves" },
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="Miből áll a föld?",
                        Answers={ "71% víz és 29% talaj", "29% víz és 71% víz", "50% víz és 50% talaj", "85% víz és 15% talaj" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Mennyi időbe telik amíg a Föld megtesz egy teljes kört a saját tengelye körül?",
                        Answers={ "12 óra", "6 óra", "24 óra", "48 óra" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Mennyi időbe telik a Földnek amíg megkerüli a Napot?",
                        Answers={ "fél év", "1 év", "5 év", "6 hónap" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hány napból áll egy év a földön?",
                        Answers={ "365 nap", "366 nap", "256 nap", "460 nap" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hány éve élnek emberek a földön?",
                        Answers={ "100.000", "10.000", "600.000", "300.000" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Mit jelent a szökőév?",
                        Answers={ "Amikor eggyel kevesebb nap van egy évben", "Amikor eggyel több nap van egy évben", "Amikor eggyel több hónap van egy évben", "Amikor 2 hónappal kevesebb van egy évben" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Milyen nagy az emberi lakosság száma a Földön?",
                        Answers={ "4 millió", "100.000", "8 billió", "16.000" },
                        CorrectAnswerIndex=2
                    },

                }
            },

         /// <summary>
         /// Mars.
         /// </summary>
            new Planet
            {
                Name = "Mars",
                Distance_from_sun = 228000000,
                Diameter = 6792,
                Age = 3000000000,
                Rotation_period = 1476,
                Rotation_speed = 868.22,
                Orbital_period = 687,
                Moons = 2,
                Mass = 6417 * Math.Pow(10, 23),
                Highest_temp = 21,
                Lowest_temp = -128,
                Statements ={
                    "A Mars a második legkisebb bolygó a naprendszerben és a negyedik bolygó a Naptól számítva.",
                    "A római háború istenéről, Marsról nevezték el.",
                    "A bolygónak két holdja van, Phobos és Demios.",
                    "Vékony légköre van, a felszínén kráterekkel, völgyekkel, dűnékkel és poláris jégsapkákkal.",
                    "Marsnak van a legnagyobb vulkánja és a legmagasabb ismert hegye a naprendszerben, aminek a neve Olympus Mons.",
                    "A bolygón számos személyzet nélküli űrhajó járt, például a Mariner 4 1965-ben.",
                    "Könnyen látható a Földről szabad szemmel is."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="A Mars hányadik bolygó a naptól számítva?",
                        Answers={ "Negyedik", "Második", "Hatodik", "Kilencedik" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Igaz-e, hogy a Mars a második legkisebb bolygó a naprendszerben?",
                        Answers={ "Igaz", "Hamis"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Minek az istene volt Mars?",
                        Answers={ "Virágok", "Élet", "Háború", "Halál" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Tudjuk, hogy a Marsnak két holdja van. Hogy hívják őket?",
                        Answers={ "Triton és Titan", "Callisto és Europa", "Phobos és Deimos"},
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Mi a neve a Mars legmagasabb ismert hegyének?",
                        Answers={ "Nincs neve", "Olympia Moon", "Olympus Mons", "Olympian Field" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Igaz-e, hogy a Marson több űrhajó is járt SZEMÉLYZETTEL?",
                        Answers={ "Igaz", "Hamis"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Igaz-e, hogy a Mars látható a Földről?",
                        Answers={ "Igaz", "Hamis"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Milyen a Mars légköre?",
                        Answers={ "Vékony", "Erős", "Gyenge", "Magas" },
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Jupiter.
         /// </summary>
            new Planet
            {
                Name = "Jupiter",
                Distance_from_sun = 778000000,
                Diameter = 143000,
                Age = 4600000000,
                Rotation_period = 595,
                Rotation_speed = 45000,
                Orbital_period = 4333,
                Moons = 81,
                Mass = 1898 * Math.Pow(10, 27),
                Highest_temp = 145,
                Lowest_temp = -195,
                Statements ={
                    "A Jupiter az ötödik bolygó a Naptól számítva, és a legnagyobb a naprendszerben.",
                    "A római istenek királyáról, Jupiterről nevezték el.",
                    "A bolygó 11.86 év alatt tesz meg egy kört a Nap körül.",
                    "Jupiter a harmadik legvilágosabb természetes bolygó a Földi égbolton, a Hold és a Vénusz után.",
                    "A bolygó elsősorban hidrogénből és héliumból áll, nincs egy jól meghatározott szilárd felülete.",
                    "Jupiternek 80 ismert holdja van és lehetséges hogy még többel is rendelkezik. A négy legnagyobb holdjának nevei: Io, Europa, Ganymede és Callisto.",
                    "Az emberek az őskor óta megfigyelik a bolygót."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="A Naptól számítva hányadik bolygó a Jupiter?",
                        Answers={ "Ötödik", "Első", "Hatodik", "Hetedik" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Minek az istene volt Jupiter?",
                        Answers={ "Az alvilág istene, Hádész", "A római istenek királya, Jupiter", "A varázslat istennője, Hekaté"},
                        CorrectAnswerIndex =1
                    },
                    new QuestionAndAnswer{
                        Question="Mennyi időbe telik a Jupiternek, amíg megtesz egy teljes kört a Nap körül?",
                        Answers={ "22 év", "600 nap", "12 év", "15 év" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hány holdja van a Jupiternek?",
                        Answers={ "20", "45", "70", "80" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Mióta figyelik meg az emberek a Jupitert?",
                        Answers={ "Tegnap óta", "Tavaly óta", "Az őskor óta", "Múlt hét óta" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Miből áll a bolygó felszíne?",
                        Answers={ "Szilárd felület", "Hidrogén és hélium", "Víz"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Mik a Jupiter négy legnagyobb holdjának nevei?",
                        Answers={ "Io, Callisto, Europa, és Ganymede", "Jupiter, Fo, Callisteo, és Phobos", "Miraculus, Saturn, Ganymede, és Quasimodo"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Igaz-e, hogy a Jupiter a legnagyobb bolygó a naprendszerben?",
                        Answers={ "Igaz", "Hamis"},
                        CorrectAnswerIndex=0
                    }
                }
            },
         
         /// <summary>
         /// Saturn.
         /// </summary>
            new Planet
            {
                Name = "Szaturnusz",
                Distance_from_sun = 1433449370,
                Diameter = 120500,
                Age = 4600000000,
                Rotation_period = 642,
                Rotation_speed = 35500,
                Orbital_period = 10756,
                Moons = 82,
                Mass = 5683 * Math.Pow(10, 26),
                Highest_temp = 57,
                Lowest_temp = -173,
                Statements ={
                    "Szaturnusz a hatodik bolygó a Naptól számítva és a második legnagyobb a naprendszerben.",
                    "Szaturnusznak 10 759 nap szükséges ahhoz, hogy meg tegyen egy kört a Nap körül.",
                    "A külső légköre lágy és nem kontrasztos, ugyanakkor a hosszú életű jellemzők megjelenhetnek.",
                    "A szélsebesség a bolygón elérheti az 1800 km/ órát.",
                    "A Szaturnusz egyik figyelemre méltó jellemzője a kitűnő gyűrűs rendszere, amely főleg jégdarabkákból áll de tartalmaz kisebb mennyiségű sziklás törmeléket és port.",
                    "Szaturnusznak 83 holdja van, közülük 53-nak adtak nevet és a legnagyobbat Titánnak nevezték el.",
                    "A bolygó a római gazdagság és mezőgazdaság istenéről, valamint Jupiter apjáról, Szaturnuszról lett elnevezve."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="A Naptól számítva hányadik bolygó a Szaturnusz?",
                        Answers={ "Első", "Ötödik", "Tizedik", "Hatodik" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question=" Igaz-e, hogy a Szaturnusznak 10759 napra van szüksége, hogy megtegyen egy kört a Nap körül?",
                        Answers={ "Igaz", "Hamis"},
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Hány holdja van a Szaturnusznak?",
                        Answers={ "53", "36", "83", "92" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Milyen gyorsan fúj a szél a bolygón?",
                        Answers={ "100km/h", "1800km/h", "320km/h", "960km/h"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Igaz-e, hogy a Szaturnusz a harmadik legnagyobb bolygó a naprendszerben?",
                        Answers={ "Igaz", "Hamis"},
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Kiről nevezték el a bolygót?",
                        Answers={ "A görög Titánok istenéről, Kronoszról", "A római vagyon és mezőgazdaság istenéről, Szaturnuszról", "A görög hó istennőjéről, Khionéről", "A skandináv villámok istenéről, Thorról" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Mi az ami a Szaturnusznak van és más bolygóknak nincs?",
                        Answers={ "Gyűrűs rendszer", "Különleges márkájú cukorka", "Nagy sebességű vonat"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Mi a Szaturnusz legnagyobb holdjának neve?",
                        Answers={ "Szellem", "Titán", "Zeusz", "Óriás" },
                        CorrectAnswerIndex=1
                    }
                }
            },
         
         /// <summary>
         /// Uranus.
         /// </summary>
            new Planet
            {
                Name = "Uránusz",
                Distance_from_sun = 2870972200,
                Diameter = 51100,
                Age = 4600000000,
                Rotation_period = 1020,
                Rotation_speed = 9320,
                Orbital_period = 30687,
                Moons = 27,
                Mass = 8682 * Math.Pow(10, 25),
                Highest_temp = 4982,
                Lowest_temp = -224,
                Statements ={
                    "Uránusz a hetedik bolygó a naprendszerben.",
                    "A görög ég istenéről, Uránuszról nevezték el.",
                    "A bolygó 84 évente kerüli meg a Napot.",
                    "Jupiterhez hasonlóan, hiányzik a jól meghatározott szilárd felszín.",
                    "A bolygó légköre hasonlít a Jupiterhez és a Szaturnuszhoz, elsősorban hidrogénből és héliumból áll, de több jeget tartalmaz és vizet, vagy például ammóniát.",
                    "Uránusznak van a leghidegebb planetáris légköre a naprendszerben, a minimum hőmérséklete -224 °C.",
                    "A szélsebesség a bolygón elérheti a 900 km / órát.",
                    "A bolygónak 27 ismert holdja van.",
                    "Csak egy űrhajó járt a bolygón 1986-ban, a Voyeur 2."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="A Naptól számítva hányadik bolygó az Uránusz?",
                        Answers={ "Harmadik", "Hetedik", "Negyedik", "Tizenegyedik" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hány évbe telik az Uránusznak, hogy megtegyen egy kört a Nap körül?",
                        Answers={ "84 év", "105 év", "140 év", "56 év" },
                        CorrectAnswerIndex =0
                    },
                    new QuestionAndAnswer{
                        Question="Igaz-e, hogy az Uránusz felszínén nem található szilárd anyag?",
                        Answers={ "Igaz", "Hamis" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Melyik bolygókkal lehetne összehasonlítani az Uránuszt?",
                        Answers={ "Neptunusszal és Merkúrral", "Marssal és Vénusszal", "Földdel és Holddal", "Jupiterrel és Szaturnusszal" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Igaz-e, hogy az Uránusznak van a leghidegebb légköre a naprendszerben?",
                        Answers={ "Igaz", "Hamis" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Kiről nevezték el az Uránuszt?",
                        Answers={ "A görög ég istenéről, Uránuszról", "Az ír sors istennőjéről, Morriganról", "Senkiről nincs elnevezve" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Hány űrhajó látogatta meg az Uránuszt?",
                        Answers={ "2", "5", "1", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Milyen sebességgel fúj a szél az Uránuszon?",
                        Answers={ "450 km/h", "900 km/h", "500 km/h", "700 km/h" },
                        CorrectAnswerIndex=1
                    }
                }
            },

         /// <summary>
         /// Neptune.
         /// </summary>
            new Planet
            {
                Name = "Neptunusz",
                Distance_from_sun = 4503443661,
                Diameter = 49500,
                Age = 4600000000,
                Rotation_period = 960,
                Rotation_speed = 9650,
                Orbital_period = 60190,
                Moons = 14,
                Mass = 1024 * Math.Pow(10, 26),
                Highest_temp = 7000,
                Lowest_temp = -218,
                Statements ={
                    "Neptunusz a nyolcadik bolygó a naprendszerben és a naptól lévő legtávolabbi.",
                    "Nincs jól meghatározható szilárd felszíne, főleg gázokból és folyadékokból áll.",
                    "A bolygó 165 évente kerüli meg a Napot.",
                    "A római tengerek istenéről, Neptunuszról nevezték el.",
                    "A Neptunusznak 14 ismert holdja van, a legnagyobbat Tritonnak hívják.",
                    "A bolygó légköre főként hidrogénből és héliumból áll, de nyomok utalnak a szén hidrogén és nitrogén jelenlétére, valamint több jeget tartalmaz mint a Jupiter vagy a Szaturnusz.",
                    "Az Uránuszhoz hasonlóan csak egy űrhajó látogatta meg a bolygót 1989-ben, a Voyeur 2.",
                    "A Neptunusz külső légköre az egyik leghidegebb hely a naprendszerben, a hőmérséklet -218 °C körül van de a bolygó közepe sokkal forróbb, 5100 °C."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Igaz-e, hogy a Neptunusz a Naptól legtávolabbi ismert bolygó?",
                        Answers={ "Igaz", "Hamis"},
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Mennyi év szükséges ahhoz, hogy a Neptunusz megtegyen egy kört a Nap körül?",
                        Answers={ "200 év", "172 év", "165 év", "147 év" },
                        CorrectAnswerIndex =2
                    },
                    new QuestionAndAnswer{
                        Question="Kiről nevezték el a Neptunuszt?",
                        Answers={ "A görög tengerek istenéről, Poszeidonról", "A római tengerek istenéről, Neptunról", "Az egyiptomi tengerek istenéről, Nu-ról)" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Hány holdja van a Neptunusznak?",
                        Answers={ "10", "16", "14", "17" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hogy hívják a Neptunusz legnagyobb holdját?",
                        Answers={ "Triton", "Oceanus", "Styx", "Néreusz" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Igaz-e, hogy sok űrhajó látogatta a bolygót?",
                        Answers={ "Igaz", "Hamis" },
                        CorrectAnswerIndex=1
                    },
                    new QuestionAndAnswer{
                        Question="Mennyi a  Neptunusz külső légkörének hőmérséklete?",
                        Answers={ "-162 °C", "-346 °C", "-218 °C", "-252 °C" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Mennyi a hőmérséklet a bolygó közepében?",
                        Answers={ "3700 °C", "4600 °C", "6600 °C", "5100 °C" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Mi volt a neve annak az űrhajónak, amelyik járt a Neptunuszon?",
                        Answers={ "Voyeur 2", "MESSENGER", "Apollo 7", "Nem volt megnevezve" },
                        CorrectAnswerIndex=0
                    },
                }
            },

         /// <summary>
         /// Pluto.
         /// </summary>
            new Planet
            {
                Name = "Plútó",
                Distance_from_sun = 5906376272,
                Diameter = 2274,
                Age = 4600000000,
                Rotation_period = 9180,
                Rotation_speed = 47.18,
                Orbital_period = 90520,
                Moons = 5,
                Mass = 1309 * Math.Pow(10, 22),
                Highest_temp = -223,
                Lowest_temp = -233,
                Statements ={
                    "Plútó egy törpe bolygó a Kuiper övön.",
                    "A római alvilág istenéről, Plútóról nevezték el.",
                    "Miután a bolygót felfedezték 1930-ban, a kilencedik bolygó lett a Naptól. Később megkérdőjelezhetővé vált a távolsága és a mérete miatt, ezért 2006-ban újra törpebolygóvá nyilvánították.",
                    "Öt ismert holdja van, Charon, Styx, Nix, Kerberos és Hydra.",
                    "2015-ben egy New Horizons nevű űrhajó leszállást hajtott végre a Plútón és ez volt az egyetlen látogatás a bolygón.",
                    "Plútó 248 évente kerüli meg a Napot.",
                    "A felszíne több mint 98%-a nitrogén jégből áll, de nyomokban metánt és szén-monoxidot is tartalmaz."
                },
                Quests ={
                    new QuestionAndAnswer{
                        Question="Kiről nevezték el a Plútót?",
                        Answers={ "A skandináv halál istennőjééről, Hélről", "A görög alvilág istenéről, Hádészről", "A görög halál istenéről, Thanatoszról", "A római alvilág istenéről, Plútóról" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="A Plútó egy normális bolygó?",
                        Answers={ "Igen", "Nem, nem létezik", "Ismeretlen", "Nem, törpebolygó" },
                        CorrectAnswerIndex =3
                    },
                    new QuestionAndAnswer{
                        Question="Mikor fedezték fel az emberek a Plútót?",
                        Answers={ "1890", "1910", "1930", "1950" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hány évbe telik az Plútó megtegyen egy kört a saját tengelye körül?",
                        Answers={ "248 nap", "248 hónap", "248 év" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Hány holdja van a Plútónak, hogy megtegyen egy kört a Nap körül?",
                        Answers={ "15", "22", "5", "10" },
                        CorrectAnswerIndex=2
                    },
                    new QuestionAndAnswer{
                        Question="Mikor látogatták meg a Plútót űrhajóval?",
                        Answers={ "2006", "2012", "2009", "2015" },
                        CorrectAnswerIndex=3
                    },
                    new QuestionAndAnswer{
                        Question="Mi volt annak az űrhajónak a neve amelyik landolt a Plútón?",
                        Answers={ "New Horizons", "Voyeur 5", "Titanic 22", "Crazy Horse" },
                        CorrectAnswerIndex=0
                    },
                    new QuestionAndAnswer{
                        Question="Miből áll a Plútó felszíne?",
                        Answers={ "Kosz", "Cukor", "Nitrogén jég", "Só", "Fű" },
                        CorrectAnswerIndex=2
                    }
                }
            },
        };

#endregion

string sqlStatements = "";
int id = 0;

foreach (Planet planet in planets_en)
{
    sqlStatements += $"INSERT INTO Planets (id, lang, info_as_json) VALUES ({id++}, 'en', '{JsonSerializer.Serialize(planet)}');\n";
}

File.WriteAllText(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Planets\en.sql", sqlStatements);


sqlStatements = "";
id = 0;

foreach (Planet planet in planets_da)
{
    sqlStatements += $"INSERT INTO Planets (id, lang, info_as_json) VALUES ({id++}, 'da', '{JsonSerializer.Serialize(planet)}');\n";
}

File.WriteAllText(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Planets\da.sql", sqlStatements);


sqlStatements = "";
id = 0;


foreach (Planet planet in planets_hu)
{
    sqlStatements += $"INSERT INTO Planets (id, lang, info_as_json) VALUES ({id++}, 'hu', '{JsonSerializer.Serialize(planet)}');\n";
}

File.WriteAllText(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Planets\hu.sql", sqlStatements);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{JsonSerializer.Serialize(planets_en)}");
File.WriteAllText(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Planets\en.json", JsonSerializer.Serialize(planets_en, new JsonSerializerOptions() { WriteIndented = true }));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{JsonSerializer.Serialize(planets_da)}");
File.WriteAllText(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Planets\da.json", JsonSerializer.Serialize(planets_da, new JsonSerializerOptions() { WriteIndented = true }));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{JsonSerializer.Serialize(planets_hu)}");
File.WriteAllText(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Planets\hu.json", JsonSerializer.Serialize(planets_hu, new JsonSerializerOptions() { WriteIndented = true }));
Console.ReadKey();


