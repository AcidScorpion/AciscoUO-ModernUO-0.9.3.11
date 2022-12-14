using ModernUO.Serialization;

namespace Server.Items
{
    [SerializationGenerator(0, false)]
    public partial class DivineCountenance : HornedTribalMask
    {
        [Constructible]
        public DivineCountenance()
        {
            Hue = 0x482;

            Attributes.BonusInt = 8;
            Attributes.RegenMana = 2;
            Attributes.ReflectPhysical = 15;
            Attributes.LowerManaCost = 8;
        }

        public override int LabelNumber => 1061289; // Divine Countenance

        public override int ArtifactRarity => 11;

        public override int BasePhysicalResistance => 8;
        public override int BaseFireResistance => 6;
        public override int BaseColdResistance => 9;
        public override int BaseEnergyResistance => 25;

        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;
    }
}
