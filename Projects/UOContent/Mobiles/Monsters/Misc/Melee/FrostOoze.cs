namespace Server.Mobiles
{
    public class FrostOoze : BaseCreature
    {
        [Constructible]
        public FrostOoze() : base(AIType.AI_Melee)
        {
            Body = 94;
            BaseSoundID = 456;

            SetStr(18, 30);
            SetDex(16, 21);
            SetInt(16, 20);

            SetHits(13, 17);

            SetDamage(3, 9);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 15, 20);
            SetResistance(ResistanceType.Cold, 40, 50);
            SetResistance(ResistanceType.Poison, 20, 30);
            SetResistance(ResistanceType.Energy, 10, 20);

            SetSkill(SkillName.MagicResist, 5.1, 10.0);
            SetSkill(SkillName.Tactics, 19.3, 34.0);
            SetSkill(SkillName.Wrestling, 25.3, 40.0);

            Fame = 450;
            Karma = -450;

            VirtualArmor = 38;
        }

        public FrostOoze(Serial serial) : base(serial)
        {
        }

        public override string CorpseName => "a frost ooze corpse";
        public override string DefaultName => "a frost ooze";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Gems, Utility.RandomMinMax(1, 2));
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);
            var version = reader.ReadInt();
        }
    }
}
