using System;
using System.ComponentModel.DataAnnotations;

namespace DVMSWebApi.Models
{
    internal class vtran
    {
        [Key]
        public int transId { get; set; }
        public DateTime transChkIn { get; set; }
        public DateTime transChkOut { get; set; }
        public string visitorName { get; set; }
        //public string visitorCitizenId { get; set; }
        //public string visitorTel { get; set; }
        //public string visitorAddress { get; set; }
        //public int? visitorCardId { get; set; }
        //public string visitorCardLocation { get; set; }
        //public int? visitorCompanyId { get; set; }
        //public int? tranTypeId { get; set; }
        //public int? areaId { get; set; }
        //public int? starffId { get; set; }
        //public string transComment { get; set; }
        //public int? sysUserId { get; set; }
        //public bool? lostCard { get; set; }
        //public bool? transDel { get; set; }
        //public string visitorCarPlateNumber { get; set; }
        //public string visitorPepleCount { get; set; }
        //public int? visitorCarTypeId { get; set; }
        //public int? visitorCarBrandId { get; set; }
        //public int? visitorCarProvinceId { get; set; }
        //public int? visitorReasonTypeId { get; set; }
        //public string Barcode_CardvisitorCar { get; set; }
        //public int? visitorCheckItem { get; set; }
        //public string transParkingTime { get; set; }

        

    }
}