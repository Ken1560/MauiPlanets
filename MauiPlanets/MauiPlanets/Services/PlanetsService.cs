using System.Drawing;
using MauiPlanets.Models;


namespace Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the " +
                "smallest in the Solar System. In English, it is named after the " +
                "ancient Roman god Mercurius (Mercury), god of commerce and " +
                "communication, and the messenger of the gods.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#353535"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/4/4a/Mercury_in_true_color.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Unmasking_the_Secrets_of_Mercury.jpg/600px-Unmasking_the_Secrets_of_Mercury.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/EW1027346412Gnomap.png/220px-EW1027346412Gnomap.png"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a " +
                "terrestrial planet and is the closest in mass and size to its " +
                "orbital neighbour Earth. Venus has by far the densest atmosphere " +
                "of the terrestrial planets, composed mostly of carbon dioxide " +
                "with a thick, global sulfuric acid cloud cover.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#a6393b"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/Venus_2_Approach_Image.jpg/290px-Venus_2_Approach_Image.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Venus_-_December_23_2016.png/220px-Venus_-_December_23_2016.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/PIA00084_Eistla_region_pancake_volcanoes.jpg/220px-PIA00084_Eistla_region_pancake_volcanoes.jpg",
                    
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and " +
                "the only astronomical object known to harbor life. This is " +
                "enabled by Earth being an ocean world, the only one in the " +
                "Solar System sustaining liquid surface water. ",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#0e3d68"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/290px-The_Earth_seen_from_Apollo_17.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Global_View_of_the_Arctic_and_Antarctic.jpg/220px-Global_View_of_the_Arctic_and_Antarctic.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Ocean_world_Earth.jpg/220px-Ocean_world_Earth.jpg"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#a23036"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png/290px-Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Mars_Valles_Marineris.jpeg/220px-Mars_Valles_Marineris.jpeg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Mars_Before_and_During_Global_Dust_Storm.jpg/220px-Mars_Before_and_During_Global_Dust_Storm.jpg"
                }
            },


            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the " +
                "Solar System. It is a gas giant with a mass more than 2.5 times that of all the " +
                "other planets in the Solar System combined and slightly less than one-thousandth " +
                "the mass of the Sun.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#a67c52"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#f0c75e"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Jupiter_and_its_shrunken_Great_Red_Spot.jpg/290px-Jupiter_and_its_shrunken_Great_Red_Spot.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Jupiter_Earth_Moon_Comparison.png/220px-Jupiter_Earth_Moon_Comparison.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/PIA21775.jpg/220px-PIA21775.jpg"
                }
            },


            new()
            {
                Name = "Saturn",
                Subtitle = "The Ringed Planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second " +
                "largest in the Solar System, after Jupiter. It is a gas giant, with an " +
                "average radius of about nine times that of Earth.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#c5a880"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#e4d3b6"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Saturn_during_Equinox.jpg/300px-Saturn_during_Equinox.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Saturn_Storm.jpg/220px-Saturn_Storm.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Saturn_from_Cassini_Orbiter_%282004-10-06%29.jpg/220px-Saturn_from_Cassini_Orbiter_%282004-10-06%29.jpg",
                   
                }
            },


            new()
            {
                Name = "Uranus",
                Subtitle = "The ice giant",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous " +
                "cyan-coloured ice giant. Most of the planet is made of water, ammonia, " +
                "and methane in a supercritical phase of matter, which astronomy calls \"ice\" or " +
                "volatiles. The planet's atmosphere has a complex layered cloud structure and " +
                "has the lowest minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar " +
                "System's planets.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#5eb8cc"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#a7e8f1"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Uranus_Voyager2_color_calibrated.png/290px-Uranus_Voyager2_color_calibrated.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Uranus%2C_Earth_size_comparison_2.jpg/220px-Uranus%2C_Earth_size_comparison_2.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4d/Adding_to_Uranus%27s_legacy.tif/lossy-page1-220px-Adding_to_Uranus%27s_legacy.tif.jpg"
                }
            },


            new()
            {
                Name = "Neptune",
                Subtitle = "The blue giant",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest known planet from the Sun. " +
                "It is the fourth-largest planet in the Solar System by diameter, " +
                "the third-most-massive planet, and the densest giant planet. It is 17 times the " +
                "mass of Earth. Compared to its fellow ice giant Uranus, Neptune is slightly more " +
                "massive, but denser and smaller.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#2a4b8d"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#4d88d3"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Neptune_Voyager2_color_calibrated.png/290px-Neptune_Voyager2_color_calibrated.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6a/Neptune-Methane.jpg/218px-Neptune-Methane.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Neptune_storms.jpg/220px-Neptune_storms.jpg"
                }
            },

            new()
            {
                Name = "Pluuto",
                Subtitle = "The dwarf planet",
                HeroImage = "pluto.png",
                Description = "Pluto (minor-planet designation: 134340 Pluto) is a dwarf " +
                "planet in the Kuiper belt, a ring of bodies beyond the orbit of Neptune. " +
                "It is the ninth-largest and tenth-most-massive known object to directly orbit " +
                "the Sun. It is the largest known trans-Neptunian object by volume, by a small " +
                "margin, but is less massive than Eris.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#5c6d7d"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#d2b490"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Pluto_in_True_Color_-_High-Res.jpg/290px-Pluto_in_True_Color_-_High-Res.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Pluto-01_Stern_03_Pluto_Color_TXT.jpg/240px-Pluto-01_Stern_03_Pluto_Color_TXT.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/MVIC_sunset_scan_of_Pluto.jpg/280px-MVIC_sunset_scan_of_Pluto.jpg"
                }
            },

            new()
            {
                Name = "Ceres",
                Subtitle = "The asteroid",
                HeroImage = "ceres.png",
                Description = "Ceres (minor-planet designation: 1 Ceres) is a dwarf planet " +
                "in the middle main asteroid belt between the orbits of Mars and Jupiter. " +
                "It was the first known asteroid, discovered on 1 January 1801 by Giuseppe " +
                "Piazzi at Palermo Astronomical Observatory in Sicily, and announced as a new " +
                "planet.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#6e6e6e"), 
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#b5a27f"),  
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg/290px-Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/PIA22660-Ceres-DwarfPlanet-Inside-ArtistConcept-20180814.jpg/220px-PIA22660-Ceres-DwarfPlanet-Inside-ArtistConcept-20180814.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/PIA20353_Ceres_Neutron_Counts_Reflect_Hydrogen_Abundance_%28cropped%29.jpg/220px-PIA20353_Ceres_Neutron_Counts_Reflect_Hydrogen_Abundance_%28cropped%29.jpg"
                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "A dwarf planet",
                HeroImage = "haumea.png",
                Description = "Haumea (minor-planet designation: 136108 Haumea) is a dwarf " +
                "planet located beyond Neptune's orbit. It was discovered in 2004 by a " +
                "team headed by Mike Brown of Caltech at the Palomar Observatory, and formally " +
                "announced in 2005 by a team headed by José Luis Ortiz Moreno at the Sierra Nevada " +
                "Observatory in Spain, who had discovered it that year in precovery images taken " +
                "by the team in 2003.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#9ba3a7"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#d8d9da"),
                Images = new()
                {
                    "https://www.bobthealien.co.uk/bobpics/haumeaaigenerated.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/07/haumea-480x320-1-jpg.webp?w=320",
                    "https://www.solarsystemscope.com/spacepedia/images/handbook/renders/haumea.png"
                }
            },

            new()
            {
                Name = "Makemake",
                Subtitle = "MK 2",
                HeroImage = "makemake.png",
                Description = "Makemake[e] (minor-planet designation: 136472 Makemake) " +
                "is a dwarf planet and the largest of what is known as the classical population " +
                "of Kuiper belt objects,[b] with a diameter approximately that of Saturn's moon " +
                "Iapetus, or 60% that of Pluto. It has one known satellite. " +
                "Its extremely low average temperature, about 40 K (−230 °C), means its surface " +
                "is covered with methane, ethane, and possibly nitrogen ices.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#8b5a2b"),
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#d4a373"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQl5ejDW_OF_-j71-Mu4-PtcsVxAm3t8mrmlq4oozk6Pw&s",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Makemake_and_its_moon.jpg/290px-Makemake_and_its_moon.jpg",
                    "https://www.universetoday.com/wp-content/uploads/2008/07/Makemake.jpg",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfcGDiVCEn0zF-rs5G6PN8GuGn3HVnrbJscQ&s"
                }
            },


            new()
            {
                Name = "Eris",
                Subtitle = "The Pluto twin",
                HeroImage = "eris.png",
                Description = "Eris is one of the most massive dwarf planets in the Solar System, " +
                "slightly larger than Pluto. Discovered in 2005, it played a key role in " +
                "redefining what constitutes a planet, ultimately leading to Pluto's " +
                "reclassification as a dwarf planet. Eris orbits the Sun at a much greater " +
                "distance than Pluto, residing in a region of icy bodies known as the scattered " +
                "disk. It is covered with a reflective surface of frozen methane, making it one " +
                "of the brightest objects in the Solar System.",
                AccentColorStart = Microsoft.Maui.Graphics.Color.FromArgb("#8a939a"), 
                AccentColorEnd = Microsoft.Maui.Graphics.Color.FromArgb("#c6cdd1"),  
                Images = new()
                {
                    "https://www.earth.com/assets/_next/image/?url=https%3A%2F%2Fcff2.earth.com%2Fuploads%2F2024%2F02%2F20135637%2FEris_icy-dwarf-planet_kuiper-belt_1m-1400x850.jpg&w=1080&q=75",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Hubble_Dysnomia_orbit_overlay.jpg/290px-Hubble_Dysnomia_orbit_overlay.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/03/Eris%2C_Earth_%26_Moon_size_comparison.png/250px-Eris%2C_Earth_%26_Moon_size_comparison.png"
                }
            },
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
