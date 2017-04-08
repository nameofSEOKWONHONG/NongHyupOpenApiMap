using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JWLibrary.Core.Date;
using NongHyupApi.Models;
using JWLibrary.Core.StringToEnum;
using NongHyupApi;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            NongHyupApi.ApiClient apiMap = new NongHyupApi.ApiClient("http://localhost:9999/NonghyupApi/");

            var now = DateTime.Now;
            OpenFinAccountARSSender sender = new OpenFinAccountARSSender
            {
                Header = new NongHyupApi.Models.SenderHeader
                {
                    ApiNm = StringEnum.GetStringValue(NongHyupApi.ApiNmCode.CheckOpenFinAccount),
                    Trtm = now.ConvertDateToString(ConvertFormat.YYYYMMDD),
                    Tsymd = now.ConvertDateToString(ConvertFormat.HHMMSS),
                    Iscd = "000058",
                    FintechApsno = "002",
                    ApiSvcCd = "DrtrA",
                    IsTuno = "201510120000000001",
                },
                DrtrRgyn = "Y",
                BrdtBrno = "19661010",
                Tlno = "01011112222",
                Csnm = "홍길동",
                CmcmDscd = StringEnum.GetStringValue(CmcmDscdCode.SKT),
                GndrDscd = "M",
                NtfrDscd = "1",
                SelfCrtcDmndYn = "Y"
            };

            //var json = apiMap.GenerateJson<OpenFinAccountARSSender>(sender);
            //var result = apiMap.Client<NongHyupApi.Models.ReceiveHeader>(json);

            var result = apiMap.Client<OpenFinAccountARSSender, OpenFinAccountARSReceiver>(sender);

            if(result != null)
            {
                
            }
        }
    }
}
