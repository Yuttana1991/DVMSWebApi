using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVMSWebApi.Models
{
    public class View_TransAuto
    {
        [Key]
        public int transId { get; set; }
        public DateTime? transChkIn { get; set; }
        public DateTime? transChkOut { get; set; }
        public string visitorName { get; set; }
        public string visitorCitizenId { get; set; }
        public string visitorAddress { get; set; }
        [Key]
        public int? areaId { get; set; }
        public string areaNameTH { get; set; }
        public string areaNameEN { get; set; }
        public string areaCodeName { get; set; }
        public string areaFullPath { get; set; }
        [Key]
        public int? visitorCarTypeId { get; set; }
        public string visitorCarType_Name { get; set; }
        public string visitorCarPlateNumber { get; set; }
        [Key]
        public int? visitorCarBrandId { get; set; }
        public string visitorcarbrand_Name { get; set; }
        [Key]
        public int? visitorCarProvinceId { get; set; }
        public string Province_Name { get; set; }
        [Key]
        public int? visitorReasonTypeId { get; set; }
        public string reason_Name { get; set; }
        public string transParkingTime { get; set; }
      
      
    }
}
