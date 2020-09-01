using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCassieEventbc
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public static string DecontaminationInit { get; set; } = "<size=30><color=purple>모든 인원들에게 알립니다 저위험군 격리구역의 오염 제거 절차가 15분 후에 이루어집니다 모든 유기물들은 붕괴를 방지하기 위해 제거되어야 합니다.</color></size>";
        public static string DecontaminationMinutesCount { get; set; } = "<size=30><color=purple>저위험군 격리구역의오염 제거 절차가 {0}분후에 진행됩니다.</color></size>";
        public static string Decontamination30s { get; set; } = "<size=30><color=purple>저위험군 격리구역의 오염 제거 절차가 30초후에 이루어 집니다 모든 검문소의 문이 열렸습니다</color></size>";
        public static string DecontaminationLockdown { get; set; } = "<size=30><color=purple>저위험군 격리구역이 패쇠되었고 오염 제거 준비가 완료되었습니다 유기물들의 제거가 시작됩니다</color></size>";
        public static string DecontEvent { get; set; } = "Decontamination process for Light Containment Zone has been started. SCP subject in zone will be destroyed.";
        public static string GeneratorFinish { get; set; } = "<size=30><color=blue>발전기{0}개가 가동되었습니다.</color></size>";
        public static string GeneratorComplete { get; set; } = "<size=30><color=blue>발전기 5개중 5개가 활성화 되었습니다 모든 발전기가 작동 되었으며 재격리 구역을 최종적으로 마무리합니다 </color></size>";
        public static string Generatorofflight { get; set; } = "모든 SCP가 격리되었으며 1분뒤 SCP079 격리절차가 시작됩니다. 고위험군 과부화까지 1분..";
        public static string AlphaWarheadStart { get; set; } = "<size=30><color=purple>알파핵탄두가 활성화되었습니다. 시설지하가{0}초후에 폭파됩니다..</color></size>";
        public static string AlphaWarheadResume { get; set; } = "<size=30><color=purple>알파핵탄두가 재활성화 되었습니다.{0}초후에 시설지하가 폭파됩니다.</color></size>";
        public static string AlphaWarheadCancel { get; set; } = "알파 핵탄두 폭파가 중지되었습니다.";
        public static string SCPDeathTesla { get; set; } = "SCP{0}가 격리되었습니다.";
        public static string SCPDeathWarhead { get; set; } = "SCP{0}가 격리되었습니다.";
        public static string SCPDeathDecont { get; set; } = "SCP{0}가 격리되었습니다.";
        public static string SCPDeathTerminated { get; set; } = "{0} terminated by {1}.{-1}";
        public static string SCPDeathContainedMTF { get; set; } = "SCP {0} 격리완료. 격리원인:{1}.{-2}";
        public static string SCPDeathUnknown { get; set; } = "{0} successfully terminated. Termination cause unspecified.{-2}";
        public static string MTFRespawnSCPS { get; set; } = "<size=20><color=blue>기동특무부대MTF소속 {0}가 시설에 진입하였습니다 격리가 필요한 SCP는 총 {1}입니다.</color></size>";
        public static string MTFRespawnNOSCP { get; set; } = "<size=20><color=blue>기동특무부대MTF소속 {0}가 시설에 진입하였습니다. 시설에 목숨을 위협하는 존재가 있습니다. 주의하십시오.</color></size>";
    }   
         
}
