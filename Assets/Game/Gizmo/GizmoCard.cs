using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Gizmos
{
    /// <summary>
    /// ����ÿ�ſ���һ������
    /// </summary>
    public class GizmoCard : MonoBehaviour
    {
        [SerializeField] Image background;
        [SerializeField] TextMeshProUGUI effectText;
        [SerializeField] TextMeshProUGUI requirementText;

        public Gizmo Gizmo { get; private set; }

        public void SetGizmo(Gizmo gizmo)
        {
            background.color = EnergyUtility.GetEnergyColor(gizmo.costEnergy);
            effectText.text = gizmo.GetEffectDescription();
            string colorText = EnergyUtility.GetEnergyColorText(gizmo.costEnergy);
            requirementText.text = string.Format("{0}���{1}", colorText, gizmo.costAmount);
        }
    }
}
