﻿using System.Xml.Serialization;

namespace CarDealer.Dto.ImportDto
{
    [XmlType("Supplier")]
    public class ImportSupplierDto
    {
        [XmlElement("name")]
        public string Name { get; set; } 

        [XmlElement("isImporter")]
        public string IsImporter { get; set; }
    }
}
