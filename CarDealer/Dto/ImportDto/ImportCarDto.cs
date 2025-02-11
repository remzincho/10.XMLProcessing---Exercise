﻿using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.Dto.ImportDto
{
    [XmlType("Car")]
    public class ImportCarDto
    {
        [XmlElement(ElementName = "make")]
        public string Make { get; set; }

        [XmlElement(ElementName = "model")]
        public string Model { get; set; }

        [XmlElement(ElementName = "TraveledDistance")]
        public long TravelledDistance { get; set; }

        [XmlArray(ElementName = "parts")]
        public List<PartIdDto> PartIds { get; set; }
    }
}