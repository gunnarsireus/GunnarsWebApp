/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GunnarsWebApp.Models
{
    [XmlRoot(ElementName = "SubmissionModel")]
    public class SubmissionModel
    {
        [Key]
        [XmlElement(ElementName = "ListIndexID")]
        public string ListIndexID { get; set; }
        [XmlElement(ElementName = "SubmissionDate")]
        public string SubmissionDate { get; set; }
        [XmlElement(ElementName = "ProjectType")]
        public string ProjectType { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Email")]
        public string Email { get; set; }
        [XmlElement(ElementName = "Address")]
        public string Address { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "City")]
        public string City { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "ProjectName")]
        public string ProjectName { get; set; }
        [XmlElement(ElementName = "ProjectDescription")]
        public string ProjectDescription { get; set; }
        [XmlElement(ElementName = "ProjectWebSiteURL")]
        public string ProjectWebSiteURL { get; set; }
        [XmlElement(ElementName = "ProjectFilePath")]
        public string ProjectFilePath { get; set; }
        [XmlElement(ElementName = "ProjectFileName")]
        public string ProjectFileName { get; set; }
    }

    [XmlRoot(ElementName = "Submissions")]
    public class Submissions
    {
        [XmlElement(ElementName = "SubmissionModel")]
        public List<SubmissionModel> SubmissionModel { get; set; }
    }

    [XmlRoot(ElementName = "SubmissionCollection")]
    public class SubmissionModelCollection
    {
        [XmlElement(ElementName = "Submissions")]
        public Submissions Submissions { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
    }

}
