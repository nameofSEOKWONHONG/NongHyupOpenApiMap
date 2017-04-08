namespace NongHyupApi.Models
{
    /// <summary>
    /// 공통 전송 해더
    /// </summary>
    public class SenderHeader
    {
        /// <summary>
        /// API명 (Len:100)
        /// </summary>
        public string ApiNm { get; set; }

        /// <summary>
        /// 전송일자(Len:8)(YYYYMMDD)
        /// </summary>
        public string Tsymd { get; set; }

        /// <summary>
        /// 전송시각(len:6)(HHMMSS)
        /// </summary>
        public string Trtm { get; set; }

        /// <summary>
        /// 기관코드(len:6)
        /// </summary>
        public string Iscd { get; set; }

        /// <summary>
        /// 핀테크 앱 인련번호 (len:3)
        /// </summary>
        public string FintechApsno { get; set; }

        /// <summary>
        /// API 서비스코드(len:20)
        /// </summary>
        public string ApiSvcCd { get; set; }

        /// <summary>
        /// 기관 거래고유번호(len:20)
        /// </summary>
        public string IsTuno { get; set; }
    }

    /// <summary>
    /// 공통 수신 헤더
    /// </summary>
    public class ReceiveHeader
    {
        /// <summary>
        ///  API명 필드 100 필수
        /// </summary>
        public string ApiNm { get; set; }

        /// <summary>
        /// 전송일자 필드 8 필수
        /// </summary>
        public string Tsymd { get; set; }

        /// <summary>
        ///  전송시각 필드 6 필수
        /// </summary>
        public string Trtm { get; set; }

        /// <summary>
        /// 기관코드 필드 6 필수
        /// </summary>
        public string Iscd { get; set; }

        /// <summary>
        /// 핀테크앱일련번호 필드 3 필수
        /// </summary>
        public string FintechApsno { get; set; }

        /// <summary>
        /// API서비스코드 필드 20 필수
        /// </summary>
        public string ApiSvcCd { get; set; }

        /// <summary>
        ///  기관 거래고유번호 필드 20 필수
        /// </summary>
        public string IsTuno { get; set; }

        /// <summary>
        /// 응답코드 필드 5 필수
        /// </summary>
        public string Rpcd { get; set; }

        /// <summary>
        /// 응답메세지 필드 100 필수
        /// </summary>
        public string Rsms { get; set; }
    }


    public class OpenFinAccountARSSender
    {
        public SenderHeader Header { get; set; }

        /// <summary>
        /// 출금이체 등록 여부 필드 1 필수 Y:등록, N:미등록
        /// </summary>
        public string DrtrRgyn { get; set; }

        /// <summary>
        /// 생년월일(사업자번호) 필드 10 필수 개인:yyyymmdd
        /// </summary>
        public string BrdtBrno { get; set; }

        /// <summary>
        /// 번호 필드 13 필수
        /// </summary>
        public string Tlno { get; set; }

        /// <summary>
        /// 고객명 필드 50 필수
        /// </summary>
        public string Csnm { get; set; }

        /// <summary>
        /// 통신사구분코드 필드 1 필수 1:SKT, 2:KT, 3:LGU+,  4:SKT MVNO, 5:KT MVNO, 6:LGU+ MVNO
        /// </summary>
        public string CmcmDscd { get; set; }

        /// <summary>
        /// 성별구분코드 필드 1 필수 M:남자, F:여자
        /// </summary>
        public string GndrDscd { get; set; }

        /// <summary>
        /// 내외국인구분코드 필드 1 필수 1:내국인, 2:외국인
        /// </summary>
        public string NtfrDscd { get; set; }

        /// <summary>
        /// 본인인증요청여부 필드 1 필수 Y:사용, N:미사용, 미입력.N으로처리
        /// </summary>
        public string SelfCrtcDmndYn { get; set; }
    }

    public class OpenFinAccountARSReceiver
    {
        public ReceiveHeader Header { get; set; }

        /// <summary>
        /// 등록번호 필드 20 필수
        /// </summary>
        public string Rgno { get; set; }
    }


    public class CheckOpenFinAccountSender
    {
        public SenderHeader Header { get; set; }

        /// <summary>
        /// 등록번호 필드 20 필수
        /// </summary>
        public string Rgno { get; set; }

        /// <summary>
        /// 생년월일(사업자번호) 필드 10 필수 개인:yyyymmdd
        /// </summary>
        public string BrdtBrno { get; set; }

        /// <summary>
        ///  전화번호 필드 13 필수
        /// </summary>
        public string Tlno { get; set; }
    }

    public class CheckOpenFinAccountReceiver
    {
        public ReceiveHeader Header { get; set; }

        /// <summary>
        /// 핀-어카운트 필드 30 필수
        /// </summary>
        public string FinAcno { get; set; }

        /// <summary>
        /// 등록일자 필드 8 필수
        /// </summary>
        public string RgsnYmd { get; set; }

        /// <summary>
        /// 계좌번호 필드 20 필수 마스킹(O) : 앞뒤 3자리 노출 나머지* 처 리, 6보다 작을경우 모두* 처리
        /// </summary>
        public string Acno { get; set; }
    }


    public class CloseFinAccountSender
    {
        public SenderHeader Header { get; set; }

        /// <summary>
        /// 핀-어카운트 필드 30 필수
        /// </summary>
        public string FinAcno { get; set; }

        /// <summary>
        /// 전화번호 필드 13 선택 ARS발급을 통해 발급된 핀-어카운트 경우 등록시 전화번호 일치여부 검증
        /// </summary>
        public string Tlno { get; set; }

        /// <summary>
        /// 생년월일(사업자번호) 필드 10 필수 등록시 생년월일과 일치여부 검증(ERP 발급의 경우 사업자번호입력
        /// </summary>
        public string BrdtBrno { get; set; }
    }

    public class CloseFinAccountReceiver
    {
        public ReceiveHeader Header { get; set; }
    }


    public class InquireFinAccountStatusSender
    {
        public SenderHeader Header { get; set; }

        /// <summary>
        /// 핀-어카운트 필드 30 필수
        /// </summary>
        public string FinAcno { get; set; }

        /// <summary>
        /// 전화번호 필드 13 (필수) 등록시 전화번호 일치여부 검증
        /// </summary>
        public string Tlno { get; set; }

        /// <summary>
        /// 생년월일(사업자번호) 필드 10 (필수) 등록시 생년월일과 일치여부 검증(ERP 발급의 경우 사업자번호 입력 )
        /// </summary>
        public string BrdtBrno { get; set; }
    }

    public class InquireFinAccountStatusReceiver
    {
        public ReceiveHeader Header { get; set; }

        /// <summary>
        /// 핀-어카운트상태 필드 1 필수   0: 처리중, 1: 정상, 9: 해지
        /// </summary>
        public FinAcnoSttsCde FinAcnoStts { get; set; }

        /// <summary>
        /// 등록일자 필드 8 필수
        /// </summary>
        public string RgsnYmd { get; set; }

        /// <summary>
        /// 해지일자 필드 8 
        /// </summary>
        public string Trymd { get; set; }
    }


    /// <summary>
    /// 출금이제 요청
    /// </summary>
    public class DrawingTransferSender
    {
        public SenderHeader Header { get; set; }

        /// <summary>
        /// 핀-어카운트 필드 30 필수
        /// </summary>
        public string FinAcno { get; set; }

        /// <summary>
        /// 거래금액 필드 15 필수
        /// </summary>
        public string Tram { get; set; }

        /// <summary>
        /// 출금계좌인자내용 필드 25 필수 출금고객계좌 통장적용 인자내용 ex) 핀테크기업명 or 핀테크서비스명 or 송금수취인
        /// </summary>
        public string DractOtlt { get; set; }

        /// <summary>
        /// 입금계좌인자내용 필드 25 미사용 출금이체시에는 출금계좌인자내용만사용
        /// </summary>
        public string MractOtlt { get; set; }
    }

    /// <summary>
    /// 출금이제 응답
    /// </summary>
    public class DrawingTransferReceiver
    {
        public ReceiveHeader Header { get; set; }
    }


    /// <summary>
    /// 출금이제 결과확인 (핀어카운트 계좌에서 핀테크 기업 약정계좌로)
    /// </summary>
    public class CheckOnDrawingTransferSedner
    {
        public SenderHeader Header { get; set; }

        /// <summary>
        /// 핀-어카운트 필드 30 필수   
        /// </summary>
        public string FinAcno { get; set; }

        /// <summary>
        /// 거래금액 필드 15 필수
        /// </summary>
        public string Tram { get; set; }

        /// <summary>
        /// 원거래일자 필드 8 필수   
        /// </summary>
        public string OrtrYmd { get; set; }

        /// <summary>
        /// 원거래 기관거래고유번호 필드 20 필수
        /// </summary>
        public string OrtrIsTuno { get; set; }
    }

    public class CheckOnDrawingTransferReceiver
    {
        public ReceiveHeader Header { get; set; }

        /// <summary>
        /// 처리결과 필드 5 필수 원거래에 대한 처리결과 ※공통부 Rpcd =‘00000’경우만 참조
        /// </summary>
        public string Pcrs { get; set; }

        /// <summary>
        /// 처리시각 필드 6 필수
        /// </summary>
        public string Prtm { get; set; }
    }


    /// <summary>
    /// 농협입금이제 (핀테크기업 약정계좌에서 고객의 핀어카운트 계좌로)
    /// </summary>
    public class ReceivedTransferFinAccountSedner
    {
        public SenderHeader Header { get; set; }

        /// <summary>
        /// 핀-어카운트 필드 30 필수
        /// </summary>
        public string FinAcno { get; set; }

        /// <summary>
        /// 거래금액 필드 15 필수
        /// </summary>
        public string Tram { get; set; }

        /// <summary>
        /// 출금계좌인자내용 필드 25 사용 출금계좌(입금이체 약정모계좌) 통장인자내 용 or 고객명
        /// </summary>
        public string DractOtlt { get; set; }

        /// <summary>
        /// 입금계좌인자내용 필드 25 필수입금고객계좌 통장적용 인자내용 ex) 핀테크기업명 or 핀테크서비스명
        /// </summary>
        public string MractOtlt { get; set; }
    }

    public class ReceivedTransferFinAccountReceiver
    {
        public ReceiveHeader Header;
    }

    

    /// <summary>
    /// 예금주조회
    /// </summary>
    public class InquireDepositorFinAccountSender
    {
        public SenderHeader Header { get; set; }

        /// <summary>
        /// 핀-어카운트 필드 30 필수
        /// </summary>
        public string FinAcno { get; set; }
    }

    public class InquireDepositorFinAccountReceiver
    {
        public ReceiveHeader Header { get; set; }

        /// <summary>
        /// 핀-어카운트 필드 30 필수
        /// </summary>
        public string FinAcno { get; set; }

        /// <summary>
        /// 예금주명 필드 50 필수
        /// </summary>
        public string Dpnm { get; set; }
    }

}
