﻿using Amine24hSandwich.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amine24hSandwich.Core.Repository
{
    class SandwichRepository
    {
        public List<Sandwich> GetAllSandwiches()
        {
            IEnumerable<Sandwich> Sandwiches =
                from SandwichGroup in SandwichGroups
                from Sandwich in SandwichGroup.Sandwiches

                select Sandwich;
            return Sandwiches.ToList<Sandwich>();
        }

        public Sandwich GetSandwichById(int SandwichId)
        {
            IEnumerable<Sandwich> Sandwiches =
                from SandwichGroup in SandwichGroups
                from Sandwich in SandwichGroup.Sandwiches
                where Sandwich.SandwichId == SandwichId
                select Sandwich;

            return Sandwiches.FirstOrDefault();
        }

        public List<SandwichGroup> GetGroupedSandwiches()
        {
            return SandwichGroups;
        }

        public List<Sandwich> GetSandwichesForGroup(int SandwichGroupId)
        {
            var group = SandwichGroups.Where(h => h.SandwichGroupId == SandwichGroupId).FirstOrDefault();

            if (group != null)
            {
                return group.Sandwiches;
            }
            return null;
        }

        public List<Sandwich> GetFavoriteSandwiches()
        {
            IEnumerable<Sandwich> Sandwiches =
                from SandwichGroup in SandwichGroups
                from Sandwich in SandwichGroup.Sandwiches
                where Sandwich.IsFavorite
                select Sandwich;

            return Sandwiches.ToList<Sandwich>();
        }


        private static List<SandwichGroup> SandwichGroups = new List<SandwichGroup>()
        {
            new SandwichGroup()
            {
                SandwichGroupId = 1, Title = "Meat lovers", ImagePath = "", Sandwiches = new List<Sandwich>()
                {
                    new Sandwich()
                    {
                        SandwichId = 1,
                        Name = "Regular Hot Dog",
                        ShortDescription = "The best there is on this planet",
                        Description = "Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                        ImagePath = "Sandwich1",
                        Available = true,
                        PrepTime= 10,
                        Ingredients = new List<string>(){"Regular bun", "Sausage", "Ketchup"},
                        Price = 8,
                        IsFavorite = true
                    },
                    new Sandwich()
                    {
                        SandwichId = 2,
                        Name = "Haute Dog",
                        ShortDescription = "The classy one",
                        Description = "Bacon ipsum dolor amet turducken ham t-bone shankle boudin kevin. Hamburger salami pork shoulder pork chop. Flank doner turducken venison rump swine sausage salami sirloin kielbasa pork belly tail cow. Pork chop bacon ground round cupim tongue, venison frankfurter bresaola tri-tip andouille sirloin turducken spare ribs biltong. Drumstick ham hock pork tail, capicola shank frankfurter beef ribs jowl meatball turkey hamburger. Tenderloin swine ham pork belly beef ribeye. ",
                        ImagePath = "Sandwich2",
                        Available = true,
                        PrepTime= 15,
                        Ingredients = new List<string>(){"Baked bun", "Gourmet sausage", "Fancy mustard from Germany"},
                        Price = 10,
                        IsFavorite = false
                    },
                    new Sandwich()
                    {
                        SandwichId = 3,
                        Name = "Extra Long",
                        ShortDescription = "For when a regular one isn't enough",
                        Description = "Capicola short loin shoulder strip steak ribeye pork loin flank cupim doner pastrami. Doner short loin frankfurter ball tip pork belly, shank jowl brisket. Kielbasa prosciutto chuck, turducken brisket short ribs tail pork shankle ball tip. Pancetta jerky andouille chuck salami pastrami bacon pig tri-tip meatball tail bresaola shank short ribs strip steak. Ham hock frankfurter ball tip, biltong cow pastrami swine tenderloin ground round pork loin t-bone. ",
                        ImagePath = "Sandwich3",
                        Available = true,
                        PrepTime= 10,
                        Ingredients = new List<string>(){"Extra long bun", "Extra long sausage", "More ketchup"},
                        Price = 8,
                        IsFavorite = true
                    }
                }
            },
            new SandwichGroup()
            {
                SandwichGroupId = 2, Title = "Veggie lovers", ImagePath = "", Sandwiches = new List<Sandwich>()
                {
                    new Sandwich()
                    {
                        SandwichId = 4,
                        Name = "Veggie Hot Dog",
                        ShortDescription = "American for non-meat-lovers",
                        Description = "Veggies es bonus vobis, proinde vos postulo essum magis kohlrabi welsh onion daikon amaranth tatsoi tomatillo melon azuki bean garlic.\n\nGumbo beet greens corn soko endive gumbo gourd. Parsley shallot courgette tatsoi pea sprouts fava bean collard greens dandelion okra wakame tomato. Dandelion cucumber earthnut pea peanut soko zucchini.",
                        ImagePath = "Sandwich4",
                        Available = true,
                        PrepTime= 10,
                        Ingredients = new List<string>(){"Bun", "Vegetarian sausage", "Ketchup"},
                        Price = 8,
                        IsFavorite = false
                    },
                    new Sandwich()
                    {
                        SandwichId = 5,
                        Name = "Haute Dog Veggie",
                        ShortDescription = "Classy and veggie",
                        Description = "Turnip greens yarrow ricebean rutabaga endive cauliflower sea lettuce kohlrabi amaranth water spinach avocado daikon napa cabbage asparagus winter purslane kale. Celery potato scallion desert raisin horseradish spinach carrot soko. Lotus root water spinach fennel kombu maize bamboo shoot green bean swiss chard seakale pumpkin onion chickpea gram corn pea. Brussels sprout coriander water chestnut gourd swiss chard wakame kohlrabi beetroot carrot watercress. Corn amaranth salsify bunya nuts nori azuki bean chickweed potato bell pepper artichoke.",
                        ImagePath = "Sandwich5",
                        Available = true,
                        PrepTime= 15,
                        Ingredients = new List<string>(){"Baked bun", "Gourmet vegetarian sausage", "Fancy mustard"},
                        Price = 10,
                        IsFavorite = true
                    },
                    new Sandwich()
                    {
                        SandwichId = 6,
                        Name = "Extra Long Veggie",
                        ShortDescription = "For when a regular one isn't enough",
                        Description = "Beetroot water spinach okra water chestnut ricebean pea catsear courgette summer purslane. Water spinach arugula pea tatsoi aubergine spring onion bush tomato kale radicchio turnip chicory salsify pea sprouts fava bean. Dandelion zucchini burdock yarrow chickpea dandelion sorrel courgette turnip greens tigernut soybean radish artichoke wattle seed endive groundnut broccoli arugula.",
                        ImagePath = "Sandwich6",
                        Available = true,
                        PrepTime= 10,
                        Ingredients = new List<string>(){"Extra long bun", "Extra long vegetarian sausage", "More ketchup"},
                        Price = 8,
                        IsFavorite = false
                    }
                }
            }
        };
    }
}
