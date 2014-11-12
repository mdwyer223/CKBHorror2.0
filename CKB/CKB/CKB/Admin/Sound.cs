using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace CKB
{
    class Sound
    {
        public static SoundEffect Trash
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/GarbageSearch"); }
        }

        public static SoundEffect Walking
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/Footsteps"); }
        }

        public static SoundEffect Dialtone
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/Dialtone"); }
        }

        public static SoundEffect DoorOpening
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/DoorOpening"); }
        }

        public static SoundEffect Elevator
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/ElevatorBell"); }
        }

        public static SoundEffect Exhale
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/Exhale"); }
        }

        public static SoundEffect Laugh1
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/Exhale"); }
        }

        public static SoundEffect Scratch
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/Scratch"); }
        }

        public static SoundEffect Shriek1
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/Shriek1"); }
        }

        public static SoundEffect Shriek2
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/Shriek2"); }
        }

        public static SoundEffect Shuffling1
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/Shuffling1"); }
        }

        public static SoundEffect CreepyRun1
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/CreepyRun1"); }
        }

        public static SoundEffect HeavyBreathing
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/HeavyBreathing"); }
        }

        public static SoundEffect NormalBreathing
        {
            get { return Game1.GameContent.Load<SoundEffect>("Sounds/NormalBreathing"); }
        }
    }
}
