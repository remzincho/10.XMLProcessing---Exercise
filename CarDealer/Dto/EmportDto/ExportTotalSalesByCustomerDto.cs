﻿using System.Xml.Serialization;

namespace CarDealer.Dto.EmportDto
{
    [XmlType("customer")]
    public class ExportTotalSalesByCustomerDto
    {
        [XmlAttribute("full-name")]
        public string FullName { get; set; }

        [XmlAttribute("bought-cars")]
        public int BoughtCars { get; set; }

        [XmlAttribute("spent-money")]
        public decimal SpentMoney { get; set; }
    }
}
