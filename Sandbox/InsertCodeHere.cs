﻿using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            NumberGenerator theNumberGenerator = new NumberGenerator();
            BattleLog theLog = new BattleLog();

            Hero theHero = new Hero(theNumberGenerator, theLog);
            Beast theBeast = new Beast(theNumberGenerator, theLog);


            // Now battle...How do we do that (Hint: You need a loop)
            // YOUR JOB: Insert code here to make theHero and theBeast battle

            while (!theBeast.IsDead() && !theHero.IsDead())
            {
                // The hero deals damage to the beast
                theBeast.ReceiveDamage(theHero.DealDamage());

                if (!theBeast.IsDead())
                {
                    // The beast deals damage to the hero, unless it's dead
                    theHero.ReceiveDamage(theBeast.DealDamage());
                }
            }
            theLog.PrintEntireBattleLog();

            

            // The LAST line of code should be ABOVE this line
        }
    }
}
