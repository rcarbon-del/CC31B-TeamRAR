﻿using System;
using Engine.Models;
namespace Engine.Actions
{
    public class AttackWithWeapon : BaseAction, IAction
    {
        private readonly GameItem _weapon;
        private readonly int _maximumDamage;
        private readonly int _minimumDamage;
        private readonly GameItem _itemInUse;
        
        public AttackWithWeapon(GameItem itemInUse, int minimumDamage, int maximumDamage)
            : base(itemInUse)
        {
            if (itemInUse.Category != GameItem.ItemCategory.Weapon)
            {
                throw new ArgumentException($"{itemInUse.Name} is not a weapon");
            }
            if (_minimumDamage < 0)
            {
                throw new ArgumentException("minimumDamage must be 0 or larger");
            }
            if (_maximumDamage < _minimumDamage)
            {
                throw new ArgumentException("maximumDamage must be >= minimumDamage");
            }
            _itemInUse = itemInUse;
            _minimumDamage = minimumDamage;
            _maximumDamage = maximumDamage;
        }
        public void Execute(LivingEntity actor, LivingEntity target)
        {
            int damage = RandomNumberGenerator.NumberBetween(_minimumDamage, _maximumDamage);
            
            string actorName = (actor is Player) ? "You" : $"The {actor.Name.ToLower()}";
            string targetName = (target is Player) ? "yourself" : $"the {target.Name.ToLower()}";

            if (damage == 0)
            {
                ReportResult($"{actorName} missed {targetName}.");
            }
            else
            {
                ReportResult($"{actorName} hit {targetName} for {damage} point{(damage > 1 ? "s" : "")}.");
                target.TakeDamage(damage);
            }
        }
    }
}