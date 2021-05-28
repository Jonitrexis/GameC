﻿using System;
using System.Collections.Generic;
using Game.Engine.Skills.SkillFactories;
using Game.Engine.Monsters.MonsterFactories;
using Game.Engine.Items;
using Game.Engine.Items.ItemFactories;
using Game.Engine.Items.BasicArmor;
using Game.Engine.Interactions.InteractionFactories;
using Game.Engine.Items.JDBBQuest;
using Game.Engine.Interactions.JDBBQuest;


namespace Game.Engine
{
    // contains information about skills, items and monsters that will be available in the game
    public static partial class Index
    {
        private static List<SkillFactory> skillFactories = new List<SkillFactory>()
        {
            new BasicSpellFactory(),
        };

        public static List<Item> Items = new List<Item>()
        {
            new BasicStaff(),
            new BasicSpear(),
            new BasicAxe(),
            new BasicSword(),
            new SteelArmor(),
            new AntiMagicArmor(),
            new BerserkerArmor(),
            new GrowingStoneArmor(),
            // quest items (if applicable) start below
            new GymirAxe(),
            new EnchantedStaff(),
            new EnchantedStaff2(),
            new EnchantedSword(),
            new EnchantedSword2(),
        };

        private static List<ItemFactory> itemFactories = new List<ItemFactory>()
        {
            new BasicArmorFactory(),
        };

        private static List<MonsterFactory> monsterFactories = new List<MonsterFactory>()
        {
            // x4
            new Monsters.MonsterFactories.RatFactory(),
            new Monsters.MonsterFactories.RatFactory(),
            new Monsters.MonsterFactories.RatFactory(),
            new Monsters.MonsterFactories.RatFactory(),
            new Monsters.MonsterFactories.BatFactory(),
            new Monsters.MonsterFactories.BatFactory(),
            new Monsters.MonsterFactories.BatFactory(),
            new Monsters.MonsterFactories.BatFactory(),
            new Monsters.MonsterFactories.SpiderFactory(),
            new Monsters.MonsterFactories.SpiderFactory(),
            new Monsters.MonsterFactories.SpiderFactory(),
            new Monsters.MonsterFactories.SpiderFactory(),
        };

        public readonly static InteractionFactory MainQuestFactory = new GymirHymirFactory();

        private static List<InteractionFactory> interactionFactories = new List<InteractionFactory>()
        {
            new SkillForgetFactory(),
            new HealInteractionFactory(),
            new JDBBQuestFactory(),
        };

    }
}
