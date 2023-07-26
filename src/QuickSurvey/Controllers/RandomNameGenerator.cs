﻿using QuickSurvey.Data;

namespace QuickSurvey.Controllers;

internal static class RandomNameGenerator
{
    private static readonly Random NameRandom = new(Guid.NewGuid().GetHashCode());
    private static readonly string[] Names = {
        "Agahnim",
        "Alfonzo",
        "Anjean",
        "Anju",
        "Aryll",
        "Ashei",
        "Auru",
        "Beedle",
        "Biggoron",
        "Birdo",
        "Blooper",
        "Bob-omb",
        "Boo",
        "Bowser",
        "Bowser Jr.",
        "Bowsette",
        "Bullet Bill",
        "Buzzy Beetle",
        "Chain Chomp",
        "Chargin Chuck",
        "Cheep Cheep",
        "Cranky Kong",
        "Daisy",
        "Dark Link",
        "Darunia",
        "Deku Tree",
        "Diddy Kong",
        "Donkey Kong",
        "Dry Bones",
        "Epona",
        "Ezlo",
        "Fawful",
        "Fi",
        "Fuzzy",
        "Ganon",
        "Ghirahim",
        "Gomba",
        "Great Fairy",
        "Gulley",
        "Guru",
        "Hammer Bro",
        "Impa",
        "Irene",
        "Kafei",
        "Kamek",
        "Kapson",
        "Kass",
        "King Boo",
        "King Bulbin",
        "King Daltus",
        "King Dodongo",
        "Koopa Troopa",
        "Lakitu",
        "Link",
        "Luigi",
        "Lumas",
        "Magikoopa",
        "Majora",
        "Makar",
        "Malon",
        "Mario",
        "Master Kohga",
        "Mechakoopa",
        "Medli",
        "Midna",
        "Mipha",
        "Monty Mole",
        "Nabbit",
        "Nabooru",
        "Navi",
        "Oren",
        "Osfala",
        "Pauline",
        "Peach",
        "Petey Piranha",
        "Piranha Plant",
        "Podoboo",
        "Pokey",
        "Poochy",
        "Rauru",
        "Ravio",
        "Rosalina",
        "Rosso",
        "Ruto",
        "Salesman",
        "Saria",
        "Seres",
        "Shy Guy",
        "Skull Kid",
        "Spike",
        "Spike Top",
        "Spiny",
        "Tatl",
        "Thwomp",
        "Tingle",
        "Toad",
        "Toadette",
        "Toadsworth",
        "Twinrova",
        "Vaati",
        "Waluigi",
        "Wario",
        "Whomp",
        "Wiggler",
        "Yoshi",
        "Yuga",
        "Zant",
        "Zelda"
    };

    internal static string NextRandomName()
    {
        var number = UserNumberCounter.NextNumber();
        return string.Concat(Names[NameRandom.Next(0, Names.Length - 1)], " ", number);
    }
}