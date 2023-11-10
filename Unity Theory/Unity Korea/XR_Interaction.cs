using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Theory.Unity_Korea
{
    internal class XR_Interaction
    {
        /*
        XRI : 
        유니티의 XRI는 Extended Reality Integration의 약자로, 
        유니티에서 확장 현실(XR) 기술을 사용하는 데 필요한 기능을 제공한다.

        XRI는 게임 개발자가 확장 현실 기술을 사용하여 보다 몰입감 있고 현실감 있는 게임을 만들 수 있도록 
        도와주는 강력한 도구라 할 수 있다.

        핸드 트래킹 지원 : 기존의 핸드 트래킹 지원에서 더 간단하게 구현이 가능
        아이트래킹 : 시선 추적과 머리 움직임을 믹싱해서 이걸 입력으로 받아들이는 케이스 기능도 추가되었다.
            다만 시선 추적 같은 경우는 메타 퀘스트2 제품에서 사용이 불가능 하다.
            또한 시선 추적만으로는 정교한 컨트롤를 하기가 어렵다.
            그렇기 때문에 시선 추적만을 단독으로 사용하는 것이 아니라 컨트롤러나 핸드 트래킹하고 같이 섞어서 사용하면
            좀더 다양한 행위들을 할 수 있게 된다.
        */

        /*
        https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples
        XR 컨텐트를 만들때 가장 걸림돌이 되는 것 중 하나가 디바이스를 올려서 밖의 상황을 보는 것인데,
        최근에는 이 테스트 시뮬레이터를 통해서 테스트, 작업을 할 수 있게 되었다.
         */

        /*
        핸드 트래킹 : https://docs.unity3d.com/Packages/com.unity.xr.hands@1.1/manual/index.html
        
        XRI의 핸드 트래킹은 XR 장치의 카메라와 센서를 사용하여 사용자의 손 위치와 움직임을 추적하는 기능이다. 
        핸드 트래킹을 사용하면 게임 개발자는 사용자의 손을 게임에 반영하여 보다 몰입감 있는 게임을 만들 수 있다.
        
        프로젝트 셋업에 가서 인스털 엑셀 핸즈로 가면 링크를 클릭 할 수 있다.

        프로젝트 세팅 -> XR 플러그인 매니지먼트 -> 오픈 XR 
            인터렉션 프로필에서 핸드 인터렉션 프로필을 추가
            All Features 에서 핸드 인터랙션 포즈와 핸드 트래킹 서브시스템, 메타 핸드 트래킹 에임을 체크한다.
            프로젝트 벨리데이션에서 경고가 없는지 확인 -> 문제가 있다면 픽스올

        손이 마젠타 색상으로 나와있기 때문에 머테리얼을 URP로 컨버트 해준다.

        메타 퀘스트를 PC와 연결시킨다.
        그러면 손을 자동으로 추적해 준다.

        손가락 마다 버튼과 연동이 가능하고 이 버튼의 기능은 사용자가 직접 지정할 수도 있다.
         */
    }
}
