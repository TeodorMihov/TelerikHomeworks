using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private const int InitialAttackPoints = 150;
        private const int InitialDefensePoints = 80;
        private const int InitialHitPoints = 200;
        private const int NeutralOwner = 0;

        private int attackPoints;
        private bool ableToGathering;

        public Giant(string name, Point position, int owner)
            : base(name, position, NeutralOwner)
        {
            this.HitPoints = InitialHitPoints;
            attackPoints = InitialAttackPoints;
            ableToGathering = false;
        }

        public int AttackPoints
        {
            get { return attackPoints; }
        }

        public int DefensePoints
        {
            get { return InitialDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != NeutralOwner)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone && ableToGathering == false)
            {
                this.attackPoints += 100;
                ableToGathering = true;
                return true;
            }

            return false;
        }
    }
}
