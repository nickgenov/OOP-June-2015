using System;

namespace TheSlum.GameEngine
{
    public class SlumEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            string characterClass = inputParams[1];
            string characterId = inputParams[2];
            int xPosition = int.Parse(inputParams[3]);
            int yPosition = int.Parse(inputParams[4]);
            Team team = (Team)Enum.Parse(typeof(Team), inputParams[5], true);

            if (characterClass == "warrior")
            {
                characterList.Add(new Warrior(characterId, xPosition, yPosition, team));
            }
            else if (characterClass == "mage")
            {
                characterList.Add(new Mage(characterId, xPosition, yPosition, team));
            }
            else if (characterClass == "healer")
            {
                characterList.Add(new Healer(characterId, xPosition, yPosition, team));
            }
        }

        protected override void AddItem(string[] inputParams)
        {
            string characterId = inputParams[1];
            string itemClass = inputParams[2];
            string itemId = inputParams[3];

            if (itemClass == "axe")
            {
                var item = new Axe(itemId);
                GetCharacterById(characterId).AddToInventory(item);
            }
            else if (itemClass == "shield")
            {
                var item = new Shield(itemId);
                GetCharacterById(characterId).AddToInventory(item);
            }
            else if (itemClass == "injection")
            {
                var item = new Injection(itemId);
                GetCharacterById(characterId).AddToInventory(item);
            }
            else if (itemClass == "pill")
            {
                var item = new Pill(itemId);
                GetCharacterById(characterId).AddToInventory(item);
            }
        }
    }
}