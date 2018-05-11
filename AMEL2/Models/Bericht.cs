using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMEL2.Models
{
    public class Bericht
    {
        public int BerichtID { get; set; }
        public int Projekt { get; set; }
        public int BN { get; set; }
        public int IT { get; set; }
        public string s1 { get; set; }
        public string s2 { get; set; }
        public string s3 { get; set; }
        public string s4 { get; set; }
        public string s5 { get; set; }
        public string s6 { get; set; }
        public string s7 { get; set; }
        public string s8 { get; set; }
        public string s9 { get; set; }
        public string s10 { get; set; }
        public string s11 { get; set; }
        public string s12 { get; set; }
        public string s13 { get; set; }
        public string s14 { get; set; }
        public string s15 { get; set; }
        public string s16 { get; set; }
        public string s17 { get; set; }
        public string s18 { get; set; }
        public string s19 { get; set; }
        public string s20 { get; set; }
        public string s21 { get; set; }
        public string s22 { get; set; }
        public string s23 { get; set; }
        public string s24 { get; set; }
        public string s25 { get; set; }
        public string s26 { get; set; }
        public string s27 { get; set; }
        public string s28 { get; set; }
        public string s29 { get; set; }
        public string s30 { get; set; }
        public string s31 { get; set; }
        public string s32 { get; set; }
        public string s33 { get; set; }
        public string s34 { get; set; }
        public string s35 { get; set; }
        public string s36 { get; set; }
        public string s37 { get; set; }
        public string s38 { get; set; }
        public string s39 { get; set; }
        public string s40 { get; set; }
        public string s41 { get; set; }
        public string s42 { get; set; }
        public string s43 { get; set; }
        public string s44 { get; set; }
        public string s45 { get; set; }
        public string s46 { get; set; }
        public string s47 { get; set; }
        public string s48 { get; set; }
        public string s49 { get; set; }
        public string s50 { get; set; }
        public string s51 { get; set; }
        public string s52 { get; set; }
        public string s53 { get; set; }
        public string s54 { get; set; }
        public string s55 { get; set; }
        public string s56 { get; set; }
        public string s57 { get; set; }
        public string s58 { get; set; }
        public string s59 { get; set; }
        public string s60 { get; set; }

        public List<SelectListItem> getListYesNo()
        {
            List<SelectListItem> listYesNo = new List<SelectListItem>();
            var data = new[]{
                 new SelectListItem{ Value="X",Text="X"},
                 new SelectListItem{ Value="-",Text="-"},
             };
            listYesNo = data.ToList();
            return listYesNo;
        }
        public List<SelectListItem> getListAntriebsart()
        {
            List<SelectListItem> listAntriebsart = new List<SelectListItem>();
            var data = new[]{
                 new SelectListItem{ Value="Leistungsabgang",Text="Leistungsabgang"},
                 new SelectListItem{ Value="Direktantrieb",Text="Direktantrieb"},
                 new SelectListItem{ Value="Stern-Dreieck-Anlauf",Text="Stern-Dreieck-Anlauf"},
                 new SelectListItem{ Value="Sanftanlauf",Text="Sanftanlauf"},
                 new SelectListItem{ Value="FU-Antrieb",Text="FU-Antrieb"},
                 new SelectListItem{ Value="2-Drehzahlen Dahlander",Text="2-Drehzahlen Dahlander"},
                 new SelectListItem{ Value="2-Drehrichtungen Matic-Antrieb",Text="2-Drehrichtungen Matic-Antrieb"},
                 new SelectListItem{ Value="Pneumatikantrieb",Text="Pneumatikantrieb"},
                 new SelectListItem{ Value="2-Drehrichtungen",Text="2-Drehrichtungen"},
                 new SelectListItem{ Value="Magnetventil elektrisch",Text="Magnetventil elektrisch"},
                 new SelectListItem{ Value="Magnetventil Pneumatikantrieb",Text="Magnetventil Pneumatikantrieb"},
             };
            listAntriebsart = data.ToList();
            return listAntriebsart;
        }
    }
    
}