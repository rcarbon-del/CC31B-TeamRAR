﻿using Engine.Models;

// 26 March 2024 NOT DONE YET - Lucci
namespace Engine.ViewModels
{
    internal class InventoryItem : GameItem
    {
        private int quantity;
        public int Quantity;
        {
            get { return quantity; }
            set
            {
                quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        //public InventoryItem(GameItem gameItem, int quantity)
            //:base(gameItem.ItemTypeID, gameItem.Name, gameItem.Price, gameItem.Description, gameItem.ImageName)
        //{
           // Quantity = quantity;
       // }//

        public void useItem()
        {
            Console.WriteLine($"You have used {Name}.");
        }

        public void dropItem()
        {
           Console.WriteLine($"You have dropped {Name}.");
        }

        public override string ToString()
        {
            return $"Name:{Name} Quantity: {Quantity}";
        }

    }
}