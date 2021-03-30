using System;
using System.Text;
using UnityEngine.Assertions;

namespace Gizmos
{
    /// <summary>
    /// ����
    /// </summary>
    public abstract class Gizmo
    {
        public Energy costEnergy;
        public int costAmount;

        public abstract string GetEffectDescription();
    }

    [Serializable]
    public class FileRandomGizmo : Gizmo
    {
        public FileRandomEffect effect;

        public override string GetEffectDescription()
        {
            return "�浵���������";
        }
    }

    [Serializable]
    public class PickRandomGizmo : Gizmo
    {
        public PickRandomEffect effect;

        public override string GetEffectDescription()
        {
            Assert.IsTrue(effect.energies.Length > 0);
            string[] colorTexts = new string[effect.energies.Length];
            for (int i = 0, length = colorTexts.Length; i < length; i++)
            {
                colorTexts[i] = EnergyUtility.GetEnergyColorText(effect.energies[i]);
            }
            var sb = new StringBuilder();
            sb.AppendFormat("��{0}��", colorTexts[0]);
            for (int i = 1, length = colorTexts.Length; i < length; i++)
            {
                sb.AppendFormat("��{0}��", colorTexts[0]);
            }
            sb.Append("���������");
            return sb.ToString();
        }
    }

    [Serializable]
    public class BuildPickGizmo : Gizmo
    {
        public BuildPickEffect effect;

        public override string GetEffectDescription()
        {
            Assert.IsTrue(effect.energies.Length > 0);
            string[] colorTexts = new string[effect.energies.Length];
            for (int i = 0, length = colorTexts.Length; i < length; i++)
            {
                colorTexts[i] = EnergyUtility.GetEnergyColorText(effect.energies[i]);
            }
            var sb = new StringBuilder();
            sb.AppendFormat("��{0}��", colorTexts[0]);
            for (int i = 1, length = colorTexts.Length; i < length; i++)
            {
                sb.AppendFormat("��{0}��", colorTexts[0]);
            }
            sb.Append("������");
            return sb.ToString();
        }
    }

    [Serializable]
    public class BuildStarGizmo : Gizmo
    {
        public BuildStarEffect effect;

        public override string GetEffectDescription()
        {
            Assert.IsTrue(effect.energies.Length > 0);
            string[] colorTexts = new string[effect.energies.Length];
            for (int i = 0, length = colorTexts.Length; i < length; i++)
            {
                colorTexts[i] = EnergyUtility.GetEnergyColorText(effect.energies[i]);
            }
            var sb = new StringBuilder();
            sb.AppendFormat("��{0}��", colorTexts[0]);
            for (int i = 1, length = colorTexts.Length; i < length; i++)
            {
                sb.AppendFormat("��{0}��", colorTexts[0]);
            }
            sb.Append("���1��");
            return sb.ToString();
        }
    }

    [Serializable]
    public class ConverterGizmo : Gizmo
    {
        public ConverterEffect effect;

        public override string GetEffectDescription()
        {
            Assert.IsTrue(effect.energies.Length > 0);
            string[] colorTexts = new string[effect.energies.Length];
            for (int i = 0, length = colorTexts.Length; i < length; i++)
            {
                colorTexts[i] = EnergyUtility.GetEnergyColorText(effect.energies[i]);
            }
            var sb = new StringBuilder();
            sb.AppendFormat("��{0}��", colorTexts[0]);
            for (int i = 1, length = colorTexts.Length; i < length; i++)
            {
                sb.AppendFormat("��{0}��", colorTexts[0]);
            }
            sb.Append("ת����������ɫ");
            return sb.ToString();
        }
    }

    [Serializable]
    public class DuplicatorGizmo : Gizmo
    {
        public DuplicatorEffect effect;

        public override string GetEffectDescription()
        {
            Assert.IsTrue(effect.energies.Length > 0);
            string[] colorTexts = new string[effect.energies.Length];
            for (int i = 0, length = colorTexts.Length; i < length; i++)
            {
                colorTexts[i] = EnergyUtility.GetEnergyColorText(effect.energies[i]);
            }
            var sb = new StringBuilder();
            sb.AppendFormat("��{0}��", colorTexts[0]);
            for (int i = 1, length = colorTexts.Length; i < length; i++)
            {
                sb.AppendFormat("��{0}��", colorTexts[0]);
            }
            sb.Append("���ѳ�2��");
            return sb.ToString();
        }
    }

    [Serializable]
    public class UpgradeGizmo : Gizmo
    {
        public UpgradeEffect effect;

        public override string GetEffectDescription()
        {
            string desc = "";
            switch (effect.type)
            {
                case UpgradeEffect.Type.StorageAdd1ResearchAdd1:
                    desc = "�����޺��о�+1";
                    break;
                case UpgradeEffect.Type.StorageAdd1FileAdd1:
                    desc = "�����޺ʹ浵+1";
                    break;
            }
            return desc;
        }
    }
}
