using JWLibrary.Core.StringToEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongHyupApi
{
    /// <summary>
    /// 통신사 구분코드
    /// </summary>
    public enum CmcmDscdCode
    {
        [StringValue("1")]
        SKT = 1,
        [StringValue("2")]
        KT = 2,
        [StringValue("3")]
        LG = 3,
        [StringValue("4")]
        SKT_MVNO = 4,
        [StringValue("5")]
        KT_MVNO = 5,
        [StringValue("6")]
        LG_MVNO = 6,
    }

    /// <summary>
    /// API명 (ToString()으로 처리)
    /// </summary>
    public enum ApiNmCode
    {
        /// <summary>
        /// 핀어카운드ARS발급
        /// </summary>
        [StringValue("OpenFinAccountARS")]
        OpenFinAccountARS,

        /// <summary>
        /// 핀어카운트ARS발급확인
        /// </summary>
        [StringValue("CheckOpenFinAccount")]
        CheckOpenFinAccount,

        /// <summary>
        /// 핀어카운트해지
        /// </summary>
        [StringValue("CloseFinAccount")]
        CloseFinAccount,

        /// <summary>
        /// 핀어카운트상태조회
        /// </summary>
        [StringValue("InquireFinAccountStatus")]
        InquireFinAccountStatus
    }

    /// <summary>
    /// 핀어카운트 상태
    /// </summary>
    public enum FinAcnoSttsCde
    {
        [StringValue("0")]
        처리중 = 0,
        [StringValue("1")]
        정상 = 1,
        [StringValue("9")]
        해지 = 9

    }
}
