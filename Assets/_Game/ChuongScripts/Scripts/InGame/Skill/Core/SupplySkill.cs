namespace Game
{
    public abstract class SupplySkill : BaseSkill, ISuppliesSkill
    {
        public SkillUpgradeInfo SkillUpgradeInfo => _statSkillSo[Level];
        public override int HashID => SuppliesType.GetHashID();

        public override void Upgrade()
        {
            return;
        }
        public void Apply<T>(T attribute) where T : IAttribute
        {
            _statSkillSo[Level].ApplyUpgrade(attribute);
        }
        
        public void UpgradeWeapon<T>(T weapon) where T : WeaponSkill
        {
            weapon.Upgrade(_statSkillSo[Level]);
        }

        public abstract SuppliesType SuppliesType { get; }
    }
}